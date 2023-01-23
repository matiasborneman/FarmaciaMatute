using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Farmacia_Matute.Clases;
using Farmacia_Matute.Negocios;
using Farmacia_Matute.Negocios.EstructurasNegocios;
using Microsoft.Reporting.WinForms;


namespace Farmacia_Matute.Capa_Presentacion_Formularios.Reportes
{
    public partial class Frm_ReportesClientes : Form
    {
        Ng_Empleados_Pacientes Client = new Ng_Empleados_Pacientes();
        Ng_TiposDoc tipo = new Ng_TiposDoc();
        DataTable Tabla = new DataTable();
        

        TratamientosEspeciales Te = new TratamientosEspeciales();
        Be_BaseDatos _Bd = new Be_BaseDatos();


        //string restriccion = "";
        public Frm_ReportesClientes()
        {
            InitializeComponent();
        }

        private void Frm_ReportesClientes_Load(object sender, EventArgs e)
        {
            Cmb_Tipo_Doc.Cargar();
            Cmb_Tipo_Doc.SelectedIndex = -1;
            Cmb_Obra_Soc.Cargar();
            Cmb_Obra_Soc.SelectedIndex = -1;


            //this.rv_simple.RefreshReport();
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            Cmb_Tipo_Doc.SelectedIndex = -1;
            txt_Nro_Doc.Text = "";
            Cmb_Obra_Soc.SelectedIndex = -1;
            

        }

        public void Btn_Buscar_Click(object sender, EventArgs e)
        {
            if (Rad_btn_Tipo_Nro_Doc.Checked == true)
            {
                if (Cmb_Tipo_Doc.SelectedIndex == -1)
                {
                    MessageBox.Show("El campo Tipo de documento está vacio. Debe Completar el campo, para realizar la búsqueda.-");
                    Cmb_Tipo_Doc.Focus();
                    return;
                }
                else
                {
                    if (txt_Nro_Doc.Text == "")
                    {
                        MessageBox.Show("El campo Nro. de documento está vacio. Debe Completar el campo, para realizar la búsqueda.-");
                        txt_Nro_Doc.Focus();
                        return;
                    }
                    
                    string varcombo = "0";
                    if (Cmb_Tipo_Doc.SelectedIndex != -1)
                        {
                            varcombo = Cmb_Tipo_Doc.SelectedValue.ToString();
                        Tabla = Client.Buscar_paciente_ob_soc( varcombo, txt_Nro_Doc.Text);
                            //DGV01.DataSource = Tabla;

                        }
                }
                 
            }

            if (Rad_btn_Ob_Soc.Checked == true)
            {
                if (Cmb_Obra_Soc.SelectedIndex == -1)
                {
                    MessageBox.Show("El campo Obra Social está vacio. Debe Completar el campo, para realizar la búsqueda.-");
                    Cmb_Obra_Soc.Focus();
                    return;
                }
                else
                {
                    string varcombo2 = "0";
                    if (Cmb_Obra_Soc.SelectedIndex != -1)
                    {
                        varcombo2 = Cmb_Obra_Soc.SelectedValue.ToString();
                        Tabla = Client.Buscar_ob_soc(varcombo2);
                        //DGV01.DataSource = Tabla;
                    }
                
                }

                
            }
            ArmarReporte();

        }
        private void ArmarReporte()
        {
            ReportDataSource Datos = new ReportDataSource("DataSet1", Tabla);

            //// Se asigna el nombre y ubicación del reporte que se desea mostrar en el ReportViewer
            rv_simple.LocalReport.ReportEmbeddedResource = "Farmacia_Matute.Capa_Presentacion_Formularios.Reportes.Reporte_Clientes_Ob_Soc_01.rdlc";
            //ReportParameter[] parametros = new ReportParameter[2];
            //***parametros[0] = new ReportParameter("RP01", "Restringido por " + restriccion);
            //***parametros[1] = new ReportParameter("RP02", _Bd.FechaHora());
            // se le comunica al reporte local dentro del ReportViewer el SetParameters
            //rv_simple.LocalReport.SetParameters(parametros);
            rv_simple.LocalReport.DataSources.Clear();
            // se asigna el recurso de datos al reporte local con información del ultimo calculo
            rv_simple.LocalReport.DataSources.Add(Datos);

            rv_simple.RefreshReport();
        }


    }
}
