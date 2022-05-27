using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Navigation;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace SmartphoneManager.Pages
{
    /// <summary>
    /// Page that shows a chart with the price history of the selected smartphone
    /// </summary>
    public sealed partial class DetailPage : Page
    {
        private static List<List<string>> priceHistory;

        /// <summary>
        /// Default main constructor
        /// </summary>
        public DetailPage()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// This function loads the data into the chart when the page is loaded
        /// </summary>
        /// <param name="e"></param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            Params data = e.Parameter as Params;

            priceHistory = data.Data;

            foreach (var price in priceHistory)
                foreach (var date in price)
                Debug.WriteLine(date);

            LineSeries ls = new LineSeries();
            ls.MarkerType = MarkerType.Circle;
            
            //Add datapoints to line
            foreach (var row in priceHistory)
            {
                string[] date = row[1].Split(' ');
                ls.Points.Add(new DataPoint(DateTimeAxis.ToDouble(DateTime.ParseExact(date[0], "d", null)), Convert.ToDouble(row[0])));
            }

            //Create a new chart and apply data lineseries
            chart.Model = new PlotModel
            {
                Title = data.Phone,
                PlotAreaBorderColor = OxyColors.Transparent,
                Axes =
                {
                    new DateTimeAxis { StringFormat = "dd/MM/yyyy", Position = AxisPosition.Bottom },
                    new LinearAxis { Position = AxisPosition.Left },
                },
                Series = { ls }
            };
        }
    }
}
