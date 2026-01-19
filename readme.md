# MWGA - To Revive 100 Billion Lines of C# Code | [简体中文版]()

**Nanjing Duchang Information Technology Co., Ltd.**  
**January 15, 2026**
<img src="https://github.com/dcsoft-yyf/MWGA/blob/main/MWGA.jpg?raw=true"/>
---

## 1. One-Sentence Introduction

MWGA stands for "Make WinForms Great Again". It is a tool that quickly migrates WinForm.NET programs using GDI+ to the Blazor WASM platform, keeping code modifications below 10%, thereby reviving 100 billion lines of C# code worldwide.

## 2. Project Background

It is estimated that there are approximately 3 to 5 million WinForms developers worldwide, accounting for 40% to 50% of all .NET developers. There are 10 to 15 million WinForms applications running in production environments. Among these applications, 60% to 80% have modernization needs, with 40% to 60% prioritizing web migration, potentially involving hundreds of billions of lines of C# code. Core driving factors include web access, interface modernization, cross-platform support, cloud integration, and security compliance. Blazor WebAssembly has become a popular choice due to its ability to reuse C# code and provide browser-based cross-platform capabilities.

However, a large number of WinForms applications use the System.Drawing module to call GDI+ for complex custom drawing and interaction. These parts are difficult to migrate through simple control mapping and usually require rewriting or significant modification. As a result, there is a strong market demand for modernization migration solutions with low modification, reusable business logic, and drawing code. However, effective tools and methods have been lacking for a long time, leading many enterprises to face high rewriting costs and risks, creating a huge supply-demand contradiction.

## 3. Our Goals

MWGA is specifically designed to help migrate WinForms applications to the Blazor WASM platform. Even for programs using GDI+ features, we expect code modifications to be no more than 10%, greatly reducing the cost and risk of WinForms software modernization.

Our long-term goal is to revive 100 billion lines of market-validated C# code, enabling them to continue providing value on modern web frontend platforms. MWGA helps developers compile the same C# code into both .exe and .wasm files, with highly consistent running effects.

**Download**: [https://github.com/dcsoft-yyf/MWGA](https://github.com/dcsoft-yyf/MWGA)

## 4. Competitive Comparison

Currently, there are the following solutions for migrating WinForms programs to Blazor WASM:

- **Code Generation Migration**: Use tool software to parse WinForms source code and automatically generate Blazor code for independent maintenance.
- **Manual Refactoring**: Reference the original WinForms program and write Blazor components from scratch, completely separate from the original WinForms program.
- **Hybrid Bridging (WebView2)**: Embed a WebView2 browser component in the WinForms program and gradually migrate software functionality to a BS structure.

The comparison between MWGA and other solutions with the same goal is as follows:

| Comparison Dimension | MWGA | Code Generation Migration | Manual Refactoring | Hybrid Bridging |
|---------------------|------|-------------------------|-------------------|-----------------|
| **Migration Efficiency** | Extremely fast (hours): Import project and render immediately, minimal coding adaptation, migration efficiency far exceeds other solutions. | Fast (days) | Very slow (weeks/months) | Medium (days/weeks) |
| **Technical Threshold** | Very low (zero Blazor/frontend foundation required): Only need to be familiar with the original WinForms project, ordinary developers can quickly get started, greatly reducing migration learning costs. | Medium (requires basic Blazor knowledge, need to learn new Blazor technology stack) | High (proficient in Blazor ecosystem, need to fully master Blazor + frontend technology stack) | Medium-High (requires dual-stack knowledge, need to master both WinForms and frontend/backend technology stacks) |
| **Code Modification** | Zero modification for ordinary projects.<br>Complex projects and GDI+ projects: less than 10% modification | Medium: 5%-20% adaptation modification after code generation (such as control event binding, style adjustment); GDI+ features require significant rewriting (30%-60%); need to adapt to Blazor technology stack specifications | 100%: Need to completely rewrite UI code, only a small amount of pure business logic code can be reused; GDI+ drawing needs to be completely rebuilt based on Blazor/JS; need to completely switch to Blazor technology stack | Medium-High: Need to modify 30%-50% of WinForms code to adapt to the bridging layer, while writing Blazor frontend interaction code; GDI+ requires additional adaptation of bridging rendering logic; need to master dual technology stack adaptation rules |
| **Cost Advantage** | Extreme cost advantage: minimal coding labor costs, no learning costs; no subsequent code maintenance costs; pure frontend deployment with no server operation and maintenance costs; projects with GDI+ can significantly save rewriting costs. | Medium: Need to bear labor costs for code generation adaptation, low subsequent maintenance costs; GDI+ adaptation requires additional costs; need to invest in Blazor technology stack training costs | Very high: High full rewriting labor costs, combined with early learning costs and later maintenance costs; GDI+ refactoring costs account for more than 50% | High: High dual-stack development labor costs, continuous bridging layer compatibility maintenance costs, no cross-platform cost advantage; GDI+ adaptation further increases costs; need to invest in dual technology stack learning and adaptation costs |
| **GDI+ Support** | Good support: Achieve GDI+ drawing migration by simulating core types such as System.Drawing.Graphics, can preserve original drawing logic and interaction effects; same code has consistent interface and logic in both WinForms and Blazor WASM environments; no technology stack changes, drawing-related development experience can be directly reused | Limited support: Can only recognize basic GDI+ syntax, complex drawing logic (such as custom rendering, dynamic drawing) cannot directly generate code, requires significant rewriting; need to rebuild drawing logic based on Blazor technology stack | Requires complete refactoring: No native GDI+ support, need to reimplement all drawing functions based on Blazor components/HTML5 Canvas+JS, extremely high learning and development costs; need to completely abandon original GDI+ development technology stack | Partial support: Can preserve WinForms native GDI+ rendering, but need to adapt WebView2 bridging communication logic, with performance loss and cross-platform limitations; need to master GDI+ adaptation technology under dual stacks |
| **Technology Stack Continuity** | Complete continuity: No need to change enterprise's existing WinForms technology stack, developers can reuse original WinForms development experience and skills; project code structure and development standards remain unchanged, only frontend rendering form changes | Partial continuity: Can reuse WinForms business logic experience, need to switch to Blazor technology stack, development standards and code structure need to adapt to Blazor framework requirements | Complete switch: Need to completely abandon WinForms technology stack, fully turn to Blazor + frontend technology stack, low reuse rate of original development experience | Dual-stack coexistence: Need to maintain both WinForms and Blazor technology stacks simultaneously |
| **Adaptation Scenarios** | Quickly verify migration effects;<br>Scenarios with high cross-platform requirements, data security sensitivity, tight migration cycles, strict cost control (advantageous adaptation);<br>WinForms project migration with GDI+ drawing functions;<br>Enterprise projects that focus on technology stack continuity and need to reuse existing development team capabilities | Projects that need long-term maintenance and gradual evolution to pure Blazor architecture; projects without complex GDI+ functions; enterprise projects that can accept partial technology stack switching | Large projects, complex logic, pursuing ultimate performance/long-term value; GDI+ projects that can accept full rewriting costs and complete technology stack switching; enterprise projects with clear Blazor technology stack transformation plans | Must retain WinForms logic, Windows platform only; projects with complex GDI+ functions but cannot bear refactoring costs; enterprise projects that can accept dual technology stack coexistence for short-term transition |

## 5. Use Case One: Minesweeper Game, 2% Code Modification

Minesweeper is a classic Windows game program. We downloaded a Minesweeper program based on MS .NET Framework 2.0 from [https://gitee.com/dingxiaowei/MineGame](https://gitee.com/dingxiaowei/MineGame). This is a WinForms program written 10 years ago, containing approximately 2,500 lines of C# code and several image resource files. The compiled .exe file runs as shown below:

![Minesweeper WinForms Version](https://github.com/dcsoft-yyf/MWGA/blob/main/images/winform-mine.png?raw=true)

This program extensively uses `System.Drawing.Graphics.DrawLine()`/`DrawImage()`/`FillRectangle()` interfaces to draw the game interface.

We created a Blazor WASM 9.0 program, copied the Minesweeper program source files, and made some compatibility modifications as shown below:

```csharp
#if MWGA
    public static async ValueTask<ShowSelfResult> ShowSelf(...)
#else
    public static ShowSelfResult ShowSelf(...)
#endif
{
    bool result;
    frmCustomGame cg = new frmCustomGame();
    cg.tbHeight.Text = height.ToString();
    cg.tbWidth.Text = width.ToString();
    cg.tbMineCount.Text = mineCount.ToString();
    cg.Location = location;
#if MWGA
    if (await cg.ShowDialog(parent) == DialogResult.OK)
#else
    if (cg.ShowDialog(parent) == DialogResult.OK)
#endif
    {
        // ...
    }
}
```

Since Blazor WASM uses a browser non-blocking thread mode, we implemented an asynchronous `ShowDialog()` function, using `await` statements to pause current code execution, thus reducing modifications to old code.

Finally, we modified no more than 50 lines (2%) of the old code, allowing the same code to compile into both .exe and .wasm files without modification. The Minesweeper program compiled into .wasm runs in Google Chrome as shown below:

![Minesweeper Blazor WASM Version](https://github.com/dcsoft-yyf/MWGA/blob/main/images/minesweeper.png?raw=true)

Thousands of lines of graphics drawing code in the program were not modified at all, as shown below:

```csharp
protected override void OnPaint(PaintEventArgs e)
{
    Rectangle rect = ClientRectangle;
    Graphics g = e.Graphics;

    g.FillRectangle(grayBrush, rect);
    drawFrame(g, new Rectangle(rect.Left, rect.Top, rect.Width - 1, rect.Height - 1));
    if (Image != null)
    {
        int offset;
        if (pressed)
            offset = 1;
        else
            offset = 0;
        g.DrawImage(Image, rect.Left + 4 + offset, rect.Top + 4 + offset);
    }
}
```

## 6. Use Case Two: Calculator, Zero Code Modification

We developed a Winform.NET calculator program containing 460 lines of C# code. Its running interface is shown below:

![Calculator WinForms Version](https://github.com/dcsoft-yyf/MWGA/blob/main/images/winform-calculator.png?raw=true)

It responds to form resize events to set the position and size of buttons and text boxes. The code is as follows:

```csharp
private void CalculatorForm_Resize(object sender, EventArgs e)
{
    UpdateControlLayout();
}

/// <summary>
/// Dynamically update the position and size of all controls (completely fill the form, no blank space)
/// </summary>
private void UpdateControlLayout()
{
    // Get form client area (excluding borders)
    Rectangle clientRect = this.ClientRectangle;

    // 1. Handle display screen (occupies top full row, height is 1/6 of client area, remaining part for buttons)
    int displayHeight = clientRect.Height / 6;
    // Display screen position: left, top, right spacing is fixedPadding, height is displayHeight
    txtDisplay.Location = new Point(_fixedPadding, _fixedPadding);
    var newSize = new Size(clientRect.Width - 2 * _fixedPadding, displayHeight - 2 * _fixedPadding);
    // ...
}
```

This C# code was not modified at all. With MWGA, it runs in Blazor WASM as shown below:

![Calculator Blazor WASM Version](https://github.com/dcsoft-yyf/MWGA/blob/main/images/calculator.png?raw=true)

## 7. Basic Principles

MWGA's basic principle is to simulate `System.Windows.Forms.Control` types and `System.Drawing.Graphics` types to achieve low-modification migration of WinForms code. MWGA establishes the following functional module mappings:

| HTML Functional Module | MWGA Functional Module |
|----------------------|----------------------|
| `<canvas>` | `System.Drawing.Graphics` |
| `<button>` | `System.Windows.Forms.Button` |
| `<img>` | `System.Windows.Forms.PictureBox` |
| `<div>` | `System.Windows.Forms.Form`<br>`System.Windows.Forms.Panel`<br>`System.Windows.Forms.Control`<br>`System.Windows.Forms.Label` |
| `<nav>` | `System.Windows.Forms.MainMenu` |
| `<input type="text">` or `<textarea>` | `System.Windows.Forms.TextBox` |
| `window.alert()` | `System.Windows.Forms.MessageBox` |
| `<div>` | `System.Windows.Forms.MessageBoxNew` |
| `element.style.cursor` | `System.Windows.Forms.Cursor` |
| `window.setTimeout()` | `System.Windows.Forms.Timer` |
| `MouseEvent`, `KeyEvent` | Win32 Messages, including `WM_KEYUP`, `WM_KEYDOWN`, `WM_LBUTTONDOWN`, `WM_LBUTTONUP`, etc. |

MWGA internally also simulates Win32 Message loop and message queue, constructing a WinForms underlying runtime framework, enabling user's WinForms-based C# code to run on Blazor WASM after recompilation.

## 8. Key Features Supported by MWGA (2026-1-15)

### System.Drawing Namespace
- `System.Drawing.Bitmap`
- `System.Drawing.Brush`
- `System.Drawing.Font`
- `System.Drawing.Graphics`
  - `DrawString()`, `DrawImage()`, `DrawLine()`, `DrawRectangle()`, `FillRectangle()`, `DrawEllipse()`, `FillEllipse()`, `MeasureString()`, `PageUnit`, `Transform`
- `System.Drawing.Pen`
- `System.Drawing.SolidBrush`
- `System.Drawing.Drawing2D.Matrix`

### System.Windows.Forms Namespace
- `System.Windows.Forms.Application`
  - `AddMessageFilter()`, `Run()`, `RemoveMessageFilter()`
- `System.Windows.Forms.Button`
- `System.Windows.Forms.Control`
  - `BackColor`, `ForeColor`, `Width`, `Height`, `Location`, `Size`, `Anchor`, `Dock`, `Visible`, `Enabled`, `Text`, `Font`, `Invalidate()`, `Refresh()`
- `System.Windows.Forms.Cursor`
- `System.Windows.Forms.Form`
  - `async ShowDialog()`, `Show()`, `Close()`, `FormBorderStyle`, `StartPosition`, `WindowState`, `Resize`
  - Load data from `Form.resx`
  - Support `Form.Designer.cs`
- `System.Windows.Forms.ImageList`
  - `Add()`, `Draw()`
- `System.Windows.Forms.MainMenu`
- `System.Windows.Forms.Label`
- `System.Windows.Forms.MessageBox`
- `System.Windows.Forms.MessageBoxNew`
  - `async Show()`
- `System.Windows.Forms.Panel`
- `System.Windows.Forms.PictureBox`
- `System.Windows.Forms.Screen`
- `System.Windows.Forms.TextBox`
- `System.Windows.Forms.Timer`

### Resource Management
- `System.Resources.ResourceManager`
- `System.ComponentModel.ComponentResourceManager`

### Platform Support
- **Development Environment**: Blazor WebAssembly 9.0/10
- **Browsers**: Chrome, Firefox and other mainstream browsers
- **Operating Systems**: Windows, Linux, Android

## 9. Multi-Language Support

MWGA supports multi-language development. All strings inside MWGA are extracted to form a string resource JS file, as shown below:

```javascript
window.__DCResourceStrings = {
    AboutBoxDesc: "Display the 'About' dialog box for this component",
    AccDGCollapse: "Collapse",
    AccDGEdit: "Edit",
    AccDGExpand: "Expand",
    AccDGNavigate: "Navigate",
    AccDGNavigateBack: "Navigate Back",
    AccDGNewRow: "(New)",
    AccDGParentRow: "Parent Row",
    AccDGParentRows: "Parent Rows",
    AccessibleActionCheck: "Check",
    AccessibleActionClick: "Click",
    AccessibleActionCollapse: "Collapse",
    AccessibleActionExpand: "Expand",
    AccessibleActionPress: "Press",
    AccessibleActionUncheck: "Uncheck",
    // ...
};
```

We currently provide Simplified Chinese and English versions. Users can modify this JS file to use their own language.

Additionally, MWGA supports the `ComponentResourceManager` type, as shown below:

```csharp
private void InitializeComponent()
{
    var resources = new System.ComponentModel.ComponentResourceManager(typeof(dlgMessage));
    this.panel1 = new System.Windows.Forms.Panel();
    this.pictureBox1 = new System.Windows.Forms.PictureBox();
    this.label1 = new System.Windows.Forms.Label();
    this.txtMessage = new System.Windows.Forms.TextBox();
    this.btnOK = new System.Windows.Forms.Button();
    this.btnCancel = new System.Windows.Forms.Button();
    this.panel1.SuspendLayout();
    ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
    this.SuspendLayout();
    // ...
}
```

Users can set program resources in the `Form.resx` file, and use form resource files after compilation. In the future, MWGA will enhance support for multi-language `.resources.dll` files.

## 10. Development and Deployment

MWGA contains only one 3.8MB file `DCSoft.MWGA.dll`, which includes all functionality and does not depend on any other third-party components.

Developers can refer to the demo programs provided at [https://github.com/dcsoft-yyf/MWGA](https://github.com/dcsoft-yyf/MWGA) for MWGA-based development. The main steps are:

### Step 1: Create Blazor WASM Project
Create a Blazor WASM 9.0/10.0 program and add a reference to the `DCSoft.MWGA.dll` assembly. **Currently, Blazor WASM 7.0/8.0 is not supported**.

### Step 2: Copy Source Code
Copy all source code files and resource files of the WinForms program to be migrated to the project.

### Step 3: Add Bootstrap Code
Add standardized MWGA bootstrap code and HTML files for the program interface.

### Step 4: Compatibility Modifications
Perform necessary compatibility checks and modifications to user program code. Main modification points are:

| Standard WinForms Feature | MWGA Modification Instructions |
|--------------------------|-------------------------------|
| `Form.ShowDialog()` | Convert user function to async mode, then use `await Form.ShowDialog()` |
| Support P/Invoke, can use `[DllImport]` to import external API functions. | P/Invoke is not supported, must modify user code to remove P/Invoke functionality. However, if P/Invoke functionality is not triggered, the program can still run normally. |
| Form resource file `.resx` | Due to changes in source file directory structure causing `.resx` file renaming, need to adjust user code to set correct names.<br>MWGA's own `ComponentResourceManager` and `ResourceManager` can automatically handle this `.resx` renaming. |
| Can directly override `Control.OnPaint` method | Need to call `DCSoft.MWGASystem.SetControlOwnerDraw(this);` in the control constructor to notify MWGA to enable Graphics submodule for this control.<br>Enabling Graphics submodule consumes some resources, so don't enable it unless necessary. |
| `MessageBox.Show()` | Can continue to use `MessageBox.Show()`, but the underlying implementation calls `window.Alert()` for simulation, and the user interface is ugly.<br>If high-fidelity is needed, use `await MessageBoxNew.Show()`, need to convert user function to async mode. |

### Step 5: Compile and Run
Compile and run the program.

MWGA supports mainstream browsers like Chrome and Firefox. Supports Windows, Linux, and Android operating systems. **Windows XP, Windows 7 and other old operating systems are not supported**.

When deploying to production, consider using [https://github.com/dcsoft-yyf/BlazorWASMPackager](https://github.com/dcsoft-yyf/BlazorWASMPackager) to package Blazor WASM program files into a single JS file for easy deployment and maintenance.

## 11. Security Statement

MWGA is not open source software, but we take the following measures to ensure the software is secure:

1. **Usage Restrictions**: MWGA's only file `DCSoft.MWGA.dll` is restricted to Blazor WASM development only. For other software types, such as WinForms, ASP.NET CORE, command line, etc., it will have no effect.

2. **Pure Frontend Component**: MWGA is a pure frontend software component with no server-side program. It can only run in browser sandbox and has no access to databases, local file systems, registries, or hardware.

3. **No Network Operations**: MWGA promises not to perform any network operations, including http, ftp, Web Socket, etc. Moreover, it is easy for users to monitor abnormal network behavior in browsers.

4. **Packaging Recommendation**: We recommend users use [https://github.com/dcsoft-yyf/BlazorWASMPackager](https://github.com/dcsoft-yyf/BlazorWASMPackager) to package Blazor WASM software into a single JS file. This can reduce network operations for downloading program files and even run using local `file://` protocol, further reducing network security risks.

5. **No Local Data Access**: MWGA promises not to access any local data, including browser cookies, localStorage, IndexDB, navigator objects, etc.

6. **No High-Privilege Operations**: MWGA promises not to perform high-privilege risky operations, such as operating cameras, location information access, etc.

7. **User Code Security Control**: For WinForms applications provided by users that request file access or database connections, MWGA will trigger JS events, allowing developers to write their own code to respond to events and handle such high-privilege behaviors. MWGA completely avoids security risks related to this. In the future, MWGA will provide a high-frequency changing security token mechanism to strengthen control over security behaviors of WinForms user code.

8. **Error Isolation**: When MWGA or user code causes program errors and crashes due to bugs, since it is a pure frontend component, it can only affect the current terminal. Restarting the client browser can recover, and it will not affect the server, with low security risks.

9. **Xinchuang Certification**: MWGA's sister software DCWriter5 uses the same software architecture. DCWriter5 has obtained original factory adaptation certification from UOS, Kylin, and Fangde operating systems. This indirectly indicates that MWGA meets domestic Xinchuang requirements.

10. **Security Reminder**: When MWGA exhibits high-privilege behaviors not described in this document, it can be suspected that `DCSoft.MWGA.dll` is not genuine or has been compromised by viruses or trojans. Even so, due to browser security sandbox restrictions, the user's runtime environment remains secure.

## 12. Copyright Statement

MWGA is a commercial closed-source product. Nanjing Duchang Information Technology Co., Ltd. owns all copyrights. Cracking and piracy are strictly prohibited.

Demo projects are open-source examples used to demonstrate migration processes and verify compatibility.

For any questions, please contact: 28348092@qq.com or leave a message at [https://github.com/dcsoft-yyf/MWGA](https://github.com/dcsoft-yyf/MWGA).

---

**Nanjing Duchang Information Technology Co., Ltd.**  
**January 15, 2026**
