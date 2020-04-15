
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

namespace Capa_Diseño_SCM.Consultas
{
    public partial class Frm_consultaProducto : Form
    {
        LIPSCM logic = new LIPSCM();

        public Frm_consultaProducto()
        {
            InitializeComponent();
        }

        public void MostrarConsulta()
        {
            OdbcDataReader mostrar = logic.consultaproducto();
            try
            {
                while (mostrar.Read())
                {
                    Dgv_consultaProd.Rows.Add(mostrar.GetString(0), mostrar.GetString(1), mostrar.GetString(2), mostrar.GetString(3), mostrar.GetString(4), mostrar.GetString(5), mostrar.GetString(6), mostrar.GetString(7), mostrar.GetString(8), mostrar.GetString(9), mostrar.GetString(10));
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Btn_actualizar_Click(object sender, EventArgs e)
        {
            Dgv_consultaProd.Rows.Clear();
            MostrarConsulta();
        }

        private void Btn_seleccionar_Click(object sender, EventArgs e)
        {
            if (Dgv_consultaProd.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
