using MGEditor.ControlsLookup;
using MGEditor.Helpers;
using MGEditor.Models;
using MGEditor.Resources;
using MGEditor.Services;
using MGEditor.Views.Pages;


namespace MGEditor.ViewModels.Pages;

public partial class HomeViewModel: ViewModel
{
    private bool _isInitialized = false;
    
    [ObservableProperty] 
    private INavigationService _navigationService;
    
    [ObservableProperty] 
    private AppSettingService  _appSettingService1;
    

    public HomeViewModel(
        INavigationService navigationService,
        AppSettingService appSettingService
        )
    {
        NavigationService =  navigationService;
        AppSettingService1 = appSettingService;
    }

    public override void OnNavigatedTo()
    {
        if  (!_isInitialized)
            InitializeViewModel();
            
    }

    private void InitializeViewModel()
    {
        AppSettingService1.ApplySettings();
        
        _isInitialized = true;
    }

    [RelayCommand]
    private void OnCardClick(string parameter)
    {
        if (string.IsNullOrWhiteSpace(parameter))
        {
            return;
        }

        Type? pageType = NameToPageTypeConverter.Convert(parameter);

        if (pageType == null)
        {
            return;
        }

        _ = NavigationService.Navigate(pageType);
    }

    [ObservableProperty]
    private ICollection<NavigationCard> _navigationCards = new ObservableCollection<NavigationCard>(
        ControlPages
            .FromNamespace(typeof(HomePage).Namespace!)
            .Select(x => new NavigationCard()
            {
				Name = GalleryPageName.GalleryName[x.Name] != null ? GalleryPageName.GalleryName[x.Name] : x.Name,
				Icon = x.Icon,
                Description = x.Description,
                PageType = x.PageType,
            }));
}
