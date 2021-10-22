using System;
using System.Globalization;
using MvvmCross.Converters;

namespace MyOwnAppMvx.Converters
{
    public class FlightNumberConverter : MvxValueConverter<string, string>
    {
        protected override string Convert(string value, Type targetType, object parameter, CultureInfo culture)
        {
            var flightNumber = $"flight n. {value}";
            return flightNumber;
        }
    }
}

