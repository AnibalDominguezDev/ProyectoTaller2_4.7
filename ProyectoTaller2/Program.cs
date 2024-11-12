using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoTaller2.C_Presentacion.Administrador;
using ProyectoTaller2.C_Presentacion.Login;
using ProyectoTaller2.C_Presentacion.Supervisor;
using ProyectoTaller2.C_Presentacion.Vendedor;

namespace ProyectoTaller2
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormPrincipalAdmin());
            //Application.Run(new FormPrincipalSupervisor());
            //Application.Run(new MenuVendedor());
            //Application.Run(new Login());
        }
    }
}
