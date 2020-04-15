using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace Capa_Datos_SCM
{
    public class SIFSCM
    {
        Conexion cn = new Conexion();
        OdbcCommand comm;

        //---------------------------------------------------------------CONSULTA IMPUESTO------------------------------------------------------------------------------------------//

        public OdbcDataReader consultaImpuesto()
        {
            try
            {
                cn.conexionbd();
                string consulta = "SELECT * FROM impuestos WHERE estado = 1 ;";
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
        //---------------------------------------------------------------INSERT IMPUESTO------------------------------------------------------------------------------------------//
        public OdbcDataReader InsertarImpuesto(string sCodigo, string sNombre, string sDescripcion, string sValor)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into impuestos values(" + sCodigo + ", '" + sNombre + "' ,'" + sDescripcion + "'," + sValor + ",1);";
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
        //---------------------------------------------------------------UPDATE IMPUESTO------------------------------------------------------------------------------------------//

        public OdbcDataReader modificarImpuesto(string sCodigo, string sNombre, string sDescripcion, string sValor)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE impuestos set nombre='" + sNombre + "', descripcion='" + sDescripcion+ "'"+ ", valor = " + sValor + " where pkidImpuesto = " + sCodigo + ";";
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
        //--------------------------------------------------------------ELIMINAR IMPUESTO------------------------------------------------------------------------------------------//

        public OdbcDataReader eliminarImpuesto(string sCodigo)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE impuestos set estado='0' where pkidImpuesto='" + sCodigo + "';";
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
        //---------------------------------------------------------------CONSULTA ORDEN DE COMPRA ENCABEZADO------------------------------------------------------------------------------------------//

        public OdbcDataReader consultaOrdenCompraEncabezado()
        {
            try
            {
                cn.conexionbd();
                string consulta = "SELECT * FROM ordencomrpaencabezado WHERE estado = 1 ;";
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
        //---------------------------------------------------------------CONSULTA PROVEEDOR-ORDEN DE COMPRA------------------------------------------------------------------------------------------//

        public OdbcDataReader consultaProveedorOrden(string sCOD)
        {
            try
            {
                OdbcCommand command = new OdbcCommand("select P.pkidProveedor, P.nombre, P.nit from ordencomrpaencabezado O left join  proveedor P on O.fkIdProveedor = P.pkidProveedor where O.pkIdOrdenCompraEncabezado = "+ sCOD +";", cn.conexionbd());
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
        //---------------------------------------------------------------CONSULTA DETALLE DE ORDEN DE COMPRA-----------------------------------------------------------------------------------------//

        public OdbcDataReader consultaDetalleOrden(string sCOD)
        {

            try
            {
                cn.conexionbd();
                string consulta = "SELECT * FROM ordencompradetalle WHERE fkIdordenCompraEncabezado = " + sCOD +";";
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

        //---------------------------------------------------------------INSERT ENCABEZADO FACTURA DE COMPRA ------------------------------------------------------------------------------------------//
        public OdbcDataReader InsertarFacturaProveedor(string sCOD, string sCODOrden, string sCODEmpleado, string sSerie, string sFactura, string fecha, string sImpuesto, string sTotalImpuesto, string sTotal, string sDescuento)
        {
            try
            {
                cn.conexionbd();
                string texto = "Factura " + " " + sSerie + " " +sFactura;
                string consulta = "insert into facturaproveedorencabezado values(" + sCOD + ","+ sCODOrden + "," + sCODEmpleado + ", '" + texto +"' , '" +  sSerie + "', '"+ sFactura + "', '" + fecha + "'," + sImpuesto + "," + sTotalImpuesto + "," + sTotal + ","+sDescuento +",1)";
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

        //---------------------------------------------------------------INSERT  FACTURA DE COMPRA DETALLE------------------------------------------------------------------------------------------//
        public OdbcDataReader InsertarFacturaProveedorDetalle(string sCodEncabezado, string sCodProducto, string sCantidad, string sPrecioUnitario, string sSubTotal)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into facturaproveedordetalle values(" + 0 + "," + sCodEncabezado + "," + sCodProducto + ","+ sCantidad + "," + sPrecioUnitario + "," + sSubTotal + ",1);";
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

        //---------------------------------------------------------------INSERT MOVIMIENTO GENERAL------------------------------------------------------------------------------------------//
        public OdbcDataReader InsertarMovimientoGeneral(string sCodProducto, string sCantidad, string sFecha, string sDocumento)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into movimiento_general values (" + 0 + "," + sCodProducto + "," +"'Factura Compra'" + ",'" + sDocumento + "'," + sCantidad + ",'" + sFecha + "');";
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
