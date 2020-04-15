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

        public string obtenerfinal(string tabla, string campo)
        {
            String camporesultante = "";
            try
            {
                string sql = "SELECT MAX(" + campo + "+1) FROM " + tabla + ";"; //SELECT MAX(idFuncion) FROM `funciones`     
                OdbcCommand command = new OdbcCommand(sql, cn.conexionbd());
                OdbcDataReader reader = command.ExecuteReader();
                reader.Read();
                camporesultante = reader.GetValue(0).ToString();
                Console.WriteLine("El resultado es: " + camporesultante);
                if (String.IsNullOrEmpty(camporesultante))
                    camporesultante = "1";
            }
            catch (Exception)
            {
                Console.WriteLine(camporesultante);
            }
            return camporesultante;
        }

        public OdbcDataReader consultaayudas(string id)
        {
            try
            {
                cn.conexionbd();
                string consultaGraAsis = " select * from ayudas where pkcodigoayuda =" + id + ";";
                comm = new OdbcCommand(consultaGraAsis, cn.conexionbd());
                OdbcDataReader mostrarResultados = comm.ExecuteReader();
                return mostrarResultados;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        // ---------------------------------------------------------Consultas Isis----------------------------------------------------

        //producto------------------------------------------------
        public OdbcDataReader Insertarproducto(string pkidProveedor, string pkidProducto, string Nombre, string Precio, string Descripcion, string Presentacion, string Costo, string estado, string tipo)
        {

            try
            {
                cn.conexionbd();
                string consulta = "insert into producto values(" + pkidProveedor + ", '" + pkidProducto + "' ,'" + Nombre + "','" + Precio + "','" + Descripcion + "','" + Presentacion + "','" + Costo + "','" + estado + "','" + tipo + "');";
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

        public OdbcDataReader Insertarproductoenbodega(string pkidBodega, string pkidProducto, string existencias, string estado)
        {

            try
            {
                cn.conexionbd();
                string consulta = "insert into productoenbodega values(" + pkidBodega + ", '" + pkidProducto + "','" + existencias + "','" + estado + "');";
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

        public OdbcDataReader modificarproducto(string pkidProveedor, string pkidProducto, string Nombre, string Precio, string Descripcion, string Presentacion, string Costo, string estado, string tipo)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE producto set pkidProveedor='" + pkidProveedor + "',Nombre='" + Nombre + "',Precio='" + Precio + "',Descripcion='" + Descripcion + "',Presentacion='" + Presentacion + "',Costo='" + Costo + "',estado='" + estado + "' where pkidproducto='" + pkidProducto + "';";
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

        public OdbcDataReader modificarproductoenbodega(string pkidBodega, string pkidProducto, string existencias, string estado)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE productoenbodega set pkidBodega='" + pkidBodega + "',pkidProducto='" + pkidProducto + "',existencias='" + existencias + "',estado='" + estado + "' where pkidproducto='" + pkidProducto + "';";
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



        public OdbcDataReader eliminarproducto(string pkidProducto)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE producto set estado='0' where pkidProducto='" + pkidProducto + "';";
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

        public OdbcDataReader eliminarproductoenbodega(string pkidProducto)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE productoenbodega set estado='0' where pkidProducto='" + pkidProducto + "';";
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

        public OdbcDataReader consultaproducto()
        {
            try
            {
                cn.conexionbd();
                string consulta = "Select pr.pkidproveedor, pr.pkidproducto,pr.Nombre,pr.Precio,pr.Descripcion,pr.Presentacion,pr.Costo,pr.estado,pr.pktipo_producto ,p.pkidBodega,p.Existencias from productoenbodega p INNER JOIN producto pr on p.pkidProducto = pr.pkidProducto  WHERE pr.estado = 1; ";
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

        //----------------------------------------------proveedores

        public OdbcDataReader Insertarproveedor(string pkidProveedor, string Nombre, string Nit, string Direccion, string Telefono, string Email, string estado)
        {

            try
            {
                cn.conexionbd();
                string consulta = "insert into proveedor values(" + pkidProveedor + ", '" + Nombre + "','" + Nit + "','" + Direccion + "','" + Telefono + "','" + Email + "','" + estado + "');";
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

        public OdbcDataReader modificarproveedor(string pkidProveedor, string Nombre, string Nit, string Direccion, string Telefono, string Email, string estado)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE proveedor set Nombre='" + Nombre + "',Nit='" + Nit + "',Direccion='" + Direccion + "',Telefono='" + Telefono + "',Email='" + Email + "',estado='" + estado + "' where pkidproveedor='" + pkidProveedor + "';";
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

        public OdbcDataReader eliminarproveedor(string pkidProveedor)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE proveedor set estado='0' where pkidProveedor='" + pkidProveedor + "';";
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

        public OdbcDataReader consultaproveedor()
        {
            try
            {
                cn.conexionbd();
                string consulta = "SELECT * FROM proveedor WHERE estado = 1 ;";
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

        //-----------------------------------Bodega
        public OdbcDataReader InsertarBodega(string pkidBodega, string Nombre, string Direccion, string Telefono, string Email, string StockMin, string StockMax, string estado)
        {

            try
            {
                cn.conexionbd();
                string consulta = "insert into bodega values(" + pkidBodega + ", '" + Nombre + ", '" + Direccion + "','" + Telefono + "','" + Email + "','" + StockMin + "','" + StockMax + "','" + estado + "');";
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

        public OdbcDataReader modificarBodega(string pkidBodega, string Nombre, string Direccion, string Telefono, string Email, string StockMin, string StockMax, string estado)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE bodedega set Nombre='" + Nombre + "',Direccion='" + Direccion + "',Telefono='" + Telefono + "',Email='" + Email + "',StockMin='" + StockMin + "',StockMax='" + StockMax + "',estado='" + estado + "' where pkidproveedor='" + pkidBodega + "';";
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

        public OdbcDataReader eliminaBodega(string pkidBodega)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE bodega set estado='0' where pkidBodega='" + pkidBodega + "';";
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

        public OdbcDataReader consultaBodega()
        {
            try
            {
                cn.conexionbd();
                string consulta = "SELECT * FROM bodega WHERE estado = 1;";
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

        public OdbcDataReader ConsultaTipoProd()
        {
            try
            {
                cn.conexionbd();
                string consulta = "SELECT * FROM  tipoproducto WHERE estado = 1;";
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

        //-----------Paula
        //---------------------------------------------------------------------------------MODIFICAR-ACRREDOR-------------------------------------------------------------------------------
        public OdbcDataReader modificaracreedor(string scodigo, string snombre, string stelefono, string snit, string semail, string sdireccion, string scalidadservicio, string sestado)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE acreedor set nombre='" + snombre + "',telefono='" + stelefono + "',nit='" + snit + "',email='" + semail + "',direccion='" + sdireccion + "',calidadservicio='" + scalidadservicio + "',estado='" + sestado + "' where pkidacreedor='" + scodigo + "';";
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
        //---------------------------------------------------------------------------------INSERTAR-ACRREDOR-------------------------------------------------------------------------------
        public OdbcDataReader insertaracreedor(string scodigo, string snombre, string stelefono, string snit, string semail, string sdireccion, string scalidadservicio, string sestado)
        {
            Console.WriteLine(scodigo + snombre + stelefono + snit + semail + sdireccion + scalidadservicio + sestado);
            try
            {
                cn.conexionbd();
             
                string consulta = "INSERT INTO acreedor values('" + scodigo + "', '" + snombre + "' ,'" + stelefono + "','" + snit + "','" + semail + "','" + sdireccion + "','" + scalidadservicio + "','" + sestado + "');";
                comm = new OdbcCommand(consulta, cn.conexionbd());
               // Console.WriteLine(scodigo+snombre+stelefono+snit+semail+sdireccion+scalidadservicio+sestado);
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        //---------------------------------------------------------------------------------ELIMINAR-ACRREDOR-------------------------------------------------------------------------------
        public OdbcDataReader eliminaracreedor(string scodigo)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE acreedor set estado='0' where pkidacreedor='" + scodigo + "';";
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
        //---------------------------------------------------------------------------------CONSULTAR-ACRREDOR-------------------------------------------------------------------------------
        public OdbcDataReader consultaracreedor()
        {
      
            try
            {
                cn.conexionbd();
                string consulta = "SELECT * FROM acreedor WHERE estado =1;";
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
        //---------------------------------------------------------------------------------MODIFICAR-TRANSPORTE-------------------------------------------------------------------------------
        public OdbcDataReader modificartransporte(string scodigo, string scodigoruta, string scodigotipotransporte, string splaca, string schasis, string smotor, string sestado)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE transporte set fkidruta='" + scodigoruta + "',fkidtipotransporte='" + scodigotipotransporte + "',placa='" + splaca + "',chasis='" + schasis + "',motor='" + smotor + "',estado='" + sestado + "' where pkidtransporte='" + scodigo + "';";
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
        //---------------------------------------------------------------------------------INSERTAR-TRANSPORTE-------------------------------------------------------------------------------
        public OdbcDataReader insertartransporte(string scodigo, string scodigoruta, string scodigotipotransporte, string splaca, string schasis, string smotor, string sestado)
        {
            try
            {
                
                cn.conexionbd();
                string consulta = "insert into transporte values(" + scodigo + ", (select pkidruta from ruta where nombre='" + scodigoruta + "') ,(select pkidtipotransporte from tipotransporte where nombre='" + scodigotipotransporte + "'),'" + splaca + "','" + schasis + "','" + smotor + "','" + sestado + "');";
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
       
        //---------------------------------------------------------------------------------ELIMINAR-TRANSPORTE-------------------------------------------------------------------------------
        public OdbcDataReader eliminartransporte(string scodigo)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE transporte set estado='0' where pkidtransporte='" + scodigo + "';";
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
        //---------------------------------------------------------------------------------CONSULTAR-TRANSPORTE-------------------------------------------------------------------------------
        public OdbcDataReader consultartransporte(string campo)
        {
            try
            {
                OdbcCommand command = new OdbcCommand("SELECT * FROM transporte WHERE estado = " + campo + " ;", cn.conexionbd());
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
        //--
        //---------------------------------------------------------------------------------MODIFICAR-TIPOTRANSPORTE-------------------------------------------------------------------------------
        public OdbcDataReader modificartipotransporte(string scodigo, string snombre, float fcapacidad, string sestado)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE tipotransporte set nombre='" + snombre + "',capacidad='" + fcapacidad + "',estado='" + sestado + "' where pkidtipotransporte='" + scodigo + "';";
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
        //---------------------------------------------------------------------------------INSERTAR-TIPOTRANSPORTE-------------------------------------------------------------------------------
        public OdbcDataReader insertartipotransporte(string scodigo, string snombre, float fcapacidad, string sestado)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into tipotransporte values(" + scodigo + ", '" + snombre + "' ,'" + fcapacidad + "','" + sestado + "');";
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
        //---------------------------------------------------------------------------------ELIMINAR-TIPOTRANSPORTE-------------------------------------------------------------------------------
        public OdbcDataReader eliminartipotransporte(string scodigo)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE tipotransporte set estado='0' where pkidtipotransporte='" + scodigo + "';";
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
        //---------------------------------------------------------------------------------CONSULTAR-TIPOTRANSPORTE-------------------------------------------------------------------------------
        public OdbcDataReader consultartipotransporte(string campo)
        {
            try
            {
                OdbcCommand command = new OdbcCommand("SELECT * FROM tipotransporte WHERE estado = " + campo + " ;", cn.conexionbd());
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
        //--
        //---------------------------------------------------------------------------------MODIFICAR-RUTA-------------------------------------------------------------------------------
        public OdbcDataReader modificarruta(string scodigo, string snombre, string sdescripcion, string sestado)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE ruta set nombre='" + snombre + "',descripcion='" + sdescripcion + "',estado='" + sestado + "' where pkidruta='" + scodigo + "';";
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
        //---------------------------------------------------------------------------------INSERTAR-RUTA-------------------------------------------------------------------------------
        public OdbcDataReader insertarruta(string scodigo, string snombre, string sdescripcion, string sestado)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into ruta values(" + scodigo + ", '" + snombre + "' ,'" + sdescripcion + "','" + sestado + "');";
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
        //---------------------------------------------------------------------------------ELIMINAR-RUTA------------------------------------------------------------------------------
        public OdbcDataReader eliminarruta(string scodigo)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE ruta set estado='0' where pkidruta='" + scodigo + "';";
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
        //---------------------------------------------------------------------------------CONSULTAR-RUTA-------------------------------------------------------------------------------
        public OdbcDataReader consultarruta(string campo)
        {
            try
            {
                OdbcCommand command = new OdbcCommand("SELECT * FROM ruta WHERE estado = " + campo + " ;", cn.conexionbd());
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
        //---------------------------------------------------------------------------------CONSULTAR-DISPONIBILIDAD-BODEGA-------------------------------------------------------------------------------
        public OdbcDataReader consultardisponibilidadbodega(string campo)
        {
            try
            {
                OdbcCommand command = new OdbcCommand("select b.nombre, b.stockmaximo  - sum(pb.existencias) as disponible from productoenbodega pb inner join bodega b on b.pkidBodega = pb.Bodega_idBodega group by nombre;", cn.conexionbd());
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
        //---------------FinPaula


    }
}