using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos_SCM
{
    public class SIPSCM
    {

        Conexion cn = new Conexion();
        OdbcCommand comm;

        public OdbcDataReader insertarbitacora(string sCodigo, string sip, string Smac, string susuario, string sdepartamento, string sfechahora, string saccion, string sformulario)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into bitacora values(" + sCodigo + ", '" + sip + "', '" + Smac + "' ,'" + susuario + "','" + sdepartamento + "','" + sfechahora + "','" + saccion + "','" + sformulario + "');";
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

        // ---------------------------------------------------------Consultas Isis-----------------------------------------

        //consulta id proveedores//

        public OdbcDataReader consultaproveedor()
        {
            try
            {
                OdbcCommand command = new OdbcCommand("SELECT idProveedor FROM proveedor WHERE estado='1'", cn.conexionbd());
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
        //producto------------------------------------------------
        public OdbcDataReader Insertarproducto(string idProveedor, string idProducto, string Nombre, string Precio, string Descripcion, string Presentacion, string Costo, string estado, string tipo)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into concepto values(" + idProveedor + ", '" + idProducto + "' ,'" + Nombre + "','" + Precio + "','" + Descripcion + "','" + Presentacion + "','" + Costo + "','" + estado + "','" + tipo + "');";
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

        public OdbcDataReader modificarproducto(string idProveedor, string idProducto, string Nombre, string Precio, string Descripcion, string Presentacion, string Costo, string estado, string tipo)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE concepto set idProveedor='" + idProveedor + "',Nombre='" + Nombre + "',Precio='" + Precio + "',Descripcion='" + Descripcion + "',Presentacion='" + Presentacion + "',Costo='" + Costo + "',estado='" + estado + "' where pkidproducto='" + idProducto + "';";
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

        public OdbcDataReader eliminarproducto(string idProducto)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE concepto set estado='0' where pkidProducto='" + idProducto + "';";
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

        public OdbcDataReader consultaproducto(string campo)
        {
            try
            {
                OdbcCommand command = new OdbcCommand("SELECT * FROM producto WHERE estado = " + campo + " ;", cn.conexionbd());
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


    }
}