using MGEditor.ControlsLookup;
using MGEditor.ViewModels.Pages.Functions;

namespace MGEditor.Views.Pages.Functions;

[GalleryPage(
    "养成系统中包含：人物基础属性、装备优化、任务优化、藏身处优化等功能.", 
    SymbolRegular.Guardian24
    )]
public partial class DevelopSystemPage : INavigableView<DevelopSystemViewModel>
{

    public DevelopSystemViewModel ViewModel { get; set; }
    public DevelopSystemPage(DevelopSystemViewModel viewModel)
    {
        ViewModel = viewModel;
        DataContext = this;
        InitializeComponent();
    }
}
