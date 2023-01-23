
using Farmacia_Matute.Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmacia_Matute.Formularios.Farmacia
{
    public partial class frm_datos_farmacia : Form
    {
        Ng_Barrios barrio = new Ng_Barrios();
        Ng_Localidades localidad = new Ng_Localidades();
        public frm_datos_farmacia()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_datos_farmacia_Load(object sender, EventArgs e)
        {
            cmb_localidad.Cargar(localidad.EstrCombo());
            cmb_barrio.Cargar(barrio.EstrCombo(cmb_localidad.SelectedValue.ToString()));
            
        }

        private void cmb_localidad_SelectionChangeCommitted(object sender, EventArgs e)
        {
            String localidad = cmb_localidad.SelectedValue.ToString();
            cmb_barrio.Cargar(barrio.EstrCombo(localidad));
        }
    }
}
