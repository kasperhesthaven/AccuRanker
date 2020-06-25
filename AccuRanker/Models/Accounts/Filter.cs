namespace DentsuDataLab.AccuRanker.Models.Accounts
{
    using Newtonsoft.Json;

    using Utility.Fields;

    public class Filter
    {
        internal Filter()
        {
        }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("attribute")]
        public string Attribute { get; set; }

        [JsonProperty("comparison")]
        public string Comparison { get; set; }
    }

    public class FiltersFields : FieldsDescriptor
    {
        public Field Type { get; protected set; }
        public Field Value { get; protected set; }
        public Field Attribute { get; protected set; }
        public Field Comparison { get; protected set; }

        public FiltersFields() : this(null)
        {
        }

        public FiltersFields(FieldsDescriptor parent) : base(parent, "filters")
        {
            MakeFields<Filter>();
        }
    }
}
