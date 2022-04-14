using System.Windows;
using System.Windows.Input;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //1
        void Button_Click(object sender, RoutedEventArgs e)
        {
            Height = 300;
            Width = 300;
            Left = -7;
            Top = 0;
        }

        //2
        void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Up)
            {
                Top -= 10;
            }
            if (e.Key == Key.Left)
            {
                Left -= 10;
            }
            if (e.Key == Key.Down)
            {
                Top += 10;
            }
            if (e.Key == Key.Right)
            {
                Left += 10;
            }
            switch (e.Key)
            {
                case Key.Up:
                    Top -= 10;
                    break;
                case Key.Left:
                    Left -= 10;
                    break;
                case Key.Down:
                    Top += 10;
                    break;
                case Key.Right:
                    Left += 10;
                    break;
                default:
                    Title = "None";
                    break;
            }
        }
    }
}
