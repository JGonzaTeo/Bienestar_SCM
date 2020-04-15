using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using Capa_Logica_SCM;

namespace Capa_Diseño_SCM
{
    public partial class Frm_ExistenciasProducto : Form
    {
        LACSCM logic = new LACSCM();
        public Frm_ExistenciasProducto()
        {
            InitializeComponent();
        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_Ayuda_Click(object sender, EventArgs e)
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

        private void Txt_entrada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void Txt_salida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void Txt_minimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void Txt_maximo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            // BUSCA EL PRODUCTO
            /*
            Frm_consultaProducto des = new Frm_consultaProducto();
            des.ShowDialog();

            if (des.DialogResult == DialogResult.OK)
            {
               Txt_productoMovInt.Text = des.Dgv_consultaProducto.Rows[des.Dgv_consultaProducto.CurrentRow.Index].
                     Cells[2].Value.ToString();
            } 
            */
        }

        private void Btn_agregar_Click(object sender, EventArgs e)
        {
            try
            {
                OdbcDataReader encabezadoM = logic.InsertarExistenciaProducto(Txt_entrada.Text, Txt_salida.Text, Txt_minimo.Text,
                    Txt_maximo.Text);
                MessageBox.Show("Datos Guardados.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Mensaje de error: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
