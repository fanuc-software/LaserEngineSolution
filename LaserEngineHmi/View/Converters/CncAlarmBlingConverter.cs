using System;
using System.Windows.Data;
using System.Globalization;

namespace LaserEngineHmi.View.Converters
{
    [ValueConversion(typeof(int), typeof(string))]
    public class CncAlarmBlingConverter : IValueConverter
    {
        public object Convert(object value,
            Type targetType, object parameter, CultureInfo culture)
        {
            int temp = (int)value;
            if (temp == 3) return "Visible";
            else return "Hidden";
        }
        //反转换方法，将字符串转换为日期类型
        public object ConvertBack(object value,
            Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();

        }
    }
}
