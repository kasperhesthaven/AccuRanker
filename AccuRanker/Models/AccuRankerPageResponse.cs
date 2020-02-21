namespace DentsuDataLab.AccuRanker.Models
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class AccuRankerPageResponse<T>
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("next")]
        public string NextPage { get; set; }

        [JsonProperty("previous")]
        public string PrevPage { get; set; }

        [JsonProperty("results")]
        public IEnumerable<T> Results { get; set; }
    }
}