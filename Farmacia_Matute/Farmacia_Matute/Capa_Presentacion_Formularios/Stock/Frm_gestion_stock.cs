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

namespace Farmacia_Matute.Capa_Presemtacion_Formularios.Stock
{
    public partial class Frm_gestion_stock : Form
    {

        Ng_Farmacias farmacia = new Ng_Farmacias();
        Ng_Medicamentos medicamentos = new Ng_Medicamentos();
        Ng_Laboratorios laboratorio = new Ng_Laboratorios();
        Be_BaseDatos bd = new Be_BaseDatos();
        Ng_ControlStock stock = new Ng_ControlStock();
        DataTable tabla = new DataTable();
        Ng_OrdenDePedido orden = new Ng_OrdenDePedido();
        public Frm_gestion_stock()
        {
            InitializeComponent();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            BorrarCampos();
        }

        private void Frm_gestion_stock_Load(object sender, EventArgs e)
        {
            cmb_farmacia.Cargar(farmacia.EstrCombo());
            cmb_laboratorio.Cargar(laboratorio.EstrCombo()); 
            cmb_farmaciaStock.Cargar(farmacia.EstrCombo());
            cmb_laboratorioStock.Cargar(laboratorio.EstrCombo());
            lblt_fecha.Pp_Text = bd.Fecha();
            grid_detalleOP.Formatear("Cuit Laboratorio,150;id,30;Medicamento,170;Cantidad,70");
            txt_NroPedido.Text = (int.Parse(orden.RecuperarNroOrden()) + 1).ToString();
        }

        private void cmb_farmaciaStock_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txt_Cuit_FarmaciaStock.Text = cmb_farmaciaStock.SelectedValue.ToString();
        }

        private void cmb_farmacia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txt_cuitfarmacia.Text = cmb_farmacia.SelectedValue.ToString();
        }

        private void cmb_laboratorio_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txt_cuitlaboratorio.Text = cmb_laboratorio.SelectedValue.ToString();
            cmb_medicamentos_op.Cargar(medicamentos.EstrCombo(cmb_laboratorio.SelectedValue.ToString()));
        }

        private void cmb_laboratorioStock_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txt_Cuit_LaboratorioStock.Text = cmb_laboratorioStock.SelectedValue.ToString();
            cmb_medicamento_stok.Cargar(medicamentos.EstrCombo(cmb_laboratorioStock.SelectedValue.ToString()));
        }

        private void btn_buscar_stock_Click(object sender, EventArgs e)
        {
            if (txt_Cuit_FarmaciaStock.Text != "" && txt_Cuit_LaboratorioStock.Text != "")
            {
                tabla = stock.BuscarMedicamento(txt_Cuit_FarmaciaStock.Text, txt_Cuit_LaboratorioStock.Text, cmb_medicamento_stok.SelectedValue.ToString());
                if (tabla.Rows.Count == 1)
                {
                    asignarDatosStock(tabla);
                }
                else
                    MessageBox.Show("No se encontro medicamento en stock");
            }
            else
                MessageBox.Show("No selecciono una farmacia o un laboratorio");

        }

        private void asignarDatosStock(DataTable tabla)
        {
            txtStock.Text = tabla.Rows[0]["Cant_en_Stock"].ToString();
            txt_StockMinimo.Text= tabla.Rows[0]["Can_min_Stock"].ToString();
            txt_StockMaximo.Text= tabla.Rows[0]["Cant_max_Stock"].ToString();
        }

        private void btn_agregarStock_Click(object sender, EventArgs e)
        {
            if (txt_Cuit_FarmaciaStock.Text != "" && txt_Cuit_LaboratorioStock.Text != "" && txt_StockMaximo.Text != "" && txt_StockMinimo.Text != "" && txtStock.Text != "")
            {
                if (stock.MedicamentoEsta(txt_Cuit_FarmaciaStock.Text, txt_Cuit_LaboratorioStock.Text, cmb_medicamento_stok.SelectedValue.ToString()))
                {
                    MessageBox.Show("Ya se encuentra en el Stock el medicamento");
                }
                else
                    stock.Insertar(txt_Cuit_FarmaciaStock.Text, txt_Cuit_LaboratorioStock.Text, cmb_medicamento_stok.SelectedValue.ToString(), txtStock.Text, txt_StockMinimo.Text, txt_StockMaximo.Text);
            }
            BorrarCampos();
        }

        private void BorrarCampos()
        {
            txtStock.Text = "";
            txt_StockMinimo.Text = "";
            txt_StockMaximo.Text = "";
            txt_Cuit_FarmaciaStock.Text= "";
            txt_Cuit_LaboratorioStock.Text= "";
            txt_cuitlaboratorio.Text = "";
            txt_cantidadmedicamentos_op.Text = "";
            // volvemos a poner el numero de pedido
            txt_NroPedido.Text = (int.Parse(orden.RecuperarNroOrden()) + 1).ToString();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea Modificar el Stock del medicamento?", "MODIFICAR STOCK!", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                stock.Modificar(txt_Cuit_FarmaciaStock.Text, txt_Cuit_LaboratorioStock.Text, cmb_medicamento_stok.SelectedValue.ToString(), txtStock.Text, txt_StockMinimo.Text, txt_StockMaximo.Text);
            }
            BorrarCampos();
        }

        private void btn_grabarOP_Click(object sender, EventArgs e)
        {
                if (grid_detalleOP.Rows.Count == 0)
                {
                    MessageBox.Show("Falta cargar los Medicamentos", "Importante"
                                    , MessageBoxButtons.OK
                                    , MessageBoxIcon.Question);
                    grid_detalleOP.Focus();
                    return;
                }
                if (orden.VerificarOrdenPedido(txt_cuitfarmacia.Text,lblt_fecha.Pp_Text, txt_NroPedido.Text) == Ng_OrdenDePedido.Pedido.no_existe)
                {
                     orden.insertar(txt_cuitfarmacia.Text, txt_NroPedido.Text, grid_detalleOP,lblt_fecha.Pp_Text);
                }
            BorrarCampos();
            grid_detalleOP.Rows.Clear();

        }

        private void grid_detalleOP_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Esta seguro de borrar la fila", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                grid_detalleOP.Rows.Remove(grid_detalleOP.CurrentRow);
            }
        }

        private void btn_agregarOP_Click(object sender, EventArgs e)
        {
            grid_detalleOP.Rows.Add();
            int ind = grid_detalleOP.Rows.Count - 1;
            grid_detalleOP.Rows[ind].Cells[0].Value = txt_cuitlaboratorio.Text;
            grid_detalleOP.Rows[ind].Cells[1].Value = cmb_medicamentos_op.SelectedValue.ToString();
            grid_detalleOP.Rows[ind].Cells[2].Value = cmb_medicamentos_op.Text;
            grid_detalleOP.Rows[ind].Cells[3].Value = txt_cantidadmedicamentos_op.Text;
            BorrarCampos();
        }

        private void btn_buscarOP_Click(object sender, EventArgs e)
        {

        }
    }
}
