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
        string scampo;
        LACSCM logic = new LACSCM();
        public Frm_MovInvDetalle()
        {
            InitializeComponent();
            scampo = logic.siguiente("movimiento_encabezado", "pkidMovimiento");
            DateTime fechaHoy = DateTime.Now;
            string fechaMovInv = fechaHoy.ToString("yyyy-MM-dd");
            Txt_fechaMov.Text = fechaMovInv;
            Txt_codigoMov.Text = scampo;
            Dgv_MovIntDetalles.Rows.Clear();
            MostrarConsulta();
        }


        public void MostrarConsulta()
        {
            OdbcDataReader mostrar = logic.consultaMovimientoGeneral(Txt_fechaMov.Text);
            
            try
            {
                while (mostrar.Read())
                {
                    Dgv_MovIntDetalles.Rows.Add(mostrar.GetString(0),mostrar.GetString(1), mostrar.GetString(2), mostrar.GetString(3), mostrar.GetString(4), mostrar.GetString(5), mostrar.GetString(6), mostrar.GetString(7));
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }

        public void MostrarConsultaConcepto()
        {
            OdbcDataReader mostrar = logic.consultaMovimientoGeneralConcepto(Txt_nombreConcep.Text);

            try
            {
                while (mostrar.Read())
                {
                    Dgv_MovIntDetalles.Rows.Add(mostrar.GetString(0), mostrar.GetString(1), mostrar.GetString(2), mostrar.GetString(3), mostrar.GetString(4), mostrar.GetString(5), mostrar.GetString(6), mostrar.GetString(7));
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }


        public void MostrarConsultaProducto()
        {
            OdbcDataReader mostrar = logic.consultaMovimientoGeneralProducto(txt_CodProducto.Text);

            try
            {
                while (mostrar.Read())
                {
                    Dgv_MovIntDetalles.Rows.Add(mostrar.GetString(0), mostrar.GetString(1), mostrar.GetString(2), mostrar.GetString(3), mostrar.GetString(4), mostrar.GetString(5), mostrar.GetString(6), mostrar.GetString(7));
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
                OdbcDataReader encabezadoM = logic.InsertarMovimientoEncabezado(Txt_codigoMov.Text, Txt_codEmpleado.Text, Txt_fechaMov.Text);
                MessageBox.Show("Datos Guardados.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Mensaje de error: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (Dgv_MovIntDetalles.Rows.Count == 0 || string.IsNullOrEmpty(Txt_codEmpleado.Text))
            {
                MessageBox.Show("Hay un campo sin completar, por favor completarlo para continuar.");
            }
            else
            {
                try
                {
                    OdbcDataReader encabezadoM = logic.InsertarMovimientoEncabezado(Txt_codigoMov.Text, Txt_codEmpleado.Text, Txt_fechaMov.Text);
                    

                    foreach (DataGridViewRow row in Dgv_MovIntDetalles.Rows)
                    {
                        OdbcDataReader ingreso = logic.InsertarDetalleMovimiento(Txt_codigoMov.Text, row.Cells[0].Value.ToString());
                    }

                    
                    MessageBox.Show("Datos ingresados correctamente.");
                    
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message + ". Consulte con soporte tecnico.");
                }
            }






        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
           
        }

       

        private void Frm_MovInvDetalle_Load(object sender, EventArgs e)
        {
            Dgv_MovIntDetalles.Rows.Clear();
            MostrarConsulta();
        }

        private void Btn_Actualizar_Click(object sender, EventArgs e)
        {
            Dgv_MovIntDetalles.Rows.Clear();
            MostrarConsulta();
            txt_CodProducto.Text = " ";
            Txt_nombreConcep.Text = " ";
        }

        private void Btn_buscarC_Click(object sender, EventArgs e)
        {
            Dgv_MovIntDetalles.Rows.Clear();
            MostrarConsultaConcepto();
            
        }

        public int sumaExistencias = 0;
        private void Btn_buscarP_Click(object sender, EventArgs e)
        {
            Dgv_MovIntDetalles.Rows.Clear();
            MostrarConsultaProducto();
            const int columnaCantidad = 5;
            foreach (DataGridViewRow row in Dgv_MovIntDetalles.Rows)
            {
                sumaExistencias += Convert.ToInt32(row.Cells[columnaCantidad].Value);
                
            }
            txt_Existencias.Text = sumaExistencias.ToString();
            
        }
    }
}