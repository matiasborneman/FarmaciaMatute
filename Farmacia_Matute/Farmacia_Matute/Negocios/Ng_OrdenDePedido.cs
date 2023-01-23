using Farmacia_Matute.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmacia_Matute.Negocios
{
    class Ng_OrdenDePedido
    {
        public enum Pedido { existe, no_existe }
        Be_BaseDatos _BD = new Be_BaseDatos();
        TratamientosEspeciales _TE = new TratamientosEspeciales();
        
        public void insertarDetalle(string fecha,string cuit_farmacia, string nroOrden, DataGridView medicamentos)
        {
            string insert_detalle = "INSERT INTO  Orden_Pedido (Fecha, CUIT_Farmacia, Nro_OrdenPedido, Id_Medicamento, CUIT_Laboratorio, Cantidad) VALUES ( "
                                    +_BD.FormatearDato(fecha, "Date");
            for (int i = 0; i < medicamentos.Rows.Count; i++)
            {
                string datos_detalle = ", " + cuit_farmacia + ", " + nroOrden + ", " + medicamentos.Rows[i].Cells[1].Value.ToString()
                + ", " + medicamentos.Rows[i].Cells[0].Value.ToString();
                datos_detalle += ", " + medicamentos.Rows[i].Cells[3].Value.ToString();
                datos_detalle += ")";

                string insert_final = insert_detalle + datos_detalle;

                _BD.Insertar(insert_final);
            }
        }

        internal Pedido VerificarOrdenPedido(string cuitFarmacia,string fecha, string nro)
        {
            string sql = "SELECT * FROM Orden_Pedido WHERE Fecha= " + _BD.FormatearDato(fecha,"Date")
                         + " AND CUIT_Farmacia = " + cuitFarmacia
                        +   "AND Nro_OrdenPedido = " + _BD.FormatearDato(nro,"int16");
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            if (tabla.Rows.Count == 0)
            {
                return Pedido.no_existe;
            }
            else
                return Pedido.existe;
        }
        public void insertar(string cuit_farmacia, string nroPedido, DataGridView medicamentos, string fecha)
        {
            _BD.IniciarTransaccion();

            insertarDetalle(fecha,cuit_farmacia,nroPedido,medicamentos);

            if (_BD.CerrarTransaccion() == Be_BaseDatos.EstadoTransaccion.correcta)
            {
                MessageBox.Show("Se finalizó correctamente la grabación");
            }
            else
            {
                MessageBox.Show("No se grabó nada hubo error");
            }
        }
        public string RecuperarNroOrden()
        {
            String sql = "SELECT Nro_OrdenPedido FROM Orden_Pedido";
            String nro = "0";
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                nro = tabla.Rows[i][0].ToString();
            }
            return nro;
        }

        public DataTable buscarOrdenPedido(string nroPedido)
        {
            String sql = "SELECT * FROM Orden_Pedido WHERE Nro_OrdenPedido=  " + _BD.FormatearDato(nroPedido,"int16") ;
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            return tabla;
        }
    }
}
