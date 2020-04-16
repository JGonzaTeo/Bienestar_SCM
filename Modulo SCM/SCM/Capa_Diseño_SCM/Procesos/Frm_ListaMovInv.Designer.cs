namespace Capa_Diseño_SCM
{
    partial class Frm_ListaMovInv
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ListaMovInv));
            this.Pnl_nombreForm = new System.Windows.Forms.Panel();
            this.Btn_ayuda = new System.Windows.Forms.Button();
            this.Btn_minimizar = new System.Windows.Forms.Button();
            this.Lbl_listaMovInt = new System.Windows.Forms.Label();
            this.Btn_cerrar = new System.Windows.Forms.Button();
            this.Btn_consultar = new System.Windows.Forms.Button();
            this.Btn_ingresar = new System.Windows.Forms.Button();
            this.Dgv_listaMovInt = new System.Windows.Forms.DataGridView();
            this.CodigoMov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoMov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Actualizar = new System.Windows.Forms.Button();
            this.Pnl_nombreForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_listaMovInt)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_nombreForm
            // 
            this.Pnl_nombreForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(40)))), ((int)(((byte)(15)))));
            this.Pnl_nombreForm.Controls.Add(this.Btn_ayuda);
            this.Pnl_nombreForm.Controls.Add(this.Btn_minimizar);
            this.Pnl_nombreForm.Controls.Add(this.Lbl_listaMovInt);
            this.Pnl_nombreForm.Controls.Add(this.Btn_cerrar);
            this.Pnl_nombreForm.Location = new System.Drawing.Point(0, 0);
            this.Pnl_nombreForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pnl_nombreForm.Name = "Pnl_nombreForm";
            this.Pnl_nombreForm.Size = new System.Drawing.Size(748, 63);
            this.Pnl_nombreForm.TabIndex = 1;
            // 
            // Btn_ayuda
            // 
            this.Btn_ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_ayuda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_ayuda.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ayuda.Image")));
            this.Btn_ayuda.Location = new System.Drawing.Point(624, 15);
            this.Btn_ayuda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_ayuda.Name = "Btn_ayuda";
            this.Btn_ayuda.Size = new System.Drawing.Size(44, 38);
            this.Btn_ayuda.TabIndex = 2;
            this.Btn_ayuda.UseVisualStyleBackColor = true;
            this.Btn_ayuda.Click += new System.EventHandler(this.Btn_ayuda_Click);
            // 
            // Btn_minimizar
            // 
            this.Btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_minimizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_minimizar.Image")));
            this.Btn_minimizar.Location = new System.Drawing.Point(577, 15);
            this.Btn_minimizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_minimizar.Name = "Btn_minimizar";
            this.Btn_minimizar.Size = new System.Drawing.Size(44, 38);
            this.Btn_minimizar.TabIndex = 1;
            this.Btn_minimizar.UseVisualStyleBackColor = true;
            this.Btn_minimizar.Click += new System.EventHandler(this.Btn_minimizar_Click);
            // 
            // Lbl_listaMovInt
            // 
            this.Lbl_listaMovInt.AutoSize = true;
            this.Lbl_listaMovInt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_listaMovInt.ForeColor = System.Drawing.Color.White;
            this.Lbl_listaMovInt.Location = new System.Drawing.Point(27, 15);
            this.Lbl_listaMovInt.Name = "Lbl_listaMovInt";
            this.Lbl_listaMovInt.Size = new System.Drawing.Size(457, 25);
            this.Lbl_listaMovInt.TabIndex = 0;
            this.Lbl_listaMovInt.Text = "LISTA DE MOVIMIENTOS DE INVENTARIOS";
            // 
            // Btn_cerrar
            // 
            this.Btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_cerrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_cerrar.Image")));
            this.Btn_cerrar.Location = new System.Drawing.Point(675, 15);
            this.Btn_cerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_cerrar.Name = "Btn_cerrar";
            this.Btn_cerrar.Size = new System.Drawing.Size(44, 38);
            this.Btn_cerrar.TabIndex = 3;
            this.Btn_cerrar.UseVisualStyleBackColor = true;
            this.Btn_cerrar.Click += new System.EventHandler(this.Btn_cerrar_Click);
            // 
            // Btn_consultar
            // 
            this.Btn_consultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(40)))), ((int)(((byte)(15)))));
            this.Btn_consultar.FlatAppearance.BorderSize = 3;
            this.Btn_consultar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.Btn_consultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_consultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Btn_consultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_consultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_consultar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_consultar.Image")));
            this.Btn_consultar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_consultar.Location = new System.Drawing.Point(338, 87);
            this.Btn_consultar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_consultar.Name = "Btn_consultar";
            this.Btn_consultar.Size = new System.Drawing.Size(146, 110);
            this.Btn_consultar.TabIndex = 6;
            this.Btn_consultar.Text = "Consultar";
            this.Btn_consultar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_consultar.UseVisualStyleBackColor = false;
            this.Btn_consultar.Click += new System.EventHandler(this.Btn_consultar_Click);
            // 
            // Btn_ingresar
            // 
            this.Btn_ingresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(40)))), ((int)(((byte)(15)))));
            this.Btn_ingresar.FlatAppearance.BorderSize = 3;
            this.Btn_ingresar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.Btn_ingresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_ingresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Btn_ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ingresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ingresar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ingresar.Image")));
            this.Btn_ingresar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_ingresar.Location = new System.Drawing.Point(228, 87);
            this.Btn_ingresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_ingresar.Name = "Btn_ingresar";
            this.Btn_ingresar.Size = new System.Drawing.Size(115, 110);
            this.Btn_ingresar.TabIndex = 4;
            this.Btn_ingresar.Text = "Ingresar";
            this.Btn_ingresar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_ingresar.UseVisualStyleBackColor = false;
            this.Btn_ingresar.Click += new System.EventHandler(this.Btn_ingresar_Click);
            // 
            // Dgv_listaMovInt
            // 
            this.Dgv_listaMovInt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_listaMovInt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoMov,
            this.Fecha,
            this.EstadoMov});
            this.Dgv_listaMovInt.Location = new System.Drawing.Point(100, 222);
            this.Dgv_listaMovInt.Margin = new System.Windows.Forms.Padding(4);
            this.Dgv_listaMovInt.Name = "Dgv_listaMovInt";
            this.Dgv_listaMovInt.RowHeadersVisible = false;
            this.Dgv_listaMovInt.RowHeadersWidth = 51;
            this.Dgv_listaMovInt.Size = new System.Drawing.Size(539, 185);
            this.Dgv_listaMovInt.TabIndex = 7;
            this.Dgv_listaMovInt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_listaMovInt_CellContentClick);
            // 
            // CodigoMov
            // 
            this.CodigoMov.HeaderText = "Codigo Mov.";
            this.CodigoMov.MinimumWidth = 6;
            this.CodigoMov.Name = "CodigoMov";
            this.CodigoMov.Width = 125;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            this.Fecha.Width = 125;
            // 
            // EstadoMov
            // 
            this.EstadoMov.HeaderText = "Estado Mov.";
            this.EstadoMov.MinimumWidth = 6;
            this.EstadoMov.Name = "EstadoMov";
            this.EstadoMov.Width = 125;
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.Location = new System.Drawing.Point(624, 415);
            this.btn_Actualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.Size = new System.Drawing.Size(100, 28);
            this.btn_Actualizar.TabIndex = 14;
            this.btn_Actualizar.Text = "Actualizar";
            this.btn_Actualizar.UseVisualStyleBackColor = true;
            this.btn_Actualizar.Click += new System.EventHandler(this.Btn_Actualizar_Click);
            // 
            // Frm_ListaMovInv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 448);
            this.Controls.Add(this.btn_Actualizar);
            this.Controls.Add(this.Dgv_listaMovInt);
            this.Controls.Add(this.Btn_consultar);
            this.Controls.Add(this.Btn_ingresar);
            this.Controls.Add(this.Pnl_nombreForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_ListaMovInv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_ListaMovInv";
            this.Load += new System.EventHandler(this.Frm_ListaMovInv_Load);
            this.Pnl_nombreForm.ResumeLayout(false);
            this.Pnl_nombreForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_listaMovInt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_nombreForm;
        private System.Windows.Forms.Button Btn_ayuda;
        private System.Windows.Forms.Button Btn_minimizar;
        private System.Windows.Forms.Label Lbl_listaMovInt;
        private System.Windows.Forms.Button Btn_cerrar;
        private System.Windows.Forms.Button Btn_consultar;
        private System.Windows.Forms.Button Btn_ingresar;
        private System.Windows.Forms.DataGridView Dgv_listaMovInt;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoMov;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoMov;
        private System.Windows.Forms.Button btn_Actualizar;
    }
}