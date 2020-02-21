namespace DentsuDataLab.AccuRanker.Utility.Fields
{
    public static class FieldsExplorer<TFieldDescriptorType> where TFieldDescriptorType : FieldsDescriptor, new()
    {
        public static TFieldDescriptorType Fields => new TFieldDescriptorType();
    }
}