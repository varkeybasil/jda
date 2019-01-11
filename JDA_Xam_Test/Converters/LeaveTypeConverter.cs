using System;
using System.Globalization;
using JDA_Xam_Test.Models;
using Xamarin.Forms;

namespace JDA_Xam_Test.Converters
{
    public class LeaveTypeConverter : IValueConverter
    {
        public LeaveTypeConverter()
        {
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var status = value;
            if (status is LeavesStatus.Approved)
                return Color.FromHex("#2d8a8e");
            else if (status is LeavesStatus.Rejected)
                return Color.FromHex("#fc393e");
            else if (status is LeavesStatus.Pending)
                return Color.FromHex("#4696cf");
            else
                return Color.Wheat;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
