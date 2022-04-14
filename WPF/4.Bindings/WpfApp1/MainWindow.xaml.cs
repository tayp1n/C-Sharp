using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Brush brushBlack = Brushes.Black;
        ObservableCollection<string> words;
        Random rand = new Random();
        List<string> listWords = new List<string>() 
        { 
            "Hello",
            "How",
            "Are",
            "You",
            "?"
        };
        public MainWindow()
        {
            InitializeComponent();
            words = new ObservableCollection<string>();
            lbWords.ItemsSource = words;
            btnRemove.IsEnabled = false;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            words.Add(listWords[rand.Next(4)]);
        }


        private void lbWords_Selected(object sender, RoutedEventArgs e)
        {
            btnRemove.IsEnabled = true;
            var lbi = (string)lbWords.SelectedItem;
            label.Content = lbi;
            label.Foreground = brushBlack;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var lbi = (string)lbWords.SelectedItem;
            Brush brush = Brushes.Green;
            label.Foreground = brush;

            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            words.Clear();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var lbi = (string)lbWords.SelectedItem;
            words.Remove(lbi);
        }
    }
}
