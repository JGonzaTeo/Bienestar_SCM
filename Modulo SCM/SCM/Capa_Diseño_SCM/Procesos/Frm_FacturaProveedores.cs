using Capa_Logica_SCM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Diseño_SCM
{
    public partial class Frm_FacturaProveedores : Form
    {
        string sUsuario, sCODOrden;
        LIFSCM logic = new LIFSCM();
        public Frm_FacturaProveedores(string Usuario, string CodOrdenEncabezado)
        {
            InitializeComponent();
            sUsuario = Usuario;
            sCODOrden = CodOrdenEncabezado;
            OdbcDataReader mostrar = logic.consultaProveedorOrden(sCODOrden);
            string[] aValores = new string[4];
            string sCampo;
            try
            {
                aValores[0] = mostrar.GetString(0);
                sCampo = mostrar.GetString(0);
                MessageBox.Show(sCampo);
                aValores[1] = mostrar.GetString(1);
                aValores[2] = mostrar.GetString(2);
                MessageBox.Show(aValores[0] + aValores[1] + aValores[2]);
                txt_CODproveedor.Text = aValores[0];
                txt_Nombreproveedor.Text = aValores[1];
                txt_nit.Text = aValores[2];
                /*
                while (mostrar.Read())
                {
                    
                }
                */
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }

        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Frm_FacturaProveedores_Load(object sender, EventArgs e)
        {
            Txt_Cod.Text = sCODOrden;
            txt_CODUsuario.Text = sUsuario;
            
        }
    }
}
