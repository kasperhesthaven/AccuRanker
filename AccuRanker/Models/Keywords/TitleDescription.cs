namespace DentsuDataLab.AccuRanker.Models.Keywords
{
    using Newtonsoft.Json;

    using Utility.Fields;

    public class TitleDescription
    {
        internal TitleDescription()
        {
        }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class TitleDescriptionFields : FieldsDescriptor
    {
        public Field Id { get; protected set; }

        public Field Title { get; protected set; }

        public Field Description { get; protected set; }

        public TitleDescriptionFields() : this(null)
        {
        }

        public TitleDescriptionFields(FieldsDescriptor parent) : base(parent, "title_description")
        {
            MakeFields<TitleDescription>();
        }
    }
}
