using System;
using System.Windows;
using System.Windows.Controls;

namespace WpfProj2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string leftoperand = "";
        string operation = "";
        string rightoperand = "";

        public MainWindow()
        {
            InitializeComponent();

            foreach (UIElement c in LayoutRoot.Children)
            {
                if (c is Button)
                {
                    if ( ((Button)c).Name != "btnCE" && ((Button)c).Name != "btnC")
                    {
                        ((Button)c).Click += Button_Click;
                    }
                }
            }
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int num;

            string s = (string)((Button)e.OriginalSource).Content;
            bool action = Int32.TryParse(s, out num);
            if (action == true)
            {
                if (operation == "")
                {
                    leftoperand += s;
                }
                else
                {
                    rightoperand += s;
                }
                inputLabel.Content += s;
            }
            else
            {
                if (s == "=")
                {
                    Calculate();
                    resLabel.Content = rightoperand;
                    return;
                }
                else if (s == "<")
                {
                    if (operation != "")
                    {
                        rightoperand = rightoperand.Remove(rightoperand.Length-1);
                    }
                    else
                    {
                        leftoperand = leftoperand.Remove(leftoperand.Length - 1);
                    }
                    inputLabel.Content = ((string)inputLabel.Content).Remove(((string)inputLabel.Content).Length - 1);
                    return;
                }
                else if (s == ".")
                {
                    if (operation != "")
                    {
                        rightoperand += ",";
                    }
                    else
                    {
                        leftoperand += ",";
                    }
                    inputLabel.Content += ",";
                    return;
                }
                if (rightoperand != "")
                 {
                     Calculate();
                     leftoperand = rightoperand;
                     rightoperand = "";
                 }
                inputLabel.Content += s;
                operation = s;
                
            }
        }
        void Calculate()
        {
            double num1 = Double.Parse(leftoperand);
            double num2 = Double.Parse(rightoperand);
            switch (operation)
            {
              
                case "-":
                    rightoperand = (num1 - num2).ToString();
                    break;
                case "*":
                    rightoperand = (num1 * num2).ToString();
                    break;
                case "/":
                    rightoperand = (num1 / num2).ToString();
                    break;
                case "+":
                    rightoperand = (num1 + num2).ToString();
                    break;
              
            }
        }

        private void btnCE_Click(object sender, RoutedEventArgs e)
        {
            resLabel.Content = "";
        }

        private void btnC_Click(object sender, RoutedEventArgs e)
        {
            resLabel.Content = "";
            inputLabel.Content = "";
            leftoperand = "";
            rightoperand = "";

        }
    }
}
