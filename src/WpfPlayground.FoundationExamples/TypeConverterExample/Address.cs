using System.ComponentModel;

namespace WpfPlayground.FoundationExamples.TypeConverterExample
{
    [TypeConverter(typeof(AddressConverter))]
    public class Address
    {
        public string Street { get; set; }

        public string StreetNumber { get; set; }

        public int ZipCode { get; set; }

        public string City { get; set; }
    }
}
