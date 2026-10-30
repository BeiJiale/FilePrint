using UnityEngine;

[CreateAssetMenu(fileName = "UIThemDarkConfig", menuName = "UI/Theme(Dark)")]
public class UIThemDark : ScriptableObject
{
    // HEX 转 Color
    private static Color C(string hex)
    {
        ColorUtility.TryParseHtmlString(hex, out Color color);
        return color;
    }

    #region 基础背景颜色

    [Header("========== 基础背景颜色 ==========")]

    [Header("整个应用程序的最底层背景颜色，通常是窗口主体的背景")]
    public Color Background = C("#17182F");

    [Header("左侧导航栏的背景颜色，用于区分导航区域和主内容区域")]
    public Color Sidebar = C("#1D1E3B");

    [Header("顶部工具栏、标题栏的背景颜色")]
    public Color TopBar = C("#1D1E3B");

    [Header("主内容显示区域的背景颜色")]
    public Color Content = C("#17182F");

    [Header("普通内容卡片的背景颜色，例如功能卡片、信息卡片")]
    public Color Surface = C("#242548");

    [Header("悬浮在普通卡片上方的内容背景，例如浮动面板、悬浮窗口")]
    public Color SurfaceElevated = C("#2D2E55");

    [Header("鼠标悬停在卡片上时的背景颜色")]
    public Color SurfaceHover = C("#303153");

    [Header("卡片或内容区域被选中时的背景颜色")]
    public Color SurfaceActive = C("#34345F");

    [Header("不可交互或被禁用的内容区域背景颜色")]
    public Color SurfaceDisabled = C("#20213B");

    [Header("对话框、确认框等弹窗的背景颜色")]
    public Color Dialog = C("#292A4C");

    [Header("下拉菜单展开后的背景颜色")]
    public Color Dropdown = C("#292A4C");

    [Header("鼠标悬停提示框的背景颜色")]
    public Color Header = C("#F5F3FF");

    [Header("模态窗口出现时，覆盖在整个界面上的半透明遮罩")]
    public Color Overlay = C("#08091BCC");

    #endregion


    #region 边框与分割线

    [Header("========== 边框与分割线 ==========")]

    [Header("普通 UI 控件的默认边框颜色")]
    public Color Border = C("#353653");

    [Header("需要突出显示的边框颜色，用于强调容器边界")]
    public Color BorderStrong = C("#48496A");

    [Header("鼠标悬停在控件上时的边框颜色")]
    public Color BorderHover = C("#6555A5");

    [Header("控件处于选中状态时的边框颜色")]
    public Color BorderActive = C("#896EFF");

    [Header("输入框默认边框颜色")]
    public Color InputBorder = C("#414263");

    [Header("用于分隔不同 UI 区域的线条颜色")]
    public Color Divider = C("#30314D");

    #endregion


    #region 文字颜色

    [Header("========== 文字颜色 ==========")]

    [Header("主要文字颜色，例如页面标题、正文、重要数据")]
    public Color TextPrimary = C("#F5F3FF");

    [Header("次要文字颜色，例如说明文字、辅助信息")]
    public Color TextSecondary = C("#B9B8D1");

    [Header("辅助性文字颜色，例如时间、备注、附加说明")]
    public Color TextTertiary = C("#9291B0");

    [Header("不可交互或禁用状态下的文字颜色")]
    public Color TextDisabled = C("#777791");

    [Header("反色文字，例如浅色背景、白色按钮上的文字")]
    public Color TextInverse = C("#17182F");

    [Header("超链接、可点击文字的默认颜色")]
    public Color TextLink = C("#A78BFA");

    [Header("鼠标悬停在超链接上时的文字颜色")]
    public Color TextLinkHover = C("#C4B5FD");

    #endregion


    #region 品牌与强调颜色

    [Header("========== 品牌与强调颜色 ==========")]

    [Header("品牌主色，用于主要按钮、重点图标和强调元素")]
    public Color Primary = C("#7657F6");

    [Header("品牌主色的悬停状态")]
    public Color PrimaryHover = C("#896EFF");

    [Header("品牌主色的按下状态")]
    public Color PrimaryPressed = C("#6345E5");

    [Header("品牌主色的禁用状态")]
    public Color PrimaryDisabled = C("#51457E");

    [Header("品牌主色的深色主题背景版本，适合选中区域和标签")]
    public Color PrimarySoft = C("#34305B");

    [Header("品牌主色的弱强调背景，用于不需要突出显示的区域")]
    public Color PrimarySubtle = C("#292644");

    [Header("品牌主色的深色版本，用于深色文字或强调元素")]
    public Color PrimaryDeep = C("#4935A5");

    [Header("放置在品牌主色背景上的前景颜色，通常是白色文字和图标")]
    public Color OnPrimary = C("#FFFFFF");

    [Header("辅助品牌色，用于次级强调元素")]
    public Color Secondary = C("#A78BFA");

    [Header("辅助品牌色的深色背景版本")]
    public Color SecondarySoft = C("#34305B");

    [Header("装饰性强调色，用于图标、插画及视觉点缀")]
    public Color Accent = C("#B49AFF");

    #endregion


    #region 按钮颜色

    [Header("========== 按钮颜色 ==========")]

    [Header("次级按钮默认背景，例如取消、返回按钮")]
    public Color ButtonSecondary = C("#34345F");

    [Header("次级按钮鼠标悬停时的背景")]
    public Color ButtonSecondaryHover = C("#41416F");

    [Header("次级按钮按下时的背景")]
    public Color ButtonSecondaryPressed = C("#4B4B7D");

    [Header("次级按钮上的文字和图标颜色")]
    public Color ButtonSecondaryText = C("#D5CCFF");

    [Header("危险操作按钮背景，例如删除、清空、移除")]
    public Color ButtonDanger = C("#C83F52");

    [Header("危险操作按钮鼠标悬停背景")]
    public Color ButtonDangerHover = C("#E05264");

    [Header("危险操作按钮上的文字和图标颜色")]
    public Color ButtonDangerText = C("#FFFFFF");

    [Header("普通按钮处于禁用状态时的背景")]
    public Color ButtonDisabled = C("#30314A");

    [Header("普通按钮处于禁用状态时的文字")]
    public Color ButtonDisabledText = C("#777791");

    #endregion


    #region 输入控件颜色

    [Header("========== 输入控件颜色 ==========")]

    [Header("输入框默认背景颜色")]
    public Color InputBackground = C("#20213F");

    [Header("鼠标悬停在输入框上时的背景颜色")]
    public Color InputHover = C("#292A4A");

    [Header("输入框获得焦点时的背景颜色")]
    public Color InputFocused = C("#242548");

    [Header("输入框获得焦点时的边框颜色")]
    public Color InputFocusBorder = C("#896EFF");

    [Header("输入框为空时占位提示文字的颜色")]
    public Color InputPlaceholder = C("#777791");

    [Header("输入框处于禁用状态时的背景颜色")]
    public Color InputDisabled = C("#20213B");

    [Header("复选框、单选框未选中时的背景颜色")]
    public Color CheckBackground = C("#20213F");

    [Header("复选框、单选框被选中时的背景颜色")]
    public Color CheckSelected = C("#7657F6");

    [Header("复选框勾选符号或单选框内部标记的颜色")]
    public Color CheckMark = C("#FFFFFF");

    #endregion


    #region 导航与菜单颜色

    [Header("========== 导航与菜单颜色 ==========")]

    [Header("导航菜单默认文字颜色")]
    public Color NavigationText = C("#B9B8D1");

    [Header("导航菜单默认图标颜色")]
    public Color NavigationIcon = C("#9291B0");

    [Header("鼠标悬停在导航菜单上时的背景颜色")]
    public Color NavigationHover = C("#292A4C");

    [Header("导航菜单当前选中项的背景颜色")]
    public Color NavigationActive = C("#34305B");

    [Header("导航菜单当前选中项的文字颜色")]
    public Color NavigationActiveText = C("#C4B5FD");

    [Header("导航菜单当前选中项的图标颜色")]
    public Color NavigationActiveIcon = C("#A78BFA");

    #endregion


    #region 状态颜色

    [Header("========== 状态颜色 ==========")]

    // 成功状态：文件校验通过、任务完成、操作成功

    [Header("成功状态的主要颜色，例如成功图标、成功标记")]
    public Color Success = C("#4ADE80");

    [Header("成功状态提示区域的背景颜色")]
    public Color SuccessBackground = C("#183B2B");

    [Header("成功状态提示区域的边框颜色")]
    public Color SuccessBorder = C("#286342");

    [Header("成功状态提示文字颜色")]
    public Color SuccessText = C("#86EFAC");


    // 警告状态：操作风险、文件异常、需要用户确认

    [Header("警告状态的主要颜色")]
    public Color Warning = C("#FBBF24");

    [Header("警告状态提示区域的背景颜色")]
    public Color WarningBackground = C("#45351B");

    [Header("警告状态提示区域的边框颜色")]
    public Color WarningBorder = C("#765522");

    [Header("警告状态提示文字颜色")]
    public Color WarningText = C("#FCD34D");


    // 错误状态：校验失败、操作失败、文件损坏

    [Header("错误状态的主要颜色")]
    public Color Error = C("#F87171");

    [Header("错误状态提示区域的背景颜色")]
    public Color ErrorBackground = C("#451F27");

    [Header("错误状态提示区域的边框颜色")]
    public Color ErrorBorder = C("#77313D");

    [Header("错误状态提示文字颜色")]
    public Color ErrorText = C("#FCA5A5");


    // 信息状态：普通提示、操作说明、处理中

    [Header("信息状态的主要颜色")]
    public Color Info = C("#60A5FA");

    [Header("信息状态提示区域的背景颜色")]
    public Color InfoBackground = C("#1C3150");

    [Header("信息状态提示区域的边框颜色")]
    public Color InfoBorder = C("#315D91");

    [Header("信息状态提示文字颜色")]
    public Color InfoText = C("#93C5FD");

    #endregion


    #region 数据展示与图表

    [Header("========== 数据展示与图表 ==========")]

    [Header("图表第一组数据的颜色，通常为品牌主色")]
    public Color ChartColor1 = C("#896EFF");

    [Header("图表第二组数据的颜色")]
    public Color ChartColor2 = C("#60A5FA");

    [Header("图表第三组数据的颜色")]
    public Color ChartColor3 = C("#4ADE80");

    [Header("图表第四组数据的颜色")]
    public Color ChartColor4 = C("#FBBF24");

    [Header("图表第五组数据的颜色")]
    public Color ChartColor5 = C("#F472B6");

    [Header("图表内部网格线的颜色")]
    public Color ChartGrid = C("#353653");

    [Header("图表坐标轴、刻度和说明文字的颜色")]
    public Color ChartLabel = C("#9291B0");

    [Header("鼠标悬停在图表数据上时，提示框的背景颜色")]
    public Color ChartHeader = C("#292A4C");

    #endregion


    #region 滚动条与进度条

    [Header("========== 滚动条与进度条 ==========")]

    [Header("滚动条轨道背景颜色")]
    public Color ScrollbarBackground = C("#20213F");

    [Header("滚动条滑块默认颜色")]
    public Color ScrollbarHandle = C("#555574");

    [Header("鼠标悬停在滚动条滑块上时的颜色")]
    public Color ScrollbarHandleHover = C("#8583A8");

    [Header("进度条未完成部分的轨道颜色")]
    public Color ProgressTrack = C("#353653");

    [Header("进度条已完成部分的填充颜色")]
    public Color ProgressFill = C("#896EFF");

    #endregion


    #region 阴影与特殊效果

    [Header("========== 阴影与特殊效果 ==========")]

    [Header("普通卡片、按钮等 UI 元素的阴影颜色")]
    public Color Shadow = C("#00000040");

    [Header("弹窗和浮动面板使用的阴影颜色")]
    public Color DialogShadow = C("#00000070");

    [Header("文本被选中时的背景高亮颜色")]
    public Color Selection = C("#896EFF40");

    [Header("键盘焦点或无障碍焦点提示的外描边颜色")]
    public Color FocusOutline = C("#896EFF");

    #endregion
}
