namespace DentsuDataLab.AccuRanker.Models.Accounts
{
    using System.Collections.Generic;

    using Newtonsoft.Json;

    using Utility.Fields;

    public class Account
    {
        public static readonly AccountFields Fields = new AccountFields();

        internal Account()
        {
        }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("api_filters")]
        public IEnumerable<ApiFilters> ApiFilters { get; set; }
    }

    public class AccountFields : FieldsDescriptor
    {
        public Field Id { get; protected set; }

        public Field Name { get; protected set; }

        public ApiFiltersFields ApiFilters => new ApiFiltersFields(this);

        public AccountFields() : this(null)
        {
        }

        public AccountFields(FieldsDescriptor parent) : base(parent, "account")
        {
            MakeFields<Account>();
        }
    }
}
