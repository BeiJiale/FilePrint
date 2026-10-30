using UnityEngine;
[CreateAssetMenu(fileName = "UIThemLightConfig", menuName = "UI/Theme(Light)")]
public class UIThemLight : ScriptableObject
{
    // HEX 转 Color
    private static Color C(string hex)
    {
        ColorUtility.TryParseHtmlString(hex, out Color color);
        return color;
    }

    #region 基础背景颜色

    [Header("========== 基础背景颜色 ==========")]

    [Header("整个应用程序的最底层背景颜色")]
    public Color Background = C("#F5F3FC");

    [Header("左侧导航栏的背景颜色")]
    public Color Sidebar = C("#FFFFFF");

    [Header("顶部工具栏、标题栏的背景颜色")]
    public Color TopBar = C("#FFFFFF");

    [Header("主内容显示区域的背景颜色")]
    public Color Content = C("#F5F3FC");

    [Header("普通内容卡片的背景颜色，例如功能卡片、信息卡片")]
    public Color Surface = C("#FFFFFF");

    [Header("悬浮在普通卡片上方的内容背景，例如浮动面板")]
    public Color SurfaceElevated = C("#FFFFFF");

    [Header("鼠标悬停在卡片上时的背景颜色")]
    public Color SurfaceHover = C("#F8F6FF");

    [Header("卡片或内容区域被选中时的背景颜色")]
    public Color SurfaceActive = C("#EDE8FF");

    [Header("不可交互或被禁用的内容区域背景")]
    public Color SurfaceDisabled = C("#F1EFF5");

    [Header("对话框、确认框等弹窗的背景颜色")]
    public Color Dialog = C("#FFFFFF");

    [Header("下拉菜单展开后的背景颜色")]
    public Color Dropdown = C("#FFFFFF");

    [Header("鼠标悬停提示框的背景颜色")]
    public Color Header = C("#25213A");

    [Header("模态窗口出现时，覆盖在整个界面上的半透明遮罩")]
    public Color Overlay = C("#17142D99");

    #endregion


    #region 边框与分割线

    [Header("========== 边框与分割线 ==========")]

    [Header("普通 UI 控件的默认边框颜色")]
    public Color Border = C("#E8E4F0");

    [Header("需要突出显示的边框颜色")]
    public Color BorderStrong = C("#D5D0E1");

    [Header("鼠标悬停在控件上时的边框颜色")]
    public Color BorderHover = C("#B9A9F7");

    [Header("控件处于选中状态时的边框颜色")]
    public Color BorderActive = C("#7657F6");

    [Header("输入框默认边框颜色")]
    public Color InputBorder = C("#DDD8E9");

    [Header("用于分隔不同 UI 区域的线条颜色")]
    public Color Divider = C("#EEEAF4");

    #endregion


    #region 文字颜色

    [Header("========== 文字颜色 ==========")]

    [Header("主要文字颜色，例如页面标题、正文、重要数据")]
    public Color TextPrimary = C("#25213A");

    [Header("次要文字颜色，例如说明文字、辅助信息")]
    public Color TextSecondary = C("#858197");

    [Header("辅助性文字颜色，例如时间、备注、附加说明")]
    public Color TextTertiary = C("#A7A3B5");

    [Header("不可交互或禁用状态下的文字颜色")]
    public Color TextDisabled = C("#C4C0CE");

    [Header("反色文字，例如深色按钮或深色背景上的文字")]
    public Color TextInverse = C("#FFFFFF");

    [Header("超链接、可点击文字的默认颜色")]
    public Color TextLink = C("#7657F6");

    [Header("鼠标悬停在超链接上时的文字颜色")]
    public Color TextLinkHover = C("#5738D5");

    #endregion


    #region 品牌与强调颜色

    [Header("========== 品牌与强调颜色 ==========")]

    [Header("品牌主色，用于主要按钮、重点图标和强调元素")]
    public Color Primary = C("#7657F6");

    [Header("品牌主色的悬停状态")]
    public Color PrimaryHover = C("#6847EA");

    [Header("品牌主色的按下状态")]
    public Color PrimaryPressed = C("#5738D5");

    [Header("品牌主色的禁用状态")]
    public Color PrimaryDisabled = C("#BFB1F9");

    [Header("品牌主色的浅色背景，适合选中区域和标签")]
    public Color PrimarySoft = C("#EDE8FF");

    [Header("品牌主色的极浅背景，用于弱强调区域")]
    public Color PrimarySubtle = C("#F7F4FF");

    [Header("品牌主色的深色版本，用于深色文字或强调")]
    public Color PrimaryDeep = C("#4935A5");

    [Header("放置在品牌主色背景上的前景颜色，通常是白色文字和图标")]
    public Color OnPrimary = C("#FFFFFF");

    [Header("辅助品牌色，用于次级强调元素")]
    public Color Secondary = C("#A78BFA");

    [Header("辅助品牌色的浅色背景")]
    public Color SecondarySoft = C("#F1EBFF");

    [Header("装饰性强调色，用于图标、插画及视觉点缀")]
    public Color Accent = C("#8B5CF6");

    #endregion


    #region 按钮颜色

    [Header("========== 按钮颜色 ==========")]

    [Header("次级按钮默认背景，例如取消、返回按钮")]
    public Color ButtonSecondary = C("#EDE8FF");

    [Header("次级按钮鼠标悬停背景")]
    public Color ButtonSecondaryHover = C("#E3DBFF");

    [Header("次级按钮按下时的背景")]
    public Color ButtonSecondaryPressed = C("#D5C8FF");

    [Header("次级按钮上的文字和图标颜色")]
    public Color ButtonSecondaryText = C("#6346C9");

    [Header("危险操作按钮背景，例如删除、清空、移除")]
    public Color ButtonDanger = C("#EF4444");

    [Header("危险操作按钮鼠标悬停背景")]
    public Color ButtonDangerHover = C("#DC2626");

    [Header("危险操作按钮上的文字和图标颜色")]
    public Color ButtonDangerText = C("#FFFFFF");

    [Header("所有普通按钮处于禁用状态时的背景")]
    public Color ButtonDisabled = C("#ECEAF1");

    [Header("所有普通按钮处于禁用状态时的文字")]
    public Color ButtonDisabledText = C("#B7B3C4");

    #endregion


    #region 输入控件颜色

    [Header("========== 输入控件颜色 ==========")]

    [Header("输入框默认背景颜色")]
    public Color InputBackground = C("#FFFFFF");

    [Header("鼠标悬停在输入框上时的背景颜色")]
    public Color InputHover = C("#FCFBFF");

    [Header("输入框获得焦点时的背景颜色")]
    public Color InputFocused = C("#FFFFFF");

    [Header("输入框获得焦点时的边框颜色")]
    public Color InputFocusBorder = C("#7657F6");

    [Header("输入框为空时占位提示文字的颜色")]
    public Color InputPlaceholder = C("#AAA6B8");

    [Header("输入框处于禁用状态时的背景颜色")]
    public Color InputDisabled = C("#F1EFF5");

    [Header("复选框、单选框未选中时的背景颜色")]
    public Color CheckBackground = C("#FFFFFF");

    [Header("复选框、单选框被选中时的背景颜色")]
    public Color CheckSelected = C("#7657F6");

    [Header("复选框勾选符号或单选框内部标记的颜色")]
    public Color CheckMark = C("#FFFFFF");

    #endregion


    #region 导航与菜单颜色

    [Header("========== 导航与菜单颜色 ==========")]

    [Header("导航菜单默认文字颜色")]
    public Color NavigationText = C("#777287");

    [Header("导航菜单默认图标颜色")]
    public Color NavigationIcon = C("#8D879E");

    [Header("鼠标悬停在导航菜单上时的背景颜色")]
    public Color NavigationHover = C("#F5F2FF");

    [Header("导航菜单当前选中项的背景颜色")]
    public Color NavigationActive = C("#EDE8FF");

    [Header("导航菜单当前选中项的文字颜色")]
    public Color NavigationActiveText = C("#6847EA");

    [Header("导航菜单当前选中项的图标颜色")]
    public Color NavigationActiveIcon = C("#7657F6");

    #endregion


    #region 状态颜色

    [Header("========== 状态颜色 ==========")]

    // 成功状态：文件校验通过、任务完成、操作成功
    [Header("成功状态的主要颜色")]
    public Color Success = C("#22C55E");

    [Header("成功状态提示区域的背景颜色")]
    public Color SuccessBackground = C("#E9F9EF");

    [Header("成功状态提示区域的边框颜色")]
    public Color SuccessBorder = C("#B7EAC9");

    [Header("成功状态提示文字颜色")]
    public Color SuccessText = C("#16803D");


    // 警告状态：操作风险、文件异常、需要用户确认
    [Header("警告状态的主要颜色")]
    public Color Warning = C("#F59E0B");

    [Header("警告状态提示区域的背景颜色")]
    public Color WarningBackground = C("#FFF6E5");

    [Header("警告状态提示区域的边框颜色")]
    public Color WarningBorder = C("#F5D69A");

    [Header("警告状态提示文字颜色")]
    public Color WarningText = C("#A16207");


    // 错误状态：校验失败、操作失败、文件损坏
    [Header("错误状态的主要颜色")]
    public Color Error = C("#EF4444");

    [Header("错误状态提示区域的背景颜色")]
    public Color ErrorBackground = C("#FDECEC");

    [Header("错误状态提示区域的边框颜色")]
    public Color ErrorBorder = C("#F5B9BF");

    [Header("错误状态提示文字颜色")]
    public Color ErrorText = C("#B91C1C");


    // 信息状态：普通提示、操作说明、处理中
    [Header("信息状态的主要颜色")]
    public Color Info = C("#3B82F6");

    [Header("信息状态提示区域的背景颜色")]
    public Color InfoBackground = C("#EAF2FF");

    [Header("信息状态提示区域的边框颜色")]
    public Color InfoBorder = C("#B9D2FF");

    [Header("信息状态提示文字颜色")]
    public Color InfoText = C("#1D4ED8");

    #endregion


    #region 数据展示与图表

    [Header("========== 数据展示与图表 ==========")]

    [Header("图表第一组数据的颜色，通常为品牌主色")]
    public Color ChartColor1 = C("#7657F6");

    [Header("图表第二组数据的颜色")]
    public Color ChartColor2 = C("#3B82F6");

    [Header("图表第三组数据的颜色")]
    public Color ChartColor3 = C("#22C55E");

    [Header("图表第四组数据的颜色")]
    public Color ChartColor4 = C("#F59E0B");

    [Header("图表第五组数据的颜色")]
    public Color ChartColor5 = C("#EC4899");

    [Header("图表内部网格线的颜色")]
    public Color ChartGrid = C("#E8E4F0");

    [Header("图表坐标轴、刻度和说明文字的颜色")]
    public Color ChartLabel = C("#858197");

    [Header("鼠标悬停在图表数据上时，提示框的背景颜色")]
    public Color ChartHeader = C("#25213A");

    #endregion


    #region 滚动条与进度条

    [Header("========== 滚动条与进度条 ==========")]

    [Header("滚动条轨道背景颜色")]
    public Color ScrollbarBackground = C("#F1EFF5");

    [Header("滚动条滑块默认颜色")]
    public Color ScrollbarHandle = C("#C4BED4");

    [Header("鼠标悬停在滚动条滑块上时的颜色")]
    public Color ScrollbarHandleHover = C("#968BAF");

    [Header("进度条未完成部分的轨道颜色")]
    public Color ProgressTrack = C("#EDE8F5");

    [Header("进度条已完成部分的填充颜色")]
    public Color ProgressFill = C("#7657F6");

    #endregion


    #region 阴影与特殊效果

    [Header("========== 阴影与特殊效果 ==========")]

    [Header("普通卡片、按钮等 UI 元素的阴影颜色")]
    public Color Shadow = C("#25213A18");

    [Header("弹窗和浮动面板使用的阴影颜色")]
    public Color DialogShadow = C("#25213A30");

    [Header("文本被选中时的背景高亮颜色")]
    public Color Selection = C("#7657F630");

    [Header("键盘焦点或无障碍焦点提示的外描边颜色")]
    public Color FocusOutline = C("#7657F6");

    #endregion
}
