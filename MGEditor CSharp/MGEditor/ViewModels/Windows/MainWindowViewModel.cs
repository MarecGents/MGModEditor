using MGEditor.Views.Pages;
using MGEditor.Views.Pages.Functions;
namespace MGEditor.ViewModels.Windows;

public partial class MainWindowViewModel : ViewModel
{
    [ObservableProperty]
    private string _applicationTitle = "MG Editor";

    [ObservableProperty]
    private ObservableCollection<object> _menuItems = new()
        {
            new NavigationViewItem()
            {
                Content = "主页",
                Icon = new SymbolIcon { Symbol = SymbolRegular.Home12 },
                TargetPageType = typeof(HomePage)
            },
            new NavigationViewItem("战局系统", SymbolRegular.PersonWalking16, typeof(RaidSystemPage)),
            new NavigationViewItem("经济系统", SymbolRegular.CurrencyDollarEuro16, typeof(EconomySystemPage)),
            new NavigationViewItem("养成系统", SymbolRegular.Guardian24, typeof(DevelopSystemPage)),
            new NavigationViewItem("容器扩容", SymbolRegular.BoxArrowUp24, typeof(ContainerExpandPage)),
            new NavigationViewItem("特色功能", SymbolRegular.Premium12, typeof(ExclusiveFeaturePage)),

        };

    [ObservableProperty]
    private ObservableCollection<object> _footerMenuItems = new()
        {
            new NavigationViewItem()
            {
                Content = "设置",
                Icon = new SymbolIcon { Symbol = SymbolRegular.Settings24 },
                TargetPageType = typeof(SettingsPage)
            }
        };

    [ObservableProperty]
    private ObservableCollection<Wpf.Ui.Controls.MenuItem> _trayMenuItems = new()
        {
            new Wpf.Ui.Controls.MenuItem { Header = "Home", Tag = "tray_home" }
        };
}
