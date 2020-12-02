using WinUI = Microsoft.UI.Xaml.Controls;
using Windows.UI.Xaml;
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
                VerticalAlignment = VerticalAlignment.Bottom,
                Margin = new Thickness(0, 0, 0, 80)
            };

            RootGrid.Children.Add(infoBar);
        }

        private void MenuFlyoutItem_Click(object sender, RoutedEventArgs e)
        {
            PreferencesInfoBar.IsOpen = false;
        }
    }
}
