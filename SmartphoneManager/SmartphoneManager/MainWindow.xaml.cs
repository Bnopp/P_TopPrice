using Microsoft.UI.Xaml;
using SmartphoneManager.Pages;
using Microsoft.UI.Windowing;
using Microsoft.UI;
using Microsoft.UI.Xaml.Media.Animation;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace SmartphoneManager
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        private AppWindow _apw;
        private OverlappedPresenter _presenter;

        /// <summary>
        /// Default main constructor
        /// </summary>
        public MainWindow()
        {
            this.InitializeComponent();

            GetAppWindowAndPresenter();
            _presenter.IsResizable = false;
            ExtendsContentIntoTitleBar = true;
            Title = "Smartphone Manager";

            ContentFrame.Navigate(typeof(WelcomePage), null, new DrillInNavigationTransitionInfo());

            _apw.Resize(new Windows.Graphics.SizeInt32(1024, 700));
        }

        /// <summary>
        /// Resize the window
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