using System;
using System.Collections.Generic;
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
        public MainWindow()
        {
            InitializeComponent();
            List<Shoes> phonesList = new List<Shoes>
            {
                new Shoes { Number="1", Code="00000000001", Articul="Черевики чолов. R1", Size="43" ,Count="1", Price=479 ,Discount="0", EndPrice=479},
                new Shoes { Number="2", Code="00000000002", Articul="Черевики чолов. R2", Size="43" ,Count="1", Price=1179 ,Discount="118", EndPrice=1061}
            };

            List<Bottom1> bottomList = new List<Bottom1> 
            {
                new Bottom1 { Number="000000001", Customer="Кузнецова", Discount="50%", Balls="3150"}
            };

            List<Bottom2> bottomList2 = new List<Bottom2>
            {
                new Bottom2 { Discription="",Discount=""}
            };
            shoesGrid.ItemsSource = phonesList;
            storageCard.ItemsSource = bottomList;
            additionalCard.ItemsSource = bottomList2;
        }
    }
}
