using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace SmartphoneManager.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class DetailPage : Page
    {
        private static List<List<string>> priceHistory;

        public DetailPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            Params data = e.Parameter as Params;

            priceHistory = data.Data;


            Debug.WriteLine(priceHistory.Count);

            foreach (var price in priceHistory)
                foreach (var date in price)
                Debug.WriteLine(date);

            LineSeries ls = new LineSeries();
            ls.MarkerType = MarkerType.Circle;
            
            foreach (var row in priceHistory)
            {
                string[] date = row[1].Split(' ');
                ls.Points.Add(new DataPoint(DateTimeAxis.ToDouble(DateTime.ParseExact(date[0], "d", null)), Convert.ToDouble(row[0])));
            }

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
