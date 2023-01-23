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
    class Ng_FacturasCompras
    {
        public enum Facturacion { existe, no_existe }
        Be_BaseDatos _BD = new Be_BaseDatos();
        TratamientosEspeciales _TE = new TratamientosEspeciales();
        public DataTable BuscarFacturasCompras(string tipoFac, string nroFac, string tipoDoc, string nro_doc, string fecha,string fechap)
        {
            string sql = "";
            sql= @"SELECT	 convert(char(10),fc.Fecha_Fac, 103) Fecha,
		                l.Razon_Social as Laboratorio,
		                fc.Nro_Fac as NroFactura,
		                tf.Descripcion as TipoFactura,
		                em.Nombre,
		                em.Apellido,
		                sum(d.Precio)as Total
                FROM	Factura_Compra fc JOIN Empleado_Paciente em
								                on fc.Id_Tipo_Doc_Emp = em.Id_Tipo_Doc
									                and fc.Nro_Doc_Emp = em.Nro_Doc
							                JOIN Laboratorios l
								                on fc.CUIT_Lab = l.CUIT_Laboratorio
							                JOIN Tipo_Factura tf
							                on	fc.Id_Tipo_Fact= tf.Id_Tipo_Factura
							                JOIN Detalle_Compra d
								                on fc.CUIT_Farmacia = d.CUIT_Farmacia
								                and fc.Id_Tipo_Fact = d.Id_Tipo_Fac
								                and fc.Nro_Fac = d.Nro_Fac					               
                  WHERE 1 = 1 ";
            if(tipoFac!=""&& nroFac!="")
            {
                sql += " AND fc.Id_Tipo_Fact = " + tipoFac
                        + " AND fc.Nro_Fac = " + nroFac;
            }
            if(tipoDoc!="" && nro_doc!="")
            {
                sql += " AND fc.Id_Tipo_Doc_Emp = " + tipoDoc
                    + " AND fc.Nro_Doc_Emp = " + nro_doc;
            }
            if(_TE.ValidarFecha(fecha) == TratamientosEspeciales.Validacion.correcta)
            {
                sql += " AND fc.Fecha_Fac= " + _BD.FormatearDato(fecha, "Date");
            }
            if (_TE.ValidarFecha(fechap) == TratamientosEspeciales.Validacion.correcta)
            {
                String[] dato = fechap.Split('/');

                sql += " AND Month(fc.Fecha_Fac)= " + dato[1]
                    + "AND Year(fc.Fecha_Fac)= "+ dato[2];
            }
            sql += @" group by    
                    fc.Nro_Fac,
                    tf.Descripcion, 
                    fc.Fecha_Fac,
                    l.Razon_Social,
                    em.Apellido,
                    em.Nombre";
            return _BD.Consulta(sql);
        }
        public DataTable CalculoEstadisticoPorLaboratorio(string tipoDoc, string nro_doc, string fecha, string fechap)
        {
            string sql = "";
            sql = @" SELECT	l.Razon_Social Denominacion,
		                        sum(d.Precio)as Total
                        FROM	Factura_Compra fc JOIN Empleado_Paciente em
								                        on fc.Id_Tipo_Doc_Emp = em.Id_Tipo_Doc
									                        and fc.Nro_Doc_Emp = em.Nro_Doc
						                        JOIN Detalle_Venta d
								                        on fc.CUIT_Farmacia = d.CUIT_Farmacia
								                        and fc.Id_Tipo_Fact = d.Id_Tipo_Fac
								                        and fc.Nro_Fac = d.Nro_Fac
						                        JOIN Laboratorios l
							                        on d.CUIT_Laboratorio= l.CUIT_Laboratorio
                WHERE 1=1 ";
            if (tipoDoc != "" && nro_doc != "")
            {
                sql += " AND fc.Id_Tipo_Doc_Emp = " + tipoDoc
                    + " AND fc.Nro_Doc_Emp = " + nro_doc;
            }
            if (_TE.ValidarFecha(fecha) == TratamientosEspeciales.Validacion.correcta)
            {
                sql += " AND fc.Fecha_Fac= " + _BD.FormatearDato(fecha, "Date");
            }
            if (_TE.ValidarFecha(fechap) == TratamientosEspeciales.Validacion.correcta)
            {
                String[] dato = fechap.Split('/');

                sql += " AND Month(fc.Fecha_Fac)= " + dato[1]
                    + "AND Year(fc.Fecha_Fac)= " + dato[2];
            }
            sql += @"group by
                    l.Razon_Social";

            return _BD.Consulta(sql);

        }
        public DataTable CalculoEstadisticoPorMedicamento(string tipoDoc, string nro_doc, string fecha, string fechap)
        {
            string sql = "";
            sql = @"SELECT	m.Nombre as Denominacion,
		                    sum(d.Precio)as Total
                    FROM	Factura_Compra fc JOIN Empleado_Paciente em
								                    on fc.Id_Tipo_Doc_Emp = em.Id_Tipo_Doc
									                    and fc.Nro_Doc_Emp = em.Nro_Doc
						                    JOIN Detalle_Compra d
								                    on fc.CUIT_Farmacia = d.CUIT_Farmacia
								                    and fc.Id_Tipo_Fact = d.Id_Tipo_Fac
								                    and fc.Nro_Fac = d.Nro_Fac
						                    JOIN Medicamentos m
								                    on d.CUIT_Laboratorio = m.CUIT_Laboratorio
								                    and d.Id_Medicamento = m.Id_Medicamento 
					
			WHERE 1=1";
            if (tipoDoc != "" && nro_doc != "")
            {
                sql += " AND fc.Id_Tipo_Doc_Emp = " + tipoDoc
                    + " AND fc.Nro_Doc_Emp = " + nro_doc;
            }
            if (_TE.ValidarFecha(fecha) == TratamientosEspeciales.Validacion.correcta)
            {
                sql += " AND fc.Fecha_Fac= " + _BD.FormatearDato(fecha, "Date");
            }
            if (_TE.ValidarFecha(fechap) == TratamientosEspeciales.Validacion.correcta)
            {
                String[] dato = fechap.Split('/');

                sql += " AND Month(fc.Fecha_Fac)= " + dato[1]
                    + "AND Year(fc.Fecha_Fac)= " + dato[2];
            }
            sql += @"group by 
							m.Nombre";

            return _BD.Consulta(sql);
        }
        public void insertar(string cuit_farmacia, string cuit_laboratorio,string tipoFac, string nroFac, string tipoDoc, string nro_doc, DataGridView medicamentos, string fecha)
        {
            _BD.IniciarTransaccion();
            
            string insert_factura = "INSERT INTO  Factura_Compra (CUIT_Farmacia ,Id_Tipo_Fact, Nro_Fac, Id_Tipo_Doc_Emp, Nro_Doc_Emp , CUIT_Lab ,Fecha_Fac) VALUES (";
            insert_factura += cuit_farmacia + ", " + tipoFac + ", " + nroFac + ", " + tipoDoc
                            + "," + nro_doc + ", " + cuit_laboratorio + "," + _BD.FormatearDato(fecha,"Date") + ")";

            _BD.Insertar(insert_factura);

            insertarDetalle(cuit_farmacia, tipoFac, nroFac, cuit_laboratorio, medicamentos);

            if (_BD.CerrarTransaccion() == Be_BaseDatos.EstadoTransaccion.correcta)
            {
                MessageBox.Show("Se finalizó correctamente la grabación");
            }
            else
            {
                MessageBox.Show("No se grabó nada hubo error");
            }
        }
        public void insertarDetalle(string cuit_farmacia, string tipoFac,string nroFac,string cuit_laboratorio,DataGridView medicamentos)
        {
            string insert_detalle = "INSERT INTO  Detalle_Compra (CUIT_Farmacia,Id_Tipo_Fac,Nro_Fac,CUIT_Laboratorio,Id_Medicamento," +
                "                     Cantidad,Precio) VALUES (";
            for (int i = 0; i < medicamentos.Rows.Count; i++)
            {
                int precio= int.Parse(medicamentos.Rows[i].Cells[3].Value.ToString())*int.Parse(medicamentos.Rows[i].Cells[2].Value.ToString()); ;
                string datos_detalle = cuit_farmacia + ", " + tipoFac + ", " + nroFac + ", " + cuit_laboratorio
                + ", " + medicamentos.Rows[i].Cells[0].Value.ToString();
                datos_detalle += ", " + medicamentos.Rows[i].Cells[2].Value.ToString();
                datos_detalle += ", " + precio;
                datos_detalle += ")";

                string insert_final = insert_detalle + datos_detalle;

                _BD.Insertar(insert_final);
            }
        }

        public Facturacion VerificarFacturacion(string nroFactura, string cuitFarmacia, string tipoFact)
        {
            string sql = "SELECT * FROM Factura_Compra WHERE CUIT_Farmacia = " + cuitFarmacia
                        + " AND Id_Tipo_Fact = " + tipoFact
                        + " AND Nro_Fac = " + nroFactura ;
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            if (tabla.Rows.Count == 0)
            {
                return Facturacion.no_existe;
            }
            else
                return Facturacion.existe;
        }
        public string RecuperarNroFactura()
        {
            String sql = "SELECT Nro_Fac FROM Factura_Compra";
            String nro = "0";
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            for(int i=0; i< tabla.Rows.Count; i++)
            {
                nro = tabla.Rows[i][0].ToString();
            }
            return nro;
        }
        public Facturacion VerificarFacturacion(String nroFactura, string tipoFact)
        {
            string sql = "SELECT * FROM Factura_Compra WHERE Id_Tipo_Fact = " + tipoFact
                        + " AND Nro_Fac = " + nroFactura;
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            if (tabla.Rows.Count == 0)
            {
                return Facturacion.no_existe;
            }
            else
                return Facturacion.existe;
        }
        public Facturacion VerificarFacturacionXEmpleado(String tipo_Doc, string nro_Doc)
        {
            string sql = "SELECT * FROM Factura_Compra WHERE Id_Tipo_Doc_Emp = " + tipo_Doc
                        + " AND Nro_Doc_Emp  = " + nro_Doc;
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            if (tabla.Rows.Count == 0)
            {
                return Facturacion.no_existe;
            }
            else
                return Facturacion.existe;
        }
    }
}
