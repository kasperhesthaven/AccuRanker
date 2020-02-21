namespace DentsuDataLab.AccuRanker.Models.Keywords
{
    using Newtonsoft.Json;
    using Utility.Fields;

    public class SearchEngine
    {
        internal SearchEngine()
        {
        }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class SearchEngineFields : FieldsDescriptor
    {
        public Field Id { get; protected set; }

        public Field Name { get; protected set; }

        public SearchEngineFields() : this(null)
        {
        }

        public SearchEngineFields(FieldsDescriptor parent) : base(parent, "search_engine")
        {
            MakeFields<SearchEngine>();
        }
    }
}