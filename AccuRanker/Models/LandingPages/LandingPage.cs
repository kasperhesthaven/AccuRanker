namespace DentsuDataLab.AccuRanker.Models.LandingPages
{
    using Newtonsoft.Json;

    using Utility.Fields;

    public class LandingPage
    {
        internal LandingPage()
        {
        }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("history")]
        public LandingPageHistory History { get; set; }
    }

    public class LandingPageFields : FieldsDescriptor
    {
        public Field Id { get; protected set; }

        public Field Path { get; protected set; }

        public Field CreatedAt { get; protected set; }

        //public CompetitorFields Competitor => new CompetitorFields(this);

        public LandingPageFields() : this(null)
        {
        }

        public LandingPageFields(FieldsDescriptor parent) : this(parent, "landing_page")
        {
        }

        protected LandingPageFields(FieldsDescriptor parent, string name) : base(parent, name)
        {
            MakeFields<LandingPage>();
        }
    }

    public class PreferredLandingPageFields : LandingPageFields
    {
        public PreferredLandingPageFields(FieldsDescriptor parent) : base(parent, "preferred_landing_page")
        {
        }
    }
}
