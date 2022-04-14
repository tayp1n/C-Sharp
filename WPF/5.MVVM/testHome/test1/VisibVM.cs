using Common;
using System;
using System.Windows;

namespace Test
{
	public class VisibVM : OnPropertyChangedClass
	{
		public VisibVM()
		{
			VisibComm = new RelayCommand(OnVisib);
			SelectVisib = Visibility.Collapsed;
		}
		public Array VisibList => Enum.GetValues(typeof(Visibility));

		private Visibility _selectVisib;
		public Visibility SelectVisib
		{
			get => _selectVisib;
			set { _selectVisib = value; OnPropertyChanged(); }
		}

		public RelayCommand VisibComm { get; set; }

		public void OnVisib(object param)
		{
			int indexOf = Array.IndexOf(VisibList, SelectVisib);
			SelectVisib = (Visibility)VisibList.GetValue((indexOf + 1) % VisibList.Length);
		}

	}
}
