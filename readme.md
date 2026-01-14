# MWGA - Make WinForms Great Again !!

<img src="https://github.com/dcsoft-yyf/MWGA/blob/main/MWGA.jpg?raw=true"/>

## Update Log | 更新日志
- 2026-1-16 :Support GDI+ API.[https://dcsoft-yyf.github.io/MWGA/index.html](https://dcsoft-yyf.github.io/MWGA/index.html)
  - Minisweeper Game Demo use GDI+ API. 
  - The same set of C# code using `System.Drawing` can be compiled into `.exe` and `.wasm` without modification. The operation effect is exactly the same. 
  - <img src="https://github.com/dcsoft-yyf/MWGA/blob/main/images/minesweeper.png?raw=true"/>
- 2026-1-4 :Frist blood [https://dcsoft-yyf.github.io/MWGA/WinFormCalculator.html](https://dcsoft-yyf.github.io/MWGA/WinFormCalculator.html)
  - Calculator Demo use TextBox and Button controls
  - <img src="https://github.com/dcsoft-yyf/MWGA/blob/main/images/calculator.png?raw=true"/>

## Current Status of Global WinForms Modernization | 全球 WinForms 现代化现状

Globally, it is estimated that there are about 3 to 5 million WinForms developers, accounting for 40% to 50% of the total number of .NET developers. There are 10 to 15 million WinForms applications running in production environments. Among these applications, 60% to 80% have modernization transformation needs, and 40% to 60% of them prioritize web-based migration, involving possibly `hundreds of billions of lines` of C# code. The core driving factors include web-side access, interface modernization, cross-platform support, cloud integration, and security compliance. Due to the reusability of C# code and browser-based cross-platform capabilities, Blazor WebAssembly has become a popular choice.

全球范围内，估计WinForms开发者约有300万至500万人，占.NET开发者总数的40%至50%。生产环境中运行着1000万至1500万个WinForms应用程序。在这些应用中，60%至80%有现代化改造需求，其中40%至60%优先选择Web化迁移，涉及的C#代码可能有`数千亿行`。核心驱动因素包括网页端访问、界面现代化、跨平台支持、云集成和安全合规。由于可复用C#代码且具备基于浏览器的跨平台能力，Blazor WebAssembly成为热门选择。

However, a large number of WinForms applications use the `System.Drawing` module to call `GDI+` for complex custom drawing and interaction. These parts are difficult to migrate through simple control mapping and usually require rewriting or significant modification. For this reason, there is a strong market demand for modern migration solutions that require minimal changes and enable reuse of business logic and drawing code. But for a long time, effective tools and methods have been lacking, leading many enterprises to face high rewriting costs and risks.

但是有大量的WinForms使用了`System.Drawing`模块调用`GDI+`进行复杂的自定义绘图和交互，这些部分难以通过简单的控件映射迁移，通常需要重写或大幅修改。为此，市场上对低改动、可复用业务逻辑和绘图代码的现代化迁移解决方案需求强烈。但长期以来一直缺乏有效工具和方法，导致许多企业面临高昂的重写成本和风险。

## Project Introduction | 项目简介

This project is specifically designed to help migrate WinForms applications to the Blazor WASM platform. Even if these programs use GDI+ functions, we expect the amount of modification to the source code of these programs to be no more than `10%`. This greatly reduces the cost and risk of modernizing WinForms software.

本项目就是专门帮助将WinForms 应用程序迁移到 Blazor WASM平台上，即使这些程序使用GDI+功能，我们也预期将对这些程序源码的修改量不超过`10%`。这极大的降低WinForms软件现代化的成本和风险。

Our long-term goal is to revitalize `100 billion lines` of market-proven C# code worldwide, allowing it to continue to deliver value on modern web front-end platforms.

我们的长期目标是能将全球`1000亿`行经过市场验证的C#代码能重获新生，在现代Web前端平台上继续发挥价值。

## 目前MWGA已经支持的关键API | The key APIs currently supported by MWGA 
- System.Drawing.Bitmap
- System.Drawing.Brush
- System.Drawing.Font
- System.Drawing.Graphics
  - DrawString( ), DrawImage( ), DrawLine( ), DrawRectangle( ), FillRectangle( ), DrawEllipse( ), FillEllipse(), MeasureString( ), PageUnit, Transform
- System.Drawing.Pen
- System.Drawing.SolidBrush
- System.Drawing.Drawing2D.Martix
- System.Windows.Forms.Application
  - AddMessageFilter( ), Run( ), RemoveMessageFilter( )
- System.Windows.Forms.Button
- System.Windows.Forms.Control
  - BackColor, ForeColor, Width, Height, Location, Size, Anchor,Dock, Visible, Enabled,Text,Font, Invalidate( ), Refresh( )
- System.Windows.Forms.Cursor
- System.Windows.Forms.Form
  - ShowDialog( ), Show( ), Close( ), FormBorderStyle, StartPosition, WindowState, Resize
  - Load data from Form.resx
  - Support Form.Designer.cs
- System.Windows.Forms.ImageList
  - Add( ) , Draw( )
- System.Windows.Forms.MainMenu
- System.Windows.Forms.Label
- System.Windows.Forms.MessageBox
- System.Windows.Forms.MessageBoxNew
- System.Windows.Forms.Panel
- System.Windows.Forms.PictureBox
- System.Windows.Forms.Screen
- System.Windows.Forms.TextBox
- System.Windows.Forms.Timer

## Estimated Market Size of Global WinForms Applications Pending Migration (USD) | 全球待迁移 WinForms 应用市场规模估算（美元）

Assuming there are approximately 500,000 – 2,000,000 WinForms applications to be migrated; the distribution of application complexity: 60% simple, 30% medium, 10% complex.

假设需要迁移的 WinForms 应用约 50 万 – 200 万 个；应用复杂度分布：简单 60%、中等 30%、复杂 10%。

- Estimated based on the median migration cost per application example (USD): The weighted average price is about 55,000 USD per application.
- TAM (Total Addressable Market) estimate: Approximately 27.5 billion – 110 billion USD (500,000 – 2,000,000 applications × 55,000 USD).
- Addressable market for tool/license model (5,000 – 20,000 USD per application): Approximately 2.5 billion – 40 billion USD.
- Market for complex applications (10%): Approximately 50,000 – 200,000 applications, accounting for about 7.5 billion – 30 billion USD at 150,000 USD per case.

- 按示例单应用迁移成本中位数估算（美元）：加权均价约 5.5 万美元/应用。
- TAM（总可寻址市场）估算：约 275 亿 – 1,100 亿 美元（50 万 – 200 万 应用 × 5.5 万美元）。
- 工具/许可模式可寻址市场（5 千 – 2 万 美元/应用）：约 25 亿 – 400 亿 美元。
- 复杂应用（10%）市场：约 5 万 – 20 万 个，按每例 15 万美元计约 75 亿 – 300 亿 美元。

## Source Code and License Notes | 源码与许可说明

- The core compatibility layer `DCWinForm2WASM` is a commercial closed-source product, owned entirely by Nanjing Duchang Information Technology Co., Ltd. Cracking and piracy are strictly prohibited.
- The demo project `DCWinForm2WASMDemo` is an open-source example used to demonstrate the migration process and verify compatibility.
- For any questions, please contact: 28348092@qq.com

- 核心兼容层 `DCWinForm2WASM` 为商业闭源产品，南京都昌信息科技有限公司拥有全部版权，严禁破解和盗版。
- 演示项目 `DCWinForm2WASMDemo` 为开源示例，用于演示迁移流程与验证兼容性。
- 有任何疑问请联系：28348092@qq.com
