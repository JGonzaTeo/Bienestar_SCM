using Capa_Datos_SCM;
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
    public partial class Frm_MantTransporte : Form
    {
        LIPSCM logic = new LIPSCM();
        Validaciones v = new Validaciones();
        string scampo;
        string slocalIP;
        string smacAddresses;
        string suser;

        public Frm_MantTransporte(String susuario)
        {
            InitializeComponent();
            //---------- CARGAR COMBOBOX DE RUTAS
            try
            {
                Cbo_ruta.Text = "Rutas";
                Cbo_ruta.Items.Clear();

                Conexion conexion = new Conexion();
                string consultaMostrar = "select * from ruta where estado='1' ;";
                OdbcCommand comm = new OdbcCommand(consultaMostrar, conexion.conexionbd());
                OdbcDataReader mostrarDatos = comm.ExecuteReader();

                while (mostrarDatos.Read())
                {
                    Cbo_ruta.Refresh();
                    Cbo_ruta.Items.Add(mostrarDatos.GetValue(1).ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //------------
            //------------ CARGAR COMBOBOX DE TIPO TRANSPORTE
            try
            {
                Cbo_tipotransporte.Text = "Tipo Transporte";
                Cbo_tipotransporte.Items.Clear();

                Conexion conexion = new Conexion();
                string consultaMostrar = "select * from tipotransporte where estado='1' ;";
                OdbcCommand comm = new OdbcCommand(consultaMostrar, conexion.conexionbd());
                OdbcDataReader mostrarDatos = comm.ExecuteReader();

                while (mostrarDatos.Read())
                {
                    Cbo_tipotransporte.Refresh();
                    Cbo_tipotransporte.Items.Add(mostrarDatos.GetValue(1).ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //--------
            //codigo siguiente 
            scampo = logic.siguiente("transporte", "pkidtransporte");
            //Bitacora
            obtenerip();
            suser = susuario;
            //bloqueo de campos
            bloquear();
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Transporte";
            Txt_codigotransporte.Text = scampo;
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
            MessageBox.Show("Para el ingreso de transporte se debe ingresar antes rutas y tipos de transportes en sus dichos mantenimientos");
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
            Txt_codigotransporte.Clear();
            Txt_codigotransporte.Focus();
            Txt_motor.Clear();
            Txt_placa.Clear();
            Txt_chasis.Clear();
            Cbo_estado.Text = "";
        }

        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            desbloquear();
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            OdbcDataReader cita = logic.modificartransporte(Txt_codigotransporte.Text, Cbo_ruta.Text, Cbo_tipotransporte.Text, Txt_placa.Text, Txt_chasis.Text, Txt_motor.Text, Cbo_estado.Text);
            logic.bitacora("0", slocalIP, smacAddresses, suser, "SCM", DateTime.Now.ToString("G"), "Modificar", this.GetType().Name);
            MessageBox.Show("Datos modificados correctamente.");
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Cbo_ruta.Text);
            MessageBox.Show(Cbo_tipotransporte.Text);
            
           /* OdbcDataReader cit2 = logic.consultartransporte2(Cbo_ruta.Text);
            OdbcDataReader cit1 = logic.consultartransporte3(Cbo_tipotransporte.Text);
            MessageBox.Show(cit2);
            MessageBox.Show(cit1);
            string ruta = cit2.GetString(0);
            string transporte = cit1.GetString(0);
            */
           // OdbcDataReader cita = logic.insertartransporte(Txt_codigotransporte.Text, ruta, transporte, Txt_placa.Text, Txt_chasis.Text, Txt_motor.Text, Cbo_estado.Text);
            MessageBox.Show("Datos registrados.");
            logic.bitacora("0", slocalIP, smacAddresses, suser, "SCM", DateTime.Now.ToString("G"), "Guardar", this.GetType().Name);
            limpiar();
        }

        private void Btn_borrar_Click(object sender, EventArgs e)
        {
            OdbcDataReader cita = logic.eliminartransporte(Txt_codigotransporte.Text);
            logic.bitacora("0", slocalIP, smacAddresses, suser, "SCM", DateTime.Now.ToString("G"), "Eliminar", this.GetType().Name);
            MessageBox.Show("Eliminado Correctamentee.");
        }

        private void Btn_consultar_Click(object sender, EventArgs e)
        {
            Frm_consultaTransporte transporte = new Frm_consultaTransporte();
            transporte.ShowDialog();

            if (transporte.DialogResult == DialogResult.OK)
            {
                Txt_codigotransporte.Text = transporte.Dgv_consultaTransporte.Rows[transporte.Dgv_consultaTransporte.CurrentRow.Index].
                      Cells[0].Value.ToString();
                Cbo_ruta.Text = transporte.Dgv_consultaTransporte.Rows[transporte.Dgv_consultaTransporte.CurrentRow.Index].
                      Cells[1].Value.ToString();
                Cbo_tipotransporte.Text = transporte.Dgv_consultaTransporte.Rows[transporte.Dgv_consultaTransporte.CurrentRow.Index].
                      Cells[2].Value.ToString();
                Txt_placa.Text = transporte.Dgv_consultaTransporte.Rows[transporte.Dgv_consultaTransporte.CurrentRow.Index].
                      Cells[3].Value.ToString();
                Txt_chasis.Text = transporte.Dgv_consultaTransporte.Rows[transporte.Dgv_consultaTransporte.CurrentRow.Index].
                      Cells[4].Value.ToString();
                Txt_motor.Text = transporte.Dgv_consultaTransporte.Rows[transporte.Dgv_consultaTransporte.CurrentRow.Index].
                      Cells[5].Value.ToString();
                Cbo_estado.Text = transporte.Dgv_consultaTransporte.Rows[transporte.Dgv_consultaTransporte.CurrentRow.Index].
                      Cells[6].Value.ToString();
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

        private void Cbo_tipotransporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Cbo_ruta_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
