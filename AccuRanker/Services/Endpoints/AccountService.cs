namespace DentsuDataLab.AccuRanker.Services.Endpoints
{
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;

    using Authorization;

    using Extensions;

    using Models.Accounts;

    using Utility;
    using Utility.Fields;
    using Utility.Http;

    public class AccountService : BaseAccuRankerService
    {
        public AccountService(HttpClient httpClient, AccuRankerAuthorizationService authService) : base(
            httpClient,
            authService)
        {
        }

        public async Task<IEnumerable<Account>> GetAccounts(params Field[] fields)
        {
            return await GetAccounts((IEnumerable<Field>)fields);
        }

        public async Task<IEnumerable<Account>> GetAccounts(IEnumerable<Field> fields)
        {
            await AuthorizeClient(AuthValues);

            var endpoint = new AccuRankerQueryBuilder("accounts/")
                .WithFields(fields)
                .Build();

            var accounts = await HttpClient.GetApiResponse<IEnumerable<Account>>(endpoint);

            if (accounts != null && accounts.HasValue)
                return accounts.Value;

            throw new ApiException(accounts?.Error);
        }

        public async Task<IEnumerable<Account>> GetAccount(int id)
        {
            await AuthorizeClient(AuthValues);

            var endpoint = new AccuRankerQueryBuilder($"accounts/{id}/")
                .Build();

            var groups = await HttpClient.GetApiResponse<IEnumerable<Account>>(endpoint);

            if (groups != null && groups.HasValue)
                return groups.Value;

            throw new ApiException(groups?.Error);
        }
    }
}
