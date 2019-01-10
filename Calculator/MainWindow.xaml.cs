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

namespace Calculator
{

    public partial class MainWindow : Window
    {

        double num1 = 0;
        double num2 = 0;
        string operation = "";


        public MainWindow()
        {
            InitializeComponent();
            txtHistory.Content = null;
        }

        private void b1_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num1 = (num1 * 10) + 1;
                txtDisplay.Text = num1.ToString();
                txtHistory.Content = null;
            }
            else
            {
                num2 = (num2 * 10) + 1;
                txtDisplay.Text = num2.ToString();
            }


        }

        private void b2_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num1 = (num1 * 10) + 2;
                txtDisplay.Text = num1.ToString();
                txtHistory.Content = null;
            }
            else
            {
                num2 = (num2 * 10) + 2;
                txtDisplay.Text = num2.ToString();
            }
        }

        private void b3_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num1 = (num1 * 10) + 3;
                txtDisplay.Text = num1.ToString();
                txtHistory.Content = null;
            }
            else
            {
                num2 = (num2 * 10) + 3;
                txtDisplay.Text = num2.ToString();
            }
        }

        private void b4_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num1 = (num1 * 10) + 4;
                txtDisplay.Text = num1.ToString();
                txtHistory.Content = null;
            }
            else
            {
                num2 = (num2 * 10) + 4;
                txtDisplay.Text = num2.ToString();
            }
        }

        private void b5_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num1 = (num1 * 10) + 5;
                txtDisplay.Text = num1.ToString();
                txtHistory.Content = null;
            }
            else
            {
                num2 = (num2 * 10) + 5;
                txtDisplay.Text = num2.ToString();
            }
        }

        private void b6_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num1 = (num1 * 10) + 6;
                txtDisplay.Text = num1.ToString();
                txtHistory.Content = null;
            }
            else
            {
                num2 = (num2 * 10) + 6;
                txtDisplay.Text = num2.ToString();
            }
        }

        private void b7_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num1 = (num1 * 10) + 7;
                txtDisplay.Text = num1.ToString();
                txtHistory.Content = null;
            }
            else
            {
                num2 = (num2 * 10) + 7;
                txtDisplay.Text = num2.ToString();
            }
        }

        private void b8_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num1 = (num1 * 10) + 8;
                txtDisplay.Text = num1.ToString();
                txtHistory.Content = null;
            }
            else
            {
                num2 = (num2 * 10) + 8;
                txtDisplay.Text = num2.ToString();
            }
        }

        private void b9_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num1 = (num1 * 10) + 9;
                txtDisplay.Text = num1.ToString();
                txtHistory.Content = null;
            }
            else
            {
                num2 = (num2 * 10) + 9;
                txtDisplay.Text = num2.ToString();
            }
        }

        private void b0_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num1 = (num1 * 10) + 0;
                txtDisplay.Text = num1.ToString();
                txtHistory.Content = null;
            }
            else
            {
                num2 = (num2 * 10) + 0;
                txtDisplay.Text = num2.ToString();
            }
        }

        private void bplus_Click(object sender, RoutedEventArgs e)
        {
            operation = "+";
            txtDisplay.Text = "0";
        }

        private void bminus_Click(object sender, RoutedEventArgs e)
        {
            operation = "-";
            txtDisplay.Text = "0";
        }

        private void bx_Click(object sender, RoutedEventArgs e)
        {
            operation = "*";
            txtDisplay.Text = "0";
        }

        private void bequal_Click(object sender, RoutedEventArgs e)
        {
            switch (operation) //a
            {
                case "+":
                    txtDisplay.Text = (num1 + num2).ToString();
                    txtHistory.Content = Convert.ToString(num1 + " + " + num2);
                    num1 = num1 + num2;
                    num2 = 0;
                    operation = "";
                    break;
                case "-":
                    txtDisplay.Text = (num1 - num2).ToString();
                    txtHistory.Content = Convert.ToString(num1 + " - " + num2);
                    num1 = num1 - num2;
                    num2 = 0;
                    operation = "";
                    break;
                case "*":
                    txtDisplay.Text = (num1 * num2).ToString();
                    txtHistory.Content = Convert.ToString(num1 + " * " + num2);
                    num1 = num1 * num2;
                    num2 = 0;
                    operation = "";
                    break;
                case "/":
                    try
                    {
                        txtDisplay.Text = (num1 / num2).ToString();
                        txtHistory.Content = Convert.ToString(num1 + " / " + num2); 
                        num1 = num1 / num2;
                        num2 = 0;
                        operation = "";
                    }
                    catch (DivideByZeroException)
                    {
                        txtDisplay.Text = "Error";
                    }
                    break;
                case "potenssi":
                    txtDisplay.Text = Math.Pow(num1, num2).ToString();
                    txtHistory.Content = Convert.ToString(num1 + " ^ " + num2);
                    num1 = Math.Pow(num1, num2);
                    num2 = 0;
                    operation = "";
                    break;
            }
        }

        private void bc_Click(object sender, RoutedEventArgs e)
        {
            num1 = 0;
            num2 = 0;
            operation = "";
            txtDisplay.Text = "0";
            txtHistory.Content = null;
        }

        private void bdiv_Click(object sender, RoutedEventArgs e)
        {
            operation = "/";
            txtDisplay.Text = "0";
        }

        private void bpii_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num1 = Math.PI;
                txtDisplay.Text = num1.ToString();
            }
            else
            {
                num2 = Math.PI;
                txtDisplay.Text = num2.ToString();
            }
        }

      

        private void broot_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                txtHistory.Content = $"√({num1})";
                num1 = Math.Sqrt(num1);
                txtDisplay.Text = num1.ToString();
            }
            else
            {
                txtHistory.Content = $"√({num2})";
                num2 = Math.Sqrt(num2);
                txtDisplay.Text = num2.ToString();
            }

        }

        private void bfactorial_Click(object sender, RoutedEventArgs e)
        {
            txtHistory.Content = $"Fact({num1})";
            double temp = num1;
            for (int i = 1; i < temp; i++)
            {
                num1 = num1 * i;
            }
            txtDisplay.Text = num1.ToString();

        }

        private void bsin_Click(object sender, RoutedEventArgs e)
        {
            txtHistory.Content = $"Sin({num1})";
            num1 = Math.Sin(num1);
            txtDisplay.Text = num1.ToString();
        }

        private void bcos_Click(object sender, RoutedEventArgs e)
        {
            txtHistory.Content = $"Cos({num1})";
            num1 = Math.Cos(num1);
            txtDisplay.Text = num1.ToString();            
        }

        private void btan_Click(object sender, RoutedEventArgs e)
        {
            txtHistory.Content = $"Tan({num1})";
            num1 = Math.Tan(num1);
            txtDisplay.Text = num1.ToString();
        }

        private void bpotenssi_Click(object sender, RoutedEventArgs e)
        {
            operation = "potenssi";
            txtDisplay.Text = "0";
        }

        private void btonegative_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num1 *= -1;
                txtDisplay.Text = num1.ToString();
            }
            else
            {
                num2 *= -1;
                txtDisplay.Text = num2.ToString();
            }
        }
    }
}
