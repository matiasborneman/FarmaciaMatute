
using Farmacia_Matute.Clases;
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

namespace Farmacia_Matute.Capa_Presemtacion_Formularios.Medicamentos
{
    public partial class Frm_medicamentos : Form
    {

        Ng_Medicamentos medicamentos = new Ng_Medicamentos();
        Ng_Laboratorios laboratorio = new Ng_Laboratorios();
        Be_BaseDatos bd = new Be_BaseDatos();
        DataTable tabla = new DataTable();
        TratamientosEspeciales te = new TratamientosEspeciales();
        int CUIT_LAB = 0;
        public Frm_medicamentos()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_medicamentos_Load(object sender, EventArgs e)
        {
            cmb_laboratorio.Cargar(laboratorio.EstrCombo());
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (txt_idmedicamento.Text != "" || txt_nombre_medicamento.Text != "")
            {

                tabla = medicamentos.BuscarMedicamento(txt_idmedicamento.Text);

                if (tabla.Rows.Count == 1)
                {
                    asignarDatos(tabla);
                }
                else
                    MessageBox.Show("No se encontro el medicamento");
            }
            else
                MessageBox.Show("No ingreso el id de medicamento o el nombre ");
        }
            private void asignarDatos(DataTable tabla)
            {
                txt_idmedicamento.Text = tabla.Rows[0]["Id_Medicamento"].ToString();
                txt_nombre_medicamento.Text = tabla.Rows[0]["Nombre"].ToString();
                txt_precio_lista.Text = tabla.Rows[0]["Precio_Lista"].ToString(); 
                DateTime fecha = DateTime.Parse(tabla.Rows[0]["Fecha_Alta"].ToString());
                lblt_fecha.Text = fecha.ToString("ddMMyyyy");
                string sql = "SELECT * FROM Laboratorios WHERE CUIT_Laboratorio= " + int.Parse(tabla.Rows[0]["CUIT_Laboratorio"].ToString());
                DataTable consulta = bd.Consulta(sql);
                cmb_laboratorio.SelectedValue = int.Parse(consulta.Rows[0]["CUIT_Laboratorio"].ToString());
                txt_cuit_laboratorio.Text = consulta.Rows[0]["CUIT_Laboratorio"].ToString();
            }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea Eliminar el Medicamento?", "BORRAR MEDICAMENTO!", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                medicamentos.Borrar(txt_cuit_laboratorio.Text,txt_idmedicamento.Text);
                BorrarCampos();
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (te.ValidarFecha(lblt_fecha.Text) == TratamientosEspeciales.Validacion.correcta && txt_idmedicamento.Text!="" && txt_nombre_medicamento.Text!="" && txt_precio_lista.Text!="")
            {
                DialogResult result = MessageBox.Show("Desea Modificar el medicamento?", "MODIFICAR MEDICAMENTO!", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    medicamentos.Modificar(cmb_laboratorio.SelectedValue.ToString(), txt_idmedicamento.Text, txt_nombre_medicamento.Text, txt_precio_lista.Text, lblt_fecha.Text);
                }
            }
            else
                MessageBox.Show("Los datos ingresados son incorrectos!");
            BorrarCampos();
        }
        public void BorrarCampos()
        {
            txt_precio_lista.Text = "";
            txt_nombre_medicamento.Text = "";
            txt_idmedicamento.Text = "";
            lblt_fecha.Text = "";
            cmb_laboratorio.SelectedIndex = -1;
            txt_cuit_laboratorio.Text = "";
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            BorrarCampos();
            txt_idmedicamento.Text = (medicamentos.RecuperarID()+ 1).ToString();
        }

        private void btn_grabar_Click(object sender, EventArgs e)
        {
            if (txt_cuit_laboratorio.Text != "" && txt_idmedicamento.Text != "" && txt_nombre_medicamento.Text != "" && txt_precio_lista.Text != "" && te.ValidarFecha(lblt_fecha.Text) == TratamientosEspeciales.Validacion.correcta)
            {
                medicamentos.Insertar(txt_cuit_laboratorio.Text, txt_idmedicamento.Text, txt_nombre_medicamento.Text, txt_precio_lista.Text, lblt_fecha.Text);
            }
            else MessageBox.Show("No ingreso los datos correctos!");
            BorrarCampos();
        }

        private void cmb_laboratorio_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txt_cuit_laboratorio.Text = cmb_laboratorio.SelectedValue.ToString();
        }
    }  
}
