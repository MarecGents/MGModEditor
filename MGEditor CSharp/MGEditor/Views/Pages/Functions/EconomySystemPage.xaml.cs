using MGEditor.ControlsLookup;
using MGEditor.ViewModels.Pages.Functions;

namespace MGEditor.Views.Pages.Functions;

[GalleryPage(
    "经济系统中包含：跳蚤市场各项优化、商人交易系统等功能。", 
    SymbolRegular.CurrencyDollarEuro16
    )]
public partial class EconomySystemPage : INavigableView<EconomySystemViewModel>
{

    public EconomySystemViewModel ViewModel { get; set; }
    public EconomySystemPage(EconomySystemViewModel viewModel)
    {
        ViewModel = viewModel;
        DataContext = this;
        InitializeComponent();
    }
}
