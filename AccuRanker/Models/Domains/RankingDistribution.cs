namespace DentsuDataLab.AccuRanker.Models.Domains
{
    using Newtonsoft.Json;
    using Utility.Fields;

    public class RankingDistribution
    {
        internal RankingDistribution()
        {
        }

        [JsonProperty("keywords_0_3")]
        public int KeywordsFrom0To3 { get; set; }

        [JsonProperty("keyword_4_10")]
        public int KeywordsFrom4To10 { get; set; }

        [JsonProperty("keywords_11_20")]
        public int KeywordsFrom11To20 { get; set; }

        [JsonProperty("keywords_21_50")]
        public int KeywordsFrom21To50 { get; set; }

        [JsonProperty("keywords_above_50")]
        public int KeywordsAbove50 { get; set; }

        [JsonProperty("keywords_unranked")]
        public int KeywordsUnranked { get; set; }

        [JsonProperty("keywords_total")]
        public int KeywordsTotal { get; set; }
    }

    public class RankingDistributionFields : FieldsDescriptor
    {
        public Field KeywordsFrom0To3 { get; protected set; }
        public Field KeywordsFrom4To10 { get; protected set; }
        public Field KeywordsFrom11To20 { get; protected set; }
        public Field KeywordsFrom21To50 { get; protected set; }
        public Field KeywordsAbove50 { get; protected set; }
        public Field KeywordsUnranked { get; protected set; }
        public Field KeywordsTotal { get; protected set; }

        public RankingDistributionFields() : this(null)
        {
        }

        public RankingDistributionFields(FieldsDescriptor parent) : base(parent, "ranking_distribution")
        {
            MakeFields<RankingDistribution>();
        }
    }
}