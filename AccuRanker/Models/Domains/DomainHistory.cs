namespace DentsuDataLab.AccuRanker.Models.Domains
{
    using Newtonsoft.Json;
    using Utility.Fields;

    public class DomainHistory
    {
        internal DomainHistory()
        {
        }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("ranking_movement")]
        public RankingMovement RankingMovement { get; set; }

        [JsonProperty("ranking_distribution")]
        public RankingDistribution RankingDistribution { get; set; }

        [JsonProperty("average_rank")]
        public double AverageRank { get; set; }

        [JsonProperty("share_of_voice")]
        public int ShareOfVoice { get; set; }
    }

    public class DomainHistoryFields : FieldsDescriptor
    {
        public Field Date { get; protected set; }
        public Field AverageRank { get; protected set; }
        public Field ShareOfVoice { get; protected set; }

        public RankingDistributionFields RankingDistribution => new RankingDistributionFields(this);
        public RankingMovementFields RankingMovement => new RankingMovementFields(this);

        public DomainHistoryFields() : this(null)
        {
        }

        public DomainHistoryFields(FieldsDescriptor parent) : base(parent, "history")
        {
            MakeFields<DomainHistory>();
        }
    }
}