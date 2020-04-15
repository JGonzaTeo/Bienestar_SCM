using Capa_Diseño_SCM.Consultas;
using Capa_Logica_SCM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Diseño_SCM.Mantenimientos
{
    public partial class Frm_MantBodega : Form
    {
        public Frm_MantBodega()
        {
            InitializeComponent();
            bloqueartxt();
            scampo = logic.siguiente("Bodega", "pkidBodega");
            Txt_IdP.Text = scampo;
            Cbo_estado.Items.Add("0");
            Cbo_estado.Items.Add("1");
        }

        LIPSCM logic = new LIPSCM();
        Validaciones v = new Validaciones();
        string scampo;
        string slocalIP;
        string smacAddresses;
        string suser;

        public void obtenerip()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    slocalIP = ip.ToString();
                }
            }
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (nic.OperationalStatus == OperationalStatus.Up)
                {
                    smacAddresses += nic.GetPhysicalAddress().ToString();
                    break;

                }
            }
        }


        public void bloqueartxt()
        {
            /*------------------------*/
            Btn_guardar.Enabled = false;
            Btn_editar.Enabled = false;
            Btn_borrar.Enabled = false;
            /*------------------------*/
            Txt_IdP.Enabled = false;
            Txt_nombre.Enabled = false;
            Txt_Direccion.Enabled = false;
            Txt_Telefono.Enabled = false;
            Txt_Email.Enabled = false;
            Txt_StockMax.Enabled = false;
            Txt_StockMin.Enabled = false;

            Cbo_estado.Enabled = false;

        }
        public void desbloqueartxt()
        {
            /*------------------------*/
            Btn_guardar.Enabled = true;
            Btn_editar.Enabled = true;
            Btn_borrar.Enabled = true;
            /*------------------------*/
            Txt_nombre.Enabled = true;
            Txt_Direccion.Enabled = true;
            Txt_Telefono.Enabled = true;
            Txt_Email.Enabled = true;
            Txt_StockMax.Enabled = true;
            Txt_StockMin.Enabled = true;

            Cbo_estado.Enabled = true;
        }

        public void limpiar()
        {
            Txt_IdP.Text = "";
            Txt_nombre.Text = "";
            Txt_Direccion.Text = "";
            Txt_Telefono.Text = "";
            Txt_Email.Text = "";
            Txt_StockMax.Text = "";
            Txt_StockMin.Text = "";

            Cbo_estado.Text = "";

        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            desbloqueartxt();
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            OdbcDataReader cita = logic.ModificarBodega(Txt_IdP.Text, Txt_nombre.Text, Txt_Direccion.Text, Txt_Telefono.Text, Txt_Email.Text, Txt_StockMax.Text, Txt_StockMin.Text, Cbo_estado.Text);
            logic.bitacora("0", slocalIP, smacAddresses, suser, "SCM", DateTime.Now.ToString("G"), "Modificar", this.GetType().Name);
            MessageBox.Show("Datos modificados correctamente.");
            limpiar();
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            OdbcDataReader cita = logic.InsertarBodega(Txt_IdP.Text, Txt_nombre.Text, Txt_Direccion.Text, Txt_Telefono.Text, Txt_Email.Text, Txt_StockMax.Text, Txt_StockMin.Text, Cbo_estado.Text);
            MessageBox.Show("Datos registrados.");
            logic.bitacora("0", slocalIP, smacAddresses, suser, "SCM", DateTime.Now.ToString("G"), "Guardar", this.GetType().Name);
            limpiar();
        }

        private void Btn_borrar_Click(object sender, EventArgs e)
        {
            OdbcDataReader cita = logic.EliminaBodega(Txt_IdP.Text);
            logic.bitacora("0", slocalIP, smacAddresses, suser, "SCM", DateTime.Now.ToString("G"), "Eliminar", this.GetType().Name);
            MessageBox.Show("Eliminado Correctamentee.");
            limpiar();
        }

        private void Btn_consultar_Click(object sender, EventArgs e)
        {
            Frm_consultaBodega concep = new Frm_consultaBodega();
            concep.ShowDialog();

            if (concep.DialogResult == DialogResult.OK)
            {

                Txt_IdP.Text = concep.Dgv_consultaBodega.Rows[concep.Dgv_consultaBodega.CurrentRow.Index].
                      Cells[0].Value.ToString();
                Txt_nombre.Text = concep.Dgv_consultaBodega.Rows[concep.Dgv_consultaBodega.CurrentRow.Index].
                      Cells[1].Value.ToString();
                Txt_Direccion.Text = concep.Dgv_consultaBodega.Rows[concep.Dgv_consultaBodega.CurrentRow.Index].
                      Cells[2].Value.ToString();
                Txt_Telefono.Text = concep.Dgv_consultaBodega.Rows[concep.Dgv_consultaBodega.CurrentRow.Index].
                      Cells[3].Value.ToString();
                Txt_Email.Text = concep.Dgv_consultaBodega.Rows[concep.Dgv_consultaBodega.CurrentRow.Index].
                     Cells[4].Value.ToString();
                Txt_StockMax.Text = concep.Dgv_consultaBodega.Rows[concep.Dgv_consultaBodega.CurrentRow.Index].
                    Cells[5].Value.ToString();
                Txt_StockMin.Text = concep.Dgv_consultaBodega.Rows[concep.Dgv_consultaBodega.CurrentRow.Index].
                    Cells[6].Value.ToString();
                Cbo_estado.Text = concep.Dgv_consultaBodega.Rows[concep.Dgv_consultaBodega.CurrentRow.Index].
                    Cells[7].Value.ToString();

            }
        }

        private void Txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.CamposLetras(e);
        }

        private void Txt_Direccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.CamposNumerosYLetras(e);
        }

        private void Txt_Telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.CampoNumerico(e);
        }

        private void Txt_Email_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.CamposNumerosYLetras(e);
        }

        private void Txt_StockMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.CampoNumerico(e);
        }

        private void Txt_StockMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.CampoNumerico(e);
        }

        private void Btn_Ayuda_Click(object sender, EventArgs e)
        {
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
        }

        private void Txt_nombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
