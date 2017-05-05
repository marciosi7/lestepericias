using System;
using System.Globalization;
using Xamarin.Forms;

namespace LestePericiasMobile.Converters
{
    class FormatDateConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string[] splittedDate = ((DateTime)value).ToString().Split(' ');
            return splittedDate[0];
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
