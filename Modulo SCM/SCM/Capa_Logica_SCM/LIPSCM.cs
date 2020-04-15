using Capa_Datos_SCM;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Logica_SCM
{
    public class LIPSCM
    {

        SIPSCM sn = new SIPSCM();

        public OdbcDataReader bitacora(string sCodigo, string sip, string Smac, string susuario, string sdepartamento, string sfechahora, string saccion, string sformulario)
        {
            return sn.insertarbitacora(sCodigo, sip, Smac, susuario, sdepartamento, sfechahora, saccion, sformulario);
        }

        public OdbcDataReader consultaayuda(string id)
        {
            return sn.consultaayudas(id);
        }

        public string siguiente(string tabla, string campo)
        {
            string llave = sn.obtenerfinal(tabla, campo);
            return llave;
        }

        // consulta proveedor combo

        public OdbcDataReader consultaproveedor()
        {
            return sn.consultaproveedor();
        }

        // -----------------------------------Producto 
        public OdbcDataReader Insertarproducto(string idProveedor, string idProducto, string Nombre, string Precio, string Descripcion, string Presentacion, string Costo, string estado, string tipo)
        {
            return sn.Insertarproducto(idProveedor, idProducto, Nombre, Precio, Descripcion, Presentacion, Costo, estado, tipo);

        }

        public OdbcDataReader Modificarproducto(string idProveedor, string idProducto, string Nombre, string Precio, string Descripcion, string Presentacion, string Costo, string estado, string tipo)
        {
            return sn.modificarproducto(idProveedor, idProducto, Nombre, Precio, Descripcion, Presentacion, Costo, estado, tipo);

        }

        public OdbcDataReader Eliminarproducto(string idProducto)
        {
            return sn.eliminarproducto(idProducto);

        }

        public OdbcDataReader consultaproducto(string numero)
        {
            return sn.consultaproducto(numero);
        }

        //-----------Paula
        //---------------------------------------------------------------------------------MODIFICAR-ACRREDOR-------------------------------------------------------------------------------
        public OdbcDataReader modificaracreedor(string scodigo, string snombre, string stelefono, string snit, string semail, string sdireccion, string scalidadservicio, string sestado)
        {
            return sn.modificaracreedor(scodigo, snombre, stelefono, snit, semail, sdireccion, scalidadservicio, sestado);
        }
        //---------------------------------------------------------------------------------INSERTAR-ACRREDOR-------------------------------------------------------------------------------
        public OdbcDataReader insertaracreedor(string scodigo, string snombre, string stelefono, string snit, string semail, string sdireccion, string scalidadservicio, string sestado)
        {
            return sn.insertaracreedor(scodigo, snombre, stelefono, snit, semail, sdireccion, scalidadservicio, sestado);
        }
        //---------------------------------------------------------------------------------ELIMINAR-ACRREDOR-------------------------------------------------------------------------------
        public OdbcDataReader eliminaracreedor(string scodigo)
        {
            return sn.eliminaracreedor(scodigo);
        }
        //---------------------------------------------------------------------------------CONSULTAR-ACRREDOR-------------------------------------------------------------------------------
        public OdbcDataReader consultaracreedor()
        {
            return sn.consultaracreedor();
        }
        //---------------------------------------------------------------------------------MODIFICAR-TRANSPORTE-------------------------------------------------------------------------------
        public OdbcDataReader modificartransporte(string scodigo, string scodigoruta, string scodigotipotransporte, string splaca, string schasis, string smotor, string sestado)
        {
            return sn.modificartransporte(scodigo, scodigoruta, scodigotipotransporte, splaca, schasis, smotor, sestado);
        }
        //---------------------------------------------------------------------------------INSERTAR-TRANSPORTE-------------------------------------------------------------------------------
        public OdbcDataReader insertartransporte(string scodigo, string scodigoruta, string scodigotipotransporte, string splaca, string schasis, string smotor, string sestado)
        {
            return sn.insertartransporte(scodigo, scodigoruta, scodigotipotransporte, splaca, schasis, smotor, sestado);
        }
        //---------------------------------------------------------------------------------ELIMINAR-TRANSPORTE-------------------------------------------------------------------------------
        public OdbcDataReader eliminartransporte(string scodigo)
        {
            return sn.eliminartransporte(scodigo);
        }
        //---------------------------------------------------------------------------------CONSULTAR-TRANSPORTE-------------------------------------------------------------------------------
        public OdbcDataReader consultartransporte(string numero)
        {
            return sn.consultartransporte(numero);
        }
        
        //---------------------------------------------------------------------------------MODIFICAR-TIPOTRANSPORTE-------------------------------------------------------------------------------
        public OdbcDataReader modificartipotransporte(string scodigo, string snombre, float fcapacidad, string sestado)
        {
            return sn.modificartipotransporte(scodigo, snombre, fcapacidad, sestado);
        }
        //---------------------------------------------------------------------------------INSERTAR-TIPOTRANSPORTE-------------------------------------------------------------------------------
        public OdbcDataReader insertartipotransporte(string scodigo, string snombre, float fcapacidad, string sestado)
        {
            return sn.insertartipotransporte(scodigo, snombre, fcapacidad, sestado);
        }
        //---------------------------------------------------------------------------------ELIMINAR-TIPOTRANSPORTE-------------------------------------------------------------------------------
        public OdbcDataReader eliminartipotransporte(string scodigo)
        {
            return sn.eliminartipotransporte(scodigo);
        }
        //---------------------------------------------------------------------------------CONSULTAR-TIPOTRANSPORTE-------------------------------------------------------------------------------
        public OdbcDataReader consultartipotransporte(string numero)
        {
            return sn.consultartipotransporte(numero);
        }
        //--
        //---------------------------------------------------------------------------------MODIFICAR-RUTA-------------------------------------------------------------------------------
        public OdbcDataReader modificarruta(string scodigo, string snombre, string sdescripcion, string sestado)
        {
            return sn.modificarruta(scodigo, snombre, sdescripcion, sestado);
        }
        //---------------------------------------------------------------------------------INSERTAR-RUTA-------------------------------------------------------------------------------
        public OdbcDataReader insertarruta(string scodigo, string snombre, string sdescripcion, string sestado)
        {
            return sn.insertarruta(scodigo, snombre, sdescripcion, sestado);
        }
        //---------------------------------------------------------------------------------ELIMINAR-RUTA-------------------------------------------------------------------------------
        public OdbcDataReader eliminarruta(string scodigo)
        {
            return sn.eliminarruta(scodigo);
        }
        //---------------------------------------------------------------------------------CONSULTAR-RUTA-------------------------------------------------------------------------------
        public OdbcDataReader consultarruta(string numero)
        {
            return sn.consultarruta(numero);
        }
        //---------------------------------------------------------------------------------CONSULTAR-DISPONIBILIDAD-BODEGA-------------------------------------------------------------------------------
        public OdbcDataReader consultardisponibilidadbodega(string numero)
        {
            return sn.consultardisponibilidadbodega(numero);
        }
        //-----------FinPaula

    }
}
