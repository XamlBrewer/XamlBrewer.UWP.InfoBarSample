using System;
using Windows.ApplicationModel.Core;
using Windows.UI;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml.Controls;
using WinUI = Microsoft.UI.Xaml.Controls;

namespace XamlBrewer.UWP.InfoBarSample
{
    public sealed partial class Shell
        : Page
    {
        public Shell()
        {
            var coreTitleBar = CoreApplication.GetCurrentView().TitleBar;
            coreTitleBar.ExtendViewIntoTitleBar = true;

            var titleBar = ApplicationView.GetForCurrentView().TitleBar;
            if (titleBar != null)
            {
                titleBar.BackgroundColor = Colors.Transparent;
                titleBar.ButtonBackgroundColor = Colors.Transparent;
                titleBar.ButtonInactiveBackgroundColor = Colors.SlateGray;
                titleBar.ButtonForegroundColor = Color.FromArgb(255, 188, 143, 143);
            }

            this.InitializeComponent();
        }

        private void NavigationView_SelectionChanged(WinUI.NavigationView sender, WinUI.NavigationViewSelectionChangedEventArgs args)
        {
            if (args.IsSettingsSelected)
            {
                // Settings are off in this app...

                //ContentFrame.Navigate(typeof(SettingsPage));
                //NavigationView.Header = "Settings";
                //return;
            }

            var item = args.SelectedItemContainer as WinUI.NavigationViewItem;

            if (item.Tag != null)
            {
                ContentFrame.Navigate(Type.GetType(item.Tag.ToString()), item.Content);
                NavigationView.Header = (sender.SelectedItem as WinUI.NavigationViewItem).Content;
            }
        }
    }
}
