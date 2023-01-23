using Farmacia_Matute.Clases;
using Farmacia_Matute.Negocios;
using Farmacia_Matute.Negocios.EstructurasNegocios;
using System;
using System.Data;
using System.Windows.Forms;

namespace Farmacia_Matute.Capa_Presentacion_Formularios.Empleados
{
    public partial class Frm_usuario : Form
    {
        string usuario = "";
        Ng_Users us = new Ng_Users();
        Ng_Empleados_Pacientes emp = new Ng_Empleados_Pacientes();
        Ng_TiposDoc tipo = new Ng_TiposDoc();
        Ng_Perfiles perfil = new Ng_Perfiles();
        TratamientosEspeciales tramiento = new TratamientosEspeciales();
        Es_Users eu = new Es_Users();
        DataTable tabla = new DataTable();
        public Frm_usuario()
        {
            InitializeComponent();
        }

        private void Frm_usuario_Load(object sender, EventArgs e)
        {
            cmb_perfil.Cargar(perfil.EstrCombo());
            cmb_tipo_doc.Cargar(tipo.EstrCombo());
        }
        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void AnalizaDatos(DataTable tabla)
        {
            if (tabla.Rows.Count == 1)
            {
                AsignarDatos(tabla);
                usuario = tabla.Rows[0]["Id_User"].ToString();
                cmb_perfil.SelectedValue = tabla.Rows[0]["Id_Rol"].ToString();
                if (usuario == "")
                {
                    MessageBox.Show("El  Empleado no tiene usuario creado");
                    txt_usuario.Focus();
                }
                
            }
            else
            {
                MessageBox.Show("No se encontró el Empleado");
            }
        }
        private void AsignarDatos(DataTable tabla)
        {
            txt_apellido.Text = tabla.Rows[0]["Apellido"].ToString();
            txt_nombre.Text = tabla.Rows[0]["Nombre"].ToString();
            if (tabla.Rows[0]["Id_User"].ToString() != null)
                txt_usuario.Text = tabla.Rows[0]["Id_User"].ToString();

        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            BorrarCampos();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (txt_nro_doc.Text != "")
            {
                 AnalizaDatos(emp.buscar_Empleado_Paciente(cmb_tipo_doc.SelectedValue.ToString(), txt_nro_doc.Text,false));
            }
            else
                MessageBox.Show("No cargo el numero de documento");
            
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Desea Eliminar el usuario?", "BORRAR USUARIO!", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                emp.BorrarUsuario(cmb_tipo_doc.SelectedValue.ToString(), txt_nro_doc.Text);
                us.Borrar(txt_usuario.Text);
                BorrarCampos();
            }

            
        }

        private void btn_grabar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea Grabar el nuevo usuario?", "GRABAR USUARIO!", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
                if (tramiento.validar(this.Controls)
                        == TratamientosEspeciales.Validacion.correcta)
                {
                    eu.id_usuario = txt_usuario.Text;
                    eu.password = txt_password.Text;
                    eu.id_perfil = cmb_perfil.SelectedValue.ToString();
                    us.Insertar(eu);
                    emp.ModificarUsuario(cmb_tipo_doc.SelectedValue.ToString(), txt_nro_doc.Text, txt_usuario.Text);
                    BorrarCampos();
                }
        }
        public void BorrarCampos()
        {
            txt_apellido.Text = "";
            txt_nombre.Text = "";
            txt_nro_doc.Text = "";
            txt_usuario.Text = "";
            txt_password.Text = "";
            cmb_perfil.SelectedValue = 1;
            cmb_tipo_doc.SelectedValue = 1;
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea Modificar el usuario?", "MODIFICAR USUARIO!", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
                if (tramiento.validar(this.Controls)
                        == TratamientosEspeciales.Validacion.correcta)
                {
                    eu.id_usuario = txt_usuario.Text;
                    eu.password = txt_password.Text;
                    eu.id_perfil = cmb_perfil.SelectedValue.ToString();

                    tabla = emp.RecuperarUsuario(cmb_tipo_doc.SelectedValue.ToString(), txt_nro_doc.Text);
                    usuario = tabla.Rows[0]["Id_User"].ToString();
                    us.Modificar(eu,usuario);
                    emp.ModificarUsuario(cmb_tipo_doc.SelectedValue.ToString(), txt_nro_doc.Text, txt_usuario.Text);
                    BorrarCampos();
                }
        }
    }
        
}
