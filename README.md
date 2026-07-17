# MGModEditor

**MG-Mod 图形化配置编辑器** — 基于 WPF 的现代化桌面 GUI 工具

[![Version](https://img.shields.io/badge/version-v1.2.0.0-green)]()
[![.NET](https://img.shields.io/badge/.NET-9.0--windows-512BD4)](https://dotnet.microsoft.com/)
[![WPF-UI](https://img.shields.io/badge/WPF--UI-4.2.0-blue)]()
[![License](https://img.shields.io/badge/License-CC%20BY--NC--ND%204.0-lightgrey)](LICENSE)

---

## 📖 简介

**MGModEditor** 是 MG-Mod 的可视化配置编辑器，采用 **C# WPF** 技术栈构建。它提供了直观的图形界面，让用户可以轻松编辑 MG-Mod 的所有配置文件，无需手动修改 JSON。

> 🎨 支持 **36 种主题配色**（18 种颜色 × 亮/暗模式），总有一款适合你！

---

## 🖥️ 技术架构

### 技术栈

| 组件 | 技术 |
|------|------|
| 语言 | C# 13 |
| 运行时 | .NET 9.0-windows |
| UI 框架 | **WPF** + **WPF-UI 4.2.0**（现代化控件库） |
| 架构模式 | **MVVM**（CommunityToolkit.Mvvm 8.4.0） |
| DI 容器 | Microsoft.Extensions.Hosting 10.0.1 |
| 发布方式 | 单文件发布 (PublishSingleFile, win-x64) |

### 项目结构

```
MGEditor/
├── App.xaml(.cs)         ← 应用入口，IHost DI 配置
├── Controls/             ← 自定义 WPF 控件
│   ├── CheckButtonFrame
│   ├── ComboxFrame
│   ├── ContainerFrameGroup
│   ├── FrameGroup
│   └── GalleryNavigationPresenter
├── ControlsLookup/       ← 页面注册与导航
├── DependencyModel/      ← DI 扩展
├── Helpers/              ← 工具类（JSON 读取、类型转换等）
├── Models/               ← 数据模型
│   ├── MGConfig.cs       ← MG 主配置模型
│   ├── AppSetting.cs     ← 应用设置
│   └── CustomThemeConfig.cs
├── Services/             ← 服务层
│   ├── MGConfigService.cs    ← 配置读写
│   ├── AppSettingService.cs  ← 应用设置
│   ├── CustomThemeService.cs ← 主题管理
│   └── WindowsProviderService.cs
├── Theme/                ← 36 个主题 XAML 资源字典
├── ViewModels/           ← MVVM 视图模型
└── Views/                ← WPF 页面视图
```

---

## ✨ 功能页面

| 页面 | 功能 |
|------|------|
| **主页 (Home)** | 概览启动页 |
| **战局系统** | AI 设置、战局参数、资源倍率 |
| **经济系统** | 跳蚤市场优化、商人交易设置 |
| **养成系统** | Scav 优化、基础属性、装备优化、附魔、藏身处 |
| **容器扩容** | 容器容积、兼容性、负重设置 |
| **特色功能** | 独立商人、独立物品、独立预设、实时跳蚤、钥匙分类、子弹数据 |
| **设置 (Settings)** | 主题切换、应用设置 |

### 配置域覆盖

编辑器可修改 MG-Mod 的全部配置文件，涵盖：

- **Bot** — AI 生命值倍率
- **Config** — 空投、AI 生成、战局默认、搜刮倍率、商人买卖、天气
- **Globals** — 跳蚤市场、撤离、装载、护甲/武器增益、经验优化
- **Hideout** — 建造/生产时间、Scav 箱、燃料、QTE
- **Locations** — 战局时间、Boss/Bot 刷新、撤离、地图保险
- **Templates** — 物品鉴定、容器扩容、堆叠、背包/护甲/头盔过滤
- **Traders** — 保险时间/费用
- **MGCustom** — 自定义商人/物品/预设/同步跳蚤

---

## 🚀 使用方式

### 下载
前往 [MG-Mod 发布仓库 Releases](https://github.com/MarecGents/MG-Mod/releases) 下载最新版本。

### 运行
MGModEditor 为免安装绿色单文件，直接运行 `MGEditor.exe` 即可。

### 系统要求
- Windows x64
- .NET 9.0 运行时（如未安装，首次运行会自动提示下载）

---

## 🎨 主题系统

MGModEditor 内置 **36 种主题配色**：

| 颜色 | 亮色 | 暗色 |
|------|:----:|:----:|
| Black, Brown, Cyan, Gray, Green | ✅ | ✅ |
| Indigo, Lemon, Magenta, Ocean, Orange | ✅ | ✅ |
| Pink, Purple, Red, Sapphire, Tea | ✅ | ✅ |
| Violet, White, Yellow | ✅ | ✅ |

可在设置页面一键切换。

---

## 📄 许可证

本项目采用 **CC BY-NC-ND 4.0** 协议。

- ✅ 允许免费使用和分享（需署名）
- ❌ **禁止商业用途**
- ❌ **禁止修改后重新发布**

保留所有版权。详见 [LICENSE](LICENSE) 文件。

---

## 🔗 相关链接

- [ODDBA 发布帖](https://sns.oddba.cn/183236.html)
- [MG-Mod（主仓库）](https://github.com/MarecGents/MG-Mod)
- [MG-Mod-CSharp（核心逻辑库）](https://github.com/MarecGents/MG-Mod-CSharp)
- 作者：[MarecGents](https://sns.oddba.cn/author/92586) | [爱发电](https://ifdian.net/a/MarecGents)
