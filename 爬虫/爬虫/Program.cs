using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace 爬虫
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (DateTime.Now > new DateTime(2016, 4, 15))
            {
                MessageBox.Show("试用过期");
                return;
            }
            Application.Run(new Form1());
        }
    }
}
