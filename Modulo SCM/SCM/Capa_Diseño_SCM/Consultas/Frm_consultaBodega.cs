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
    public partial class Frm_consultaBodega : Form
    {
        public Frm_consultaBodega()
        {
            InitializeComponent();
            MostrarConsulta();
        }

        LIPSCM logic = new LIPSCM();

        public void MostrarConsulta()
        {
            OdbcDataReader mostrarDatos = logic.ConsultaBodega();
            try
            {
                while (mostrarDatos.Read())
                {

                    Dgv_consultaBodega.Rows.Add(mostrarDatos.GetString(0), mostrarDatos.GetString(1), mostrarDatos.GetString(2), mostrarDatos.GetString(3), mostrarDatos.GetString(4), mostrarDatos.GetString(5), mostrarDatos.GetString(6), mostrarDatos.GetString(7));

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

        private void Frm_consultaBodega_Load(object sender, EventArgs e)
        {
            Dgv_consultaBodega.Rows.Clear();
            MostrarConsulta();
        }

        private void Btn_seleccionar_Click(object sender, EventArgs e)
        {
            if (Dgv_consultaBodega.Rows.Count == 0)
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
            Dgv_consultaBodega.Rows.Clear();
            MostrarConsulta();
        }

        private void Dgv_consultaBodega_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
