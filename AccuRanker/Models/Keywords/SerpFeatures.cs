namespace DentsuDataLab.AccuRanker.Models.Keywords
{
    using Newtonsoft.Json;
    using Utility.Fields;

    public class SerpFeatures
    {
        internal SerpFeatures()
        {
        }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("ads_top")]
        public bool AdsTop { get; set; }

        [JsonProperty("ads_bottom")]
        public bool AdsBottom { get; set; }

        [JsonProperty("shopping")]
        public bool Shopping { get; set; }

        [JsonProperty("maps_local_teaser")]
        public bool MapsLocalTeaser { get; set; }

        [JsonProperty("maps_local")]
        public bool MapsLocal { get; set; }

        [JsonProperty("related_questions")]
        public bool RelatedQuestions { get; set; }

        [JsonProperty("carousel")]
        public bool Carousel { get; set; }

        [JsonProperty("image_pack")]
        public bool ImagePack { get; set; }

        [JsonProperty("reviews")]
        public bool Reviews { get; set; }

        [JsonProperty("tweets")]
        public bool Tweets { get; set; }

        [JsonProperty("news")]
        public bool News { get; set; }

        [JsonProperty("site_links")]
        public bool SiteLinks { get; set; }

        [JsonProperty("feature_snippet")]
        public bool FeatureSnippet { get; set; }

        [JsonProperty("knowledge_panel")]
        public bool KnowledgePanel { get; set; }

        [JsonProperty("knowledge_cards")]
        public bool KnowledgeCards { get; set; }

        [JsonProperty("video")]
        public bool Video { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class SerpFeaturesFields : FieldsDescriptor
    {
        public Field Id { get; protected set; }

        public Field AdsTop { get; protected set; }

        public Field AdsBottom { get; protected set; }

        public Field Shopping { get; protected set; }

        public Field MapsLocalTeaser { get; protected set; }

        public Field MapsLocal { get; protected set; }

        public Field RelatedQuestions { get; protected set; }

        public Field Carousel { get; protected set; }

        public Field ImagePack { get; protected set; }

        public Field Reviews { get; protected set; }

        public Field Tweets { get; protected set; }

        public Field News { get; protected set; }

        public Field SiteLinks { get; protected set; }

        public Field FeatureSnippet { get; protected set; }

        public Field KnowledgePanel { get; protected set; }

        public Field KnowledgeCards { get; protected set; }

        public Field Video { get; protected set; }

        public Field Total { get; protected set; }

        public SerpFeaturesFields() : this(null)
        {
        }

        public SerpFeaturesFields(FieldsDescriptor parent) : base(parent, "page_serp_features")
        {
            MakeFields<SerpFeatures>();
        }
    }
}