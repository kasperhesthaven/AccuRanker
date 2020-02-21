namespace DentsuDataLab.AccuRanker.Services.Endpoints
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;
    using Authorization;
    using Models.Domains;
    using Models.Keywords;
    using Utility;
    using Utility.Fields;

    public class KeywordService : BaseAccuRankerService
    {
        public KeywordService(HttpClient httpClient, AccuRankerAuthorizationService authService) : base(httpClient, authService)
        {
        }

        public async Task<IEnumerable<Keyword>> GetKeywords(Domain domain, DateTime from, DateTime to, params Field[] fields)
        {
            return await GetKeywords(domain, from, to, (IEnumerable<Field>)fields);
        }

        public async Task<IEnumerable<Keyword>> GetKeywords(Domain domain, DateTime from, DateTime to, IEnumerable<Field> fields)
        {
            return await GetKeywords(domain.Id, from, to, fields);
        }

        public virtual async Task<IEnumerable<Keyword>> GetKeywords(long domainId, DateTime from, DateTime to, IEnumerable<Field> fields)
        {
            await AuthorizeClient(AuthValues);

            var endpoint = new AccuRankerQueryBuilder($"domains/{domainId}/keywords/")
                .WithFields(fields)
                .WithDateRange(from, to);

            var keywords = await GetAllPages<Keyword>(endpoint, 1000);

            return keywords;
        }
    }
}