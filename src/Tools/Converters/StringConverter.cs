using System.Drawing;
using System.Globalization;

namespace Tools.Converters
{
    public static class StringConverter
    {
        private static readonly CultureInfo CurrentCultureInfo = CultureInfo.InvariantCulture;

        public static bool ToBool(this string value)
        {
            return Convert.ToBoolean(value, CurrentCultureInfo);
        }

        public static int ToInt(this string value)
        {
            return Convert.ToInt32(value);
        }

        public static Size ToSize(this string value)
        {
            var sc = new SizeConverter();

            if (sc.IsValid(value))
            {
                return (Size)sc.ConvertFromString(value);
            }

            throw new ArgumentException($"The following value cannot be converted to Size type: {value}.");
        }
    }
}