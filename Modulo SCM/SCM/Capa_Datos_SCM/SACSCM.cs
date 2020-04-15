using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace Capa_Datos_SCM
{
    public class SACSCM
    {
        /*---------------------------------------------CAPA ANGEL Y CONNY--------------------------------------*/
        Conexion cn = new Conexion();
        OdbcCommand comm;
        //---------------------------------------------------------------INSERT ENCABEZADO MOVIMIENTO------------------------------------------------------------------------------------------//
        public OdbcDataReader InsertarEncabezadoMovimiento(string sCodigo, string sNombre, string sFecha, string sTipo, string sEstado, 
            string sDescripcion)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into movimiento_encabezado values(" + sCodigo + ", '" + sNombre + "' ,'" + sFecha + "' ,'" +
                   sTipo + ", '" + sDescripcion + ");";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        //---------------------------------------------------------------UPDATE ENCABEZADO MOVIMIENTO------------------------------------------------------------------------------------------//
        public OdbcDataReader ModificarEncabezadoMovimiento(string sCodigo, string sNombre, string sFecha, string sTipo, string sEstado,
            string sDescripcion)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE movimiento_encabezado set nombre='" + sNombre + "',descripcion='" + sDescripcion + "',fecha'" + sFecha + 
                    "',tipo'" + sTipo + "',estado'" + sEstado +" where pkidImpuesto='" + sCodigo + "';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        //---------------------------------------------------------------CONSULTA ENCABEZADO MOVIMIENTO------------------------------------------------------------------------------------------//
        public OdbcDataReader ConsultaEncabezadoMovimiento()
        {
            try
            {
                OdbcCommand command = new OdbcCommand("SELECT * FROM movimiento_encabezado WHERE estado = 1 ;", cn.conexionbd());
                OdbcDataReader reader = command.ExecuteReader();
                reader.Read();
                return reader;
            }
            catch (Exception err)
            {

                Console.WriteLine(err.Message);
                return null;
            }
        }
        //---------------------------------------------------------------INSERT DETALLE MOVIMIENTO------------------------------------------------------------------------------------------//
        public OdbcDataReader InsertarDetalleMovimiento(string sConcepto, string sPrecio, string sCosto, string sCantidad)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into movimiento_detalle values(" + sConcepto + ", '" + sPrecio + "' ,'" + sCosto + 
                    "' ,'" + sCantidad + ");";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        //---------------------------------------------------------------INSERT DETALLE MOVIMIENTO------------------------------------------------------------------------------------------//
        public OdbcDataReader InsertarExistenciaProducto(string sEntrada, string sSalida, string sMinimo, string sMaximo)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into existencia_producto values(" + sEntrada + ", '" + sSalida + "' ,'" + sMinimo +
                    "' ,'" + sMaximo + ");";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
    }
}
