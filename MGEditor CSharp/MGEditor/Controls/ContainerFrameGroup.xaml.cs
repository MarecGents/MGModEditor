using MGEditor.Models;
using MGEditor.Resources;

namespace MGEditor.Controls;

public class ContainerFrameGroup: Control
{

    /// <summary>Identifies the <see cref="HeaderText"/> dependency property.</summary>
    public static readonly DependencyProperty HeaderTextProperty = 
        DependencyProperty.Register(
            nameof(HeaderText),
            typeof(string),
            typeof(ContainerFrameGroup),
            new PropertyMetadata("Default HeaderText")
            );
    public static readonly DependencyProperty ContainerIdProperty =
        DependencyProperty.Register(
            nameof(ContainerId),
            typeof(string),
            typeof(ContainerFrameGroup),
            new PropertyMetadata("Default ContainerId", OnContainerIdOrExpandChanged)
            );
    public static readonly DependencyProperty ContainerExpandProperty =
        DependencyProperty.Register(
            nameof(ContainerExpand),
            typeof(Dictionary<string, MGModConfig_Templates_ContainerExpands>),
            typeof(ContainerFrameGroup),
            new FrameworkPropertyMetadata(
                null,
                FrameworkPropertyMetadataOptions.BindsTwoWayByDefault,
                OnContainerIdOrExpandChanged)
            );
    public static readonly DependencyProperty IsExpandedProperty =
        DependencyProperty.Register(
            nameof(IsExpanded),
            typeof(bool?),
            typeof(ContainerFrameGroup),
            new PropertyMetadata(null, OnIsExpandedChanged)
            );
    public static readonly DependencyProperty ExpandWidthProperty =
        DependencyProperty.Register(
            nameof(ExpandWidth),
            typeof(int?),
            typeof(ContainerFrameGroup),
            new PropertyMetadata(null, OnExpandWidthChanged)
            );
    public static readonly DependencyProperty ExpandHeightProperty =
        DependencyProperty.Register(
            nameof(ExpandHeight),
            typeof(int?),
            typeof(ContainerFrameGroup),
            new PropertyMetadata(null, OnExpandHeightChanged)
            );
    public static readonly DependencyProperty IsFilterProperty =
        DependencyProperty.Register(
            nameof(IsFilter),
            typeof(bool?),
            typeof(ContainerFrameGroup),
            new PropertyMetadata(null, OnIsFilterChanged)
            );
    public static readonly DependencyProperty IsNoWeightProperty =
        DependencyProperty.Register(
            nameof(IsNoWeight),
            typeof(bool?),
            typeof(ContainerFrameGroup),
            new PropertyMetadata(null, OnIsNoWeightChanged)
            );
    public string? HeaderText
    {
        get => (string?)GetValue(HeaderTextProperty);
        set => SetValue(HeaderTextProperty, value);
    }
    public string? ContainerId
    {
        get => (string?)GetValue(ContainerIdProperty);
        set => SetValue(ContainerIdProperty, value);
    }
    public Dictionary<string, MGModConfig_Templates_ContainerExpands>? ContainerExpand
    {
        get => (Dictionary<string, MGModConfig_Templates_ContainerExpands>?)GetValue(ContainerExpandProperty);
        set => SetValue(ContainerExpandProperty, value);
    }
    public bool? IsExpanded
    {
        get => (bool?)GetValue(IsExpandedProperty);
        set => SetValue(IsExpandedProperty, value);
    }
    public int? ExpandWidth
    {
        get => (int?)GetValue(ExpandWidthProperty);
        set => SetValue(ExpandWidthProperty, value);
    }
    public int? ExpandHeight
    {
        get => (int?)GetValue(ExpandHeightProperty);
        set => SetValue(ExpandHeightProperty, value);
    }
    public bool? IsFilter
    {
        get => (bool?)GetValue(IsFilterProperty);
        set => SetValue(IsFilterProperty, value);
    }
    public bool? IsNoWeight
    {
        get => (bool?)GetValue(IsNoWeightProperty);
        set => SetValue(IsNoWeightProperty, value);
    }

    public List<KeyValue> ExpandWidthList { get; } = new ConfigItems().ContainerExpandWidth;
    public List<KeyValue> ExpandHeightList { get; } = new ConfigItems().ContainerExpandHeight;
    public ContainerFrameGroup()
    {

    }

    private static void OnContainerIdOrExpandChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        var control = (ContainerFrameGroup)d;

        // 两个关键依赖属性都已赋值时再初始化
        if (!string.IsNullOrEmpty(control.ContainerId) && control.ContainerExpand != null &&
            control.ContainerExpand.TryGetValue(control.ContainerId, out var expand))
        {
            control.HeaderText = expand.Name;
            control.IsExpanded = expand.enable;
            control.ExpandWidth = expand.cellsH;
            control.ExpandHeight = expand.cellsV;
            control.IsFilter = expand.Filter;
            control.IsNoWeight = expand.Weight;
        }
    }
    private static void OnIsExpandedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        var control = (ContainerFrameGroup)d;
        control.ContainerExpand[control.ContainerId].enable = (bool)e.NewValue;
    }
    private static void OnExpandWidthChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        var control = (ContainerFrameGroup)d;
        control.ContainerExpand[control.ContainerId].cellsH = (int)e.NewValue;
    }
    private static void OnExpandHeightChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        var control = (ContainerFrameGroup)d;
        control.ContainerExpand[control.ContainerId].cellsV = (int)e.NewValue;
    }
    private static void OnIsFilterChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        var control = (ContainerFrameGroup)d;
        control.ContainerExpand[control.ContainerId].Filter = (bool)e.NewValue;
    }
    private static void OnIsNoWeightChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        var control = (ContainerFrameGroup)d;
        control.ContainerExpand[control.ContainerId].Weight = (bool)e.NewValue;
    }

}
