namespace DentsuDataLab.AccuRanker.Models.Domains
{
    using Newtonsoft.Json;
    using Utility.Fields;

    public class RankingMovement
    {
        internal RankingMovement()
        {
        }

        [JsonProperty("winners")]
        public int Winners { get; set; }

        [JsonProperty("share_of_voice_winners")]
        public int ShareOfVoiceWinners { get; set; }

        [JsonProperty("losers")]
        public int Losers { get; set; }

        [JsonProperty("share_of_voice_losers")]
        public int ShareOfVoiceLosers { get; set; }

        [JsonProperty("no_movement")]
        public int NoMovement { get; set; }

        [JsonProperty("share_of_voice_no_movement")]
        public int ShareOfVoiceNoMovement { get; set; }
    }

    public class RankingMovementFields : FieldsDescriptor
    {
        public Field Winners { get; protected set; }
        public Field ShareOfVoiceWinners { get; protected set; }
        public Field Losers { get; protected set; }
        public Field ShareOfVoiceLosers { get; protected set; }
        public Field NoMovement { get; protected set; }
        public Field ShareOfVoiceNoMovement { get; protected set; }

        public RankingMovementFields() : this(null)
        {
        }

        public RankingMovementFields(FieldsDescriptor parent) : base(parent, "ranking_movement")
        {
            MakeFields<RankingMovement>();
        }
    }
}