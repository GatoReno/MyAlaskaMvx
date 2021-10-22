using System;
using System.Globalization;
using MvvmCross.Converters;

namespace MyOwnAppMvx.Converters
{
    public class DateConverter : MvxValueConverter<DateTime, string>
    {
        protected override string Convert(DateTime value, Type targetType, object parameter, CultureInfo culture)
        {
            var date = value.ToString("dd/MM hh:mm tt");
            return date;
        }
    }
}
