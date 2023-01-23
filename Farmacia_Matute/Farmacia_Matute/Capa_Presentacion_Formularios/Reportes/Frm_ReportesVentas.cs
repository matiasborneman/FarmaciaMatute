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

namespace Farmacia_Matute.Capa_Presentacion_Formularios.Reportes
{
    
    public partial class Frm_ReportesVentas : Form
    {
        Ng_TiposDoc tipo = new Ng_TiposDoc();
        Ng_TiposFactura tipofac = new Ng_TiposFactura();
        DataTable Tabla = new DataTable();
        TratamientosEspeciales Te = new TratamientosEspeciales();
        Ng_FacturasVentas factura = new Ng_FacturasVentas();
        Be_BaseDatos _Bd = new Be_BaseDatos();
        string restriccion = "";
        public Frm_ReportesVentas()
        {
            InitializeComponent();
        }

        private void Frm_ReportesVentas_Load(object sender, EventArgs e)
        {
            cmb_tipo_doc.Cargar(tipo.EstrCombo());
            cmb_tipo_factura.Cargar(tipofac.EstrCombo());
            cmb_tipo_doc_pac.Cargar(tipo.EstrCombo());
        }
        private void BuscarFacturas()
        {
            if (rb_Empleado.Checked == false && rb_Factura.Checked == false && rb_Fecha.Checked == false && rb_Cliente.Checked==false && rb_Periodo.Checked==false)
            {
                MessageBox.Show("No Seleciono ninguna opcion");
                return;
            }
            if (rb_Fecha.Checked == true)
            {
                if (Te.ValidarFecha(lblt_fecha.Pp_Text) == TratamientosEspeciales.Validacion.correcta)
                {
                    Tabla = factura.BuscarFacturasVentas("", "", "", "", "", "", lblt_fecha.Pp_Text,"");
                    restriccion = "Fecha Facturación: " + lblt_fecha.Pp_Text;
                    return;
                }
            }
            if (rb_Periodo.Checked == true)
            {
                if (Te.ValidarFecha(lblt_fecha.Pp_Text) == TratamientosEspeciales.Validacion.correcta)
                {
                    Tabla = factura.BuscarFacturasVentas("", "", "", "", "", "", "",lblt_fecha.Pp_Text);
                    restriccion = "El Periodo de Facturación: " + lblt_fecha.Pp_Text.Substring(3,7);
                    return;
                }

            }
            if (rb_Empleado.Checked == true)
            {
                if (txt_nrodoc.Text != "")
                {
                    if (factura.VerificarFacturacionXEmpleado(cmb_tipo_doc.SelectedValue.ToString(), txt_nrodoc.Text) == Ng_FacturasVentas.Facturacion.existe)
                    {
                        Tabla = factura.BuscarFacturasVentas("", "", cmb_tipo_doc.SelectedValue.ToString(), txt_nrodoc.Text,"","","", "");
                        restriccion = "Doc. Empleado: " + txt_nrodoc.Text;
                        return;
                    }
                    else
                        MessageBox.Show("EL Empleado no tiene facturacion");
                }
                else
                    MessageBox.Show("No cargo los datos del Empleado");
            }
            if (rb_Cliente.Checked == true)
            {
                if (txt_nro_doc_pac.Text != "")
                {
                    if (factura.VerificarFacturacionXPaciente(cmb_tipo_doc_pac.SelectedValue.ToString(),txt_nro_doc_pac.Text) == Ng_FacturasVentas.Facturacion.existe)
                    {
                        Tabla = factura.BuscarFacturasVentas("", "", "","",cmb_tipo_doc_pac.SelectedValue.ToString(), txt_nro_doc_pac.Text,"", "");
                        restriccion = "Doc. Cliente: " + txt_nro_doc_pac.Text;
                        return;
                    }
                    else
                        MessageBox.Show("EL Cliente no tiene facturacion");
                }
                else
                    MessageBox.Show("No cargo los datos del Empleado");
            }
            if (rb_Factura.Checked == true)
            {
                if (txt_nrofac.Text != "")
                {
                    if (factura.VerificarFacturacion(txt_nrofac.Text, cmb_tipo_factura.SelectedValue.ToString()) == Ng_FacturasVentas.Facturacion.existe)
                    {
                        Tabla = factura.BuscarFacturasVentas(cmb_tipo_factura.SelectedValue.ToString(), txt_nrofac.Text,"","","", "","", "");
                        restriccion = "Factura Nro: " + txt_nrofac.Text;
                        return;
                    }
                    else
                        MessageBox.Show("No Existe la Factura!");
                }
                else
                    MessageBox.Show("No se cargo la Factura");
            }

            if (Tabla.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron facturas Para los datos Cargados");
            }
        }
        private void ArmarReporte()
        {
            ReportDataSource Datos = new ReportDataSource("DataSet1", Tabla);
            //// Se asigna el nombre y ubicación del reporte que se desea mostrar en el ReportViewer
            rv_simple.LocalReport.ReportEmbeddedResource = "Farmacia_Matute.Capa_Presentacion_Formularios.Reportes.ReporteVentas.rdlc";
            ReportParameter[] parametros = new ReportParameter[2];
            // se asigan el parametro al objeto parametros
            parametros[0] = new ReportParameter("RP01", "Restringido por " + restriccion);
            parametros[1] = new ReportParameter("RP02", _Bd.FechaHora());
            // se le comunica al reporte local dentro del ReportViewer el SetParameters
            rv_simple.LocalReport.SetParameters(parametros);
            // esto es necesario en caso de emitir varias veces el mismo reporte
            rv_simple.LocalReport.DataSources.Clear();
            // se asigna el recurso de datos al reporte local con información del ultimo calculo
            rv_simple.LocalReport.DataSources.Add(Datos);
            rv_simple.RefreshReport();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            BuscarFacturas();
            LimpiarTextos();
            ArmarReporte();
        }
        private void LimpiarTextos()
        {
            txt_nrodoc.Text = "";
            txt_nrofac.Text = "";
            txt_nro_doc_pac.Text = "";
            lblt_fecha.Pp_Text = "";

        }
    }
}
