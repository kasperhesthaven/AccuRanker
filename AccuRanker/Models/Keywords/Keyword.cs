namespace DentsuDataLab.AccuRanker.Models.Keywords
{
    using Domains;

    using LandingPages;

    using Newtonsoft.Json;

    using Utility.Fields;

    public class Keyword
    {
        public static readonly KeywordFields Fields = new KeywordFields();

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("keyword")]
        public string KeywordName { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("search_locale")]
        public SearchLocale SearchLocale { get; set; }

        [JsonProperty("search_location")]
        public string SearchLocation { get; set; }

        [JsonProperty("starred")]
        public bool Starred { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("search_engine")]
        public SearchEngine SearchEngine { get; set; }

        [JsonProperty("search_type")]
        public SearchType SearchType { get; set; }

        [JsonProperty("preferred_landing_page")]
        public LandingPage PreferredLandingPage { get; set; }

        [JsonProperty("search_volume")]
        public SearchVolume SearchVolume { get; set; }

        [JsonProperty("ranks")]
        public Rank[] Ranks { get; set; }

        [JsonProperty("competitor_ranks")]
        public CompetitorRank[] CompetitorRank { get; set; }
    }

    public class KeywordFields : FieldsDescriptor
    {
        public Field Id { get; protected set; }

        public Field KeywordName { get; protected set; }

        public Field CreatedAt { get; protected set; }

        public Field SearchLocation { get; protected set; }

        public Field Starred { get; protected set; }

        public Field Tags { get; protected set; }

        public Field SearchType { get; protected set; }

        public CompetitorRankFields CompetitorRank => new CompetitorRankFields(this);

        public SearchEngineFields SearchEngine => new SearchEngineFields(this);

        public SearchLocaleFields SearchLocale => new SearchLocaleFields(this);

        public SearchVolumeFields SearchVolume => new SearchVolumeFields(this);

        public RankFields Rank => new RankFields(this);

        public PreferredLandingPageFields LandingPage => new PreferredLandingPageFields(this);

        public KeywordFields() : this(null)
        {
        }

        public KeywordFields(FieldsDescriptor parent) : base(parent, "keyword")
        {
            MakeFields<Keyword>();
        }
    }
}
