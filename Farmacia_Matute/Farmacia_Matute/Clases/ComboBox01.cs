using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace Farmacia_Matute.Clases
{
    class ComboBox01 : ComboBox
    {
        public string Pp_Tabla { get; set; }
        public string Pp_Display { get; set; }
        public string Pp_Value { get; set; }
        public bool Pp_seleccionado { get; set; }

        public bool Pp_validable { get; set; }
        public string Pp_nombre_campo { get; set; }
        public string Pp_nombre_tabla { get; set; }
        public string Pp_mensajeError { get; set; }

        Be_BaseDatos _BD = new Be_BaseDatos();

        public void Cargar()
        {
            string sql = "SELECT * FROM " + Pp_Tabla;
            DisplayMember = Pp_Display;
            ValueMember = Pp_Value;
            DataSource = _BD.Consulta(sql);
        }
        public void Cargar(string nombre_tabla, string display, string value)
        {
            string sql = "SELECT * FROM " + nombre_tabla;
            DisplayMember = display;
            ValueMember = value;
            DataSource = _BD.Consulta(sql);
        }
        public void Cargar(DataTable tabla, string display, string value)
        {
            DisplayMember = display;
            ValueMember = value;
            DataSource = tabla;
        }
        public void Cargar(EstructuraComboBox ec)
        {
            DisplayMember = ec.Display;
            ValueMember = ec.Value;
            DataSource = ec.Tabla;
        }
    }

}
