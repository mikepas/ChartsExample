using System;
using System.Windows.Controls;
using LiveCharts;
using LiveCharts.Wpf;

namespace ChartsPOC
{
    public partial class BasicColumn : UserControl
    {
        public SeriesCollection SeriesCollection { get; set; }
        public string[] Labels { get; set; }
        public Func<double, string> Formatter { get; set; }

        public BasicColumn()
        {
            InitializeComponent();

            SeriesCollection = new SeriesCollection
            {
                new ColumnSeries {Title = "Ja", Values = new ChartValues<double> {50}},
                new ColumnSeries {Title = "Nee", Values = new ChartValues<double> {10}}
            };

            Labels = new[] { "hebben de bezoekers het naar hun zin?" };
            Formatter = value => value.ToString("N");

            DataContext = this;
        }
    }
}
