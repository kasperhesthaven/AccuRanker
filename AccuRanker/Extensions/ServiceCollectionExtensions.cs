namespace DentsuDataLab.AccuRanker.Extensions
{
    using Microsoft.Extensions.DependencyInjection;

    using Services.Authorization;
    using Services.Endpoints;

    public static class ServiceCollectionExtensions
    {
        public static void AddAccuRankerServices(this IServiceCollection services)
        {
            services.AddSingleton<AccuRankerClientStore>();

            services.AddTransient<AccuRankerAuthorizationService>();

            services.AddTransient<AccountService>();
            services.AddTransient<DomainService>();
            services.AddTransient<KeywordService>();

            services.AddHttpClient<AccountService>();
            services.AddHttpClient<DomainService>();
            services.AddHttpClient<KeywordService>();
        }
    }
}
