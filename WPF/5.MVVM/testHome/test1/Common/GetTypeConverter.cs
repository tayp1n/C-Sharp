using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Common
{
	[ValueConversion(typeof(object), typeof(Visibility))]
	public class GetTypeConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return value?.GetType();
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
