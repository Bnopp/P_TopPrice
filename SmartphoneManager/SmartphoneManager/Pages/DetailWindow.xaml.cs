using Microsoft.UI;
using Microsoft.UI.Windowing;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Media.Animation;

namespace SmartphoneManager.Pages
{
    /// <summary>
    /// Detail window that opens to show up the detail page
    /// </summary>
    public sealed partial class DetailWindow : Window
    {
        private AppWindow _apw;
        private OverlappedPresenter _presenter;

        /// <summary>
        /// Default main constructor
        /// </summary>
        /// <param name="data">data needed to be send to the detail page for the chart</param>
        public DetailWindow(Params data)
        {
            this.InitializeComponent();

            GetAppWindowAndPresenter();

            _presenter.IsResizable = false;
            ExtendsContentIntoTitleBar = true;
            Title = "Smartphone Manager - Detail";
            _apw.Resize(new Windows.Graphics.SizeInt32(512, 250));

            //Navigate to detail page
            GraphFrame.Navigate(typeof(DetailPage), data, new DrillInNavigationTransitionInfo());
        }

        /// <summary>
        /// Resize Window
        /// </summary>
        public void GetAppWindowAndPresenter()
        {
            var hWnd = WinRT.Interop.WindowNative.GetWindowHandle(this);
            WindowId myWndId = Microsoft.UI.Win32Interop.GetWindowIdFromWindow(hWnd);
            _apw = AppWindow.GetFromWindowId(myWndId);
            _presenter = _apw.Presenter as OverlappedPresenter;
        }
    }
}
