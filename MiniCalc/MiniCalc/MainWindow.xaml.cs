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

namespace MiniCalc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        long nr1 = 0;
        long nr2 = 0;
        string input = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if (input == "")
            {
                nr1 = (nr1 * 10) + 1;
                txtDisplay.Text = nr1.ToString();
            }
            else
            {
                nr2 = (nr2 * 10) + 1;
                txtDisplay.Text = nr2.ToString();

            }
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            if (input == "")
            {
                nr1 = (nr1 * 10) + 2;
                txtDisplay.Text = nr1.ToString();
            }
            else
            {
                nr2 = (nr2 * 10) + 2;
                txtDisplay.Text = nr2.ToString();

            }
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            if (input == "")
            {
                nr1 = (nr1 * 10) + 3;
                txtDisplay.Text = nr1.ToString();
            }
            else
            {
                nr2 = (nr2 * 10) + 3;
                txtDisplay.Text = nr2.ToString();
            }
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            if (input == "")
            {
                nr1 = (nr1 * 10) + 4;
                txtDisplay.Text = nr1.ToString();
            }
            else
            {
                nr2 = (nr2 * 10) + 4;
                txtDisplay.Text = nr2.ToString();
            }
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            if (input == "")
            {
                nr1 = (nr1 * 10) + 5;
                txtDisplay.Text = nr1.ToString();
            }
            else
            {
                nr2 = (nr2 * 10) + 5;
                txtDisplay.Text = nr2.ToString();
            }
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            if (input == "")
            {
                nr1 = (nr1 * 10) + 6;
                txtDisplay.Text = nr1.ToString();
            }
            else
            {
                nr2 = (nr2 * 10) + 6;
                txtDisplay.Text = nr2.ToString();
            }
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            if (input == "")
            {
                nr1 = (nr1 * 10) + 7;
                txtDisplay.Text = nr1.ToString();
            }
            else
            {
                nr2 = (nr2 * 10) + 7;
                txtDisplay.Text = nr2.ToString();
            }
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            if (input == "")
            {
                nr1 = (nr1 * 10) + 8;
                txtDisplay.Text = nr1.ToString();
            }
            else
            {
                nr2 = (nr2 * 10) + 8;
                txtDisplay.Text = nr2.ToString();
            }
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            if (input == "")
            {
                nr1 = (nr1 * 10) + 9;
                txtDisplay.Text = nr1.ToString();
            }
            else
            {
                nr2 = (nr2 * 10) + 9;
                txtDisplay.Text = nr2.ToString();
            }
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            if (input == "")
            {
                nr1 = (nr1 * 10);
                txtDisplay.Text = nr1.ToString();
            }
            else
            {
                nr2 = (nr2 * 10);
                txtDisplay.Text = nr2.ToString();
            }
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            input = "+";
            txtDisplay.Text = "0";
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            input = "-";
            txtDisplay.Text = "0";

        }

        private void btnMultiply_Click(object sender, RoutedEventArgs e)
        {
            input = "*";
            txtDisplay.Text = "0";
        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            input = "/";
            txtDisplay.Text = "0";
        }

        private void btnEquals_Click(object sender, RoutedEventArgs e)
        {
            switch (input)
            {
                case "+":
                    txtDisplay.Text = (nr1 + nr2).ToString();
                    break;
                case "-":
                    txtDisplay.Text = (nr1 - nr2).ToString();
                    break;
                case "*":
                    txtDisplay.Text = (nr1 * nr2).ToString();
                    break;
                case "/":
                    txtDisplay.Text = (nr1 / nr2).ToString();
                    break;
            }
        }

        private void btnPlusMinus_Click(object sender, RoutedEventArgs e)
        {
            if (input == "")
            {
                nr1 *= -1;
                txtDisplay.Text = nr1.ToString();
            }
            else
            {
                nr2 *= -1;
                txtDisplay.Text = nr2.ToString();

            }
        }

        private void btnAC_Click(object sender, RoutedEventArgs e)
        {
            nr1 = 0;
            nr2 = 0;
            input = "";
            txtDisplay.Text = "0";
        }

        private void btnComma_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Text += "."; 
        }

        private void btnBackSpace_Click(object sender, RoutedEventArgs e)
        {
            if (input == "")
            {
                nr1 = (nr1 / 10);
                txtDisplay.Text = nr1.ToString();
            }
            else
            {
                nr2 = (nr2 / 10);
                txtDisplay.Text = nr2.ToString();

            }
        }
    }
}



