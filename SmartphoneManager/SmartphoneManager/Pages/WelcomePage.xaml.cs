using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media.Animation;

namespace SmartphoneManager.Pages
{
    /// <summary>
    /// Page displayed on app launch, welcome page
    /// </summary>
    public sealed partial class WelcomePage : Page
    {
        /// <summary>
        /// Default main constructor
        /// </summary>
        public WelcomePage()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// When button is pressed, navigate to main search page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(SearchPage), null, new DrillInNavigationTransitionInfo());
        }
        
        /// <summary>
        /// Set focus to invisible button, needed to prevent WinUI 3 glitch
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            btnDefaultFocus.Focus(FocusState.Programmatic);
        }
    }
}