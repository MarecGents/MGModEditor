using MGEditor.ControlsLookup;
using MGEditor.ViewModels.Pages.Functions;

namespace MGEditor.Views.Pages.Functions;

[GalleryPage(
    "战局系统中包含：AI系统、进入战局默认选项、战局参数、资源倍率等功能。", 
    SymbolRegular.PersonWalking16
    )]
public partial class RaidSystemPage : INavigableView<RaidSystemViewModel>
{
    public RaidSystemViewModel ViewModel {  get; set; }
    public RaidSystemPage(RaidSystemViewModel viewModel)
    {
        ViewModel = viewModel;
        DataContext = this;
        InitializeComponent();
    }
}
