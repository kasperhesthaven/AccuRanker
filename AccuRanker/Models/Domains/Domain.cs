namespace DentsuDataLab.AccuRanker.Models.Domains
{
    using System;

    using Newtonsoft.Json;

    using Utility.Fields;

    public class Domain
    {
        public static readonly DomainFields Fields = new DomainFields();

        internal Domain()
        {
        }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("last_scraped")]
        public DateTime LastScraped { get; set; }

        [JsonProperty("group")]
        public Group Group { get; set; }

        [JsonProperty("domain")]
        public string DomainName { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("default_search_locale")]
        public SearchLocale SearchLocale { get; set; }

        [JsonProperty("default_search_location")]
        public string SearchLocation { get; set; }

        [JsonProperty("google_business_name")]
        public string GoogleBusinessName { get; set; }

        [JsonProperty("competitors")]
        public Competitor[] Competitors { get; set; }

        [JsonProperty("history")]
        public DomainHistory[] History { get; set; }
    }

    public class DomainFields : FieldsDescriptor
    {
        public Field Id { get; protected set; }

        public Field LastScraped { get; protected set; }

        public Field DomainName { get; protected set; }

        public Field DisplayName { get; protected set; }

        public Field CreatedAt { get; protected set; }

        public Field SearchLocation { get; protected set; }

        public Field GoogleBusinessName { get; protected set; }

        public GroupFields Group => new GroupFields(this);

        public DefaultSearchLocaleFields SearchLocale => new DefaultSearchLocaleFields(this);

        public DomainHistoryFields History => new DomainHistoryFields(this);

        public CompetitorFields Competitor => new CompetitorFields(this);

        public DomainFields() : this(null)
        {
        }

        public DomainFields(FieldsDescriptor parent) : base(parent, "domain")
        {
            MakeFields<Domain>();
        }
    }
}
