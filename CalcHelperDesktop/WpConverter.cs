using System;
using System.Globalization;
using System.Windows.Data;

namespace CalcHelperDesktop
{
    public class WpConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int result = Int32.Parse(value.ToString()) - 200;
            return result < 0 ? 0 : result ;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
