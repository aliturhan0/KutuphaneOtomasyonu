using Kitaplik2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kitaplik2
{
    internal static class Program
    {
        /// <summary>
        /// Uygulaman�n ana girdi noktas�.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Giri�Ekran�());
        }
    }
}
