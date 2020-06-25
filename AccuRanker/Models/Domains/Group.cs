namespace DentsuDataLab.AccuRanker.Models.Domains
{
    using Accounts;

    using Newtonsoft.Json;

    using Utility.Fields;

    public class Group
    {
        internal Group()
        {
        }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("account")]
        public Account Account { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
    }

    public class GroupFields : FieldsDescriptor
    {
        public Field Id { get; protected set; }

        public Field Name { get; protected set; }

        public Field CreatedAt { get; protected set; }

        public AccountFields Account => new AccountFields(this);

        public GroupFields() : this(null)
        {
        }

        public GroupFields(FieldsDescriptor parent) : base(parent, "group")
        {
            MakeFields<Group>();
        }
    }
}
