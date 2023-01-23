using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Farmacia_Matute.Negocios;
using Microsoft.Reporting.WinForms;
using Farmacia_Matute.Negocios.EstructurasNegocios;


namespace Farmacia_Matute.Capa_Presentacion_Formularios.Reportes
{
    public partial class Frm_Reporte_Medic_Lab : Form
    {
        Ng_Medicamentos medicamentos = new Ng_Medicamentos();
        DataTable Tabla = new DataTable();
        public Frm_Reporte_Medic_Lab()
        {
            InitializeComponent();
        }

        private void Frm_Reporte_Medic_Lab_Load(object sender, EventArgs e)
        {
            Cmb_Lab.Cargar();
            Cmb_Lab.SelectedIndex = -1;

            //this.rv_simple.RefreshReport();
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            //medicamentos
            
            if (Rad_btn_medic.Checked == true)
            {
                if (txt_medic.Text == "")
                {
                    MessageBox.Show("El campo Medicamentos está vacio. Debe Completar el campo, para realizar la búsqueda.-");
                    txt_medic.Focus();
                    return;
                }
                else
                {
                    Tabla = medicamentos.Buscar_Medicamento(txt_medic.Text);
                    ArmarReporte();
                }
            }
            
            //laboratorios
            if (Rad_btn_Lab.Checked == true)
            {
                if (Cmb_Lab.SelectedIndex == -1)
                {
                    MessageBox.Show("El campo Laboratorios está vacio. Debe Completar el campo, para realizar la búsqueda.-");
                    txt_medic.Focus();
                    return;
                }
                else
                {
                    string varcombo2 = "0";
                    varcombo2 = Cmb_Lab.SelectedValue.ToString();
                    Tabla = medicamentos.Buscar_Lab(varcombo2);
                    ArmarReporte();
                    
                }
                
            }
           
            
        }
        private void ArmarReporte()
        {
            ReportDataSource Datos = new ReportDataSource("DataSet1", Tabla);

            //// Se asigna el nombre y ubicación del reporte que se desea mostrar en el ReportViewer
            rv_simple.LocalReport.ReportEmbeddedResource = "Farmacia_Matute.Capa_Presentacion_Formularios.Reportes.Reporte_Lab_Medic01.rdlc";
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

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_medic.Text = "";
            Cmb_Lab.SelectedIndex = - 1;
        }
    }

}

