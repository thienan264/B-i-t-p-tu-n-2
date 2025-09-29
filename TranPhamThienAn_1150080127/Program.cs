using _1150080127_TranPhamThienAn;
using ApDung1;
using ApDung2;
using ApDung3;
using ApDung4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Thuchanh2;
using ThucHanh3;

namespace TranPhamThienAn_1150080127
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new ThucHanh1());
            // Application.Run(new Apdung1());
            // Application.Run(new Apdung2());
            // Application.Run(new ThucHanh2());
            // Application.Run(new Apdung3());
            // Application.Run(new Thuchanh3());
               Application.Run(new Apdung4());


        }
    }
}
