using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Farmacia_Matute.Capa_Presemtacion_Formularios.Stock;
using Farmacia_Matute.Capa_Presentacion_Formularios.Compras;
using Farmacia_Matute.Capa_Presentacion_Formularios.Estadisticas;
using Farmacia_Matute.Capa_Presentacion_Formularios.Reportes;
using Farmacia_Matute.Formularios.Usuarios;

namespace Farmacia_Matute
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Frm_home());
        }
    }
}
