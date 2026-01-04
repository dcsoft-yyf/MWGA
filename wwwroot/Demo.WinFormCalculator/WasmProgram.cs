using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.JSInterop;

namespace WinFormCalculator
{
    public static class WasmProgram
    {
        /// <summary>
        /// 一个很简单的测试窗体
        /// </summary>
        [JSInvokable]
        public static void TestFirstForm()
        {
            Application.EnableVisualStyles();
            var frm = new Form();
            frm.Text = "First form" + DateTime.Now.ToString();
            frm.Size = new System.Drawing.Size(200, 300);
            frm.BackColor = System.Drawing.Color.Red;
            frm.Load += delegate( object? sender, EventArgs e)
            {
                frm.Text = frm.Size.ToString();
            };
            Application.Run(frm);
        }

        /// <summary>
        /// 计算器的应用程序的主入口点。
        /// </summary>
        [JSInvokable]
        public static void Main4WinFormCalculator()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CalculatorForm());
        }
    }
}
