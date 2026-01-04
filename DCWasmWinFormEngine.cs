using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Text.Json.Nodes;
using System.Collections.Generic;
using System;
using System.Drawing;
using Microsoft.JSInterop;
using DCSoft;

namespace DCSoft.WinForm2WASM
{
    public partial class DCWasmWinFormEngine
    {
        /// <summary>
        /// 封装 Invoke 调用，强制使用「标识符 + params object[]」重载
        /// </summary>
        public static T InvokeJSFunction<T>(string identifier, params object?[]? args)
        {
            // 直接调用 params 重载（因为 args 是显式的 object[]）
            return _jsRuntime.Invoke<T>(identifier, args);
        }
        [JSInvokable]
        public static void InstallFontNames(string[] fontNames)
        {
            WinForm2WASMPublish.SetFamilies(fontNames);
        }
        [JSInvokable]
        public static void AddStandardControlTypeName(string typeName)
        {
            WinForm2WASMPublish.AddStandardControlTypeName(typeName);
        }
        private static Microsoft.JSInterop.JSInProcessRuntime _jsRuntime;
        public static void Start(Microsoft.JSInterop.JSInProcessRuntime rt)
        {
            if (rt == null)
            {
                throw new ArgumentNullException("rt");
            }
            _jsRuntime = rt;
            WinForm2WASMPublish.Start(new MyJSRuntime(rt), typeof(DCWasmWinFormEngine).Assembly);
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
            public async void InvokeVoidAsync(string identifier, params object?[]? args)
            {
                _rt.InvokeVoidAsync(identifier, args);
            }
        }
        /// <summary>
        /// 设置屏幕大小
        /// </summary>
        /// <param name="width">宽度</param>
        /// <param name="height">高度</param>
        /// <param name="defaultFontName">默认字体名称</param>
        /// <param name="defaultFontSize">Point为单位的默认字体大小</param>
        [JSInvokable]
        public static void SetScreenSize(
            int width,
            int height,
            string defaultFontName,
            float defaultFontSize)
        {
            WinForm2WASMPublish.SetScreenSize(width, height, defaultFontName, defaultFontSize);
        }
        
        [JSInvokable]
        public static int PackageArgumentObjectToHandle( JsonNode json )
        {
            return WinForm2WASMPublish.PackageToHandle(json);
        }

        [JSInvokable]
        public static void SendMessage_WM_WINDOWPOSCHANGED( int handle , JsonObject args )
        {
            WinForm2WASMPublish.SendMessage_WM_WINDOWPOSCHANGED(handle, args);
        }
        
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
            WinForm2WASMPublish.SendMessageToControl(handle, msg, wParam, lParam); 
        }

        

        /// <summary>
        /// 处理已经发送的消息
        /// </summary>
        [JSInvokable]
        public static void HandlePostedMessage()
        {
            WinForm2WASMPublish.HandlePostedMessage();
        }
    }
}