using System;
using System.Windows;
using System.Windows.Controls;

namespace Abazov_323
{
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(txtX.Text, out double x) &&
                double.TryParse(txtY.Text, out double y) &&
                double.TryParse(txtZ.Text, out double z))
            {
                double part1 = (Math.Exp(x) + 1) / Math.Sqrt(Math.Abs(x - 2));
                double part2 = (2 * Math.Abs(x + y) * Math.Pow(x + 1, -1)) / Math.Atan(z);
                txtResult.Text = (part1 * part2).ToString("F6");
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtX.Clear(); txtY.Clear(); txtZ.Clear(); txtResult.Clear();
        }
    }
}