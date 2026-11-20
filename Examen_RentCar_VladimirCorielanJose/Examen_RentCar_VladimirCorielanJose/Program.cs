using System;
using System.Windows.Forms;

namespace Examen_RentCar_VladimirCorielanJose
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmAlquiler());
        }
    }
}