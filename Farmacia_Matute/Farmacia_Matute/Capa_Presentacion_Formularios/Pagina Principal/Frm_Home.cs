using System;
using System.Windows.Forms;
using Farmacia_Matute.Capa_Presentacion_Formularios.Obras_sociales;
using Farmacia_Matute.Capa_Presentacion_Formularios.Empleados;
using Farmacia_Matute.Formularios.Empleados;
using Farmacia_Matute.Formularios.Farmacia;
using Farmacia_Matute.Formularios.Usuarios;
using Farmacia_Matute.Negocios;
using Farmacia_Matute.Capa_Presemtacion_Formularios.Medicamentos;
using Farmacia_Matute.Capa_Presemtacion_Formularios.Laboratorio;
using Farmacia_Matute.Capa_Presemtacion_Formularios.Obras_sociales;
using Farmacia_Matute.Capa_Presemtacion_Formularios.Configuracion;
using Farmacia_Matute.Capa_Presemtacion_Formularios.Stock;
using Farmacia_Matute.Capa_Presemtacion_Formularios.Clientes;
using Farmacia_Matute.Capa_Presentacion_Formularios.Compras;
using Farmacia_Matute.Capa_Presentacion_Formularios.Reportes;
using Farmacia_Matute.Capa_Presentacion_Formularios.Estadisticas;

namespace Farmacia_Matute
{
    public partial class Frm_home : Form
    {

        Ng_Users us = new Ng_Users();
        public Frm_home()
        {
            InitializeComponent();
        }

        private void farmaciaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void estadísticasInofrmesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_home_Load(object sender, EventArgs e)
        {

            Frm_login login = new Frm_login();
            login.ShowDialog();
            switch (login.Perfil)
            {
                case 1: //FORMULARIOS PERMITIDOS PARA EL ADMINISTRADOR muestra todos los items
                    break;
                case 2: //FORMULARIOS PERMITIDOS PARA EL PERFIL STOCK
                    farmaciaToolStripMenuItem.Enabled = false;
                    clientesToolStripMenuItem.Enabled = false;
                    empleadosToolStripMenuItem.Enabled = false;
                    configuraciónToolStripMenuItem.Enabled = false;
                    comprasToolStripMenuItem.Enabled = false;
                    ventasToolStripMenuItem.Enabled = false;
                    clientesToolStripMenuItem1.Enabled = false;
                    //empleadosToolStripMenuItem1.Enabled = false;
                    ventasToolStripMenuItem1.Enabled = false;

                    break;
                case 3:// FORMULARIOS PERMITIDOS PARA EL PERFIL DE VENTAS
                    farmaciaToolStripMenuItem.Enabled = false;
                    clientesToolStripMenuItem.Enabled = false;
                    empleadosToolStripMenuItem.Enabled = false;
                    configuraciónToolStripMenuItem.Enabled = false;
                    stockToolStripMenuItem.Enabled = false;
                    //stockToolStripMenuItem1.Enabled = false;
                    clientesToolStripMenuItem1.Enabled = false;
                    //empleadosToolStripMenuItem1.Enabled = false;
                    comprasToolStripMenuItem.Enabled = false;
                    comprasToolStripMenuItem1.Enabled = false;
                    break;
                case 4:// FORMULARIOS PERMITIDOS PARA EL PERIL DE COMPRAS
                    farmaciaToolStripMenuItem.Enabled = false;
                    clientesToolStripMenuItem.Enabled = false;
                    empleadosToolStripMenuItem.Enabled = false;
                    configuraciónToolStripMenuItem.Enabled = false;
                    stockToolStripMenuItem.Enabled = false;
                    //stockToolStripMenuItem1.Enabled = false;
                    clientesToolStripMenuItem1.Enabled = false;
                    //empleadosToolStripMenuItem1.Enabled = false;
                    ventasToolStripMenuItem.Enabled = false;
                    ventasToolStripMenuItem1.Enabled = false;
                    break;
            }
        }

        private void sucursalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_datos_farmacia farmacia = new frm_datos_farmacia();
            farmacia.ShowDialog();

        }

        private void datosPersonalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_datos_empleado empleado = new Frm_datos_empleado();
            empleado.ShowDialog();

        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_usuario usuario = new Frm_usuario();
            usuario.ShowDialog();

        }

        private void datosPersonalesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_datos_clientes clientes = new Frm_datos_clientes();
            clientes.ShowDialog();

        }

        private void medicamentosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_medicamentos medicamentos = new Frm_medicamentos();
            medicamentos.ShowDialog();

        }

        
        private void datosLAboratorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_datos_laboratorio laboratorio = new Frm_datos_laboratorio();
            laboratorio.ShowDialog();

        }

        private void datosObraSocialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_obra_social obra_social = new Frm_obra_social();
            obra_social.ShowDialog();

        }

        
        private void barriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_barrios barrios = new Frm_barrios();
            barrios.ShowDialog();
        }

        private void localidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_localidad localidad = new Frm_localidad();
            localidad.ShowDialog();

        }

        

        private void gestiónDeStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_gestion_stock stock = new Frm_gestion_stock();
            stock.ShowDialog();

        }

        private void gestiónDeComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_FacturaCompra compras = new Frm_FacturaCompra();
            compras.ShowDialog();

        }

        private void gestiónDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_FacturaVenta ventas = new Frm_FacturaVenta();
            ventas.ShowDialog();

        }

        private void comprasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_EstadisticasCompras frm_EstadisticasCompras = new Frm_EstadisticasCompras();
            frm_EstadisticasCompras.ShowDialog();
        }

        private void ventasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_EstadisticasVentas frm_EstadisticasVentas = new Frm_EstadisticasVentas();
            frm_EstadisticasVentas.ShowDialog();
        }

        private void reporteDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void clientesPorObraSocialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ReportesClientes frm_ReportesClientes = new Frm_ReportesClientes();
            frm_ReportesClientes.ShowDialog();
        }

        private void reporteDeComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ReporteCompras reporteCompra = new Frm_ReporteCompras();
            reporteCompra.ShowDialog();
        }

        private void reporteDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ReportesVentas reporteVenta = new Frm_ReportesVentas();
            reporteVenta.ShowDialog();
        }

        private void medicamentosPorLaboratorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Reporte_Medic_Lab reporte_MedicLab = new Frm_Reporte_Medic_Lab();
            reporte_MedicLab.ShowDialog();
        }

        private void padrónDePacientesPorObraSocialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Estadistica_Clientes_X_OS est_Cli_X_os = new Frm_Estadistica_Clientes_X_OS();
            est_Cli_X_os.ShowDialog();
        }

        private void estadisticasLaboratorioPorProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Estad_Lab_Prod Lab_Prod = new Frm_Estad_Lab_Prod();
            Lab_Prod.ShowDialog();
        }
    }
}