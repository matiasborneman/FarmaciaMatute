using Farmacia_Matute.Clases;
using Farmacia_Matute.Negocios;
using Farmacia_Matute.Negocios.EstructurasNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmacia_Matute.Capa_Presemtacion_Formularios.Clientes
{
    public partial class Frm_datos_clientes : Form
    {

        Ng_Empleados_Pacientes pac = new Ng_Empleados_Pacientes();
        Ng_TiposDoc tipo = new Ng_TiposDoc();
        Ng_Perfiles perfil = new Ng_Perfiles();
        TratamientosEspeciales tramiento = new TratamientosEspeciales();
        Ng_Barrios barrio = new Ng_Barrios();
        Ng_Localidades localida = new Ng_Localidades();
        Ng_ObrasSociales obrasocial = new Ng_ObrasSociales();
        Be_BaseDatos _Bd = new Be_BaseDatos();
        Es_Paciente ee = new Es_Paciente();
        public Frm_datos_clientes()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btn_editar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea Modificar el Cliente?", "MODIFICAR CLIENTE!", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
                if (tramiento.validar(this.Controls)
                        == TratamientosEspeciales.Validacion.correcta)
                {
                    ee.apellido = txt_apellido.Text;
                    ee.nombre = txt_nombre.Text;
                    ee.nro_doc = txt_nrodoc.Text;
                    ee.id_tipo_doc = cmb_tipo_doc.SelectedValue.ToString();
                    ee.id_barrio = cmb_barrio.SelectedValue.ToString();
                    ee.id_ob_social = cmb_obra_social.SelectedValue.ToString();
                    ee.id_rol = "6";
                    ee.fecha_nac = lblt_fecha.Text;
                    ee.calle_nro = txt_nro_calle.Text;
                    ee.calle = txt_calle.Text;

                    pac.Modificar(ee);
                    BorrarCampos();
                }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {

            if (txt_nrodoc.Text != "")
            {
                AnalizaDatos(pac.buscar_Empleado_Paciente(cmb_tipo_doc.SelectedValue.ToString(), txt_nrodoc.Text, true));
            }
            else
                MessageBox.Show("No cargo el numero de documento");
        }
        private void AnalizaDatos(DataTable tabla)
        {
            if (tabla.Rows.Count == 1)
            {
                AsignarDatos(tabla);
                string sql = "SELECT * FROM Obra_Social WHERE id_ob_soc= " + int.Parse(tabla.Rows[0]["Id_Ob_Soc"].ToString());
                DataTable consulta = _Bd.Consulta(sql);
                txt_tipo_cobertura.Text = obrasocial.recuperarTipoCobertura(consulta.Rows[0]["id_cobertura"].ToString());
                sql = "SELECT * FROM Barrios WHERE Id= " + int.Parse(tabla.Rows[0]["Id_Barrio"].ToString());
                consulta = _Bd.Consulta(sql);
                cmb_localidad.SelectedValue = int.Parse(barrio.recuperarlocalidad(consulta.Rows[0]["Id_Localidad"].ToString()));
                cmb_barrio.SelectedValue = consulta.Rows[0]["Id"].ToString();
            }
            else
            {
                MessageBox.Show("No se encontró el Cliente");
            }
        }
        private void AsignarDatos(DataTable tabla)
        {
            txt_apellido.Text = tabla.Rows[0]["Apellido"].ToString();
            txt_nombre.Text = tabla.Rows[0]["Nombre"].ToString();
            txt_calle.Text = tabla.Rows[0]["Calle"].ToString();
            txt_nro_calle.Text = tabla.Rows[0]["Calle_Nro"].ToString();
            cmb_obra_social.SelectedValue = int.Parse(tabla.Rows[0]["Id_Ob_Soc"].ToString());
            DateTime fecha = DateTime.Parse(tabla.Rows[0]["Fecha_Nac"].ToString());
            lblt_fecha.Text = fecha.ToString("ddMMyyyy");
        }

        public void BorrarCampos()
        {

            txt_apellido.Text = "";
            txt_nombre.Text = "";
            txt_nrodoc.Text = "";
            txt_calle.Text = "";
            txt_nro_calle.Text = "";
            txt_tipo_cobertura.Text = "";
            cmb_tipo_doc.SelectedValue = 1;
            cmb_obra_social.SelectedValue = 1;
            cmb_barrio.SelectedValue = 1;
            cmb_localidad.SelectedValue = 1;
            lblt_fecha.Text = "";
        }

        private void btn_grabar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea Grabar el nuevo Cliente?", "GRABAR CLIENTE!", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
                if (tramiento.validar(this.Controls)
                        == TratamientosEspeciales.Validacion.correcta)
                {
                    ee.apellido = txt_apellido.Text;
                    ee.nombre = txt_nombre.Text;
                    ee.nro_doc = txt_nrodoc.Text;
                    ee.id_tipo_doc = cmb_tipo_doc.SelectedValue.ToString();
                    ee.id_barrio = cmb_barrio.SelectedValue.ToString();
                    ee.id_ob_social = cmb_obra_social.SelectedValue.ToString();
                    ee.id_rol = "6";
                    ee.fecha_nac = lblt_fecha.Text;
                    ee.calle_nro = txt_nro_calle.Text;
                    ee.calle = txt_calle.Text;
                    pac.Insertar(ee);
                    BorrarCampos();
                }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea Eliminar el Paciente?", "BORRAR EMPLEADO!", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                pac.BorrarCliente(cmb_tipo_doc.SelectedValue.ToString(), txt_nrodoc.Text);
                BorrarCampos();
            }
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            BorrarCampos();
        }

        private void cmb_obra_social_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txt_tipo_cobertura.Text = obrasocial.recuperarTipoCobertura(cmb_obra_social.SelectedValue.ToString());
        }

        private void Frm_datos_clientes_Load(object sender, EventArgs e)
        {

            cmb_tipo_doc.Cargar(tipo.EstrCombo());
            cmb_localidad.Cargar(localida.EstrCombo());
            cmb_obra_social.Cargar(obrasocial.EstrCombo());
            cmb_barrio.Cargar(barrio.EstrCombo(cmb_localidad.SelectedValue.ToString()));
        }

        private void cmb_localidad_SelectionChangeCommitted(object sender, EventArgs e)
        {
            String localidad = cmb_localidad.SelectedValue.ToString();
            cmb_barrio.Cargar(barrio.EstrCombo(localidad));
        }
    }
}
