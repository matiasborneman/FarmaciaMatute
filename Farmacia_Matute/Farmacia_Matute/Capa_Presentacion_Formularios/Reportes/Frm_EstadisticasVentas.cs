using Farmacia_Matute.Clases;
using Farmacia_Matute.Negocios;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmacia_Matute.Capa_Presentacion_Formularios.Estadisticas
{
    public partial class Frm_EstadisticasVentas : Form
    {

        Ng_TiposDoc tipo = new Ng_TiposDoc();
        Ng_FacturasVentas ventas = new Ng_FacturasVentas();
        DataTable Tabla = new DataTable();
        TratamientosEspeciales Te = new TratamientosEspeciales();
        Be_BaseDatos _BD = new Be_BaseDatos();
        string restriccion = "";
        public Frm_EstadisticasVentas()
        {
            InitializeComponent();
        }
        private void ArmarReporte()
        {
            ReportDataSource datos = new ReportDataSource("DataSet2", Tabla);
            rv_simple.LocalReport.ReportEmbeddedResource = "Farmacia_Matute.Capa_Presentacion_Formularios.Reportes.Reporte_Estadisticas_Ventas1.rdlc";
            ReportParameter[] para = new ReportParameter[2];
            para[0] = new ReportParameter("RP01", "Análisis Estadístico Por " + restriccion);
            para[1] = new ReportParameter("RP02", _BD.FechaHora());
            rv_simple.LocalReport.SetParameters(para);
            rv_simple.LocalReport.DataSources.Clear();
            rv_simple.LocalReport.DataSources.Add(datos);
            rv_simple.RefreshReport();
        }
        public void CrearTablaEstadisticas()
        {

            if (rb_Empleado.Checked == false && rb_Fecha.Checked == false && rb_Periodo.Checked == false && rb_PorMedicamentos.Checked == false && rb_PorLaboratorio.Checked == false)
            {
                MessageBox.Show("No Seleciono ninguna opcion");
                return;
            }
            if (rb_PorLaboratorio.Checked == true)
            {
                if (rb_Fecha.Checked == true)
                {
                    if (Te.ValidarFecha(lblt_fecha.Pp_Text) == TratamientosEspeciales.Validacion.correcta)
                    {
                        Tabla = ventas.CalculoEstadisticoPorLaboratorio("", "", lblt_fecha.Pp_Text, "");
                        restriccion = "Fecha Facturación: " + lblt_fecha.Pp_Text;
                        return;
                    }
                    else
                        MessageBox.Show("No ingreso Fecha valida");
                }
                if (rb_Periodo.Checked == true)
                {
                    if (Te.ValidarFecha(lblt_fecha.Pp_Text) == TratamientosEspeciales.Validacion.correcta)
                    {
                        Tabla = ventas.CalculoEstadisticoPorLaboratorio(cmb_tipo_doc.SelectedValue.ToString(), txt_nrodoc.Text, "", lblt_fecha.Pp_Text);

                        restriccion = "El Periodo de Facturaión: " + lblt_fecha.Pp_Text.Substring(3, 7);
                        return;
                    }
                    else
                        MessageBox.Show("No ingreso Fecha valida");

                }
                if (rb_Empleado.Checked == true)
                {
                    if (txt_nrodoc.Text != "")
                    {
                        if (ventas.VerificarFacturacionXEmpleado(cmb_tipo_doc.SelectedValue.ToString(), txt_nrodoc.Text) == Ng_FacturasVentas.Facturacion.existe)
                        {
                            Tabla = ventas.CalculoEstadisticoPorLaboratorio(cmb_tipo_doc.SelectedValue.ToString(), txt_nrodoc.Text, "", "");
                            restriccion = "Doc. Empleado: " + txt_nrodoc.Text;
                            return;
                        }
                        else
                            MessageBox.Show("EL Empleado no tiene facturacion");
                    }
                    else
                        MessageBox.Show("No cargo los datos del Empleado");
                }
            }
            if (rb_PorMedicamentos.Checked == true)
            {
                if (rb_Empleado.Checked == false && rb_Fecha.Checked == false && rb_Periodo.Checked == false)
                {
                    MessageBox.Show("No Seleciono ninguna opcion");
                    return;
                }
                if (rb_Fecha.Checked == true)
                {
                    if (Te.ValidarFecha(lblt_fecha.Pp_Text) == TratamientosEspeciales.Validacion.correcta)
                    {
                        Tabla = ventas.CalculoEstadisticoPorMedicamento("", "", lblt_fecha.Pp_Text, "");
                        restriccion = "Fecha Facturación: " + lblt_fecha.Pp_Text;
                        return;
                    }
                    else
                        MessageBox.Show("No ingreso Fecha valida");
                }
                if (rb_Periodo.Checked == true)
                {
                    if (Te.ValidarFecha(lblt_fecha.Pp_Text) == TratamientosEspeciales.Validacion.correcta)
                    {
                        Tabla = ventas.CalculoEstadisticoPorMedicamento(cmb_tipo_doc.SelectedValue.ToString(), txt_nrodoc.Text, "", lblt_fecha.Pp_Text);

                        restriccion = "El Periodo de Facturación: " + lblt_fecha.Pp_Text.Substring(3, 7);
                        return;
                    }
                    else
                        MessageBox.Show("No ingreso Fecha valida");

                }
                if (rb_Empleado.Checked == true)
                {
                    if (txt_nrodoc.Text != "")
                    {
                        if (ventas.VerificarFacturacionXEmpleado(cmb_tipo_doc.SelectedValue.ToString(), txt_nrodoc.Text) == Ng_FacturasVentas.Facturacion.existe)
                        {
                            Tabla = ventas.CalculoEstadisticoPorMedicamento(cmb_tipo_doc.SelectedValue.ToString(), txt_nrodoc.Text, "", "");
                            restriccion = "Doc. Empleado: " + txt_nrodoc.Text;
                            return;
                        }
                        else
                            MessageBox.Show("EL Empleado no tiene facturacion");
                    }
                    else
                        MessageBox.Show("No cargo los datos del Empleado");
                }
                if(Tabla.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron facturas Para los datos Cargados");
                }
            }
        }
        private void LimpiarTextos()
        {
            txt_nrodoc.Text = "";
            lblt_fecha.Pp_Text = "";

        }

        private void Frm_EstadisticasVentas_Load(object sender, EventArgs e)
        {
            cmb_tipo_doc.Cargar(tipo.EstrCombo());
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            CrearTablaEstadisticas();
            ArmarReporte();
            LimpiarTextos();
        }
    }
}
