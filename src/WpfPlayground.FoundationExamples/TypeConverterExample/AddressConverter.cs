using System;
using System.ComponentModel;
using System.Globalization;

namespace WpfPlayground.FoundationExamples.TypeConverterExample
{
    public class AddressConverter : TypeConverter
    {
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            if (sourceType == typeof(string))
                return true;
            return base.CanConvertFrom(context, sourceType);
        }

        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            if(value is string)
            {
                string[] values = value.ToString().Split(' ');
                if(values.Length == 4)
                {
                    return new Address
                    {
                        Street = values[0],
                        StreetNumber = values[1],
                        ZipCode = int.Parse(values[2]),
                        City = values[3]
                    };
                }
            }

            return base.ConvertFrom(context, culture, value);
        }
    }
}
