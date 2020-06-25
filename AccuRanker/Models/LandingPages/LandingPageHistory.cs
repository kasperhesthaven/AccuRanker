namespace DentsuDataLab.AccuRanker.Models.LandingPages
{
    using Newtonsoft.Json;

    using Utility.Fields;

    public class LandingPageHistory
    {
        internal LandingPageHistory()
        {
        }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("average_rank")]
        public double AverageRank { get; set; }

        [JsonProperty("share_of_voice")]
        public int ShareOfVoice { get; set; }

        [JsonProperty("search_volume")]
        public int SearchVolume { get; set; }

        [JsonProperty("keywords")]
        public int Keywords { get; set; }
    }

    public class LandingPageHistoryFields : FieldsDescriptor
    {
        public Field Date { get; protected set; }
        public Field AverageRank { get; protected set; }
        public Field ShareOfVoice { get; protected set; }
        public Field SearchVolume { get; protected set; }
        public Field Keywords { get; protected set; }

        public LandingPageHistoryFields() : this(null)
        {
        }

        public LandingPageHistoryFields(FieldsDescriptor parent) : base(parent, "history")
        {
            MakeFields<LandingPageHistory>();
        }
    }
}
