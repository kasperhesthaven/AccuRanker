namespace DentsuDataLab.AccuRanker.Models.Keywords
{
    using System;

    using Newtonsoft.Json;

    using Utility.Fields;

    public class CompetitorRank
    {
        internal CompetitorRank()
        {
        }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("rank")]
        public int? Rank { get; set; }

        [JsonProperty("share_of_voice")]
        public int? ShareOfVoice { get; set; }

        [JsonProperty("competitor")]
        public KeywordCompetitor Competitor { get; set; }

        [JsonProperty("highest_ranking_page")]
        public string HighestRankingPage { get; set; }

        [JsonProperty("is_local_result")]
        public bool? IsLocalResult { get; set; }

        [JsonProperty("is_featured_snippet")]
        public bool? IsFeaturedSnippet { get; set; }

        [JsonProperty("has_sitelinks")]
        public bool? HasSitelinks { get; set; }

        [JsonProperty("has_video")]
        public bool? HasVideo { get; set; }

        [JsonProperty("has_reviews")]
        public bool? HasReviews { get; set; }
    }

    public class CompetitorRankFields : FieldsDescriptor
    {
        public Field Id { get; protected set; }
        public Field CreatedAt { get; protected set; }
        public Field Rank { get; protected set; }
        public Field ShareOfVoice { get; protected set; }
        public Field HighestRankingPage { get; protected set; }
        public Field IsLocalResult { get; protected set; }
        public Field IsFeaturedSnippet { get; protected set; }
        public Field HasSitelinks { get; protected set; }
        public Field HasVideo { get; protected set; }
        public Field HasReviews { get; protected set; }

        //public CompetitorFields Competitor => new CompetitorFields(this);

        public CompetitorRankFields() : this(null)
        {
        }

        public CompetitorRankFields(FieldsDescriptor parent) : base(parent, "competitor_ranks")
        {
            MakeFields<CompetitorRank>();
        }
    }
}
