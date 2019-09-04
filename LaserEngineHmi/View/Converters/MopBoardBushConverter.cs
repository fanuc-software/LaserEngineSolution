using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Data;
using System.Globalization;
using System.Windows;

namespace LaserEngineHmi.View.Converters
{
    [ValueConversion(typeof(bool), typeof(string))]
    public class MopBoardBushConverter : IValueConverter
    {
        public object Convert(object value,
            Type targetType, object parameter, CultureInfo culture)
        {
            bool bTemp = (bool)value;
            if (bTemp == true) return "#FF333399";
            else return "#FF484848";
        }
        //反转换方法，将字符串转换为日期类型
        public object ConvertBack(object value,
            Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
