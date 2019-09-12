using System;
using System.Globalization;
using Xamarin.Forms;

namespace MvvmMeetup.ViewModels
{
    public class DecimalToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var _value = (decimal)value;
            return _value > 10 ? Color.Red : Color.Green;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
