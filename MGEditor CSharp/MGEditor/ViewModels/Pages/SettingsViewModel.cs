using MGEditor.Resources;
using MGEditor.Services;

namespace MGEditor.ViewModels.Pages;

public partial class SettingsViewModel : ViewModel
{
    private bool _isInitialized = false;

    [ObservableProperty]
    private AppSettingService _appSettingService1;

    public SettingsViewModel(AppSettingService appSettingService)
    {
        AppSettingService1 = appSettingService;
    }

	public override void OnNavigatedTo()
	{
        if (!_isInitialized)
            InitializeViewModel();
    }

    private void InitializeViewModel()
    {
        SettingValueInit();

        _isInitialized = true;
    }

    private void SettingValueInit()
    {
        ThemeTypeValue = AppSettingService1.EditorSetting.Personalized.Theme;
        AppVersion = $"MGEditor - {GetAssemblyVersion()}";
    }

    private string GetAssemblyVersion()
    {
        return GalleryAssembly.Asssembly.GetName().Version?.ToString()
               ?? String.Empty;
    }
    
    [ObservableProperty]
    private string _themeTypeValue;

    partial void OnThemeTypeValueChanged(string value)
    {
        if (String.IsNullOrEmpty(value))
            return;

        if (value == "Light")
        {
            ApplicationThemeManager.Apply(
                ApplicationTheme.Light,
                WindowBackdropType.Auto);
        }
        else if (value == "Dark")
        {
            ApplicationThemeManager.Apply(
                ApplicationTheme.Dark,
                WindowBackdropType.Auto);
        }
        else if (value == "Unknown")
        {
            ApplicationThemeManager.Apply(
                ApplicationTheme.Unknown,
                WindowBackdropType.Auto);
        }
        else if (value == "HighContrast")
        {
            ApplicationThemeManager.Apply(
                ApplicationTheme.HighContrast,
                WindowBackdropType.Auto);
        }

        AppSettingService1.EditorSetting.Personalized.Theme = value;
    }

    public List<KeyValue> ThemeValueList { get; } = new()
    {
        new KeyValue { Key = "Light", Value = "浅色" },
        new KeyValue { Key = "Dark", Value = "深色" },
        new KeyValue { Key = "HighContrast", Value = "高对比度" },
        new KeyValue { Key = "Unknown", Value = "未知" },
    };
    
    [ObservableProperty]
    private string _appVersion;

}