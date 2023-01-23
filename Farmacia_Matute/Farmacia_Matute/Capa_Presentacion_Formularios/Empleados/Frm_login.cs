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

namespace Farmacia_Matute.Formularios.Usuarios
{
    public partial class Frm_login : Form
    {
        
        public bool Valido { set; get; }
        public string Usuario { set; get; }
        public string Clave { set; get; }
        public int Perfil { set; get; }
        public Frm_login()
        {
            InitializeComponent();
        }

        private void btn_ingresar_Click_1(object sender, EventArgs e)
        {

            if (this.txt_usuario.Text == "")
            {
                MessageBox.Show("No esta cargado el usuario", "IMPORTANTE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_usuario.Focus();
                return;
            }
            if (txt_password.Text == "")
            {
                MessageBox.Show("No esta cargado la Clave", "IMPORTANTE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_password.Focus();
                return;
            }
            Ng_Users usu = new Ng_Users();
            if (usu.Validar_usuario(txt_usuario.Text, txt_password.Text) == Ng_Users.Respuesta.validacion_correcta)
            {
                this.Usuario = txt_usuario.Text;
                this.Perfil = usu.Recuperar_Perfil(txt_usuario.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("Este usuario y clave no esta registrado en la base de datos"
                               , "IMPORTANTE", MessageBoxButtons.OK, MessageBoxIcon.Stop);


            }
        }
    }



}

