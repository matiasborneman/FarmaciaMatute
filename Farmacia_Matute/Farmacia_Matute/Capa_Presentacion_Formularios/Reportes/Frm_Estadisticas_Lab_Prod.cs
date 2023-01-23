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

namespace Farmacia_Matute.Capa_Presentacion_Formularios.Reportes
{
    public partial class Frm_Estad_Lab_Prod : Form
    {
        Ng_Empleados_Pacientes Client = new Ng_Empleados_Pacientes();
        Ng_Laboratorios Labo = new Ng_Laboratorios();
        DataTable Tabla = new DataTable();
        public Frm_Estad_Lab_Prod()
        {
            InitializeComponent();
        }


        private void Frm_Estad_Lab_Prod_Load(object sender, EventArgs e)
        {
            Cmb_Lab.Cargar();
            Cmb_Lab.SelectedIndex = -1;

            //this.reportViewer1.RefreshReport();
        }
        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            Cmb_Lab.SelectedIndex = -1;
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            if (Rad_btn_por_Lab.Checked == true)
            {
                if (Cmb_Lab.SelectedIndex == -1)
                {
                    MessageBox.Show("El campo Laboratorio está vacio. Debe Completar el campo, para realizar la búsqueda.-");
                    Cmb_Lab.Focus();
                    return;
                }
                else
                {
                    string varcombo2 = "0";
                    if (Cmb_Lab.SelectedIndex != -1)
                    {
                        varcombo2 = Cmb_Lab.SelectedValue.ToString();
                        Tabla = Labo.Buscar_Est_X_Lab(varcombo2);
                        ArmarReporte();
                    }

                }

            }
            if (Rad_btn_Todos_Lab.Checked == true)
            {
                Tabla = Labo.Buscar_Est_todos_Lab();
                ArmarReporte();
            }



        }


        private void ArmarReporte()
        {
            ReportDataSource Datos = new ReportDataSource("DataSet1", Tabla);

            //// Se asigna el nombre y ubicación del reporte que se desea mostrar en el ReportViewer
            rv_simple.LocalReport.ReportEmbeddedResource = "Farmacia_Matute.Capa_Presentacion_Formularios.Reportes.Reporte_Estadistica_Laoratorios_x_Productos.rdlc";
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

