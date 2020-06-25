namespace DentsuDataLab.AccuRanker.Models.Domains
{
    using Newtonsoft.Json;

    using Utility.Fields;

    public class Competitor
    {
        internal Competitor()
        {
        }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("google_business_name")]
        public string GoogleBusinessName { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("history")]
        public DomainHistory[] History { get; set; }
    }

    public class CompetitorFields : FieldsDescriptor
    {
        public Field Id { get; protected set; }

        public Field Domain { get; protected set; }

        public Field DisplayName { get; protected set; }

        public Field GoogleBusinessName { get; protected set; }

        public Field CreatedAt { get; protected set; }

        public DomainHistoryFields History => new DomainHistoryFields(this);

        public CompetitorFields() : this(null)
        {
        }

        public CompetitorFields(FieldsDescriptor parent) : base(parent, "competitors")
        {
            MakeFields<Competitor>();
        }
    }
}
