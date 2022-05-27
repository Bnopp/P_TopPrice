using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System;
using System.IO;
using System.Collections.ObjectModel;
using Microsoft.UI.Xaml.Media.Imaging;

namespace SmartphoneManager.Pages
{
    /// <summary>
    /// The main page of this software allowing to search/sort/classify data in a database
    /// </summary>
    public sealed partial class SearchPage : Page
    {
        private Data _data;
        private ObservableCollection<Phone> _phones { get; set; }

        /// <summary>
        /// Default main constructor
        /// </summary>
        public SearchPage()
        {
            this.InitializeComponent();

            cbTop.SelectedIndex = 0;

            _data = new Data();
            
            //Connect to server + database
            _data.EstablishConnection("localhost", "db_topprice", "root", "root");

            //Load all operating systems from database
            foreach (var os in _data.GetAllOS())
            {
                cbOS.Items.Add(os);
            }

            //Load all smartphone brands from database
            foreach (var brand in _data.GetAllBrands())
            {
                cbConstructor.Items.Add(brand);
            }

            //get and display search results
            ShowPhones();
        }

        /// <summary>
        /// When search button is pressed, get and display search results
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            ShowPhones();
        }

        /// <summary>
        /// When any combo box is changed, update data and search results accordingly
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbUpdate(object sender, SelectionChangedEventArgs e)
        {
            if (_data != null)
                ShowPhones();
        }

        /// <summary>
        /// When any combo box is changed, due to sizing problems, depending on the selected index, update font size and call cbUpdate method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbClassify_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if ((sender as ComboBox).SelectedIndex == 1)
                (sender as ComboBox).FontSize = 15;
            else
                (sender as ComboBox).FontSize = 10;

            cbSort.SelectedIndex = 0;

            cbUpdate(sender, e);
        }

        /// <summary>
        /// When any combo box is changed, due to sizing problems, depending on the selected index, update font size and call cbUpdate method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbSort_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if ((sender as ComboBox).SelectedIndex == 0 || (sender as ComboBox).SelectedIndex == 1)
                (sender as ComboBox).FontSize = 15;
            else
                (sender as ComboBox).FontSize = 10;

            cbClassify.SelectedIndex = -1;

            cbUpdate(sender, e);
        }

        /// <summary>
        /// When a smartphone is clicked on, open new detail window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// When clear button is pressed, reset filter combo boxes selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearFilters_Click(object sender, RoutedEventArgs e)
        {
            cbConstructor.SelectedIndex = -1;
            cbOS.SelectedIndex = -1;
            cbTop.SelectedIndex = 0;
        }

        /// <summary>
        /// Request the needed data to the database and display each smartphone with it's data on a grid
        /// </summary>
        private void ShowPhones()
        {
            //in case there are any phones on the grid, clear them
            phoneLibrary.Items.Clear();

            //Load Phones
            foreach (var phone in _data.GetPhones(tbSearch.Text, cbTop.SelectedItem.ToString(), cbSort, cbConstructor, cbOS, cbClassify))
            {
                StackPanel sp = new StackPanel();
                sp.Orientation = Orientation.Vertical;

                //set default image to the missing image, it is later changed if the needed image exists
                var uri = "ms-appx:///Assets/images/phones/imageMissing.png";

                //updates smartphone image if exists
                if (File.Exists(System.AppDomain.CurrentDomain.BaseDirectory + "/Assets/images/phones/" + phone.Specs[1] + ".png"))
                {
                    uri = "ms-appx:///Assets/images/phones/" + phone.Specs[1] + ".png";
                }

                //sets and adds all the data together on a grid slot
                BitmapImage img = new BitmapImage(new Uri(uri, UriKind.Absolute));
                sp.Children.Add(new Image() { Source = img });
                sp.Children.Add(new TextBlock() { Text = phone.Specs[2] + " CHF" });
                sp.Children.Add(new TextBlock()
                { Text = _data.GetOneBrand(phone.Specs[12], true)[0] + " " + phone.Specs[1] + " (Capacité de " + phone.Specs[3] + "GB, Vie de batterie: " + phone.Specs[4] + "h, Taille de l'écran: " + phone.Specs[6] + '"' + ", Résolution de l'écran: " + phone.Specs[7] + ", " + phone.Specs[5] + "GB de RAM)" });

                Button btn = new Button();
                btn.Content = sp;
                btn.Tag = phone.Specs[0] + " " + phone.Specs[1];
                btn.Click += new RoutedEventHandler(detail_Click);

                //add smartphone to the grid
                phoneLibrary.Items.Add(btn);
            }
        }
    }
}
