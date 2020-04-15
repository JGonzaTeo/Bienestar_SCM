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
    public partial class Frm_consultaTransporte : Form
    {
        LIPSCM logic = new LIPSCM();
        public Frm_consultaTransporte()
        {
            InitializeComponent();
            Dgv_consultaTransporte.Rows.Clear();
            MostrarTabla();
        }

        public void MostrarTabla()
        {
            OdbcDataReader mostrar = logic.consultartransporte("1");
            try
            {
                while (mostrar.Read())
                {
                    Dgv_consultaTransporte.Rows.Add(mostrar.GetString(0), mostrar.GetString(1), mostrar.GetString(2), mostrar.GetString(3), mostrar.GetString(4), mostrar.GetString(5), mostrar.GetString(6));
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }

        private void Btn_seleccionar_Click(object sender, EventArgs e)
        {
            if (Dgv_consultaTransporte.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void Btn_actualizar_Click(object sender, EventArgs e)
        {
            Dgv_consultaTransporte.Rows.Clear();
            MostrarTabla();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Ayuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ayuda no disponible");
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Frm_consultaTransporte_Load(object sender, EventArgs e)
        {
            Dgv_consultaTransporte.Rows.Clear();
            MostrarTabla();
        }
    }
}
