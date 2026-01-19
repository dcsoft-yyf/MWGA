using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MWGAWinFormDemo
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
           
            //var ms = typeof(Program).Assembly.GetManifestResourceStream("MWGAWinFormDemo.dlgMessage.resources");
            //var r2 = new System.ComponentModel.ComponentResourceManager(typeof(dlgMessage));
            //var rs = r2.GetResourceSet(System.Globalization.CultureInfo.CurrentCulture, true, true);
            //var e2 = rs.GetEnumerator();
            //while( e2.MoveNext ())
            //{
            //    Console.WriteLine(e2.Key + "=" + e2.Value);
            //}
            //return;
            //Main2();return;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Minesweeper.frmMinesweeper());
            Application.Run(new CalculatorForm());
        }

        static void Main2()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var frm = new Form();
            frm.Size = new System.Drawing.Size(400, 400);
            frm.StartPosition = FormStartPosition.CenterScreen;
            var btn = new Button();
            btn.Text = "button";
            btn.Click += delegate (object sender2, EventArgs args2)
                {
                    var dlg = new dlgMessage();
                    dlg.InputMessageText = "This is some message!!" + DateTime.Now.ToString();
                    var result = dlg.ShowDialog();
                    frm.Text ="Dialog result =" + result.ToString();
                };
            frm.Controls.Add(btn);
            Application.Run(frm);
        }
    }
}
