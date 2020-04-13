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

    }
}
