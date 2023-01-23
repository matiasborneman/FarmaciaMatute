using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;



namespace Farmacia_Matute.Negocios.EstructurasNegocios
{
    class Es_Paciente
    {
        public string id_tipo_doc { get; set; }
        public string nro_doc { get; set; }
        public string apellido { get; set; }
        public string nombre { get; set; }
        public string id_rol { get; set; }
        public string fecha_nac { get; set; }
        public string id_ob_social { get; set; }
        public string calle { get; set; }
        public string calle_nro { get; set; }
        public string id_barrio { get; set; }
    }
}
