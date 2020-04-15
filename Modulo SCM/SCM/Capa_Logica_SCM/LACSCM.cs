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
        public OdbcDataReader InsertarMovimientoEncabezado(string sCodigo, string sCODEmpleado, string fecha)
        {
            return sn.InsertarMovimientoEncabezado(sCodigo, sCODEmpleado, fecha);

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
            return sn.consultaMovimientoEncabezado();
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------//
        //------------------------------------------------------------------------------------------------------INSERTS DETALLE MOVIMIENTO-------------------------------------------------------//
        public OdbcDataReader InsertarDetalleMovimiento(string sCodEncabezado, string sMovGeneral)
        {
            return sn.InsertarMovimientoDetalle(sCodEncabezado,sMovGeneral);
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------//
        //------------------------------------------------------------------------------------------------------INSERTS EXISTENCIA PRODCUTO-------------------------------------------------------//
        public OdbcDataReader InsertarExistenciaProducto(string sEntrada, string sSalida, string sMinimo, string sMaximo)
        {
            return sn.InsertarExistenciaProducto(sEntrada, sSalida, sMinimo, sMaximo);
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------//

        //------------------------------------------------------------------------------------------------------CONSULTAR MOVIMIENTOS-------------------------------------------------------//
        public OdbcDataReader consultaMovimientoGeneral(string fecha)
        {
            return sn.consultaMovimientoGeneral(fecha);
        }

        public OdbcDataReader consultaMovimientoGeneralConcepto(string concepto)
        {
            return sn.consultaMovimientoGeneralConcepto(concepto);
        }

        public OdbcDataReader consultaMovimientoGeneralProducto(string producto)
        {
            return sn.consultaMovimientoGeneralProducto(producto);
        }

    }
}
