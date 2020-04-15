namespace Capa_Diseño_SCM.Mantenimientos
{
    partial class Frm_MantTransporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_MantTransporte));
            this.gpb_datos = new System.Windows.Forms.GroupBox();
            this.Cbo_tipotransporte = new System.Windows.Forms.ComboBox();
            this.Cbo_ruta = new System.Windows.Forms.ComboBox();
            this.Cbo_estado = new System.Windows.Forms.ComboBox();
            this.Txt_motor = new System.Windows.Forms.TextBox();
            this.Txt_chasis = new System.Windows.Forms.TextBox();
            this.Txt_placa = new System.Windows.Forms.TextBox();
            this.Txt_codigotransporte = new System.Windows.Forms.TextBox();
            this.Lbl_estado = new System.Windows.Forms.Label();
            this.Lbl_tipotransporte = new System.Windows.Forms.Label();
            this.Lbl_ruta = new System.Windows.Forms.Label();
            this.Lbl_motor = new System.Windows.Forms.Label();
            this.Lbl_chasis = new System.Windows.Forms.Label();
            this.Lbl_placa = new System.Windows.Forms.Label();
            this.Lbl_codigotransporte = new System.Windows.Forms.Label();
            this.Btn_consultar = new System.Windows.Forms.Button();
            this.Btn_borrar = new System.Windows.Forms.Button();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Btn_editar = new System.Windows.Forms.Button();
            this.Btn_ingresar = new System.Windows.Forms.Button();
            this.Pnl_nombreForm = new System.Windows.Forms.Panel();
            this.btn_Ayuda = new System.Windows.Forms.Button();
            this.btn_minimizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.gpb_datos.SuspendLayout();
            this.Pnl_nombreForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpb_datos
            // 
            this.gpb_datos.Controls.Add(this.Cbo_tipotransporte);
            this.gpb_datos.Controls.Add(this.Cbo_ruta);
            this.gpb_datos.Controls.Add(this.Cbo_estado);
            this.gpb_datos.Controls.Add(this.Txt_motor);
            this.gpb_datos.Controls.Add(this.Txt_chasis);
            this.gpb_datos.Controls.Add(this.Txt_placa);
            this.gpb_datos.Controls.Add(this.Txt_codigotransporte);
            this.gpb_datos.Controls.Add(this.Lbl_estado);
            this.gpb_datos.Controls.Add(this.Lbl_tipotransporte);
            this.gpb_datos.Controls.Add(this.Lbl_ruta);
            this.gpb_datos.Controls.Add(this.Lbl_motor);
            this.gpb_datos.Controls.Add(this.Lbl_chasis);
            this.gpb_datos.Controls.Add(this.Lbl_placa);
            this.gpb_datos.Controls.Add(this.Lbl_codigotransporte);
            this.gpb_datos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_datos.Location = new System.Drawing.Point(23, 189);
            this.gpb_datos.Margin = new System.Windows.Forms.Padding(2);
            this.gpb_datos.Name = "gpb_datos";
            this.gpb_datos.Padding = new System.Windows.Forms.Padding(2);
            this.gpb_datos.Size = new System.Drawing.Size(916, 167);
            this.gpb_datos.TabIndex = 89;
            this.gpb_datos.TabStop = false;
            this.gpb_datos.Text = "Datos";
            // 
            // Cbo_tipotransporte
            // 
            this.Cbo_tipotransporte.FormattingEnabled = true;
            this.Cbo_tipotransporte.Location = new System.Drawing.Point(657, 62);
            this.Cbo_tipotransporte.Margin = new System.Windows.Forms.Padding(2);
            this.Cbo_tipotransporte.Name = "Cbo_tipotransporte";
            this.Cbo_tipotransporte.Size = new System.Drawing.Size(169, 25);
            this.Cbo_tipotransporte.TabIndex = 17;
            this.Cbo_tipotransporte.SelectedIndexChanged += new System.EventHandler(this.Cbo_tipotransporte_SelectedIndexChanged);
            // 
            // Cbo_ruta
            // 
            this.Cbo_ruta.FormattingEnabled = true;
            this.Cbo_ruta.Location = new System.Drawing.Point(657, 32);
            this.Cbo_ruta.Margin = new System.Windows.Forms.Padding(2);
            this.Cbo_ruta.Name = "Cbo_ruta";
            this.Cbo_ruta.Size = new System.Drawing.Size(169, 25);
            this.Cbo_ruta.TabIndex = 16;
            this.Cbo_ruta.SelectedIndexChanged += new System.EventHandler(this.Cbo_ruta_SelectedIndexChanged);
            // 
            // Cbo_estado
            // 
            this.Cbo_estado.FormattingEnabled = true;
            this.Cbo_estado.Items.AddRange(new object[] {
            "0",
            "1"});
            this.Cbo_estado.Location = new System.Drawing.Point(657, 97);
            this.Cbo_estado.Margin = new System.Windows.Forms.Padding(2);
            this.Cbo_estado.Name = "Cbo_estado";
            this.Cbo_estado.Size = new System.Drawing.Size(169, 25);
            this.Cbo_estado.TabIndex = 15;
            // 
            // Txt_motor
            // 
            this.Txt_motor.Location = new System.Drawing.Point(214, 127);
            this.Txt_motor.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_motor.Name = "Txt_motor";
            this.Txt_motor.Size = new System.Drawing.Size(169, 23);
            this.Txt_motor.TabIndex = 11;
            // 
            // Txt_chasis
            // 
            this.Txt_chasis.Location = new System.Drawing.Point(214, 97);
            this.Txt_chasis.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_chasis.Name = "Txt_chasis";
            this.Txt_chasis.Size = new System.Drawing.Size(169, 23);
            this.Txt_chasis.TabIndex = 10;
            // 
            // Txt_placa
            // 
            this.Txt_placa.Location = new System.Drawing.Point(214, 64);
            this.Txt_placa.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_placa.Name = "Txt_placa";
            this.Txt_placa.Size = new System.Drawing.Size(169, 23);
            this.Txt_placa.TabIndex = 9;
            // 
            // Txt_codigotransporte
            // 
            this.Txt_codigotransporte.Location = new System.Drawing.Point(214, 32);
            this.Txt_codigotransporte.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_codigotransporte.Name = "Txt_codigotransporte";
            this.Txt_codigotransporte.Size = new System.Drawing.Size(169, 23);
            this.Txt_codigotransporte.TabIndex = 8;
            // 
            // Lbl_estado
            // 
            this.Lbl_estado.AutoSize = true;
            this.Lbl_estado.Location = new System.Drawing.Point(524, 105);
            this.Lbl_estado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_estado.Name = "Lbl_estado";
            this.Lbl_estado.Size = new System.Drawing.Size(52, 17);
            this.Lbl_estado.TabIndex = 7;
            this.Lbl_estado.Text = "Estado";
            // 
            // Lbl_tipotransporte
            // 
            this.Lbl_tipotransporte.AutoSize = true;
            this.Lbl_tipotransporte.Location = new System.Drawing.Point(523, 70);
            this.Lbl_tipotransporte.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_tipotransporte.Name = "Lbl_tipotransporte";
            this.Lbl_tipotransporte.Size = new System.Drawing.Size(130, 17);
            this.Lbl_tipotransporte.TabIndex = 5;
            this.Lbl_tipotransporte.Text = "Tipo de Transporte";
            // 
            // Lbl_ruta
            // 
            this.Lbl_ruta.AutoSize = true;
            this.Lbl_ruta.Location = new System.Drawing.Point(524, 40);
            this.Lbl_ruta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_ruta.Name = "Lbl_ruta";
            this.Lbl_ruta.Size = new System.Drawing.Size(38, 17);
            this.Lbl_ruta.TabIndex = 4;
            this.Lbl_ruta.Text = "Ruta";
            // 
            // Lbl_motor
            // 
            this.Lbl_motor.AutoSize = true;
            this.Lbl_motor.Location = new System.Drawing.Point(64, 133);
            this.Lbl_motor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_motor.Name = "Lbl_motor";
            this.Lbl_motor.Size = new System.Drawing.Size(44, 17);
            this.Lbl_motor.TabIndex = 3;
            this.Lbl_motor.Text = "Motor";
            // 
            // Lbl_chasis
            // 
            this.Lbl_chasis.AutoSize = true;
            this.Lbl_chasis.Location = new System.Drawing.Point(64, 103);
            this.Lbl_chasis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_chasis.Name = "Lbl_chasis";
            this.Lbl_chasis.Size = new System.Drawing.Size(50, 17);
            this.Lbl_chasis.TabIndex = 2;
            this.Lbl_chasis.Text = "Chasis";
            // 
            // Lbl_placa
            // 
            this.Lbl_placa.AutoSize = true;
            this.Lbl_placa.Location = new System.Drawing.Point(64, 70);
            this.Lbl_placa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_placa.Name = "Lbl_placa";
            this.Lbl_placa.Size = new System.Drawing.Size(43, 17);
            this.Lbl_placa.TabIndex = 1;
            this.Lbl_placa.Text = "Placa";
            // 
            // Lbl_codigotransporte
            // 
            this.Lbl_codigotransporte.AutoSize = true;
            this.Lbl_codigotransporte.Location = new System.Drawing.Point(64, 37);
            this.Lbl_codigotransporte.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_codigotransporte.Name = "Lbl_codigotransporte";
            this.Lbl_codigotransporte.Size = new System.Drawing.Size(146, 17);
            this.Lbl_codigotransporte.TabIndex = 0;
            this.Lbl_codigotransporte.Text = "Codigo de Transporte";
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
            this.Btn_consultar.Location = new System.Drawing.Point(614, 75);
            this.Btn_consultar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_consultar.Name = "Btn_consultar";
            this.Btn_consultar.Size = new System.Drawing.Size(140, 89);
            this.Btn_consultar.TabIndex = 88;
            this.Btn_consultar.Text = "Consultar";
            this.Btn_consultar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_consultar.UseVisualStyleBackColor = false;
            this.Btn_consultar.Click += new System.EventHandler(this.Btn_consultar_Click);
            // 
            // Btn_borrar
            // 
            this.Btn_borrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(40)))), ((int)(((byte)(15)))));
            this.Btn_borrar.FlatAppearance.BorderSize = 3;
            this.Btn_borrar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.Btn_borrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_borrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Btn_borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_borrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_borrar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_borrar.Image")));
            this.Btn_borrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_borrar.Location = new System.Drawing.Point(530, 75);
            this.Btn_borrar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_borrar.Name = "Btn_borrar";
            this.Btn_borrar.Size = new System.Drawing.Size(86, 89);
            this.Btn_borrar.TabIndex = 87;
            this.Btn_borrar.Text = "Borrar";
            this.Btn_borrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_borrar.UseVisualStyleBackColor = false;
            this.Btn_borrar.Click += new System.EventHandler(this.Btn_borrar_Click);
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(40)))), ((int)(((byte)(15)))));
            this.Btn_guardar.FlatAppearance.BorderSize = 3;
            this.Btn_guardar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.Btn_guardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_guardar.Image")));
            this.Btn_guardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_guardar.Location = new System.Drawing.Point(446, 75);
            this.Btn_guardar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(86, 89);
            this.Btn_guardar.TabIndex = 86;
            this.Btn_guardar.Text = "Guardar";
            this.Btn_guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_guardar.UseVisualStyleBackColor = false;
            this.Btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // Btn_editar
            // 
            this.Btn_editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(40)))), ((int)(((byte)(15)))));
            this.Btn_editar.FlatAppearance.BorderSize = 3;
            this.Btn_editar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.Btn_editar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_editar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_editar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_editar.Image")));
            this.Btn_editar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_editar.Location = new System.Drawing.Point(362, 75);
            this.Btn_editar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_editar.Name = "Btn_editar";
            this.Btn_editar.Size = new System.Drawing.Size(86, 89);
            this.Btn_editar.TabIndex = 85;
            this.Btn_editar.Text = "Editar";
            this.Btn_editar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_editar.UseVisualStyleBackColor = false;
            this.Btn_editar.Click += new System.EventHandler(this.Btn_editar_Click);
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
            this.Btn_ingresar.Location = new System.Drawing.Point(278, 75);
            this.Btn_ingresar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_ingresar.Name = "Btn_ingresar";
            this.Btn_ingresar.Size = new System.Drawing.Size(86, 89);
            this.Btn_ingresar.TabIndex = 84;
            this.Btn_ingresar.Text = "Ingresar";
            this.Btn_ingresar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_ingresar.UseVisualStyleBackColor = false;
            this.Btn_ingresar.Click += new System.EventHandler(this.Btn_ingresar_Click);
            // 
            // Pnl_nombreForm
            // 
            this.Pnl_nombreForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(40)))), ((int)(((byte)(15)))));
            this.Pnl_nombreForm.Controls.Add(this.btn_Ayuda);
            this.Pnl_nombreForm.Controls.Add(this.btn_minimizar);
            this.Pnl_nombreForm.Controls.Add(this.label1);
            this.Pnl_nombreForm.Controls.Add(this.btn_cerrar);
            this.Pnl_nombreForm.Location = new System.Drawing.Point(0, -1);
            this.Pnl_nombreForm.Margin = new System.Windows.Forms.Padding(2);
            this.Pnl_nombreForm.Name = "Pnl_nombreForm";
            this.Pnl_nombreForm.Size = new System.Drawing.Size(970, 51);
            this.Pnl_nombreForm.TabIndex = 83;
            // 
            // btn_Ayuda
            // 
            this.btn_Ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Ayuda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Ayuda.Image = ((System.Drawing.Image)(resources.GetObject("btn_Ayuda.Image")));
            this.btn_Ayuda.Location = new System.Drawing.Point(887, 12);
            this.btn_Ayuda.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Ayuda.Name = "btn_Ayuda";
            this.btn_Ayuda.Size = new System.Drawing.Size(33, 31);
            this.btn_Ayuda.TabIndex = 6;
            this.btn_Ayuda.UseVisualStyleBackColor = true;
            this.btn_Ayuda.Click += new System.EventHandler(this.btn_Ayuda_Click);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_minimizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_minimizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimizar.Image")));
            this.btn_minimizar.Location = new System.Drawing.Point(852, 12);
            this.btn_minimizar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(33, 31);
            this.btn_minimizar.TabIndex = 5;
            this.btn_minimizar.UseVisualStyleBackColor = true;
            this.btn_minimizar.Click += new System.EventHandler(this.btn_minimizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "MANTENIMIENTO DE TRANSPORTE";
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cerrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cerrar.Image")));
            this.btn_cerrar.Location = new System.Drawing.Point(925, 12);
            this.btn_cerrar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(33, 31);
            this.btn_cerrar.TabIndex = 4;
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // Frm_MantTransporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 414);
            this.Controls.Add(this.gpb_datos);
            this.Controls.Add(this.Btn_consultar);
            this.Controls.Add(this.Btn_borrar);
            this.Controls.Add(this.Btn_guardar);
            this.Controls.Add(this.Btn_editar);
            this.Controls.Add(this.Btn_ingresar);
            this.Controls.Add(this.Pnl_nombreForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Frm_MantTransporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_MantTransporte";
            this.gpb_datos.ResumeLayout(false);
            this.gpb_datos.PerformLayout();
            this.Pnl_nombreForm.ResumeLayout(false);
            this.Pnl_nombreForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpb_datos;
        private System.Windows.Forms.ComboBox Cbo_tipotransporte;
        private System.Windows.Forms.ComboBox Cbo_ruta;
        private System.Windows.Forms.ComboBox Cbo_estado;
        private System.Windows.Forms.TextBox Txt_motor;
        private System.Windows.Forms.TextBox Txt_chasis;
        private System.Windows.Forms.TextBox Txt_placa;
        private System.Windows.Forms.TextBox Txt_codigotransporte;
        private System.Windows.Forms.Label Lbl_estado;
        private System.Windows.Forms.Label Lbl_tipotransporte;
        private System.Windows.Forms.Label Lbl_ruta;
        private System.Windows.Forms.Label Lbl_motor;
        private System.Windows.Forms.Label Lbl_chasis;
        private System.Windows.Forms.Label Lbl_placa;
        private System.Windows.Forms.Label Lbl_codigotransporte;
        private System.Windows.Forms.Button Btn_consultar;
        private System.Windows.Forms.Button Btn_borrar;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Button Btn_editar;
        private System.Windows.Forms.Button Btn_ingresar;
        private System.Windows.Forms.Panel Pnl_nombreForm;
        private System.Windows.Forms.Button btn_Ayuda;
        private System.Windows.Forms.Button btn_minimizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cerrar;
    }
}