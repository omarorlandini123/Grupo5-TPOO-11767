using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pruebaBD
{
    internal static class Program
    {
       
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Crear instancia de la clase Conexion
            Conexion conexion = new Conexion();

            // Probar la conexión
            conexion.TestConnection();

            Application.Run(new MenuPrincipal());

        }

    }
}
