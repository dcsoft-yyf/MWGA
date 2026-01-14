using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.JSInterop;

namespace MWGAWinFormDemo
{
    public static class WasmProgram
    {
        [JSInvokable]
        public static void RunMinesweeper()
        {
            try
            {
                Application.Run(new Minesweeper.frmMinesweeper());
            }
            catch( Exception ext )
            {
                Console.WriteLine(ext.ToString());  
            }
        }
        [JSInvokable]
        public static void TestResourceForm()
        {
            try
            {
                var dlg = new dlgMessage();
                dlg.InputMessageText = "Some text " + DateTime.Now.ToString();
                Application.Run(dlg);
            }
            catch( System.Exception ext )
            {
                Console.WriteLine(ext.ToString());
            }
        }
        [JSInvokable]
        public static void TestTimer()
        {
            try
            {
                var frm = new Form();
                frm.Width = 500;
                frm.Height = 400;
                var timer = new System.Windows.Forms.Timer();
                timer.Interval = 500;
                timer.Tick += delegate (object obj2, EventArgs args2)
                {
                    frm.Text = DateTime.Now.ToLongTimeString();
                };
                timer.Start();
                Application.Run(frm);
            }
            catch(Exception ext )
            {
                Console.WriteLine(ext.ToString());
            }
        }
        
        [JSInvokable]
        public static void TestMessageBox()
        {
            Application.EnableVisualStyles();
            var frm = new Form();
            frm.Text = "Demo of messagebox ";
            frm.Size = new System.Drawing.Size(400, 300);
            var btn = new Button();
            btn.Text = "Show Old MessageBox";
            btn.Bounds = new System.Drawing.Rectangle(20, 20, 150, 40);
            btn.Dock = DockStyle.Top;
            btn.Click += delegate( object? sender, EventArgs e)
            {
                var result = System.Windows.Forms.MessageBox.Show("Hello from old message box!","Old MessageBox", MessageBoxButtons.YesNo);
                frm.Text = "Old=" + result.ToString();
            };
            frm.Controls.Add(btn);

            var lbl = new Label();
            lbl.AutoSize = true;
            lbl.Text = "Show New MessageBox";
            lbl.Height = 50;
            lbl.Dock = DockStyle.Bottom;
            lbl.Click += async delegate( object? sender, EventArgs e)
            {
                // 使用新的异步 MessageBoxNew API来显示更好的呈现效果
                var result = await System.Windows.Forms.MessageBoxNew.Show(
                    "Hello from new message box!", 
                    "New MessageBox",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);
                frm.Text = "New=" + result.ToString();
                //System.Windows.Forms.MessageBox.Show("New Result:" + result.ToString());
            };
            frm.Controls.Add(lbl);
            Application.Run(frm);
        }
 

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
