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
    public partial class Frm_ListaMovInv : Form
    {
        LACSCM logic = new LACSCM();
        public Frm_ListaMovInv()
        {
            InitializeComponent();
            Dgv_listaMovInt.Rows.Clear();
            MostrarConsulta();
        }


        //-----------------------------------------------------------------------------------para mostrar en DGV------------------------------------------------------------------------------
        public void MostrarConsulta()
        {
            OdbcDataReader mostrar = logic.consultaEncabezadoMovimiento();
            try
            {
                while (mostrar.Read())
                {
                    Dgv_listaMovInt.Rows.Add(mostrar.GetString(0), mostrar.GetString(2), mostrar.GetString(3));
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }
        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------


        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_ayuda_Click(object sender, EventArgs e)
        {
            /*
            string ruta = "";
            string indice = "";

            OdbcDataReader mostrarayuda = logic.consultaayuda("2");
            try
            {
                while (mostrarayuda.Read())
                {
                    ruta = mostrarayuda.GetString(1);
                    indice = mostrarayuda.GetString(2);
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }

            Help.ShowHelp(this, ruta, indice);
             */
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            // MOVIMIENTO DE INVENTARIOS VACIO
            Frm_MovInvDetalle MIVacio = new Frm_MovInvDetalle();
            MIVacio.Show();
        }

        private void Btn_consultar_Click(object sender, EventArgs e)
        {
            // MOVIMIENTO DE INVENTARIOS LLENO CON TODOS LOS CAMPOS BLOQUEADOS
            Frm_MovInvDetalle MILlenoBloqueado = new Frm_MovInvDetalle();
            MILlenoBloqueado.Show();
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            // MOVIMIENTO DE INVENTARIOS LLENO CON LOS CAMPOS DESBLOQUEADOS
            Frm_MovInvDetalle MILlenoDesbloqueado = new Frm_MovInvDetalle();
            MILlenoDesbloqueado.Show();
        }

        private void Dgv_listaMovInt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = Dgv_listaMovInt.CurrentCell.RowIndex;
            Dgv_listaMovInt.Rows[fila].Selected = true;

        }

        private void Frm_ListaMovInv_Load(object sender, EventArgs e)
        {
            Dgv_listaMovInt.Rows.Clear();
            MostrarConsulta();
        }
    }
}
