namespace Capa_Diseño_SCM
{
    partial class Frm_ExistenciasProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ExistenciasProducto));
            this.Pnl_nombreForm = new System.Windows.Forms.Panel();
            this.Btn_Ayuda = new System.Windows.Forms.Button();
            this.Btn_minimizar = new System.Windows.Forms.Button();
            this.Lbl_existencias = new System.Windows.Forms.Label();
            this.Btn_cerrar = new System.Windows.Forms.Button();
            this.Lbl_productoMovInt = new System.Windows.Forms.Label();
            this.Txt_productoMovInt = new System.Windows.Forms.TextBox();
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.Lbl_entMovInt = new System.Windows.Forms.Label();
            this.Lbl_salMovInt = new System.Windows.Forms.Label();
            this.Lbl_minMovInt = new System.Windows.Forms.Label();
            this.Lbl_maxMovInt = new System.Windows.Forms.Label();
            this.Btn_agregar = new System.Windows.Forms.Button();
            this.Txt_entrada = new System.Windows.Forms.TextBox();
            this.Txt_minimo = new System.Windows.Forms.TextBox();
            this.Txt_salida = new System.Windows.Forms.TextBox();
            this.Txt_maximo = new System.Windows.Forms.TextBox();
            this.Lbl_proMovInt = new System.Windows.Forms.Label();
            this.Lbl_exisMovInt = new System.Windows.Forms.Label();
            this.Dgv_existencias = new System.Windows.Forms.DataGridView();
            this.CodigoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entradas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salidas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Minimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Maximo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pnl_nombreForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_existencias)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_nombreForm
            // 
            this.Pnl_nombreForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(40)))), ((int)(((byte)(15)))));
            this.Pnl_nombreForm.Controls.Add(this.Btn_Ayuda);
            this.Pnl_nombreForm.Controls.Add(this.Btn_minimizar);
            this.Pnl_nombreForm.Controls.Add(this.Lbl_existencias);
            this.Pnl_nombreForm.Controls.Add(this.Btn_cerrar);
            this.Pnl_nombreForm.Location = new System.Drawing.Point(0, 0);
            this.Pnl_nombreForm.Margin = new System.Windows.Forms.Padding(2);
            this.Pnl_nombreForm.Name = "Pnl_nombreForm";
            this.Pnl_nombreForm.Size = new System.Drawing.Size(641, 51);
            this.Pnl_nombreForm.TabIndex = 1;
            // 
            // Btn_Ayuda
            // 
            this.Btn_Ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Ayuda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_Ayuda.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Ayuda.Image")));
            this.Btn_Ayuda.Location = new System.Drawing.Point(545, 12);
            this.Btn_Ayuda.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Ayuda.Name = "Btn_Ayuda";
            this.Btn_Ayuda.Size = new System.Drawing.Size(33, 31);
            this.Btn_Ayuda.TabIndex = 2;
            this.Btn_Ayuda.UseVisualStyleBackColor = true;
            this.Btn_Ayuda.Click += new System.EventHandler(this.Btn_Ayuda_Click);
            // 
            // Btn_minimizar
            // 
            this.Btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_minimizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_minimizar.Image")));
            this.Btn_minimizar.Location = new System.Drawing.Point(510, 12);
            this.Btn_minimizar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_minimizar.Name = "Btn_minimizar";
            this.Btn_minimizar.Size = new System.Drawing.Size(33, 31);
            this.Btn_minimizar.TabIndex = 1;
            this.Btn_minimizar.UseVisualStyleBackColor = true;
            this.Btn_minimizar.Click += new System.EventHandler(this.Btn_minimizar_Click);
            // 
            // Lbl_existencias
            // 
            this.Lbl_existencias.AutoSize = true;
            this.Lbl_existencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_existencias.ForeColor = System.Drawing.Color.White;
            this.Lbl_existencias.Location = new System.Drawing.Point(20, 12);
            this.Lbl_existencias.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_existencias.Name = "Lbl_existencias";
            this.Lbl_existencias.Size = new System.Drawing.Size(290, 20);
            this.Lbl_existencias.TabIndex = 0;
            this.Lbl_existencias.Text = "EXISTENCIAS DE UN PRODUCTO";
            // 
            // Btn_cerrar
            // 
            this.Btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_cerrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_cerrar.Image")));
            this.Btn_cerrar.Location = new System.Drawing.Point(583, 12);
            this.Btn_cerrar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_cerrar.Name = "Btn_cerrar";
            this.Btn_cerrar.Size = new System.Drawing.Size(33, 31);
            this.Btn_cerrar.TabIndex = 3;
            this.Btn_cerrar.UseVisualStyleBackColor = true;
            this.Btn_cerrar.Click += new System.EventHandler(this.Btn_cerrar_Click);
            // 
            // Lbl_productoMovInt
            // 
            this.Lbl_productoMovInt.AutoSize = true;
            this.Lbl_productoMovInt.Location = new System.Drawing.Point(21, 74);
            this.Lbl_productoMovInt.Name = "Lbl_productoMovInt";
            this.Lbl_productoMovInt.Size = new System.Drawing.Size(50, 13);
            this.Lbl_productoMovInt.TabIndex = 2;
            this.Lbl_productoMovInt.Text = "Producto";
            // 
            // Txt_productoMovInt
            // 
            this.Txt_productoMovInt.Enabled = false;
            this.Txt_productoMovInt.Location = new System.Drawing.Point(84, 71);
            this.Txt_productoMovInt.Name = "Txt_productoMovInt";
            this.Txt_productoMovInt.Size = new System.Drawing.Size(405, 20);
            this.Txt_productoMovInt.TabIndex = 4;
            // 
            // Btn_buscar
            // 
            this.Btn_buscar.Location = new System.Drawing.Point(522, 69);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.Btn_buscar.TabIndex = 5;
            this.Btn_buscar.Text = "Buscar";
            this.Btn_buscar.UseVisualStyleBackColor = true;
            // 
            // Lbl_entMovInt
            // 
            this.Lbl_entMovInt.AutoSize = true;
            this.Lbl_entMovInt.Location = new System.Drawing.Point(95, 119);
            this.Lbl_entMovInt.Name = "Lbl_entMovInt";
            this.Lbl_entMovInt.Size = new System.Drawing.Size(44, 13);
            this.Lbl_entMovInt.TabIndex = 5;
            this.Lbl_entMovInt.Text = "Entrada";
            // 
            // Lbl_salMovInt
            // 
            this.Lbl_salMovInt.AutoSize = true;
            this.Lbl_salMovInt.Location = new System.Drawing.Point(292, 119);
            this.Lbl_salMovInt.Name = "Lbl_salMovInt";
            this.Lbl_salMovInt.Size = new System.Drawing.Size(36, 13);
            this.Lbl_salMovInt.TabIndex = 6;
            this.Lbl_salMovInt.Text = "Salida";
            // 
            // Lbl_minMovInt
            // 
            this.Lbl_minMovInt.AutoSize = true;
            this.Lbl_minMovInt.Location = new System.Drawing.Point(95, 171);
            this.Lbl_minMovInt.Name = "Lbl_minMovInt";
            this.Lbl_minMovInt.Size = new System.Drawing.Size(42, 13);
            this.Lbl_minMovInt.TabIndex = 7;
            this.Lbl_minMovInt.Text = "Mínimo";
            // 
            // Lbl_maxMovInt
            // 
            this.Lbl_maxMovInt.AutoSize = true;
            this.Lbl_maxMovInt.Location = new System.Drawing.Point(292, 171);
            this.Lbl_maxMovInt.Name = "Lbl_maxMovInt";
            this.Lbl_maxMovInt.Size = new System.Drawing.Size(43, 13);
            this.Lbl_maxMovInt.TabIndex = 8;
            this.Lbl_maxMovInt.Text = "Máximo";
            // 
            // Btn_agregar
            // 
            this.Btn_agregar.Location = new System.Drawing.Point(522, 144);
            this.Btn_agregar.Name = "Btn_agregar";
            this.Btn_agregar.Size = new System.Drawing.Size(75, 23);
            this.Btn_agregar.TabIndex = 10;
            this.Btn_agregar.Text = "Agregar";
            this.Btn_agregar.UseVisualStyleBackColor = true;
            // 
            // Txt_entrada
            // 
            this.Txt_entrada.Location = new System.Drawing.Point(158, 119);
            this.Txt_entrada.Name = "Txt_entrada";
            this.Txt_entrada.Size = new System.Drawing.Size(100, 20);
            this.Txt_entrada.TabIndex = 6;
            // 
            // Txt_minimo
            // 
            this.Txt_minimo.Location = new System.Drawing.Point(158, 168);
            this.Txt_minimo.Name = "Txt_minimo";
            this.Txt_minimo.Size = new System.Drawing.Size(100, 20);
            this.Txt_minimo.TabIndex = 8;
            // 
            // Txt_salida
            // 
            this.Txt_salida.Location = new System.Drawing.Point(357, 119);
            this.Txt_salida.Name = "Txt_salida";
            this.Txt_salida.Size = new System.Drawing.Size(100, 20);
            this.Txt_salida.TabIndex = 7;
            // 
            // Txt_maximo
            // 
            this.Txt_maximo.Location = new System.Drawing.Point(357, 168);
            this.Txt_maximo.Name = "Txt_maximo";
            this.Txt_maximo.Size = new System.Drawing.Size(100, 20);
            this.Txt_maximo.TabIndex = 9;
            // 
            // Lbl_proMovInt
            // 
            this.Lbl_proMovInt.AutoSize = true;
            this.Lbl_proMovInt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_proMovInt.Location = new System.Drawing.Point(167, 228);
            this.Lbl_proMovInt.Name = "Lbl_proMovInt";
            this.Lbl_proMovInt.Size = new System.Drawing.Size(94, 24);
            this.Lbl_proMovInt.TabIndex = 14;
            this.Lbl_proMovInt.Text = "Producto";
            // 
            // Lbl_exisMovInt
            // 
            this.Lbl_exisMovInt.AutoSize = true;
            this.Lbl_exisMovInt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_exisMovInt.Location = new System.Drawing.Point(365, 228);
            this.Lbl_exisMovInt.Name = "Lbl_exisMovInt";
            this.Lbl_exisMovInt.Size = new System.Drawing.Size(116, 24);
            this.Lbl_exisMovInt.TabIndex = 15;
            this.Lbl_exisMovInt.Text = "Existencias";
            // 
            // Dgv_existencias
            // 
            this.Dgv_existencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_existencias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoProducto,
            this.NombreProducto,
            this.Entradas,
            this.Salidas,
            this.Minimo,
            this.Maximo});
            this.Dgv_existencias.Location = new System.Drawing.Point(12, 258);
            this.Dgv_existencias.Name = "Dgv_existencias";
            this.Dgv_existencias.RowHeadersVisible = false;
            this.Dgv_existencias.Size = new System.Drawing.Size(604, 150);
            this.Dgv_existencias.TabIndex = 16;
            // 
            // CodigoProducto
            // 
            this.CodigoProducto.HeaderText = "Codigo Producto";
            this.CodigoProducto.Name = "CodigoProducto";
            // 
            // NombreProducto
            // 
            this.NombreProducto.HeaderText = "Nombre Producto";
            this.NombreProducto.Name = "NombreProducto";
            // 
            // Entradas
            // 
            this.Entradas.HeaderText = "Entradas";
            this.Entradas.Name = "Entradas";
            // 
            // Salidas
            // 
            this.Salidas.HeaderText = "Salidas";
            this.Salidas.Name = "Salidas";
            // 
            // Minimo
            // 
            this.Minimo.HeaderText = "Minimo";
            this.Minimo.Name = "Minimo";
            // 
            // Maximo
            // 
            this.Maximo.HeaderText = "Maximo";
            this.Maximo.Name = "Maximo";
            // 
            // Frm_ExistenciasProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 423);
            this.Controls.Add(this.Dgv_existencias);
            this.Controls.Add(this.Lbl_exisMovInt);
            this.Controls.Add(this.Lbl_proMovInt);
            this.Controls.Add(this.Txt_maximo);
            this.Controls.Add(this.Txt_salida);
            this.Controls.Add(this.Txt_minimo);
            this.Controls.Add(this.Txt_entrada);
            this.Controls.Add(this.Btn_agregar);
            this.Controls.Add(this.Lbl_maxMovInt);
            this.Controls.Add(this.Lbl_minMovInt);
            this.Controls.Add(this.Lbl_salMovInt);
            this.Controls.Add(this.Lbl_entMovInt);
            this.Controls.Add(this.Btn_buscar);
            this.Controls.Add(this.Txt_productoMovInt);
            this.Controls.Add(this.Lbl_productoMovInt);
            this.Controls.Add(this.Pnl_nombreForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_ExistenciasProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_ExistenciasProducto";
            this.Pnl_nombreForm.ResumeLayout(false);
            this.Pnl_nombreForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_existencias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_nombreForm;
        private System.Windows.Forms.Button Btn_Ayuda;
        private System.Windows.Forms.Button Btn_minimizar;
        private System.Windows.Forms.Label Lbl_existencias;
        private System.Windows.Forms.Button Btn_cerrar;
        private System.Windows.Forms.Label Lbl_productoMovInt;
        private System.Windows.Forms.TextBox Txt_productoMovInt;
        private System.Windows.Forms.Button Btn_buscar;
        private System.Windows.Forms.Label Lbl_entMovInt;
        private System.Windows.Forms.Label Lbl_salMovInt;
        private System.Windows.Forms.Label Lbl_minMovInt;
        private System.Windows.Forms.Label Lbl_maxMovInt;
        private System.Windows.Forms.Button Btn_agregar;
        private System.Windows.Forms.TextBox Txt_entrada;
        private System.Windows.Forms.TextBox Txt_minimo;
        private System.Windows.Forms.TextBox Txt_salida;
        private System.Windows.Forms.TextBox Txt_maximo;
        private System.Windows.Forms.Label Lbl_proMovInt;
        private System.Windows.Forms.Label Lbl_exisMovInt;
        private System.Windows.Forms.DataGridView Dgv_existencias;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entradas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Minimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maximo;
    }
}