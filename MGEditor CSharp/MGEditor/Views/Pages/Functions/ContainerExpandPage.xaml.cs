using MGEditor.ControlsLookup;
using MGEditor.ViewModels.Pages.Functions;

namespace MGEditor.Views.Pages.Functions;

[GalleryPage(
    "涉及到塔科夫内所有容器类型物品的扩容调节，如物品箱、医疗箱、食品箱等。", 
    SymbolRegular.BoxArrowUp24
    )]
public partial class ContainerExpandPage : INavigableView<ContainerExpandViewModel>
{
    
    public ContainerExpandViewModel ViewModel { get; set; }
    public ContainerExpandPage(ContainerExpandViewModel viewModel)
    {
        ViewModel = viewModel;
        DataContext = this;
        InitializeComponent();
    }
}
