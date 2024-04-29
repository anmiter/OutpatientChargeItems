using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OutpatientCharges2._0
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Communal.frm_LoginByPassword frm_LoginByPassword = new Communal.frm_LoginByPassword();
            frm_LoginByPassword.ShowDialog();
            Application.Run();
        }
    }
}
