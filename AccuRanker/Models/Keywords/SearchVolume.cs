namespace DentsuDataLab.AccuRanker.Models.Keywords
{
    using Newtonsoft.Json;

    using Utility.Fields;

    public class SearchVolume
    {
        public SearchVolume()
        {
        }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("search_volume")]
        public int? SearchVolumeAmount { get; set; }

        [JsonProperty("avg_cost_per_click")]
        public double? AvgCostPerClick { get; set; }

        [JsonProperty("competition")]
        public double? Competition { get; set; }
    }

    public class SearchVolumeFields : FieldsDescriptor
    {
        public Field Id { get; protected set; }

        public Field SearchVolumeAmount { get; protected set; }

        public Field AvgCostPerClick { get; protected set; }

        public Field Competition { get; protected set; }

        public SearchVolumeFields() : this(null)
        {
        }

        public SearchVolumeFields(FieldsDescriptor parent) : base(parent, "search_volume")
        {
            MakeFields<SearchVolume>();
        }
    }
}