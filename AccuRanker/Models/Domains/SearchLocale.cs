namespace DentsuDataLab.AccuRanker.Models.Domains
{
    using Newtonsoft.Json;

    using Utility.Fields;

    public class SearchLocale
    {
        internal SearchLocale()
        {
        }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }

        [JsonProperty("locale_short")]
        public string LocaleShort { get; set; }
    }

    public class SearchLocaleFields : FieldsDescriptor
    {
        public Field Id { get; protected set; }

        public Field CountryCode { get; protected set; }

        public Field Region { get; protected set; }

        public Field Locale { get; protected set; }

        public Field LocaleShort { get; protected set; }

        public SearchLocaleFields() : this(null)
        {
        }

        public SearchLocaleFields(FieldsDescriptor parent) : this(parent, "search_locale")
        {
        }

        protected SearchLocaleFields(FieldsDescriptor parent, string name) : base(parent, name)
        {
            MakeFields<SearchLocale>();
        }
    }

    public class DefaultSearchLocaleFields : SearchLocaleFields
    {
        public DefaultSearchLocaleFields(FieldsDescriptor parent) : base(parent, "default_search_locale")
        {
        }
    }
}
