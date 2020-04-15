using Capa_Diseño_SCM.Consultas;
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
        double dImpuesto = 0;
        double dSubTotal = 0;
        string sCampo;
        public Frm_FacturaProveedores(string Usuario, string CodOrdenEncabezado)
        {
            InitializeComponent();
            sUsuario = Usuario;
            sCODOrden = CodOrdenEncabezado;

        }
        void llenarEncabezado()
        {
            //LLENADO DE DATOS DEL LA ORDEN DE COMPRA
            OdbcDataReader mostrar = logic.consultaProveedorOrden(sCODOrden);
            string[] aValores = new string[4];
            string sCampo;
            try
            {
                aValores[0] = mostrar.GetString(0);
                sCampo = mostrar.GetString(0);
                aValores[1] = mostrar.GetString(1);
                aValores[2] = mostrar.GetString(2);

                txt_CODproveedor.Text = aValores[0];
                txt_Nombreproveedor.Text = aValores[1];
                txt_nit.Text = aValores[2];
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }

        void llenarDetalle()
        {
            
            MessageBox.Show(sCODOrden);
            OdbcDataReader mostrar = logic.consultaDetalleOrden(sCODOrden);
            try
            {
                while (mostrar.Read())
                {               
                    Dgv_pedido.Rows.Add(mostrar.GetString(0), mostrar.GetString(1), mostrar.GetString(2), mostrar.GetString(3));
                }
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

        private void dtp_fecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_buscarI_Click(object sender, EventArgs e)
        {
            Frm_consultaImpuesto concep = new Frm_consultaImpuesto();
            concep.ShowDialog();

            if (concep.DialogResult == DialogResult.OK)
            {
                txt_codImpuesto.Text = concep.Dgv_consulta.Rows[concep.Dgv_consulta.CurrentRow.Index].
                      Cells[0].Value.ToString();
                txt_nombreImpuesto.Text = concep.Dgv_consulta.Rows[concep.Dgv_consulta.CurrentRow.Index].
                      Cells[1].Value.ToString();
                txt_valor.Text = concep.Dgv_consulta.Rows[concep.Dgv_consulta.CurrentRow.Index].
                      Cells[3].Value.ToString();
            }
            if (string.IsNullOrEmpty(txt_valor.Text))
            {
                MessageBox.Show("Debe de seleccionar un impuesto para continuar.");
            }else
            {
                Dgv_entregado.Enabled = true;
                Dgv_pedido.Enabled = true;
                dImpuesto = dSubTotal * Convert.ToDouble(txt_valor.Text);

                txt_totalImpuesto.Text = (Convert.ToString(dImpuesto));

                txt_total.Text = (Convert.ToString(dImpuesto + dSubTotal));
            }
        }

        private void Btn_pasaUno_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
 
        }

        private void Dgv_pedido_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Dgv_entregado.Rows.Add(Convert.ToString(Dgv_pedido.CurrentRow.Cells[0].Value), Convert.ToString(Dgv_pedido.CurrentRow.Cells[1].Value), Convert.ToString(Dgv_pedido.CurrentRow.Cells[2].Value), Convert.ToString(Dgv_pedido.CurrentRow.Cells[3].Value));
            Dgv_pedido.Rows.Remove(Dgv_pedido.SelectedRows[0]);
            //Variable donde almacenaremos el resultado de la sumatoria.
            dSubTotal = 0;
            //Método con el que recorreremos todas las filas de nuestro Datagridview
            foreach (DataGridViewRow row in Dgv_entregado.Rows)
            {
                //Aquí seleccionaremos la columna que contiene los datos numericos.
                dSubTotal += Convert.ToDouble(row.Cells[3].Value);
            }
            //Por ultimo asignamos el resultado a el texto de nuestro Label
            txt_subTotal.Text = (Convert.ToString(dSubTotal));

            dImpuesto = dSubTotal * Convert.ToDouble(txt_valor.Text);

            txt_totalImpuesto.Text = (Convert.ToString(dImpuesto));

            txt_total.Text = (Convert.ToString(dImpuesto + dSubTotal));

        }

        private void Dgv_entregado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Dgv_pedido.Rows.Add(Convert.ToString(Dgv_entregado.CurrentRow.Cells[0].Value), Convert.ToString(Dgv_entregado.CurrentRow.Cells[1].Value), Convert.ToString(Dgv_entregado.CurrentRow.Cells[2].Value), Convert.ToString(Dgv_entregado.CurrentRow.Cells[3].Value));
         
            Dgv_entregado.Rows.Remove(Dgv_entregado.SelectedRows[0]);
            //Variable donde almacenaremos el resultado de la sumatoria.
            dSubTotal = 0;
            //Método con el que recorreremos todas las filas de nuestro Datagridview
            foreach (DataGridViewRow row in Dgv_entregado.Rows)
            {
                //Aquí seleccionaremos la columna que contiene los datos numericos.
                dSubTotal += Convert.ToDouble(row.Cells[3].Value);
            }
            //Por ultimo asignamos el resultado a el texto de nuestro Label
            txt_subTotal.Text = (Convert.ToString(dSubTotal));

            dImpuesto = dSubTotal * Convert.ToDouble(txt_valor.Text);

            txt_totalImpuesto.Text = (Convert.ToString(dImpuesto));

            txt_total.Text = (Convert.ToString(dImpuesto + dSubTotal));
        }

        private void BTn_guardar_Click(object sender, EventArgs e)
        {
            if (Dgv_entregado.Rows.Count == 0 || string.IsNullOrEmpty(txt_serie.Text) || string.IsNullOrEmpty(txt_codFactura.Text))
            {
                MessageBox.Show("Hay un campo sin completar, por favor completarlo para continuar.");
            }
            else
            {
                try
                {
                    OdbcDataReader cita = logic.ingresoEncabezadoFactura(sCampo, Txt_Cod.Text, txt_CODUsuario.Text, txt_serie.Text, txt_codFactura.Text, dtp_fecha.Text, txt_codImpuesto.Text, txt_totalImpuesto.Text, txt_total.Text);
                    
                    foreach (DataGridViewRow row in Dgv_entregado.Rows){
                        OdbcDataReader ingreso = logic.InsertarFacturaProveedorDetalle(sCampo, row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString());
                    }
                        
                    string sDocumento = "Factura " + " " + txt_serie.Text + " " + txt_codFactura.Text;
                    foreach (DataGridViewRow row in Dgv_entregado.Rows){
                        OdbcDataReader ingreso = logic.InsertarMovimientoGeneral(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), dtp_fecha.Text, sDocumento);
                    }
                    MessageBox.Show("Datos ingresados correctamente.");
                    this.Close();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message + ". Consulte con soporte tecnico.");              
                }
            }

        }

        private void Frm_FacturaProveedores_Load(object sender, EventArgs e)
        {
            sCampo = logic.siguiente("facturaproveedorencabezado", "pkidEncabezadoFacturaP");
            txt_CodFacturaP.Text = sCampo;
            Txt_Cod.Text = sCODOrden;
            txt_CODUsuario.Text = sUsuario;
            dtp_fecha.Format = DateTimePickerFormat.Custom;
            dtp_fecha.CustomFormat = "yyyy/MM/dd";
            llenarEncabezado();
            llenarDetalle();
            Dgv_entregado.Enabled = false;
            Dgv_pedido.Enabled = false;
        }
    }
}
