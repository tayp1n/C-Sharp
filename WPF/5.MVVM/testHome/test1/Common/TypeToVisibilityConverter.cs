using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Common
{
	[ValueConversion(typeof(Type), typeof(Visibility))]
	public class TypeToVisibilityConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (value == null)
				return null;
			Type typeOrig = value.GetType();

			if (!(parameter is Type typeTempl) && (!(parameter is string _valp) || (typeTempl = Type.GetType(_valp)) == null))
				return null;

			Visibility result = typeOrig == typeTempl || typeOrig.IsSubclassOf(typeTempl) ? Visibility.Visible : Visibility.Collapsed;
			return result;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
