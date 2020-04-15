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
    public partial class Frm_MovInvDetalle : Form
    {
        LACSCM logic = new LACSCM();
        public Frm_MovInvDetalle()
        {
            InitializeComponent();
            DateTime fechaHoy = DateTime.Now;
            string fechaMovInv = fechaHoy.ToString("yyyy/MM/dd");
            Txt_fechaMov.Text = fechaMovInv;
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

        private void Txt_precioPro_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Txt_cantidadPro_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Txt_costoPro_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            // GUARDA EL ENCABEZADO DEL MOVIMIENTO
            try
            {
                OdbcDataReader encabezadoM = logic.InsertarEncabezadoMovimiento(Txt_codigoMov.Text, Txt_nombreMov.Text, Txt_fechaMov.Text,
                    Txt_tipoMov.Text, Txt_estadoMov.Text, Txt_descripcionMov.Text);
                MessageBox.Show("Datos Guardados.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Mensaje de error: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public float sumaPrecio = 0;
        public float sumaCosto = 0;
        private void Btn_agregar_Click(object sender, EventArgs e)
        {
            // AGREGA EL PRODUCTO AL DATA Y GUARDA EL DETALLE DEL MOVIMIENTO
            //DGV

            //GUARDA EL DETALLE DEL MOVIMIENTO
            try
            {
                OdbcDataReader encabezadoM = logic.InsertarDetalleMovimiento(Txt_conceptoPro.Text, Txt_precioPro.Text, Txt_costoPro.Text,
                    Txt_cantidadPro.Text);
                MessageBox.Show("Datos Guardados.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Mensaje de error: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //SUMA DE LA COLUMNA DEL DATA GRID
            const int columnaPrecio = 4;
            const int columnaCosto = 5;
            foreach (DataGridViewRow row in Dgv_MovIntDetalles.Rows)
            {
                sumaPrecio += (int)row.Cells[columnaPrecio].Value;
                sumaCosto += (int)row.Cells[columnaCosto].Value;
            }
            Txt_precioTotal.Text = sumaPrecio.ToString();
            Txt_costoTotal.Text = sumaCosto.ToString();
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            // SE SELECCIONA UN ELEMENTO DEL DATA PARA ELIMINARLO
            Dgv_MovIntDetalles.Rows.Remove(Dgv_MovIntDetalles.CurrentRow);
        }
    }
}