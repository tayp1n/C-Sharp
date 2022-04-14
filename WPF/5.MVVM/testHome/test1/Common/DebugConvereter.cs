using System;
using System.Globalization;
using System.Windows.Data;

namespace Common
{
	public class DebugConvereter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return value;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return value;
		}
	}

}
