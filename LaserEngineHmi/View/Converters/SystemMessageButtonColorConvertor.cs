using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Data;
using System.Globalization;
using System.Windows;

namespace LaserEngineHmi.View.Converters
{

    [ValueConversion(typeof(List<string>), typeof(string))]
    public class SystemMessageButtonBackgroundColorConvertor : IValueConverter
    {
        public object Convert(object value,
            Type targetType, object parameter, CultureInfo culture)
        {
            var temp = (List<string>)value;
            if (temp.Count()!=0) return "Red";
            else return "White";
        }
        //反转换方法，将字符串转换为日期类型
        public object ConvertBack(object value,
            Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    [ValueConversion(typeof(List<string>), typeof(string))]
    public class SystemMessageButtonForgroundColorConvertor : IValueConverter
    {
        public object Convert(object value,
            Type targetType, object parameter, CultureInfo culture)
        {
            var temp = (List<string>)value;
            if (temp.Count() != 0) return "White";
            else return "DarkGray";
        }
        //反转换方法，将字符串转换为日期类型
        public object ConvertBack(object value,
            Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
