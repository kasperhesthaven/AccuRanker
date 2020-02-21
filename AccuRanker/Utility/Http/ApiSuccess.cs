namespace DentsuDataLab.AccuRanker.Utility.Http
{
    using Newtonsoft.Json;

    public class ApiSuccess
    {
        [JsonProperty("successMessage")]
        public string SuccessMessage { get; set; }
    }
}