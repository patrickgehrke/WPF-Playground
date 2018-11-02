namespace WpfPlayground.FoundationExamples.TypeConverterExample
{
    public class Friend
    {
        public string Name { get; set; }

        public Address Address { get; set; }

        public override string ToString()
        {
            if (this.Address != null)
                return $"Name: {Name} Address: {Address.Street} {Address.StreetNumber} {Address.ZipCode} {Address.City}";

            return base.ToString();
        }
    }
}
