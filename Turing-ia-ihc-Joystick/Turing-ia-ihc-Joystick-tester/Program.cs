using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Turing_ia_ihc_Joystick_tester
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Thread thr = new Thread(frmServer);
            thr.Start();
            Application.Run(new Client());
        }

        static void frmServer()
        {
            Server s = new Server();
            s.ShowDialog();
        }
    }
}
