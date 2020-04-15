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
    public partial class Frm_MantAcreedor : Form
    {
        LIPSCM logic = new LIPSCM();
        Validaciones v = new Validaciones();
        string scampo;
        string slocalIP;
        string smacAddresses;
        string suser;

        public Frm_MantAcreedor(String susuario)
        {
            InitializeComponent();
            //codigo siguiente 
            scampo = logic.siguiente("acreedor", "pkidacreedor");
            //Bitacora
            obtenerip();
            suser = susuario;
            //bloqueo de campos
            bloquear();
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Acreedor";
            Txt_codigoacreedor.Text = scampo;
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

        public void desbloquear()
        {
            //habilita campos para ingreso de datos
            gpb_datos.Enabled = true;
            Btn_guardar.Enabled = true;
            Btn_editar.Enabled = true;
            Btn_borrar.Enabled = true;
        }

        public void bloquear()
        {
            //bloqueo de campos
            gpb_datos.Enabled = false;
            Btn_guardar.Enabled = false;
            Btn_editar.Enabled = false;
            Btn_borrar.Enabled = false;
        }

        public void limpiar()
        {
            Txt_codigoacreedor.Clear();
            Txt_codigoacreedor.Focus();
            Txt_nombre.Clear();
            Txt_telefono.Clear();
            Txt_nit.Clear();
            Txt_email.Clear();
            Cbo_calidadservicio.Text = "";
            Txt_direccion.Clear();
            Cbo_estado.Text = "";

        }

        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            desbloquear();
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            OdbcDataReader cita = logic.modificaracreedor(Txt_codigoacreedor.Text, Txt_nombre.Text, Txt_telefono.Text, Txt_nit.Text, Txt_email.Text, Txt_direccion.Text, Cbo_calidadservicio.Text, Cbo_estado.Text);
            logic.bitacora("0", slocalIP, smacAddresses, suser, "SCM", DateTime.Now.ToString("G"), "Modificar", this.GetType().Name);
            MessageBox.Show("Datos modificados correctamente.");
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            OdbcDataReader cita = logic.insertaracreedor(Txt_codigoacreedor.Text, Txt_nombre.Text, Txt_telefono.Text, Txt_nit.Text, Txt_email.Text, Txt_direccion.Text, Cbo_calidadservicio.Text, Cbo_estado.Text);
            MessageBox.Show("Datos registrados.");
            MessageBox.Show(Txt_codigoacreedor.Text+ Txt_nombre.Text + Txt_telefono.Text+ Txt_nit.Text+ Txt_email.Text+ Txt_direccion.Text+ Cbo_calidadservicio.Text+ Cbo_estado.Text);
          
            logic.bitacora("0", slocalIP, smacAddresses, suser, "SCM", DateTime.Now.ToString("G"), "Guardar", this.GetType().Name);
            limpiar();
        }

        private void Btn_borrar_Click(object sender, EventArgs e)
        {
            OdbcDataReader cita = logic.eliminaracreedor(Txt_codigoacreedor.Text);
            logic.bitacora("0", slocalIP, smacAddresses, suser, "SCM", DateTime.Now.ToString("G"), "Eliminar", this.GetType().Name);
            MessageBox.Show("Eliminado Correctamentee.");
        }

        private void Btn_consultar_Click(object sender, EventArgs e)
        {
            Frm_consultaAcreedor acreedores = new Frm_consultaAcreedor();
            acreedores.ShowDialog();

            if (acreedores.DialogResult == DialogResult.OK)
            {
                Txt_codigoacreedor.Text = acreedores.Dgv_consultaAcreedores.Rows[acreedores.Dgv_consultaAcreedores.CurrentRow.Index].
                      Cells[0].Value.ToString();
                Txt_nombre.Text = acreedores.Dgv_consultaAcreedores.Rows[acreedores.Dgv_consultaAcreedores.CurrentRow.Index].
                      Cells[1].Value.ToString();
                Txt_telefono.Text = acreedores.Dgv_consultaAcreedores.Rows[acreedores.Dgv_consultaAcreedores.CurrentRow.Index].
                      Cells[2].Value.ToString();
                Txt_nit.Text = acreedores.Dgv_consultaAcreedores.Rows[acreedores.Dgv_consultaAcreedores.CurrentRow.Index].
                      Cells[3].Value.ToString();
                Txt_email.Text = acreedores.Dgv_consultaAcreedores.Rows[acreedores.Dgv_consultaAcreedores.CurrentRow.Index].
                      Cells[4].Value.ToString();
                Txt_direccion.Text = acreedores.Dgv_consultaAcreedores.Rows[acreedores.Dgv_consultaAcreedores.CurrentRow.Index].
                      Cells[5].Value.ToString();
                Cbo_calidadservicio.Text = acreedores.Dgv_consultaAcreedores.Rows[acreedores.Dgv_consultaAcreedores.CurrentRow.Index].
                      Cells[6].Value.ToString();
                Cbo_estado.Text = acreedores.Dgv_consultaAcreedores.Rows[acreedores.Dgv_consultaAcreedores.CurrentRow.Index].
                     Cells[7].Value.ToString();
            }
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Txt_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.CampoNumerico(e);
        }
    }
}
