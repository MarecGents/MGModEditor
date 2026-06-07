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
            CustomThemeService.Remove();
            ApplicationThemeManager.Apply(ApplicationTheme.Light, WindowBackdropType.None, false);
        }
        else if (value == "Dark")
        {
            CustomThemeService.Remove();
            ApplicationThemeManager.Apply(ApplicationTheme.Dark, WindowBackdropType.None, false);
        }
        else if (value == "HighContrast")
        {
            CustomThemeService.Remove();
            ApplicationThemeManager.Apply(ApplicationTheme.HighContrast, WindowBackdropType.None, false);
        }
        else
        {
            CustomThemeService.Apply(value);
        }
        AppSettingService1.EditorSetting.Personalized.Theme = value;
    }

    public List<KeyValue> ThemeValueList { get; set; } = GetThemeValueList();

    private static List<KeyValue> GetThemeValueList()
    {
        List<KeyValue> themeValueList = new()
        {
            new KeyValue { Key = "Light", Value = "浅色" },
            new KeyValue { Key = "Dark", Value = "深色" },
            new KeyValue { Key = "HighContrast", Value = "高对比度" },
        };
        foreach (var themeConfig in CustomThemeRegistry.AllThemes)
        {
            themeValueList.Add(
                new KeyValue { Key = themeConfig.Key, Value = themeConfig.DisplayName }
                );
        }
        return themeValueList;
    }
    
    [ObservableProperty]
    private string _appVersion;

}