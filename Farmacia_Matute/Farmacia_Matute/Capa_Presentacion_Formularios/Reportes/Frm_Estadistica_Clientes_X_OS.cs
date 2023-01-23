using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Farmacia_Matute.Clases;
using Farmacia_Matute.Negocios;
using Farmacia_Matute.Negocios.EstructurasNegocios;
using Microsoft.Reporting.WinForms;
//
namespace Farmacia_Matute.Capa_Presentacion_Formularios.Reportes
{
    public partial class Frm_Estadistica_Clientes_X_OS : Form
    {
        Ng_Empleados_Pacientes Client = new Ng_Empleados_Pacientes();
        Ng_ObrasSociales os = new Ng_ObrasSociales();
        DataTable Tabla = new DataTable();
        
        public Frm_Estadistica_Clientes_X_OS()
        {
            InitializeComponent();
        }

        private void Frm_Estadistica_Clientes_X_OS_Load(object sender, EventArgs e)
        {
            Cmb_OS.Cargar();
            Cmb_OS.SelectedIndex = -1;
            //this.rv_simple.RefreshReport();
            //this.rv_simple.RefreshReport();
        }
        private void Btn_Salir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_limpiar_Click_1(object sender, EventArgs e)
        {
            Cmb_OS.Cargar();
            Cmb_OS.SelectedIndex = -1;
        }
        private void Btn_Buscar_Click_1(object sender, EventArgs e)
        {
            if (Rad_btn_por_OS.Checked == true)
            {
                if (Cmb_OS.SelectedIndex == -1)
                {
                    MessageBox.Show("El campo Obra Social está vacio. Debe Completar el campo, para realizar la búsqueda.-");
                    Cmb_OS.Focus();
                    return;
                }
                else
                {
                    string varcombo2 = "0";
                    if (Cmb_OS.SelectedIndex != -1)
                    {
                        varcombo2 = Cmb_OS.SelectedValue.ToString();
                        Tabla = os.Buscar_Est_Cli_por_ObSoc(varcombo2);
                        ArmarReporte();
                    }

                }

            }
            if (Rad_btn_Todas_OS.Checked == true)
            {
                Tabla = os.Buscar_Est_Cli_OS();
                ArmarReporte();
            }

            

        }

        
        private void ArmarReporte()
        {
            ReportDataSource Datos = new ReportDataSource("DataSet1", Tabla);

            //// Se asigna el nombre y ubicación del reporte que se desea mostrar en el ReportViewer
            rv_simple.LocalReport.ReportEmbeddedResource = "Farmacia_Matute.Capa_Presentacion_Formularios.Reportes.Reporte_Estad_Client_x_OS.rdlc";
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

