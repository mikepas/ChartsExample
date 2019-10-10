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

namespace ChartsPOC
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ColumnChart_OnClick(object sender, RoutedEventArgs e)
        {
            var columnChartWindow = new ColumnChartWindow();
            columnChartWindow.Show();
        }

        private void LineChart_OnClick(object sender, RoutedEventArgs e)
        {
            var lineChartWindow = new LineChartWindow();
            lineChartWindow.Show();
        }

        private void PieChart_OnClick(object sender, RoutedEventArgs e)
        {
            var pieChartWindow = new PieChartWindow();
            pieChartWindow.Show();
        }
    }
}
