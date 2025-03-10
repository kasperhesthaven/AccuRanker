﻿namespace DentsuDataLab.AccuRanker.Services
{
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Threading.Tasks;

    using Authorization;

    using Extensions;

    using Models;

    using Utility;
    using Utility.Auth;
    using Utility.Http;

    public abstract class BaseAccuRankerService
    {
        protected HttpClient HttpClient { get; }

        protected AccuRankerAuthorizationService AuthService { get; }

        protected AuthValues AuthValues;

        protected BaseAccuRankerService(HttpClient httpClient, AccuRankerAuthorizationService authService)
        {
            HttpClient = httpClient;
            AuthService = authService;
        }

        /// <summary>
        /// Sets the auth values for the service to use.
        /// </summary>
        /// <param name="authValues">The auth values.</param>
        public void SetAuthValues(AuthValues authValues)
        {
            AuthValues = authValues;
        }

        protected async Task AuthorizeClient(AuthValues authValues)
        {
            var client = await AuthService.AuthorizeClient(authValues);

            HttpClient.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Token", authValues.ClientSecret);
        }

        internal virtual async Task<IEnumerable<T>> GetAllPages<T>(AccuRankerQueryBuilder baseQuery, int pageSize = 500)
        {
            var offset = 0;
            var allObjects = new List<T>();

            ApiResponse<AccuRankerPageResponse<T>> response;

            do
            {
                var endpoint = baseQuery
                    .WithLimit(pageSize)
                    .WithOffset(offset)
                    .Build();

                response = await HttpClient.GetApiResponse<AccuRankerPageResponse<T>>(endpoint);

                if (response == null || !response.HasValue)
                    throw new ApiException(response?.Error);

                var objects = response.Value.Results;
                allObjects.AddRange(objects);

                offset += pageSize;
            } while (!string.IsNullOrEmpty(response.Value.NextPage));


            return allObjects;
        }
    }
}
