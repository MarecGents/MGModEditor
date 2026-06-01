namespace MGEditor.Resources;

public class ConfigItems
{
    public List<KeyValue> AIHealth { get; } = new()
    {
        new KeyValue{ Key=1, Value="x1"},
        new KeyValue{ Key=2, Value="x2"},
        new KeyValue{ Key=3, Value="x3"},
        new KeyValue{ Key=4, Value="x4"},
        new KeyValue{ Key=5, Value="x5"},

    };
    public List<KeyValue> AISpawnNumber { get; } = new()
    {
        new KeyValue{ Key=-10, Value="-10" },
        new KeyValue{ Key=-8, Value="-8" },
        new KeyValue{ Key=-4, Value="-4" },
        new KeyValue{ Key=-2, Value="-2" },
        new KeyValue{ Key=0, Value="0" },
        new KeyValue{ Key=2, Value="2" },
        new KeyValue{ Key=4, Value="4" },
        new KeyValue{ Key=8, Value="8" },
        new KeyValue{ Key=10, Value="10" },
    };
    public List<KeyValue> USECRate { get; } = (new()
    {
        new KeyValue{ Key=-1, Value="默认比例" },
        new KeyValue{ Key=0, Value="0%" },
        new KeyValue{ Key=10, Value="10%" },
        new KeyValue{ Key=20, Value="20%" },
        new KeyValue{ Key=30, Value="30%" },
        new KeyValue{ Key=40, Value="40%" },
        new KeyValue{ Key=50, Value="50%" },
        new KeyValue{ Key=60, Value="60%" },
        new KeyValue{ Key=70, Value="70%" },
        new KeyValue{ Key=80, Value="80%" },
        new KeyValue{ Key=90, Value="90%" },
        new KeyValue{ Key=100, Value="100%" },
    });

    public List<KeyValue> aiAmount { get; } = new()
    {
        new KeyValue{ Key="AsOnline", Value="同在线" },
        new KeyValue{ Key="NoBots", Value="无" },
        new KeyValue{ Key="Low", Value="低" },
        new KeyValue{ Key="Medium", Value="中" },
        new KeyValue{ Key="High", Value="高" },
        new KeyValue{ Key="Horde", Value="排山倒海" },
    };

    public List<KeyValue> aiDifficulty { get; } = new()
    {
        new KeyValue{ Key="AsOnline", Value="同在线" },
        new KeyValue{ Key="Easy", Value="简单" },
        new KeyValue{ Key="Medium", Value="中等" },
        new KeyValue{ Key="Hard", Value="困难" },
        new KeyValue{ Key="Impossible", Value="地狱" },
        new KeyValue{ Key="Random", Value="随机" },
    };

    public List<KeyValue> RaidTime { get; } = new()
    {
        new KeyValue{ Key=-1.0, Value="默认时长" },
        new KeyValue{ Key=30.0, Value="30分钟" },
        new KeyValue{ Key=60.0, Value="1.0小时" },
        new KeyValue{ Key=90.0, Value="1.5小时" },
        new KeyValue{ Key=120.0, Value="2.0小时" },
        new KeyValue{ Key=180.0, Value="3.0小时" },
        new KeyValue{ Key=240.0, Value="4.0小时" },
    };

    public List<KeyValue> BOSSSpwanChance { get; } = new()
    {
        new KeyValue{ Key=-1.0, Value="默认概率"},
        new KeyValue{ Key=0.0, Value="0%"},
        new KeyValue{ Key=10.0, Value="10%"},
        new KeyValue{ Key=20.0, Value="20%"},
        new KeyValue{ Key=30.0, Value="30%"},
        new KeyValue{ Key=40.0, Value="40%"},
        new KeyValue{ Key=50.0, Value="50%"},
        new KeyValue{ Key=60.0, Value="60%"},
        new KeyValue{ Key=70.0, Value="70%"},
        new KeyValue{ Key=80.0, Value="80%"},
        new KeyValue{ Key=90.0, Value="90%"},
        new KeyValue{ Key=100.0, Value="100%"},
    };
    public List<KeyValue> AirdropType { get; } = new() {
        new KeyValue{ Key="default", Value="默认"},
        new KeyValue{ Key="moreWeapon", Value="多武器" },
        new KeyValue{ Key="moreBarter", Value="多交换物品"},
        new KeyValue{ Key="moreFoodMedical", Value="吃喝医疗"},
        new KeyValue{ Key="moreMixed", Value="混合种类"},
    };
    
    public List<KeyValue> WeatherMode { get; } = new()
    {
        new KeyValue{ Key="default", Value="默认天气" },
        new KeyValue{ Key="mode1", Value="晴空万里" },
        new KeyValue{ Key="mode2", Value="阴雨连绵" },
        new KeyValue{ Key="mode3", Value="狂风暴雨" },
        new KeyValue{ Key="mode4", Value="云雾缭绕" },
        new KeyValue{ Key="mode5", Value="究极变态天气" },
        new KeyValue{ Key="Custom", Value="自定义" },
    };

    public List<KeyValue> CloudMode { get; } = new()
    {
        new KeyValue{ Key="default", Value="默认" },
        new KeyValue{ Key="mode1", Value="万里无云" },
        new KeyValue{ Key="mode2", Value="少云" },
        new KeyValue{ Key="mode3", Value="多云" },
        new KeyValue{ Key="mode4", Value="乌云密布" },
    };
    public Dictionary<string, List<double>> CloudModeWeight { get; } = new()
    {
        { "default", new List<double> { 20, 8, 0, 0, 0, 0, 0, 0, 0, 0, 0 } },
        { "mode1", new List<double> { 20, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0  } },
        { "mode2", new List<double> { 0, 0, 20, 10, 10, 5, 0, 0, 0, 0, 0  } },
        { "mode3", new List<double> { 0, 0, 0, 0, 0, 10, 20, 20, 10, 0, 0  } },
        { "mode4", new List<double> { 0, 0, 0, 0, 0, 0, 0, 0, 5, 5, 20  } },
    };

    public List<KeyValue> WindMode { get; } = new()
    {
        new KeyValue{ Key="default", Value="默认" },
        new KeyValue{ Key="mode1", Value="无风" },
        new KeyValue{ Key="mode2", Value="微风" },
        new KeyValue{ Key="mode3", Value="大风" },
        new KeyValue{ Key="mode4", Value="狂风" },
    };
    public Dictionary<string, List<double>> WindModeWeight { get; } = new()
    {
        { "default", new List<double> { 6, 3, 2, 1, 1 } },
        { "mode1", new List<double> { 10, 0, 0, 0, 0 } },
        { "mode2", new List<double> { 0, 6, 0, 0, 0 } },
        { "mode3", new List<double> { 0, 0, 3, 3, 0 } },
        { "mode4", new List<double> { 0, 0, 0, 0, 10 } },
    };

    public List<KeyValue> RainMode { get; } = new()
    {
        new KeyValue{ Key="default", Value="默认" },
        new KeyValue{ Key="mode1", Value="无雨" },
        new KeyValue{ Key="mode2", Value="绵绵细雨" },
        new KeyValue{ Key="mode3", Value="小雨" },
        new KeyValue{ Key="mode4", Value="大雨" },
        new KeyValue{ Key="mode5", Value="滂沱大雨" },
    };
    public Dictionary<string, List<double>> RainModeWeight { get; } = new()
    {
        { "default", new List<double> { 1, 0, 0, 0, 0 } },
        { "mode1", new List<double> { 0, 0, 0, 0, 0 } },
        { "mode2", new List<double> { 0, 5, 0, 0, 0 } },
        { "mode3", new List<double> { 0, 5, 5, 0, 0 } },
        { "mode4", new List<double> { 0, 0, 10, 10, 0 } },
        { "mode5", new List<double> { 0, 0, 0, 0, 10 } },
    };

    public List<KeyValue> FogMode { get; } = new()
    {
        new KeyValue{ Key="default", Value="默认" },
        new KeyValue{ Key="mode1", Value="无雾" },
        new KeyValue{ Key="mode2", Value="朦胧淡雾" },
        new KeyValue{ Key="mode3", Value="云雾缭绕" },
        new KeyValue{ Key="mode4", Value="雾霾" },
    };
    public Dictionary<string, List<double>> FogModeWeight { get; } = new()
    {
        { "default", new List<double> { 30, 6, 4, 3, 1 } },
        { "mode1", new List<double> { 35, 0, 0, 0, 0 } },
        { "mode2", new List<double> { 0, 35, 0, 0, 0 } },
        { "mode3", new List<double> { 0, 0, 35, 0, 0 } },
        { "mode4", new List<double> { 0, 0, 0, 35, 35 } },
    };

    public List<KeyValue> LootMultiple { get; } = new()
    {
        new KeyValue{ Key=1, Value="x1" },
        new KeyValue{ Key=2, Value="x2" },
        new KeyValue{ Key=3, Value="x3" },
        new KeyValue{ Key=5, Value="x5" },
        new KeyValue{ Key=8, Value="x8" },
        new KeyValue{ Key=10, Value="x10" },
        new KeyValue{ Key=15, Value="x15" },
        new KeyValue{ Key=20, Value="x20" },
        new KeyValue{ Key=30, Value="x30" },
        new KeyValue{ Key=50, Value="x50" },
    };

    public List<KeyValue> SellNumber { get; } = new()
    {
        new KeyValue{ Key=1, Value="x1" },
        new KeyValue{ Key=2, Value="x2" },
        new KeyValue{ Key=5, Value="x5" },
        new KeyValue{ Key=10, Value="x10" },
        new KeyValue{ Key=20, Value="x20" },
    };

    public List<KeyValue> UpdateTime { get; } = new()
    {
        new KeyValue{ Key=-1, Value="默认时间" },
        new KeyValue{ Key=3600, Value="60分钟" },
        new KeyValue{ Key=1800, Value="30分钟" },
        new KeyValue{ Key=600, Value="10分钟" },
        new KeyValue{ Key=300, Value="5分钟" },
    };

    public List<KeyValue> InsuranceTime { get; } = new()
    {
        new KeyValue{ Key=-1, Value="默认速度" },
        new KeyValue{ Key=4, Value="快速回保" },
        new KeyValue{ Key=2, Value="极速回保" },
        new KeyValue{ Key=0, Value="保险秒回" },
    };
    public List<KeyValue> InsuranceCost { get; } = new()
    {
        new KeyValue{ Key=-1.0, Value="默认费用" },
        new KeyValue{ Key=0.01, Value="非常便宜" },
        new KeyValue{ Key=0.15, Value="一般价格" },
        new KeyValue{ Key=0.40, Value="较为昂贵" },
        new KeyValue{ Key=0.60, Value="极其昂贵" },
    };
    public List<KeyValue> ReturnChance { get; } = new()
    {
        new KeyValue{ Key=-1, Value="默认概率" },
        new KeyValue{ Key=0, Value="0%" },
        new KeyValue{ Key=20, Value="20%" },
        new KeyValue{ Key=40, Value="40%" },
        new KeyValue{ Key=60, Value="60%" },
        new KeyValue{ Key=80, Value="80%" },
        new KeyValue{ Key=100, Value="100%" },
    };
    public List<KeyValue> LoadSpeed { get; } = new()
    {
        new KeyValue{ Key="default", Value="默认速度" },
        new KeyValue{ Key="mode1", Value="快速装卸" },
        new KeyValue{ Key="mode2", Value="极速装卸" },
        new KeyValue{ Key="mode3", Value="闪电装卸" },
    };
    public List<KeyValue> MagazineCapacity { get; } = new()
    {
        new KeyValue{ Key=1, Value="x1" },
        new KeyValue{ Key=2, Value="x2" },
        new KeyValue{ Key=3, Value="x3" },
        new KeyValue{ Key=4, Value="x4" },
        new KeyValue{ Key=5, Value="x5" },
    };

    public List<KeyValue> ItemsDurability { get; } = new()
    {
        new KeyValue{ Key=1, Value="x1" },
        new KeyValue{ Key=2, Value="x2" },
        new KeyValue{ Key=4, Value="x4" },
        new KeyValue{ Key=5, Value="x5" },
        new KeyValue{ Key=8, Value="x8" },
        new KeyValue{ Key=10, Value="x10" },
    };

    public List<KeyValue> AmmoStack { get; } = new()
    {
        new KeyValue{ Key=1, Value="x1" },
        new KeyValue{ Key=2, Value="x2" },
        new KeyValue{ Key=5, Value="x5" },
        new KeyValue{ Key=10, Value="x10" },
        new KeyValue{ Key=20, Value="x20" },
        new KeyValue{ Key=50, Value="x50" },
        new KeyValue{ Key=100, Value="x100" },
        new KeyValue{ Key=500, Value="x500" },
        new KeyValue{ Key=1000, Value="x1000" },
    };

    public List<KeyValue> MoneyStack { get; } = new()
    {
        new KeyValue{ Key=1, Value="x1" },
        new KeyValue{ Key=5, Value="x5" },
        new KeyValue{ Key=10, Value="x10" },
        new KeyValue{ Key=50, Value="x50" },
        new KeyValue{ Key=100, Value="x100" },
    };

    public List<KeyValue> HideoutTime { get; } = new()
    {
        new KeyValue{ Key=-1.0, Value="默认时间" },
        new KeyValue{ Key=30.0, Value="30秒" },
        new KeyValue{ Key=300.00, Value="5分钟" },
        new KeyValue{ Key=1200.0, Value="20分钟" },
        new KeyValue{ Key=3600.0, Value="1小时" },
        new KeyValue{ Key=10800.0, Value="3小时" },
    };

    public List<KeyValue> BonusesLevel { get; } = new()
    {
        new KeyValue { Key = 1, Value = "默认加成" },
        new KeyValue { Key = 2, Value = "双倍加成" },
        new KeyValue { Key = 3, Value = "五倍加成" },
        new KeyValue { Key = 4, Value = "十倍加成" },
    };
    
    public List<KeyValue> RewardMultiple { get; } = new()
    {
        new KeyValue { Key = 1, Value = "默认倍率" },
        new KeyValue { Key = 2, Value = "x2" },
        new KeyValue { Key = 3, Value = "x3" },
        new KeyValue { Key = 4, Value = "x4" },
        new KeyValue { Key = 5, Value = "x5" },
        new KeyValue { Key = 10, Value = "x10" },
    };

    public List<KeyValue> ContainerExpandWidth { get; } = Enumerable.Range(1, 20)
        .Select(i => new KeyValue { Key = i, Value = $"{i}格" })
        .ToList();
    public List<KeyValue> ContainerExpandHeight { get; } = Enumerable.Range(1, 16)
        .Select(i => new KeyValue { Key = i, Value = $"{i}格" })
        .ToList();
}

public class KeyValue
{
    public object Key { get; set; }
    public string Value { get; set; }

}
