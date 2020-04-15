using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos_SCM;
using System.Data.Odbc;

namespace Capa_Logica_SCM
{
   public class LACSCM
    {
        /*---------------------------------------------CAPA ANGEL Y CONNY--------------------------------------*/
        Sentencias sn1 = new Sentencias();
        /*-----------------------------------------------------------------------Metodos Generales------------------------------------------------------------*/
        public string siguiente(string tabla, string campo)
        {
            string llave = sn1.obtenerfinal(tabla, campo);
            return llave;
        }
        public OdbcDataReader bitacora(string sCodigo, string sip, string Smac, string susuario, string sdepartamento, string sfechahora, string saccion, string sformulario)
        {
            return sn1.insertarbitacora(sCodigo, sip, Smac, susuario, sdepartamento, sfechahora, saccion, sformulario);
        }
        public OdbcDataReader consultaayuda(string id)
        {
            return sn1.consultaayudas(id);
        }
        //---------------------------------------------------------------------------------------------------------------------------------------------------------------
        SACSCM sn = new SACSCM();
        //------------------------------------------------------------------------------------------------------INSERTS ENCABEZADO MOVIMIENTOO-------------------------------------------------------//
        public OdbcDataReader InsertarEncabezadoMovimiento(string sCodigo, string sNombre, string sFecha, string sTipo, string sEstado,
            string sDescripcion)
        {
            return sn.InsertarEncabezadoMovimiento(sCodigo, sNombre, sFecha, sTipo, sEstado, sDescripcion);
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------//
        //------------------------------------------------------------------------------------------------------UPDATE ENCABEZADO MOVIMIENTO-------------------------------------------------------//
        public OdbcDataReader ModificarEncabezadoMovimiento(string sCodigo, string sNombre, string sFecha, string sTipo, string sEstado,
            string sDescripcion)
        {
            return sn.ModificarEncabezadoMovimiento(sCodigo, sNombre, sFecha, sTipo, sEstado, sDescripcion);
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------//
        //------------------------------------------------------------------------------------------------------CONSULTA ENCABEZADO MOVIMIENTO-------------------------------------------------------//
        public OdbcDataReader consultaEncabezadoMovimiento()
        {
            return sn.ConsultaEncabezadoMovimiento();
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------//
        //------------------------------------------------------------------------------------------------------INSERTS DETALLE MOVIMIENTO-------------------------------------------------------//
        public OdbcDataReader InsertarDetalleMovimiento(string sConcepto, string sPrecio, string sCosto, string sCantidad)
        {
            return sn.InsertarDetalleMovimiento(sConcepto,sPrecio,sCosto,sCantidad);
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------//
        //------------------------------------------------------------------------------------------------------INSERTS EXISTENCIA PRODCUTO-------------------------------------------------------//
        public OdbcDataReader InsertarExistenciaProducto(string sEntrada, string sSalida, string sMinimo, string sMaximo)
        {
            return sn.InsertarDetalleMovimiento(sEntrada, sSalida, sMinimo, sMaximo);
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------//


    }
}
