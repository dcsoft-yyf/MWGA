global using DCSoft.WinForm2WASM;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.JSInterop;
using Microsoft.Extensions.DependencyInjection;
using System.ComponentModel;
using MWGAWinFormDemo;

[assembly: System.Reflection.AssemblyMetadata("IsTrimmable", "false")]

namespace DCSoft.WinForm2WASM
{
    [System.Runtime.Versioning.SupportedOSPlatform("browser")]
    internal class Prograss
    {
        public static async Task Main(string[] args)
        {
            // 1. 构建极简宿主（仅初始化核心服务，不含 RootComponent）
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            var host = builder.Build();

            // 2. 解析 JSRuntime
            var jsRuntime = host.Services.GetRequiredService<IJSRuntime>() as JSInProcessRuntime;

            
            await DCWasmWinFormEngine.Start(jsRuntime);

            

            await host.RunAsync();

            //// 3. 执行 JS 操作（示例：调用自定义 JS 函数）
            //var browserInfo = await jsRuntime.InvokeAsync<string>("getBrowserInfo");
            //Console.WriteLine($"从 JS 获取浏览器信息：{browserInfo}");

            //// 4. 继续构建完整应用并启动
            //builder.RootComponents.Add<App>("#app");
            //builder.RootComponents.Add<HeadOutlet>("head::after");
            //await host.RunAsync();

            //var builder = DCSoft.WebAssemblyHostBuilder.CreateDefault(args);

            //DCWasmWinFormEngine.Start(WASMJSRuntime.Instance);
            ////await System.Runtime.InteropServices.JavaScript.JSHost.ImportAsync("DCWinForm2WASM", "./DCWinForm2WASM.js");
            //await WASMJSRuntime.Instance.InvokeVoidAsync("__StartDCSoftWinForm2WASM");
            //await builder.Build().RunAsync();
        }
    }
}