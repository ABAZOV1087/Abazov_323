using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Abazov_323
{
    public partial class Page3 : Page
    {
        public Page3()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(txtX0.Text, out double x0) &&
                double.TryParse(txtXk.Text, out double xk) &&
                double.TryParse(txtDx.Text, out double dx) &&
                double.TryParse(txtB.Text, out double b))
            {
                txtResult.Clear();
                graphPolyline.Points.Clear();

                double canvasWidth = chartCanvas.ActualWidth;
                double canvasHeight = chartCanvas.ActualHeight;

                for (double x = x0; x <= xk; x = Math.Round(x + dx, 2))
                {
                    double y = (Math.Pow(x, 2.5) - b) * Math.Log(x * x + 12.7);
                    txtResult.AppendText($"x={x:F2} | y={y:F4}\n");

                    double plotX = (x - x0) / (xk - x0) * canvasWidth;
                    double plotY = canvasHeight - (y * 2);
                    graphPolyline.Points.Add(new Point(plotX, plotY));
                }
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Clear();
            graphPolyline.Points.Clear();
        }
    }
}