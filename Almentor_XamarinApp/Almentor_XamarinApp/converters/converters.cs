using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace Almentor_XamarinApp.converters
{
    [Preserve(AllMembers = true)]
    public class ConverterIndex : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int val = int.Parse(value.ToString());
            return $"{val } : 3";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
