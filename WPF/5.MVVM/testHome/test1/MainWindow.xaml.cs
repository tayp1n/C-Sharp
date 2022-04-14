using Test.View;
using Test.ViewModel;
using System.Windows;

namespace Test
{
	/// <summary>
	/// Логика взаимодействия для MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		Window asas;
		public MainWindow()
		{
			DataContext = new EditWorkersVM(FullViewPersonDialog);
			InitializeComponent();
		}

		/// <summary>Метод вызова Диалого с плным показом информации</summary>
		/// <returns>Возвращает:
		/// <see langword="true"/> - если нажато "Сохранить",
		/// <see langword="false"/> - если "Отменить",
		/// <see langword="null"/> - если закрыт диалог без использования кнопок.</returns>
		private bool? FullViewPersonDialog()
			=> new FullViewPerson() { DataContext = DataContext }
			.ShowDialog();
	}
}
