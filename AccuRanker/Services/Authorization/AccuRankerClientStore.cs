namespace DentsuDataLab.AccuRanker.Services.Authorization
{
    using Utility.Auth;

    public class AccuRankerClientStore
    {
        private readonly object _lockObject = new object();

        private IdentityClient _client;

        public virtual IdentityClient Client

        {
            get
            {
                lock (_lockObject)
                {
                    return _client;
                }
            }
            set
            {
                lock (_lockObject)
                {
                    _client = value;
                }
            }
        }
    }

}