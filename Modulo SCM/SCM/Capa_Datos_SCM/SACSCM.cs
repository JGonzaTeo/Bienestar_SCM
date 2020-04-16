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
        public OdbcDataReader InsertarMovimientoEncabezado(string sCodigo, string sCODEmpleado, string fecha)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into movimiento_encabezado values(" + sCodigo + ", '" + sCODEmpleado + "' ,'" + fecha + "',1);";
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
        public OdbcDataReader consultaMovimientoEncabezado()
        {
            try
            {
                cn.conexionbd();
                string consulta = "SELECT * FROM movimiento_encabezado WHERE estado = 1 ;";
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
        public OdbcDataReader InsertarMovimientoDetalle(string sCodEncabezado, string sMovGeneral)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into movimiento_detalle values(" + 0 + "," + sCodEncabezado + "," + sMovGeneral +");";
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

        //---------------------------------------------------------------CONSULTA MOVIMIENTO GENERAL------------------------------------------------------------------------------------------//
        public OdbcDataReader consultaMovimientoGeneral(string fecha)
        {
            try
            {
                cn.conexionbd();
                string consulta = "SELECT m.pkidmovimiento_general,m.pkidProducto, p.Nombre, m.concepto,m.documento,m.cantidad, p.Precio, p.Costo FROM movimiento_general m inner join producto p on m.pkidProducto=p.pkidProducto where m.fecha='"+fecha+"';";
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


        //---------------------------------------------------------------CONSULTA MOVIMIENTO GENERAL POR CONCEPTO------------------------------------------------------------------------------------------//
        public OdbcDataReader consultaMovimientoGeneralConcepto(string concepto, string fecha)
        {
            try
            {
                cn.conexionbd();
                string consulta = "SELECT m.pkidmovimiento_general,m.pkidProducto, p.Nombre, m.concepto,m.documento,m.cantidad, p.Precio, p.Costo FROM movimiento_general m inner join producto p on m.pkidProducto = p.pkidProducto where m.concepto = '"+concepto +"' and m.fecha = '"+fecha+"';";
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


        //---------------------------------------------------------------CONSULTA MOVIMIENTO GENERAL POR Producto------------------------------------------------------------------------------------------//
        public OdbcDataReader consultaMovimientoGeneralProducto(string producto, string fecha)
        {
            try
            {
                cn.conexionbd();
                
                string consulta = "SELECT m.pkidmovimiento_general,m.pkidProducto, p.Nombre, m.concepto,m.documento,m.cantidad, p.Precio, p.Costo FROM movimiento_general m inner join producto p on m.pkidProducto = p.pkidProducto where m.pkidProducto = '" + producto + "' and m.fecha = '" + fecha + "';";
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
