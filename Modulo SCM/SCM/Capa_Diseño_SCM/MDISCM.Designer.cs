namespace Capa_Diseño_SCM
{
    partial class MDISCM
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDISCM));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.percepcionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.impuestosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acreedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeTransporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rutaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bodegaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoFacturaProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.existenciasProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimientosDeInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disponibilidadEnBodegaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.printPreviewToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsMenu,
            this.mantenimientosToolStripMenuItem,
            this.procesoToolStripMenuItem,
            this.cerrarToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // toolsMenu
            // 
            this.toolsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.toolsMenu.Name = "toolsMenu";
            this.toolsMenu.Size = new System.Drawing.Size(90, 20);
            this.toolsMenu.Text = "&Herramientas";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.optionsToolStripMenuItem.Text = "&Opciones";
            // 
            // mantenimientosToolStripMenuItem
            // 
            this.mantenimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.percepcionToolStripMenuItem,
            this.impuestosToolStripMenuItem,
            this.acreedorToolStripMenuItem,
            this.transporteToolStripMenuItem,
            this.tipoDeTransporteToolStripMenuItem,
            this.rutaToolStripMenuItem,
            this.bodegaToolStripMenuItem,
            this.productoToolStripMenuItem,
            this.proveedoresToolStripMenuItem});
            this.mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            this.mantenimientosToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.mantenimientosToolStripMenuItem.Text = "Mantenimientos";
            // 
            // percepcionToolStripMenuItem
            // 
            this.percepcionToolStripMenuItem.Name = "percepcionToolStripMenuItem";
            this.percepcionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.percepcionToolStripMenuItem.Text = "Percepción";
            this.percepcionToolStripMenuItem.Click += new System.EventHandler(this.PercepcionToolStripMenuItem_Click);
            // 
            // impuestosToolStripMenuItem
            // 
            this.impuestosToolStripMenuItem.Name = "impuestosToolStripMenuItem";
            this.impuestosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.impuestosToolStripMenuItem.Text = "Impuestos";
            this.impuestosToolStripMenuItem.Click += new System.EventHandler(this.impuestosToolStripMenuItem_Click);
            // 
            // acreedorToolStripMenuItem
            // 
            this.acreedorToolStripMenuItem.Name = "acreedorToolStripMenuItem";
            this.acreedorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.acreedorToolStripMenuItem.Text = "Acreedor";
            this.acreedorToolStripMenuItem.Click += new System.EventHandler(this.acreedorToolStripMenuItem_Click);
            // 
            // transporteToolStripMenuItem
            // 
            this.transporteToolStripMenuItem.Name = "transporteToolStripMenuItem";
            this.transporteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.transporteToolStripMenuItem.Text = "Transporte";
            this.transporteToolStripMenuItem.Click += new System.EventHandler(this.transporteToolStripMenuItem_Click);
            // 
            // tipoDeTransporteToolStripMenuItem
            // 
            this.tipoDeTransporteToolStripMenuItem.Name = "tipoDeTransporteToolStripMenuItem";
            this.tipoDeTransporteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tipoDeTransporteToolStripMenuItem.Text = "Tipo de Transporte";
            this.tipoDeTransporteToolStripMenuItem.Click += new System.EventHandler(this.tipoDeTransporteToolStripMenuItem_Click);
            // 
            // rutaToolStripMenuItem
            // 
            this.rutaToolStripMenuItem.Name = "rutaToolStripMenuItem";
            this.rutaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rutaToolStripMenuItem.Text = "Ruta";
            this.rutaToolStripMenuItem.Click += new System.EventHandler(this.rutaToolStripMenuItem_Click);
            // 
            // bodegaToolStripMenuItem
            // 
            this.bodegaToolStripMenuItem.Name = "bodegaToolStripMenuItem";
            this.bodegaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bodegaToolStripMenuItem.Text = "Bodega";
            this.bodegaToolStripMenuItem.Click += new System.EventHandler(this.BodegaToolStripMenuItem_Click);
            // 
            // productoToolStripMenuItem
            // 
            this.productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            this.productoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.productoToolStripMenuItem.Text = "Producto";
            this.productoToolStripMenuItem.Click += new System.EventHandler(this.ProductoToolStripMenuItem_Click);
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            this.proveedoresToolStripMenuItem.Click += new System.EventHandler(this.ProveedoresToolStripMenuItem_Click);
            // 
            // procesoToolStripMenuItem
            // 
            this.procesoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresoFacturaProveedoresToolStripMenuItem,
            this.existenciasProductoToolStripMenuItem,
            this.movimientosDeInventarioToolStripMenuItem,
            this.disponibilidadEnBodegaToolStripMenuItem});
            this.procesoToolStripMenuItem.Name = "procesoToolStripMenuItem";
            this.procesoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.procesoToolStripMenuItem.Text = "Proceso";
            // 
            // ingresoFacturaProveedoresToolStripMenuItem
            // 
            this.ingresoFacturaProveedoresToolStripMenuItem.Name = "ingresoFacturaProveedoresToolStripMenuItem";
            this.ingresoFacturaProveedoresToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.ingresoFacturaProveedoresToolStripMenuItem.Text = "Ingreso Factura Proveedores";
            this.ingresoFacturaProveedoresToolStripMenuItem.Click += new System.EventHandler(this.ingresoFacturaProveedoresToolStripMenuItem_Click);
            // 
            // existenciasProductoToolStripMenuItem
            // 
            this.existenciasProductoToolStripMenuItem.Name = "existenciasProductoToolStripMenuItem";
            this.existenciasProductoToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.existenciasProductoToolStripMenuItem.Text = "Existencias Producto";
            this.existenciasProductoToolStripMenuItem.Click += new System.EventHandler(this.existenciasProductoToolStripMenuItem_Click);
            // 
            // movimientosDeInventarioToolStripMenuItem
            // 
            this.movimientosDeInventarioToolStripMenuItem.Name = "movimientosDeInventarioToolStripMenuItem";
            this.movimientosDeInventarioToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.movimientosDeInventarioToolStripMenuItem.Text = "Movimientos de Inventario";
            this.movimientosDeInventarioToolStripMenuItem.Click += new System.EventHandler(this.movimientosDeInventarioToolStripMenuItem_Click);
            // 
            // disponibilidadEnBodegaToolStripMenuItem
            // 
            this.disponibilidadEnBodegaToolStripMenuItem.Name = "disponibilidadEnBodegaToolStripMenuItem";
            this.disponibilidadEnBodegaToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.disponibilidadEnBodegaToolStripMenuItem.Text = "Disponibilidad en Bodega";
            this.disponibilidadEnBodegaToolStripMenuItem.Click += new System.EventHandler(this.disponibilidadEnBodegaToolStripMenuItem_Click_1);
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.cerrarToolStripMenuItem.Text = "cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.CerrarToolStripMenuItem_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.toolStripSeparator1,
            this.printToolStripButton,
            this.printPreviewToolStripButton,
            this.toolStripSeparator2,
            this.helpToolStripButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(632, 27);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.newToolStripButton.Text = "Nuevo";
            this.newToolStripButton.Click += new System.EventHandler(this.ShowNewForm);
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.openToolStripButton.Text = "Abrir";
            this.openToolStripButton.Click += new System.EventHandler(this.OpenFile);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.saveToolStripButton.Text = "Guardar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
            this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.printToolStripButton.Text = "Imprimir";
            // 
            // printPreviewToolStripButton
            // 
            this.printPreviewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printPreviewToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripButton.Image")));
            this.printPreviewToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.printPreviewToolStripButton.Name = "printPreviewToolStripButton";
            this.printPreviewToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.printPreviewToolStripButton.Text = "Vista previa de impresión";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.helpToolStripButton.Text = "Ayuda";
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel.Text = "Estado";
            // 
            // MDISCM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MDISCM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MDISCM";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem toolsMenu;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripButton printPreviewToolStripButton;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem mantenimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem percepcionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresoFacturaProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem impuestosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem existenciasProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimientosDeInventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acreedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDeTransporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rutaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disponibilidadEnBodegaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bodegaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
    }
}



