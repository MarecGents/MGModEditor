using MGEditor.ControlsLookup;
using MGEditor.ViewModels.Pages.Functions;

namespace MGEditor.Views.Pages.Functions;

[GalleryPage(
    "特色功能为非原版修改项，为MG手搓功能。如：独立商人、独立物品等。", 
    SymbolRegular.Premium12
    )]
public partial class ExclusiveFeaturePage : INavigableView<ExclusiveFeatureViewModel>
{
    public ExclusiveFeatureViewModel ViewModel { get; set; }
    public ExclusiveFeaturePage(ExclusiveFeatureViewModel viewModel)
    {
        ViewModel = viewModel;
        DataContext = this;
        InitializeComponent();
    }
}
