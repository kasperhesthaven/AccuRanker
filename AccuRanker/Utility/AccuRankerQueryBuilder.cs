namespace DentsuDataLab.AccuRanker.Utility
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    using Fields;

    internal class AccuRankerQueryBuilder
    {
        protected static readonly Uri BaseUri = new Uri("https://app.accuranker.com/api/v4/");

        private readonly Uri _uri;

        private readonly List<Field> _fields;

        private DateTime? _from;

        private DateTime? _to;

        private int _limit;

        private int _offset;

        public AccuRankerQueryBuilder(string relativePath)
        {
            _uri = new Uri(BaseUri, relativePath);

            _fields = new List<Field>();
        }

        public AccuRankerQueryBuilder WithFields(IEnumerable<Field> fields)
        {
            _fields.AddRange(fields);

            return this;
        }

        public AccuRankerQueryBuilder WithLimit(int limit)
        {
            _limit = limit;

            return this;
        }

        public AccuRankerQueryBuilder WithOffset(int offset)
        {
            _offset = offset;

            return this;
        }

        public AccuRankerQueryBuilder WithDateRange(DateTime from, DateTime to)
        {
            _from = from;
            _to = to;

            return this;
        }

        public Uri Build()
        {
            var uriBuilder = new UriBuilder(_uri);
            var query = HttpUtility.ParseQueryString(uriBuilder.Query);

            // Fields
            if (_fields.Any())
            {
                var fieldString = string.Join(",", _fields);
                query["fields"] = fieldString;
            }


            // Date range
            if (_from.HasValue && _to.HasValue)
            {
                query["period_from"] = _from.Value.ToString("yyyy-MM-dd");
                query["period_to"] = _to.Value.ToString("yyyy-MM-dd");
            }


            if (_limit > 0)
                query["limit"] = _limit.ToString();

            query["offset"] = _offset.ToString();

            uriBuilder.Query = query.ToString();

            return uriBuilder.Uri;
        }
    }
}
