

using System.ComponentModel;

using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Text.Json.Nodes;
using System.Collections.Generic;
using System;
using System.Drawing;
using Microsoft.JSInterop;
using DCSoft;
namespace DCSoft
{
    public static class MWGASystem
    {
#if MWGA
        public static void SetControlOwnerDraw( System.Windows.Forms.Control ctl )
        {
            ctl.DCOwnerDrawMode = DCOwnerDrawModeConsts.OwnerDraw;
        }
        public static void SetControlOwnerDrawWidthScroll(System.Windows.Forms.ScrollableControl ctl)
        {
            ctl.DCOwnerDrawMode = DCOwnerDrawModeConsts.OwnerDrawWithScroll;
        }
#else
        public static void SetControlOwnerDraw( System.Windows.Forms.Control ctl )
        {
            // 在真实的Winform.NET环境下，不做任何处理
        }
        public static void SetControlOwnerDrawWidthScroll(System.Windows.Forms.ScrollableControl ctl)
        {
            // 在真实的Winform.NET环境下，不做任何处理
        }
#endif
    }
}
namespace System.Resources
{
    internal class ResourceManager : System.ComponentModel.MWGAComponentResourceManager
    {
        public ResourceManager(Type t) : base(t)
        {
        }
    }
}
namespace System.ComponentModel
{
    /// <summary>
    /// 替换掉系统定义的System.ComponentModel.ComponentResourceManager,这可以避免修改源代码，但会导致编译警告。
    /// </summary>
    internal class ComponentResourceManager : System.ComponentModel.MWGAComponentResourceManager
    {
        public ComponentResourceManager(Type t) : base(t)
        {
        }
    }
}
namespace DCSoft.WinForm2WASM
{
    public partial class DCWasmWinFormEngine
    {
        [JSInvokable]
        public static void MarshalReturnStringValue(string str, int ptr)
        {
            MWGAPublish.MarshalReturnStringValue(str, ptr);
        }
        [JSInvokable]
        public static void MarshalFreePtr(int ptr)
        {
            MWGAPublish.MarshalFreePtr(ptr);
        }
        [JSInvokable]
        public static JsonValue MarshalPtrToJsonValue(int ptr)
        {
            return MWGAPublish.MarshalPtrToJsonValue(ptr);
        }
        [JSInvokable]
        public static int MarshalJsonValueToPtr(JsonValue json)
        {
            return MWGAPublish.MarshalJsonValueToPtr(json);
        }
        

        ///// <summary>
        ///// 封装 Invoke 调用，强制使用「标识符 + params object[]」重载
        ///// </summary>
        //public static T InvokeJSFunction<T>(string identifier, params object?[]? args)
        //{
        //    // 直接调用 params 重载（因为 args 是显式的 object[]）
        //    return _jsRuntime.Invoke<T>(identifier, args);
        //}
        //[JSInvokable]
        //public static int SendDataFromJS(JsonObject json)
        //{
        //    return MWGAPublish.SendDataFromJS(json);
        //}

        [JSInvokable]
        public static JsonNode DCExecuteControlCommand(int handle, string strCommand, JsonNode args)
        {
            return MWGAPublish.DCExecuteControlCommand(handle, strCommand, args);
        }
        //[JSInvokable]
        //public static void AddStandardControlTypeName(string typeName)
        //{
        //    MWGAPublish.AddStandardControlTypeName(typeName);
        //}
        //private static Microsoft.JSInterop.JSInProcessRuntime _jsRuntime;
        public static ValueTask Start(Microsoft.JSInterop.JSInProcessRuntime rt)
        {
            if (rt == null)
            {
                throw new ArgumentNullException("rt");
            }
            //_jsRuntime = rt;
            return MWGAPublish.Start(new MyJSRuntime(rt), typeof(DCWasmWinFormEngine).Assembly);
        }
        private class MyJSRuntime :DCSoft.IDCJSRuntime
        {
            public MyJSRuntime(JSInProcessRuntime rt)
            {
                if(rt == null )
                {
                    throw new ArgumentNullException("rt");
                }
                this._rt = rt;
            }
            private JSInProcessRuntime _rt = null;
            public T Invoke<T>(string identifier, params object?[]? args)
            {
                return _rt.Invoke<T>(identifier, args);
            }
            public ValueTask<T> InvokeAsync<T>(string identifier, params object?[]? args)
            {
                return _rt.InvokeAsync<T>(identifier, args);
            }
            public System.Threading.Tasks.ValueTask InvokeVoidAsync(string identifier, params object?[]? args)
            {
                return _rt.InvokeVoidAsync(identifier, args);
            }
        }
        ///// <summary>
        ///// 设置屏幕大小
        ///// </summary>
        ///// <param name="width">宽度</param>
        ///// <param name="height">高度</param>
        ///// <param name="defaultFontName">默认字体名称</param>
        ///// <param name="defaultFontSize">Point为单位的默认字体大小</param>
        //[JSInvokable]
        //public static void SetScreenSize(
        //    int width,
        //    int height,
        //    string defaultFontName,
        //    float defaultFontSize)
        //{
        //    MWGAPublish.SetScreenSize(width, height, defaultFontName, defaultFontSize);
        //}
        
        [JSInvokable]
        public static int PackageArgumentObjectToHandle( JsonNode json )
        {
            return MWGAPublish.PackageToHandle(json);
        }

        //[JSInvokable]
        //public static void SendMessage_WM_WINDOWPOSCHANGED( int handle , JsonObject args )
        //{
        //    MWGAPublish.SendMessage_WM_WINDOWPOSCHANGED(handle, args);
        //}
        
        /// <summary>
        /// 发送消息到控件
        /// </summary>
        /// <param name="handle">控件句柄</param>
        /// <param name="msg">消息类型</param>
        /// <param name="wParam">参数1</param>
        /// <param name="lParam">参数2</param>
        [JSInvokable]
        public async static void SendMessageToControl(int handle , int msg, int wParam, int lParam)
        {
            MWGAPublish.SendMessageToControl(handle, msg, wParam, lParam); 
        }

        

        ///// <summary>
        ///// 处理已经发送的消息
        ///// </summary>
        //[JSInvokable]
        //public static void HandlePostedMessage()
        //{
        //    MWGAPublish.HandlePostedMessage();
        //}
    }
}