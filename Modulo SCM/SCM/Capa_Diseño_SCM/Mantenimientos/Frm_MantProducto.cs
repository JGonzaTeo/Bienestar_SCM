using Capa_Logica_SCM;
using CapaDiseño.Consulta;
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
    public partial class Frm_MantProducto : Form
    {
        LIPSCM logic = new LIPSCM();
        Validaciones v = new Validaciones();
        string scampo;
        string slocalIP;
        string smacAddresses;
        string suser;

        public Frm_MantProducto()
        {
            InitializeComponent();
            bloqueartxt();
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

        public void bloqueartxt()
        {
            /*------------------------*/
            Btn_guardar.Enabled = false;
            Btn_editar.Enabled = false;
            Btn_borrar.Enabled = false;
            /*------------------------*/
            Txt_IdP.Enabled = false;
            Txt_nombre.Enabled = false;
            Txt_Costo.Enabled = false;
            Txt_Descripcion.Enabled = false;
            Txt_Existencias.Enabled = false;
            Txt_Precio.Enabled = false;

            Cbo_estado.Enabled = false;
            Cbo_Proveedor.Enabled = false;
            Txt_Presentacion.Enabled = false;

        }
        public void desbloqueartxt()
        {
            /*------------------------*/
            Btn_guardar.Enabled = true;
            Btn_editar.Enabled = true;
            Btn_borrar.Enabled = true;
            /*------------------------*/
            Txt_IdP.Enabled = true;
            Txt_nombre.Enabled = true;
            Txt_Costo.Enabled = true;
            Txt_Descripcion.Enabled = true;
            Txt_Existencias.Enabled = true;
            Txt_Precio.Enabled = true;

            Cbo_estado.Enabled = true;
            Cbo_Proveedor.Enabled = true;
            Txt_Presentacion.Enabled = true;
        }

        public void limpiar()
        {
            Txt_IdP.Text = "";
            Txt_nombre.Text = "";
            Txt_Costo.Text = "";
            Txt_Descripcion.Text = "";
            Txt_Existencias.Text = "";
            Txt_Precio.Text = "";

            Cbo_estado.Text = "";
            Cbo_Proveedor.Text = "";
            Txt_Presentacion.Text = "";
        }

        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            desbloqueartxt();
        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            OdbcDataReader cita = logic.Modificarproducto(Cbo_Proveedor.Text, Txt_IdP.Text, Txt_nombre.Text, Txt_Precio.Text, Txt_Descripcion.Text, Txt_Presentacion.Text, Txt_Costo.Text, Cbo_estado.Text, Cbo_TipoP.Text);
            logic.bitacora("0", slocalIP, smacAddresses, suser, "RRHH", DateTime.Now.ToString("G"), "Modificar", this.GetType().Name);
            MessageBox.Show("Datos modificados correctamente.");
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            OdbcDataReader cita = logic.Insertarproducto(Cbo_Proveedor.Text, Txt_IdP.Text, Txt_nombre.Text, Txt_Precio.Text, Txt_Descripcion.Text, Txt_Presentacion.Text, Txt_Costo.Text, Cbo_estado.Text, Cbo_TipoP.Text);
            MessageBox.Show("Datos registrados.");
            logic.bitacora("0", slocalIP, smacAddresses, suser, "RRHH", DateTime.Now.ToString("G"), "Guardar", this.GetType().Name);
            limpiar();
        }

        private void Btn_borrar_Click(object sender, EventArgs e)
        {
            OdbcDataReader cita = logic.Eliminarproducto(Txt_IdP.Text);
            logic.bitacora("0", slocalIP, smacAddresses, suser, "RRHH", DateTime.Now.ToString("G"), "Eliminar", this.GetType().Name);
            MessageBox.Show("Eliminado Correctamentee.");
        }

        private void Btn_consultar_Click(object sender, EventArgs e)
        {
            Frm_consultaConceptos concep = new Frm_consultaConceptos();
            concep.ShowDialog();

            if (concep.DialogResult == DialogResult.OK)
            {
                Cbo_Proveedor.Text = concep.Dgv_consultaConceptos.Rows[concep.Dgv_consultaConceptos.CurrentRow.Index].
                      Cells[0].Value.ToString();
                Txt_IdP.Text = concep.Dgv_consultaConceptos.Rows[concep.Dgv_consultaConceptos.CurrentRow.Index].
                      Cells[1].Value.ToString();
                Txt_nombre.Text = concep.Dgv_consultaConceptos.Rows[concep.Dgv_consultaConceptos.CurrentRow.Index].
                      Cells[2].Value.ToString();
                Txt_Precio.Text = concep.Dgv_consultaConceptos.Rows[concep.Dgv_consultaConceptos.CurrentRow.Index].
                      Cells[3].Value.ToString();
                Txt_Descripcion.Text = concep.Dgv_consultaConceptos.Rows[concep.Dgv_consultaConceptos.CurrentRow.Index].
                      Cells[4].Value.ToString();
                Txt_Presentacion.Text = concep.Dgv_consultaConceptos.Rows[concep.Dgv_consultaConceptos.CurrentRow.Index].
                     Cells[5].Value.ToString();
                Txt_Costo.Text = concep.Dgv_consultaConceptos.Rows[concep.Dgv_consultaConceptos.CurrentRow.Index].
                    Cells[6].Value.ToString();
                Cbo_estado.Text = concep.Dgv_consultaConceptos.Rows[concep.Dgv_consultaConceptos.CurrentRow.Index].
                    Cells[5].Value.ToString();
                Cbo_TipoP.Text = concep.Dgv_consultaConceptos.Rows[concep.Dgv_consultaConceptos.CurrentRow.Index].
                    Cells[5].Value.ToString();
            }
        }
    }
}
