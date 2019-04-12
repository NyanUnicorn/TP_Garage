using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace TPGarage.Client.Converters
{
    class IsCheckedToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) 
            => value is bool ? value.Equals(true) ? Visibility.Visible : Visibility.Collapsed : Visibility.Collapsed;
        /*{
            Visibility result = Visibility.Collapsed;
            if(value != null && value != DependencyProperty.UnsetValue)
            {
                result = Visibility.Visible;
            }
            return result;
        }*/

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
