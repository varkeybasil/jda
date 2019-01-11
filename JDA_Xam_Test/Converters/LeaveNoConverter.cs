using System;
using System.Globalization;
using Xamarin.Forms;

namespace JDA_Xam_Test.Converters
{
    public class LeaveNoConverter : IValueConverter
    {
        public LeaveNoConverter()
        {
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var days = value;
            if ((int)days > 1)
            {
                return days + "days";
            }
            else
                return "1 day";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
