namespace Capa_Diseño_SCM
{
    partial class Frm_MovInvDetalle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_MovInvDetalle));
            this.Pnl_nombreForm = new System.Windows.Forms.Panel();
            this.Btn_Ayuda = new System.Windows.Forms.Button();
            this.Btn_minimizar = new System.Windows.Forms.Button();
            this.Lbl_MovInt = new System.Windows.Forms.Label();
            this.Btn_cerrar = new System.Windows.Forms.Button();
            this.Gpb_MovInt = new System.Windows.Forms.GroupBox();
            this.btn_buscarP = new System.Windows.Forms.Button();
            this.txt_CodProducto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_buscarC = new System.Windows.Forms.Button();
            this.Txt_fechaMov = new System.Windows.Forms.TextBox();
            this.Txt_codEmpleado = new System.Windows.Forms.TextBox();
            this.Txt_nombreConcep = new System.Windows.Forms.TextBox();
            this.Txt_codigoMov = new System.Windows.Forms.TextBox();
            this.Lbl_estadoMov = new System.Windows.Forms.Label();
            this.Lbl_fechaMov = new System.Windows.Forms.Label();
            this.Lbl_nombreConcep = new System.Windows.Forms.Label();
            this.Lbl_codigoMov = new System.Windows.Forms.Label();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Dgv_MovIntDetalles = new System.Windows.Forms.DataGridView();
            this.Codigo_Movimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Concepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Existencias = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Actualizar = new System.Windows.Forms.Button();
            this.Pnl_nombreForm.SuspendLayout();
            this.Gpb_MovInt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_MovIntDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_nombreForm
            // 
            this.Pnl_nombreForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(40)))), ((int)(((byte)(15)))));
            this.Pnl_nombreForm.Controls.Add(this.Btn_Ayuda);
            this.Pnl_nombreForm.Controls.Add(this.Btn_minimizar);
            this.Pnl_nombreForm.Controls.Add(this.Lbl_MovInt);
            this.Pnl_nombreForm.Controls.Add(this.Btn_cerrar);
            this.Pnl_nombreForm.Location = new System.Drawing.Point(0, 0);
            this.Pnl_nombreForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pnl_nombreForm.Name = "Pnl_nombreForm";
            this.Pnl_nombreForm.Size = new System.Drawing.Size(920, 63);
            this.Pnl_nombreForm.TabIndex = 1;
            // 
            // Btn_Ayuda
            // 
            this.Btn_Ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Ayuda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_Ayuda.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Ayuda.Image")));
            this.Btn_Ayuda.Location = new System.Drawing.Point(807, 10);
            this.Btn_Ayuda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Ayuda.Name = "Btn_Ayuda";
            this.Btn_Ayuda.Size = new System.Drawing.Size(44, 38);
            this.Btn_Ayuda.TabIndex = 2;
            this.Btn_Ayuda.UseVisualStyleBackColor = true;
            this.Btn_Ayuda.Click += new System.EventHandler(this.Btn_Ayuda_Click);
            // 
            // Btn_minimizar
            // 
            this.Btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_minimizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_minimizar.Image")));
            this.Btn_minimizar.Location = new System.Drawing.Point(760, 10);
            this.Btn_minimizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_minimizar.Name = "Btn_minimizar";
            this.Btn_minimizar.Size = new System.Drawing.Size(44, 38);
            this.Btn_minimizar.TabIndex = 1;
            this.Btn_minimizar.UseVisualStyleBackColor = true;
            this.Btn_minimizar.Click += new System.EventHandler(this.Btn_minimizar_Click);
            // 
            // Lbl_MovInt
            // 
            this.Lbl_MovInt.AutoSize = true;
            this.Lbl_MovInt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_MovInt.ForeColor = System.Drawing.Color.White;
            this.Lbl_MovInt.Location = new System.Drawing.Point(27, 15);
            this.Lbl_MovInt.Name = "Lbl_MovInt";
            this.Lbl_MovInt.Size = new System.Drawing.Size(354, 25);
            this.Lbl_MovInt.TabIndex = 0;
            this.Lbl_MovInt.Text = "MOVIMIENTOS DE INVENTARIOS";
            // 
            // Btn_cerrar
            // 
            this.Btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_cerrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_cerrar.Image")));
            this.Btn_cerrar.Location = new System.Drawing.Point(857, 10);
            this.Btn_cerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_cerrar.Name = "Btn_cerrar";
            this.Btn_cerrar.Size = new System.Drawing.Size(44, 38);
            this.Btn_cerrar.TabIndex = 3;
            this.Btn_cerrar.UseVisualStyleBackColor = true;
            this.Btn_cerrar.Click += new System.EventHandler(this.Btn_cerrar_Click);
            // 
            // Gpb_MovInt
            // 
            this.Gpb_MovInt.Controls.Add(this.btn_buscarP);
            this.Gpb_MovInt.Controls.Add(this.txt_CodProducto);
            this.Gpb_MovInt.Controls.Add(this.label2);
            this.Gpb_MovInt.Controls.Add(this.btn_buscarC);
            this.Gpb_MovInt.Controls.Add(this.Txt_fechaMov);
            this.Gpb_MovInt.Controls.Add(this.Txt_codEmpleado);
            this.Gpb_MovInt.Controls.Add(this.Txt_nombreConcep);
            this.Gpb_MovInt.Controls.Add(this.Txt_codigoMov);
            this.Gpb_MovInt.Controls.Add(this.Lbl_estadoMov);
            this.Gpb_MovInt.Controls.Add(this.Lbl_fechaMov);
            this.Gpb_MovInt.Controls.Add(this.Lbl_nombreConcep);
            this.Gpb_MovInt.Controls.Add(this.Lbl_codigoMov);
            this.Gpb_MovInt.Location = new System.Drawing.Point(16, 69);
            this.Gpb_MovInt.Margin = new System.Windows.Forms.Padding(4);
            this.Gpb_MovInt.Name = "Gpb_MovInt";
            this.Gpb_MovInt.Padding = new System.Windows.Forms.Padding(4);
            this.Gpb_MovInt.Size = new System.Drawing.Size(869, 157);
            this.Gpb_MovInt.TabIndex = 2;
            this.Gpb_MovInt.TabStop = false;
            this.Gpb_MovInt.Text = "Movimientos";
            // 
            // btn_buscarP
            // 
            this.btn_buscarP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_buscarP.BackgroundImage")));
            this.btn_buscarP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscarP.Location = new System.Drawing.Point(756, 86);
            this.btn_buscarP.Margin = new System.Windows.Forms.Padding(4);
            this.btn_buscarP.Name = "btn_buscarP";
            this.btn_buscarP.Size = new System.Drawing.Size(43, 39);
            this.btn_buscarP.TabIndex = 109;
            this.btn_buscarP.UseVisualStyleBackColor = true;
            this.btn_buscarP.Click += new System.EventHandler(this.Btn_buscarP_Click);
            // 
            // txt_CodProducto
            // 
            this.txt_CodProducto.Location = new System.Drawing.Point(559, 94);
            this.txt_CodProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txt_CodProducto.Name = "txt_CodProducto";
            this.txt_CodProducto.Size = new System.Drawing.Size(173, 22);
            this.txt_CodProducto.TabIndex = 108;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(429, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 107;
            this.label2.Text = "Codigo Producto";
            // 
            // btn_buscarC
            // 
            this.btn_buscarC.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_buscarC.BackgroundImage")));
            this.btn_buscarC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscarC.Location = new System.Drawing.Point(339, 86);
            this.btn_buscarC.Margin = new System.Windows.Forms.Padding(4);
            this.btn_buscarC.Name = "btn_buscarC";
            this.btn_buscarC.Size = new System.Drawing.Size(43, 39);
            this.btn_buscarC.TabIndex = 106;
            this.btn_buscarC.UseVisualStyleBackColor = true;
            this.btn_buscarC.Click += new System.EventHandler(this.Btn_buscarC_Click);
            // 
            // Txt_fechaMov
            // 
            this.Txt_fechaMov.Enabled = false;
            this.Txt_fechaMov.Location = new System.Drawing.Point(626, 28);
            this.Txt_fechaMov.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_fechaMov.Name = "Txt_fechaMov";
            this.Txt_fechaMov.Size = new System.Drawing.Size(173, 22);
            this.Txt_fechaMov.TabIndex = 12;
            // 
            // Txt_codEmpleado
            // 
            this.Txt_codEmpleado.Location = new System.Drawing.Point(120, 23);
            this.Txt_codEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_codEmpleado.Name = "Txt_codEmpleado";
            this.Txt_codEmpleado.Size = new System.Drawing.Size(173, 22);
            this.Txt_codEmpleado.TabIndex = 11;
            // 
            // Txt_nombreConcep
            // 
            this.Txt_nombreConcep.Location = new System.Drawing.Point(142, 94);
            this.Txt_nombreConcep.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_nombreConcep.Name = "Txt_nombreConcep";
            this.Txt_nombreConcep.Size = new System.Drawing.Size(173, 22);
            this.Txt_nombreConcep.TabIndex = 10;
            // 
            // Txt_codigoMov
            // 
            this.Txt_codigoMov.Enabled = false;
            this.Txt_codigoMov.Location = new System.Drawing.Point(373, 26);
            this.Txt_codigoMov.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_codigoMov.Name = "Txt_codigoMov";
            this.Txt_codigoMov.Size = new System.Drawing.Size(173, 22);
            this.Txt_codigoMov.TabIndex = 7;
            // 
            // Lbl_estadoMov
            // 
            this.Lbl_estadoMov.AutoSize = true;
            this.Lbl_estadoMov.Location = new System.Drawing.Point(16, 28);
            this.Lbl_estadoMov.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_estadoMov.Name = "Lbl_estadoMov";
            this.Lbl_estadoMov.Size = new System.Drawing.Size(88, 17);
            this.Lbl_estadoMov.TabIndex = 4;
            this.Lbl_estadoMov.Text = "ID Empleado";
            // 
            // Lbl_fechaMov
            // 
            this.Lbl_fechaMov.AutoSize = true;
            this.Lbl_fechaMov.Location = new System.Drawing.Point(571, 31);
            this.Lbl_fechaMov.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_fechaMov.Name = "Lbl_fechaMov";
            this.Lbl_fechaMov.Size = new System.Drawing.Size(47, 17);
            this.Lbl_fechaMov.TabIndex = 3;
            this.Lbl_fechaMov.Text = "Fecha";
            // 
            // Lbl_nombreConcep
            // 
            this.Lbl_nombreConcep.AutoSize = true;
            this.Lbl_nombreConcep.Location = new System.Drawing.Point(12, 97);
            this.Lbl_nombreConcep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_nombreConcep.Name = "Lbl_nombreConcep";
            this.Lbl_nombreConcep.Size = new System.Drawing.Size(122, 17);
            this.Lbl_nombreConcep.TabIndex = 2;
            this.Lbl_nombreConcep.Text = "Nombre Concepto";
            // 
            // Lbl_codigoMov
            // 
            this.Lbl_codigoMov.AutoSize = true;
            this.Lbl_codigoMov.Location = new System.Drawing.Point(313, 26);
            this.Lbl_codigoMov.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_codigoMov.Name = "Lbl_codigoMov";
            this.Lbl_codigoMov.Size = new System.Drawing.Size(52, 17);
            this.Lbl_codigoMov.TabIndex = 0;
            this.Lbl_codigoMov.Text = "Código";
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.Location = new System.Drawing.Point(801, 525);
            this.Btn_guardar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(100, 28);
            this.Btn_guardar.TabIndex = 6;
            this.Btn_guardar.Text = "Guardar";
            this.Btn_guardar.UseVisualStyleBackColor = true;
            this.Btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // Dgv_MovIntDetalles
            // 
            this.Dgv_MovIntDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_MovIntDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo_Movimiento,
            this.CodigoProducto,
            this.NombreProducto,
            this.Concepto,
            this.Documento,
            this.Cantidad,
            this.Precio,
            this.Costo});
            this.Dgv_MovIntDetalles.Location = new System.Drawing.Point(16, 270);
            this.Dgv_MovIntDetalles.Margin = new System.Windows.Forms.Padding(4);
            this.Dgv_MovIntDetalles.Name = "Dgv_MovIntDetalles";
            this.Dgv_MovIntDetalles.RowHeadersVisible = false;
            this.Dgv_MovIntDetalles.RowHeadersWidth = 51;
            this.Dgv_MovIntDetalles.Size = new System.Drawing.Size(869, 216);
            this.Dgv_MovIntDetalles.TabIndex = 7;
            // 
            // Codigo_Movimiento
            // 
            this.Codigo_Movimiento.HeaderText = "Codigo Movimiento";
            this.Codigo_Movimiento.MinimumWidth = 6;
            this.Codigo_Movimiento.Name = "Codigo_Movimiento";
            this.Codigo_Movimiento.Width = 125;
            // 
            // CodigoProducto
            // 
            this.CodigoProducto.HeaderText = "Codigo Producto";
            this.CodigoProducto.MinimumWidth = 6;
            this.CodigoProducto.Name = "CodigoProducto";
            this.CodigoProducto.Width = 125;
            // 
            // NombreProducto
            // 
            this.NombreProducto.HeaderText = "Nombre Producto";
            this.NombreProducto.MinimumWidth = 6;
            this.NombreProducto.Name = "NombreProducto";
            this.NombreProducto.Width = 125;
            // 
            // Concepto
            // 
            this.Concepto.HeaderText = "Concepto";
            this.Concepto.MinimumWidth = 6;
            this.Concepto.Name = "Concepto";
            this.Concepto.Width = 125;
            // 
            // Documento
            // 
            this.Documento.HeaderText = "Documento";
            this.Documento.MinimumWidth = 6;
            this.Documento.Name = "Documento";
            this.Documento.Width = 125;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 125;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.Width = 125;
            // 
            // Costo
            // 
            this.Costo.HeaderText = "Costo";
            this.Costo.MinimumWidth = 6;
            this.Costo.Name = "Costo";
            this.Costo.Width = 125;
            // 
            // txt_Existencias
            // 
            this.txt_Existencias.Enabled = false;
            this.txt_Existencias.Location = new System.Drawing.Point(105, 525);
            this.txt_Existencias.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Existencias.Name = "txt_Existencias";
            this.txt_Existencias.Size = new System.Drawing.Size(132, 22);
            this.txt_Existencias.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 526);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Existencia";
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.Location = new System.Drawing.Point(668, 526);
            this.btn_Actualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.Size = new System.Drawing.Size(100, 28);
            this.btn_Actualizar.TabIndex = 13;
            this.btn_Actualizar.Text = "Actualizar";
            this.btn_Actualizar.UseVisualStyleBackColor = true;
            this.btn_Actualizar.Click += new System.EventHandler(this.Btn_Actualizar_Click);
            // 
            // Frm_MovInvDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 565);
            this.Controls.Add(this.btn_Actualizar);
            this.Controls.Add(this.txt_Existencias);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dgv_MovIntDetalles);
            this.Controls.Add(this.Gpb_MovInt);
            this.Controls.Add(this.Btn_guardar);
            this.Controls.Add(this.Pnl_nombreForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_MovInvDetalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario Movimientos";
            this.Load += new System.EventHandler(this.Frm_MovInvDetalle_Load);
            this.Pnl_nombreForm.ResumeLayout(false);
            this.Pnl_nombreForm.PerformLayout();
            this.Gpb_MovInt.ResumeLayout(false);
            this.Gpb_MovInt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_MovIntDetalles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_nombreForm;
        private System.Windows.Forms.Button Btn_Ayuda;
        private System.Windows.Forms.Button Btn_minimizar;
        private System.Windows.Forms.Label Lbl_MovInt;
        private System.Windows.Forms.Button Btn_cerrar;
        private System.Windows.Forms.GroupBox Gpb_MovInt;
        private System.Windows.Forms.Label Lbl_estadoMov;
        private System.Windows.Forms.Label Lbl_fechaMov;
        private System.Windows.Forms.Label Lbl_nombreConcep;
        private System.Windows.Forms.Label Lbl_codigoMov;
        private System.Windows.Forms.TextBox Txt_fechaMov;
        private System.Windows.Forms.TextBox Txt_codEmpleado;
        private System.Windows.Forms.TextBox Txt_nombreConcep;
        private System.Windows.Forms.TextBox Txt_codigoMov;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.DataGridView Dgv_MovIntDetalles;
        private System.Windows.Forms.TextBox txt_Existencias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_buscarC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_Movimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Concepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
        private System.Windows.Forms.Button btn_buscarP;
        private System.Windows.Forms.TextBox txt_CodProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Actualizar;
    }
}

