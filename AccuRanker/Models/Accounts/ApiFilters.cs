namespace DentsuDataLab.AccuRanker.Models.Accounts
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Utility.Fields;

    public class ApiFilters
    {
        public static readonly ApiFiltersFields Fields = new ApiFiltersFields();

        internal ApiFilters()
        {
        }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("filters")]
        public IEnumerable<Filter> Filters { get; set; }
    }

    public class ApiFiltersFields : FieldsDescriptor
    {
        public Field Id { get; protected set; }

        public Field Name { get; protected set; }

        public FiltersFields Filters => new FiltersFields(this);

        public ApiFiltersFields() : this(null)
        {
        }

        public ApiFiltersFields(FieldsDescriptor parent) : base(parent, "api_filters")
        {
            MakeFields<ApiFilters>();
        }
    }
}