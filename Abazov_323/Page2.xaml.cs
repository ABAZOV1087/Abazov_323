using System;
using System.Windows;
using System.Windows.Controls;

namespace Abazov_323
{
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(txtX.Text, out double x) && double.TryParse(txtY.Text, out double y))
            {
                double fx;
                if (rbSinh.IsChecked == true) fx = Math.Sinh(x);
                else if (rbSqr.IsChecked == true) fx = Math.Pow(x, 2);
                else fx = Math.Exp(x);

                double d;
                if (x > y)
                {
                    d = Math.Pow(fx - y, 3) + Math.Atan(fx);
                }
                else if (y > x)
                {
                    d = Math.Pow(y - fx, 3) + Math.Atan(fx);
                }
                else
                {
                    d = Math.Pow(y + fx, 3) + 0.5;
                }

                txtResult.Text = d.ToString("F6");
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите числовые значения для x и y.");
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtX.Clear();
            txtY.Clear();
            txtResult.Clear();
            rbSinh.IsChecked = true;
        }
    }
}