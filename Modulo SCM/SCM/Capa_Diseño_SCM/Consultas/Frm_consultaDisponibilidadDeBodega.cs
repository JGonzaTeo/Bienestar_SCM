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
    public partial class Frm_consultaDisponibilidadDeBodega : Form
    {
        LIPSCM logic = new LIPSCM();
        public Frm_consultaDisponibilidadDeBodega()
        {
            InitializeComponent();
            Dgv_consultaDisponibilidadBodega.Rows.Clear();
            MostrarTabla();
        }

        public void MostrarTabla()
        {
            OdbcDataReader mostrar = logic.consultardisponibilidadbodega("1");
            try
            {
                while (mostrar.Read())
                {
                    Dgv_consultaDisponibilidadBodega.Rows.Add(mostrar.GetString(0), mostrar.GetString(1));
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }

        private void Btn_actualizar_Click(object sender, EventArgs e)
        {
            Dgv_consultaDisponibilidadBodega.Rows.Clear();
            MostrarTabla();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_Ayuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ayuda no disponble");
        }

        private void Frm_consultaDisponibilidadDeBodega_Load(object sender, EventArgs e)
        {
            Dgv_consultaDisponibilidadBodega.Rows.Clear();
            MostrarTabla();
        }
    }
}
