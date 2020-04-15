using Capa_Diseño_SCM.Consultas;
using Capa_Diseño_SCM.Mantenimientos;
using CapaDiseño.Mantenimientos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Diseño_SCM
{
    public partial class MDISCM : Form
    {
        private int childFormNumber = 0;
        string susuario = "usuario";
        public MDISCM()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }
        bool ventanaConceptos = false;
        Frm_MantPercepciones conceptos = new Frm_MantPercepciones("");
        private void PercepcionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_MantPercepciones);
            if (ventanaConceptos == false || frmC == null)
            {
                if (frmC == null)
                {
                    conceptos = new Frm_MantPercepciones(susuario);
                }

                conceptos.MdiParent = this;
                conceptos.Show();
                Application.DoEvents();
                ventanaConceptos = true;
            }
            else
            {
                conceptos.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        private void CerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        bool ventanafactura = false;
        Frm_BusquedaOrdenCompra facturaP = new Frm_BusquedaOrdenCompra("");
        private void ingresoFacturaProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_BusquedaOrdenCompra);
            if (ventanafactura == false || frmC == null)
            {
                if (frmC == null)
                {
                    facturaP = new Frm_BusquedaOrdenCompra(susuario);
                }

                facturaP.MdiParent = this;
                facturaP.Show();
                Application.DoEvents();
                ventanafactura = true;
            }
            else
            {
                facturaP.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaImpuestos = false;
        Frm_MantImpuestos impuestos = new Frm_MantImpuestos("");
        private void impuestosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_MantImpuestos);
            if (ventanaImpuestos == false || frmC == null)
            {
                if (frmC == null)
                {
                    impuestos = new Frm_MantImpuestos(susuario);
                }

                impuestos.MdiParent = this;
                impuestos.Show();
                Application.DoEvents();
                ventanaImpuestos = true;
            }
            else
            {
                impuestos.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaExistencia = false;
        Frm_ExistenciasProducto existenciaP = new Frm_ExistenciasProducto();
        private void existenciasProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_ExistenciasProducto);
            if (ventanaExistencia == false || frmC == null)
            {
                if (frmC == null)
                {
                    facturaP = new Frm_BusquedaOrdenCompra(susuario);
                }

                existenciaP.MdiParent = this;
                existenciaP.Show();
                Application.DoEvents();
                ventanaExistencia = true;
            }
            else
            {
                existenciaP.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool movimientoInventario = false;
        Frm_ListaMovInv movInv = new Frm_ListaMovInv();
        private void movimientosDeInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_ListaMovInv);
            if (movimientoInventario == false || frmC == null)
            {
                if (frmC == null)
                {
                    facturaP = new Frm_BusquedaOrdenCompra(susuario);
                }

                movInv.MdiParent = this;
                movInv.Show();
                Application.DoEvents();
                movimientoInventario = true;
            }
            else
            {
                movInv.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }
        bool mantAcreedor = false;
        Frm_MantAcreedor mantacreedor = new Frm_MantAcreedor("");
        private void acreedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_MantAcreedor);
            if (mantAcreedor == false || frmC == null)
            {
                if (frmC == null)
                {
                    mantacreedor = new Frm_MantAcreedor(susuario);
                }

                mantacreedor.MdiParent = this;
                mantacreedor.Show();
                Application.DoEvents();
                mantAcreedor = true;
            }
            else
            {
                mantacreedor.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }
        bool mantTransporte = false;
        Frm_MantTransporte manttransporte = new Frm_MantTransporte("");
        private void transporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_MantTransporte);
            if (mantTransporte == false || frmC == null)
            {
                if (frmC == null)
                {
                    manttransporte = new Frm_MantTransporte(susuario);
                }

                manttransporte.MdiParent = this;
                manttransporte.Show();
                Application.DoEvents();
                mantTransporte = true;
            }
            else
            {
                manttransporte.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }
        bool mantTipoTransporte = false;
        Frm_MantTipoTransporte manttipotransporte = new Frm_MantTipoTransporte("");
        private void tipoDeTransporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_MantTipoTransporte);
            if (mantTipoTransporte == false || frmC == null)
            {
                if (frmC == null)
                {
                    manttipotransporte = new Frm_MantTipoTransporte(susuario);
                }

                manttipotransporte.MdiParent = this;
                manttipotransporte.Show();
                Application.DoEvents();
                mantTipoTransporte = true;
            }
            else
            {
                manttipotransporte.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }
        bool mantRuta = false;
        Frm_MantRuta mantruta = new Frm_MantRuta("");
        private void rutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_MantRuta);
            if (mantRuta == false || frmC == null)
            {
                if (frmC == null)
                {
                    mantruta = new Frm_MantRuta(susuario);
                }

                mantruta.MdiParent = this;
                mantruta.Show();
                Application.DoEvents();
                mantRuta = true;
            }
            else
            {
                mantruta.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }
        bool DisponibilidadBodega = false;
        Frm_consultaDisponibilidadDeBodega disponibilidadbodega = new Frm_consultaDisponibilidadDeBodega();
        private void disponibilidadEnBodegaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_consultaDisponibilidadDeBodega);
            if (DisponibilidadBodega == false || frmC == null)
            {
                if (frmC == null)
                {
                    disponibilidadbodega = new Frm_consultaDisponibilidadDeBodega();
                }

                disponibilidadbodega.MdiParent = this;
                disponibilidadbodega.Show();
                Application.DoEvents();
                DisponibilidadBodega = true;
            }
            else
            {
                disponibilidadbodega.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }
        bool DisponibilidadBodega1 = false;
        Frm_consultaDisponibilidadDeBodega disponibilidadbodega1 = new Frm_consultaDisponibilidadDeBodega();
        private void disponibilidadEnBodegaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
                Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_consultaDisponibilidadDeBodega);
                if (DisponibilidadBodega1 == false || frmC == null)
                {
                    if (frmC == null)
                    {
                        disponibilidadbodega1 = new Frm_consultaDisponibilidadDeBodega();
                    }

                    disponibilidadbodega1.MdiParent = this;
                    disponibilidadbodega1.Show();
                    Application.DoEvents();
                    DisponibilidadBodega1 = true;
                }
                else
                {
                    disponibilidadbodega1.WindowState = System.Windows.Forms.FormWindowState.Normal;
                }
            
        }
    }
}
