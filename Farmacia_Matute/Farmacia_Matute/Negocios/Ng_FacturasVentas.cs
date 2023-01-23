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
    class Ng_FacturasVentas
    {
        public enum Facturacion { existe, no_existe }
        Be_BaseDatos _BD = new Be_BaseDatos();
        TratamientosEspeciales _TE = new TratamientosEspeciales();
        public DataTable BuscarFacturasVentas(string tipoFac, string nroFac, string tipoDoc, string nro_doc, string tipoDocPac, string nro_docPac, string fecha, string fechap)
        {
            string sql = "";
            sql = @"SELECT convert(char(10),fv.Fecha_Fac, 103) Fecha,
		                    fv.CUIT_Farmacia,
		                    fv.Nro_Fac as NroFactura,
		                    tf.Descripcion as TipoFactura,
		                    em.Nombre,
		                    em.Apellido,
		                    cl.Nombre as Nombre_Pac,
		                    cl.Apellido as Apellido_Pac,
		                    sum(d.Precio)as Total
                     FROM    Factura_Venta fv JOIN Empleado_Paciente em
                                                     on fv.Id_Tipo_Doc_Emp = em.Id_Tipo_Doc
                                                         and fv.Nro_Doc_Emp = em.Nro_Doc
                                                 JOIN Empleado_Paciente cl

                                                    on fv.Id_Tipo_Doc_Pac = cl.Id_Tipo_Doc
                                                        and fv.Nro_Doc_Pac = cl.Nro_Doc

                                                JOIN Tipo_Factura tf
                                                on  fv.Id_Tipo_Fact= tf.Id_Tipo_Factura

                                                JOIN Detalle_Venta d
                                                    on fv.CUIT_Farmacia = d.CUIT_Farmacia

                                                    and fv.Id_Tipo_Fact = d.Id_Tipo_Fac

                                                    and fv.Nro_Fac = d.Nro_Fac				               
                  WHERE 1 = 1 ";
            if (tipoFac != "" && nroFac != "")
            {
                sql += " AND fv.Id_Tipo_Fact = " + tipoFac
                        + " AND fv.Nro_Fac = " + nroFac;
            }
            if (tipoDoc != "" && nro_doc != "")
            {
                sql += " AND fv.Id_Tipo_Doc_Emp = " + tipoDoc
                    + " AND fv.Nro_Doc_Emp = " + nro_doc;
            }
            if (tipoDocPac != "" && nro_docPac != "")
            {
                sql += " AND fv.Id_Tipo_Doc_Pac = " + tipoDocPac
                    + " AND fv.Nro_Doc_Pac = " + nro_docPac;
            }
            if (_TE.ValidarFecha(fecha) == TratamientosEspeciales.Validacion.correcta)
            {
                sql += " AND fv.Fecha_Fac= " + _BD.FormatearDato(fecha, "Date");
            }
            if (_TE.ValidarFecha(fechap) == TratamientosEspeciales.Validacion.correcta)
            {
                String[] dato = fechap.Split('/');

                sql += " AND Month(fv.Fecha_Fac)= " + dato[1]
                    + "AND Year(fv.Fecha_Fac)= " + dato[2];
            }
            sql += @"group by

                            fv.Nro_Fac,
                            fv.CUIT_Farmacia,
                            tf.Descripcion,
                            fv.Fecha_Fac,
                            em.Apellido,
                            em.Nombre,
                            cl.Apellido,
                            cl.Nombre";

            return _BD.Consulta(sql);
        }

        public DataTable CalculoEstadisticoPorLaboratorio(string tipoDoc, string nro_doc, string fecha, string fechap)
        {
            string sql = "";
            sql = @" SELECT	l.Razon_Social Denominacion,
		                        sum(d.Precio)as Total
                        FROM	Factura_Venta fv JOIN Empleado_Paciente em
								                        on fv.Id_Tipo_Doc_Emp = em.Id_Tipo_Doc
									                        and fv.Nro_Doc_Emp = em.Nro_Doc
						                        JOIN Detalle_Venta d
								                        on fv.CUIT_Farmacia = d.CUIT_Farmacia
								                        and fv.Id_Tipo_Fact = d.Id_Tipo_Fac
								                        and fv.Nro_Fac = d.Nro_Fac
						                        JOIN Laboratorios l
							                        on d.CUIT_Laboratorio= l.CUIT_Laboratorio
                WHERE 1=1 ";
            if (tipoDoc != "" && nro_doc != "")
            {
                sql += " AND fv.Id_Tipo_Doc_Emp = " + tipoDoc
                    + " AND fv.Nro_Doc_Emp = " + nro_doc;
            }
            if (_TE.ValidarFecha(fecha) == TratamientosEspeciales.Validacion.correcta)
            {
                sql += " AND fv.Fecha_Fac= " + _BD.FormatearDato(fecha, "Date");
            }
            if (_TE.ValidarFecha(fechap) == TratamientosEspeciales.Validacion.correcta)
            {
                String[] dato = fechap.Split('/');

                sql += " AND Month(fv.Fecha_Fac)= " + dato[1]
                    + "AND Year(fv.Fecha_Fac)= " + dato[2];
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
                    FROM	Factura_Venta fv JOIN Empleado_Paciente em
								                    on fv.Id_Tipo_Doc_Emp = em.Id_Tipo_Doc
									                    and fv.Nro_Doc_Emp = em.Nro_Doc
						                    JOIN Detalle_Compra d
								                    on fv.CUIT_Farmacia = d.CUIT_Farmacia
								                    and fv.Id_Tipo_Fact = d.Id_Tipo_Fac
								                    and fv.Nro_Fac = d.Nro_Fac
						                    JOIN Medicamentos m
								                    on d.CUIT_Laboratorio = m.CUIT_Laboratorio
								                    and d.Id_Medicamento = m.Id_Medicamento 
					
			WHERE 1=1";
            if (tipoDoc != "" && nro_doc != "")
            {
                sql += " AND fv.Id_Tipo_Doc_Emp = " + tipoDoc
                    + " AND fv.Nro_Doc_Emp = " + nro_doc;
            }
            if (_TE.ValidarFecha(fecha) == TratamientosEspeciales.Validacion.correcta)
            {
                sql += " AND fv.Fecha_Fac= " + _BD.FormatearDato(fecha, "Date");
            }
            if (_TE.ValidarFecha(fechap) == TratamientosEspeciales.Validacion.correcta)
            {
                String[] dato = fechap.Split('/');

                sql += " AND Month(fv.Fecha_Fac)= " + dato[1]
                    + "AND Year(fv.Fecha_Fac)= " + dato[2];
            }
            sql += @"group by 
							m.Nombre";

            return _BD.Consulta(sql);
        }
        public void insertar(string cuit_farmacia, string cuit_laboratorio,string tipoFac, string nroFac, string tipoDoc, string nro_doc, string tipoDocPac, string nro_docPac, DataGridView medicamentos, string fecha)
        {
            _BD.IniciarTransaccion();
            
            string insert_factura = "INSERT INTO  Factura_Venta (CUIT_Farmacia ,Id_Tipo_Fact, Nro_Fac,Id_Tipo_Doc_Pac, Nro_Doc_Pac, Id_Tipo_Doc_Emp, Nro_Doc_Emp ,Fecha_Fac) VALUES (";
            insert_factura += cuit_farmacia + ", " + tipoFac + ", " + nroFac + ", " + tipoDocPac
                            + "," + nro_docPac+ ", "+ tipoDoc+ "," + nro_doc +"," + _BD.FormatearDato(fecha,"Date") + ")";

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
            string insert_detalle = "INSERT INTO  Detalle_Venta (CUIT_Farmacia,Id_Tipo_Fac,Nro_Fac,CUIT_Laboratorio,Id_Medicamento," +
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
            string sql = "SELECT * FROM Factura_Venta WHERE CUIT_Farmacia = " + cuitFarmacia
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
            String sql = "SELECT Nro_Fac FROM Factura_Venta";
            String nro = "";
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            if (tabla.Rows.Count == 0)
                nro = "0";
            else
                for(int i=0; i< tabla.Rows.Count; i++)
                {
                    nro = tabla.Rows[i][0].ToString();
                }
            return nro;
        }
        public Facturacion VerificarFacturacionXEmpleado(String tipo_Doc, string nro_Doc)
        {
            string sql = "SELECT * FROM Factura_Venta WHERE Id_Tipo_Doc_Emp = " + tipo_Doc
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
        public Facturacion VerificarFacturacionXPaciente(String tipo_Doc, string nro_Doc)
        {
            string sql = "SELECT * FROM Factura_Venta WHERE Id_Tipo_Doc_Pac = " + tipo_Doc
                        + " AND Nro_Doc_Pac  = " + nro_Doc;
            DataTable tabla = new DataTable();
            tabla = _BD.Consulta(sql);
            if (tabla.Rows.Count == 0)
            {
                return Facturacion.no_existe;
            }
            else
                return Facturacion.existe;
        }
        public Facturacion VerificarFacturacion(String nroFactura, string tipoFact)
        {
            string sql = "SELECT * FROM Factura_Venta WHERE Id_Tipo_Fact = " + tipoFact
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
    }
}
