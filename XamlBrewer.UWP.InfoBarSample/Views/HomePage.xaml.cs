using WinUI = Microsoft.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls;

namespace XamlBrewer.UWP.InfoBarSample.Views
{
    public sealed partial class HomePage : Page
    {
        public HomePage()
        {
            this.InitializeComponent();

            var infoBar = new WinUI.InfoBar
            {
                Title = "OOPS",
                Message = "Division by zero. Dude, I told you so ...",
                Severity = WinUI.InfoBarSeverity.Error,
                IsOpen = true,
                VerticalAlignment = Windows.UI.Xaml.VerticalAlignment.Bottom,
                Margin = new Windows.UI.Xaml.Thickness(0, 0, 0, 80)
            };

            RootGrid.Children.Add(infoBar);
        }

        private void MenuFlyoutItem_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            PreferencesInfoBar.IsOpen = false;
        }
    }
}
