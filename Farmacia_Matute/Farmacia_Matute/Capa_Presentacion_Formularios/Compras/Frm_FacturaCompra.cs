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

namespace Farmacia_Matute.Capa_Presentacion_Formularios.Compras
{
    public partial class Frm_FacturaCompra : Form
    {
        Ng_Farmacias farmacia = new Ng_Farmacias();
        Ng_Medicamentos medicamentos = new Ng_Medicamentos();
        Ng_Laboratorios laboratorio = new Ng_Laboratorios();
        Ng_TiposDoc tipo = new Ng_TiposDoc();
        Ng_TiposFactura tipofac = new Ng_TiposFactura();
        Be_BaseDatos bd = new Be_BaseDatos();
        Ng_Empleados_Pacientes emp = new Ng_Empleados_Pacientes();
        Ng_FacturasCompras facturas = new Ng_FacturasCompras();

        public Frm_FacturaCompra()
        {
            InitializeComponent();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (txt_nrodoc.Text != "")
            {
                AnalizaDatos(emp.buscar_Empleado_Paciente(cmb_tipo_doc.SelectedValue.ToString(), txt_nrodoc.Text,false));
            }
            else
                MessageBox.Show("No cargo el numero de documento");

        }
        private void AnalizaDatos(DataTable tabla)
        {
            if (tabla.Rows.Count == 1)
            {
                AsignarDatos(tabla);
                
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
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            
            grid_detalle.Rows.Add();
            int ind = grid_detalle.Rows.Count - 1;
            grid_detalle.Rows[ind].Cells[0].Value = cmb_medicamentos.SelectedValue.ToString();
            grid_detalle.Rows[ind].Cells[1].Value = cmb_medicamentos.Text;
            grid_detalle.Rows[ind].Cells[2].Value = txt_cantidadmedicamentos.Text;
            grid_detalle.Rows[ind].Cells[3].Value = medicamentos.RetornarPrecio(cmb_medicamentos.SelectedValue.ToString());
            txt_total.Text = CalcularTotal().ToString();
        }

        private void Frm_FacturaCompra_Load(object sender, EventArgs e)
        {
            cmb_tipo_doc.Cargar(tipo.EstrCombo());
            cmb_farmacia.Cargar(farmacia.EstrCombo());
            cmb_laboratorio.Cargar(laboratorio.EstrCombo());
            cmb_tipo_factura.Cargar(tipofac.EstrCombo());
            grid_detalle.Formatear("id,30;Medicamento,170;Cantidad,70;Precio,70");
            lblt_fecha.Pp_Text = bd.Fecha();
            txt_nrofac.Text = (int.Parse(facturas.RecuperarNroFactura())+1).ToString();

        }

        private void cmb_farmacia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txt_cuitfarmacia.Text = cmb_farmacia.SelectedValue.ToString();
        }

        private void cmb_laboratorio_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txt_cuitlaboratorio.Text = cmb_laboratorio.SelectedValue.ToString();
            cmb_medicamentos.Cargar(medicamentos.EstrCombo(cmb_laboratorio.SelectedValue.ToString()));
        }
        private double CalcularTotal()
        {
            double Total = 0;
            for (int i = 0; i < grid_detalle.Rows.Count; i++)
            {
                Total += Convert.ToDouble(grid_detalle.Rows[i].Cells[2].Value.ToString()) *
                         Convert.ToDouble(grid_detalle.Rows[i].Cells[3].Value.ToString());
            }
            return Total;
        }

        private void btn_grabar_Click(object sender, EventArgs e)
        {
            if (grid_detalle.Rows.Count == 0)
            {
                MessageBox.Show("Falta cargar los Medicamentos", "Importante"
                                , MessageBoxButtons.OK
                                , MessageBoxIcon.Question);
                grid_detalle.Focus();
                return;
            }
            if (facturas.VerificarFacturacion(txt_nrofac.Text,txt_cuitfarmacia.Text,cmb_tipo_factura.SelectedValue.ToString()) == Ng_FacturasCompras.Facturacion.no_existe)
            {
                facturas.insertar(txt_cuitfarmacia.Text, txt_cuitlaboratorio.Text, cmb_tipo_factura.SelectedValue.ToString(),
                    txt_nrofac.Text, cmb_tipo_doc.SelectedValue.ToString(), txt_nrodoc.Text, grid_detalle, lblt_fecha.Pp_Text.ToString());
            }
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            txt_apellido.Text = "";
            txt_nombre.Text = "";
            txt_nrodoc.Text = "";
            txt_cuitfarmacia.Text = "";
            txt_cuitlaboratorio.Text = "";
            txt_cantidadmedicamentos.Text = "";
            txt_nrofac.Text = (int.Parse(facturas.RecuperarNroFactura()) + 1).ToString();
            grid_detalle.Rows.Clear();
        }

        private void grid_detalle_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Esta seguro de borrar la fila", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                grid_detalle.Rows.Remove(grid_detalle.CurrentRow);
            }
        }
    }
}
