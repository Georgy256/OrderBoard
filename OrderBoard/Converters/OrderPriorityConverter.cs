using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.ComponentModel;
using System.Windows;
using OrderBoard.Constants;
using System.Windows.Controls;

namespace OrderBoard.Converters
{
    public class OrderPriorityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ((OrderPriority)value).ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (OrderPriority)Enum.Parse(typeof(OrderPriority), value.ToString());
        }
    }
}
