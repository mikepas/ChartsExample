using System;
using System.Windows.Controls;
using System.Windows.Media;
using LiveCharts;
using LiveCharts.Wpf;

namespace ChartsPOC
{
    public partial class LineChart : UserControl
    {
        public SeriesCollection SeriesCollection { get; set; }
        public string[] Labels { get; set; }
        public Func<int, string> YFormatter { get; set; }

        public LineChart()
        {
            InitializeComponent();

            SeriesCollection = new SeriesCollection
            {
                new LineSeries { Title = "Bezoekers", Values = new ChartValues<int> {40, 60, 50, 20, 40, 60}}
            };

            Labels = new[] {"10:00", "12:00", "14:00", "16:00", "18:00", "20:00"};
            YFormatter = value => value.ToString("N1");

            DataContext = this;
        }
    }
}
