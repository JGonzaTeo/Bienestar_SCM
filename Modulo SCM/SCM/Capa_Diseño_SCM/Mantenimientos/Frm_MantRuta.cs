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
    public partial class Frm_MantRuta : Form
    {
        LIPSCM logic = new LIPSCM();
        string scampo;
        string slocalIP;
        string smacAddresses;
        string suser;

        public Frm_MantRuta(String susuario)
        {
            InitializeComponent();
            //codigo siguiente 
            scampo = logic.siguiente("ruta", "pkidruta");
            //Bitacora
            obtenerip();
            suser = susuario;
            //bloqueo de campos
            bloquearcampos();
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Ruta";
            Txt_codigoruta.Text = scampo;
        }


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

        public void bloquearcampos()
        {
            gpb_datos.Enabled = false;
            Btn_guardar.Enabled = false;
            Btn_editar.Enabled = false;
            Btn_borrar.Enabled = false;
        }

        public void desbloquearcampos()
        {
            gpb_datos.Enabled = true;
            Btn_guardar.Enabled = true;
            Btn_editar.Enabled = true;
            Btn_borrar.Enabled = true;
        }

        public void limpiar()
        {
            Txt_codigoruta.Clear();
            Txt_codigoruta.Focus();
            Txt_nombre.Clear();
            Txt_descripcion.Clear();
        }

        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            desbloquearcampos();
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            if (Cbo_estado.Text == "Activo")
            {
                Cbo_estado.Text = "1";
            }
            else
            {
                Cbo_estado.Text = "0";
            }
            OdbcDataReader cita = logic.modificarruta(Txt_codigoruta.Text, Txt_nombre.Text, Txt_descripcion.Text, Cbo_estado.Text);
            logic.bitacora("0", slocalIP, smacAddresses, suser, "SCM", DateTime.Now.ToString("G"), "Modificar", this.GetType().Name);
            MessageBox.Show("Datos modificados correctamente.");
            limpiar();
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            if (Cbo_estado.Text == "Activo")
            {
                Cbo_estado.Text = "1";
            }
            else
            {
                Cbo_estado.Text = "0";
            }
            OdbcDataReader cita = logic.insertarruta(Txt_codigoruta.Text, Txt_nombre.Text, Txt_descripcion.Text, Cbo_estado.Text);
            logic.bitacora("0", slocalIP, smacAddresses, suser, "SCM", DateTime.Now.ToString("G"), "Guardar", this.GetType().Name);
            MessageBox.Show("Datos registrados correctamente.");
            limpiar();
        }

        private void Btn_borrar_Click(object sender, EventArgs e)
        {
            if (Cbo_estado.Text == "Activo")
            {
                Cbo_estado.Text = "1";
            }
            else
            {
                Cbo_estado.Text = "0";
            }
            OdbcDataReader cita = logic.eliminarruta(Txt_codigoruta.Text);
            logic.bitacora("0", slocalIP, smacAddresses, suser, "SCM", DateTime.Now.ToString("G"), "Eliminar", this.GetType().Name);
            MessageBox.Show("Datos eliminados correctamente.");
            limpiar();
        }

        private void Btn_consultar_Click(object sender, EventArgs e)
        {
            Frm_consultaRuta ruta = new Frm_consultaRuta();
            ruta.ShowDialog();

            if (ruta.DialogResult == DialogResult.OK)
            {
                Txt_codigoruta.Text = ruta.Dgv_consultaRuta.Rows[ruta.Dgv_consultaRuta.CurrentRow.Index].
                      Cells[0].Value.ToString();
                Txt_nombre.Text = ruta.Dgv_consultaRuta.Rows[ruta.Dgv_consultaRuta.CurrentRow.Index].
                      Cells[1].Value.ToString();
                Txt_descripcion.Text = ruta.Dgv_consultaRuta.Rows[ruta.Dgv_consultaRuta.CurrentRow.Index].
                      Cells[2].Value.ToString();
                Cbo_estado.Text = ruta.Dgv_consultaRuta.Rows[ruta.Dgv_consultaRuta.CurrentRow.Index].
                      Cells[3].Value.ToString();
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

        private void btn_Ayuda_Click(object sender, EventArgs e)
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
    }
}
