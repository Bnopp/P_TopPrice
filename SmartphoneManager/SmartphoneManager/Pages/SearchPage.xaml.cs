using Microsoft.UI;
using Microsoft.UI.Windowing;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.ViewManagement;
using System.Collections.ObjectModel;
using Microsoft.UI.Xaml.Media.Imaging;
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.Axes;
using Microsoft.UI.Xaml.Media.Animation;
using Microsoft.UI.Xaml.Hosting;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace SmartphoneManager.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SearchPage : Page
    {
        private Data _data;
        private ObservableCollection<Phone> _phones { get; set; }

        public SearchPage()
        {
            this.InitializeComponent();

            cbSort.SelectedIndex = 0;

            _data = new Data();

            _data.EstablishConnection("localhost", "db_topprice", "root", "root");

            //Load OS
            foreach (var os in _data.GetAllOS())
            {
                cbOS.Items.Add(os);
            }

            //Load Brands
            foreach (var brand in _data.GetAllBrands())
            {
                cbConstructor.Items.Add(brand);
            }

            ShowPhones();
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            ShowPhones();
        }

        private void cbFilters(object sender, SelectionChangedEventArgs e)
        {
            if (_data != null)
                ShowPhones();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            ShowPhones();
        }

        private void ShowPhones()
        {
            phoneLibrary.Items.Clear();

            //Load Phones
            foreach (var phone in _data.GetPhones(tbSearch.Text, cbSort.SelectedItem.ToString(), cbConstructor, cbOS))
            {
                
                StackPanel sp = new StackPanel();
                sp.Orientation = Orientation.Vertical;

                var uri = "ms-appx:///Assets/images/phones/imageMissing.png";
                //var uri = "ms-appx:///Assets/images/phones/iPhone SE.png";

                if (File.Exists(System.AppDomain.CurrentDomain.BaseDirectory + "/Assets/images/phones/" + phone.Specs[1] + ".png"))
                {
                    uri = "ms-appx:///Assets/images/phones/" + phone.Specs[1] + ".png";
                }

                BitmapImage img = new BitmapImage(new Uri(uri, UriKind.Absolute));
                img.DecodePixelWidth = (int)sp.Width;
                sp.Children.Add(new Image() { Source = img });
                sp.Children.Add(new TextBlock() { Text = phone.Specs[2] + " CHF"});
                sp.Children.Add(new TextBlock()
                { Text = _data.GetOneBrand(phone.Specs[12], true)[0] + " " + phone.Specs[1] + " (" + phone.Specs[3] + "GB, " + phone.Specs[6] + '"' + ")" });

                Button btn = new Button();
                btn.Content = sp;
                btn.Tag = phone.Specs[0] + " " + phone.Specs[1];
                btn.Click += new RoutedEventHandler(detail_Click);
                phoneLibrary.Items.Add(btn);
            }
        }

        private void detail_Click(object sender, RoutedEventArgs e)
        {
            string[] phoneDetail = (sender as Button).Tag.ToString().Split(" ");
            Params data = new Params();
            data.Data = _data.GetPriceHistory(phoneDetail[0]);
            data.Phone = "";
            for (int i = 1; i < phoneDetail.Length; i++)
            {
                data.Phone += phoneDetail[i];
                if (i < phoneDetail.Length - 1)
                    data.Phone += " ";
            }
            DetailWindow window = new DetailWindow(data);
            window.Activate();
        }

        private void btnClearFilters_Click(object sender, RoutedEventArgs e)
        {
            cbConstructor.SelectedIndex = -1;
            cbOS.SelectedIndex = -1;
        }
    }
}
