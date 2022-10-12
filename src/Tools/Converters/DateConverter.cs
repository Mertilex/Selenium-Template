using System.Globalization;

namespace Tools.Converters
{

    public static class DateConverter
    {
        private static readonly CultureInfo CurrentCultureInfo = CultureInfo.InvariantCulture;

        public static string ToFileDateTimeString(this DateTime value)
        {
            return value.ToString("yyyyMMdd_HHmmss", CurrentCultureInfo);
        }
    }
}