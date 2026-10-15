using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Birth_Date_String
{
    // 程式主類別：包含應用程式的進入點
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// 程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
