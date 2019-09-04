using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Data;
using System.Globalization;
using System.Windows;

namespace LaserEngineHmi.View.Converters
{
    [ValueConversion(typeof(int), typeof(string))]
    public class NcFolderLevelIconConverter : IValueConverter
    {
        public object Convert(object value,
            Type targetType, object parameter, CultureInfo culture)
        {
            int temp = (int)value;
            if (temp == 1) return "-";
            else if (temp == 2) return "   |-";
            else if (temp == 3) return "       |-";
            else return "";
        }
        //反转换方法，将字符串转换为日期类型
        public object ConvertBack(object value,
            Type targetType, object parameter, CultureInfo culture)
        {
            string temp = (string)value;
            if (temp == "空气") return 1;
            else if (temp == "氧气") return 2;
            else if (temp == "氮气") return 3;
            else return 4;
        }
    }
    
}
