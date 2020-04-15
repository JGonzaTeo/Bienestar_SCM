namespace Capa_Diseño_SCM.Mantenimientos
{
    partial class Frm_MantAcreedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_MantAcreedor));
            this.gpb_datos = new System.Windows.Forms.GroupBox();
            this.Cbo_calidadservicio = new System.Windows.Forms.ComboBox();
            this.Cbo_estado = new System.Windows.Forms.ComboBox();
            this.Txt_direccion = new System.Windows.Forms.TextBox();
            this.Txt_email = new System.Windows.Forms.TextBox();
            this.Txt_nit = new System.Windows.Forms.TextBox();
            this.Txt_telefono = new System.Windows.Forms.TextBox();
            this.Txt_nombre = new System.Windows.Forms.TextBox();
            this.Txt_codigoacreedor = new System.Windows.Forms.TextBox();
            this.Lbl_estado = new System.Windows.Forms.Label();
            this.Lbl_calidadservicio = new System.Windows.Forms.Label();
            this.Lbl_direccion = new System.Windows.Forms.Label();
            this.Lbl_email = new System.Windows.Forms.Label();
            this.Lbl_nit = new System.Windows.Forms.Label();
            this.Lbl_telefono = new System.Windows.Forms.Label();
            this.Lbl_nombre = new System.Windows.Forms.Label();
            this.Lbl_codigoacreedor = new System.Windows.Forms.Label();
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
            this.gpb_datos.Controls.Add(this.Cbo_calidadservicio);
            this.gpb_datos.Controls.Add(this.Cbo_estado);
            this.gpb_datos.Controls.Add(this.Txt_direccion);
            this.gpb_datos.Controls.Add(this.Txt_email);
            this.gpb_datos.Controls.Add(this.Txt_nit);
            this.gpb_datos.Controls.Add(this.Txt_telefono);
            this.gpb_datos.Controls.Add(this.Txt_nombre);
            this.gpb_datos.Controls.Add(this.Txt_codigoacreedor);
            this.gpb_datos.Controls.Add(this.Lbl_estado);
            this.gpb_datos.Controls.Add(this.Lbl_calidadservicio);
            this.gpb_datos.Controls.Add(this.Lbl_direccion);
            this.gpb_datos.Controls.Add(this.Lbl_email);
            this.gpb_datos.Controls.Add(this.Lbl_nit);
            this.gpb_datos.Controls.Add(this.Lbl_telefono);
            this.gpb_datos.Controls.Add(this.Lbl_nombre);
            this.gpb_datos.Controls.Add(this.Lbl_codigoacreedor);
            this.gpb_datos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_datos.Location = new System.Drawing.Point(23, 189);
            this.gpb_datos.Margin = new System.Windows.Forms.Padding(2);
            this.gpb_datos.Name = "gpb_datos";
            this.gpb_datos.Padding = new System.Windows.Forms.Padding(2);
            this.gpb_datos.Size = new System.Drawing.Size(916, 167);
            this.gpb_datos.TabIndex = 82;
            this.gpb_datos.TabStop = false;
            this.gpb_datos.Text = "Datos";
            // 
            // Cbo_calidadservicio
            // 
            this.Cbo_calidadservicio.FormattingEnabled = true;
            this.Cbo_calidadservicio.Items.AddRange(new object[] {
            "Muy Satisfecho",
            "Satisfecho",
            "Neutral",
            "Insatisfecho",
            "Muy Insatisfecho"});
            this.Cbo_calidadservicio.Location = new System.Drawing.Point(657, 94);
            this.Cbo_calidadservicio.Margin = new System.Windows.Forms.Padding(2);
            this.Cbo_calidadservicio.Name = "Cbo_calidadservicio";
            this.Cbo_calidadservicio.Size = new System.Drawing.Size(169, 25);
            this.Cbo_calidadservicio.TabIndex = 16;
            // 
            // Cbo_estado
            // 
            this.Cbo_estado.FormattingEnabled = true;
            this.Cbo_estado.Items.AddRange(new object[] {
            "Inactivo",
            "Activo"});
            this.Cbo_estado.Location = new System.Drawing.Point(657, 127);
            this.Cbo_estado.Margin = new System.Windows.Forms.Padding(2);
            this.Cbo_estado.Name = "Cbo_estado";
            this.Cbo_estado.Size = new System.Drawing.Size(169, 25);
            this.Cbo_estado.TabIndex = 15;
            // 
            // Txt_direccion
            // 
            this.Txt_direccion.Location = new System.Drawing.Point(657, 61);
            this.Txt_direccion.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_direccion.Name = "Txt_direccion";
            this.Txt_direccion.Size = new System.Drawing.Size(169, 23);
            this.Txt_direccion.TabIndex = 14;
            // 
            // Txt_email
            // 
            this.Txt_email.Location = new System.Drawing.Point(657, 32);
            this.Txt_email.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_email.Name = "Txt_email";
            this.Txt_email.Size = new System.Drawing.Size(169, 23);
            this.Txt_email.TabIndex = 13;
            // 
            // Txt_nit
            // 
            this.Txt_nit.Location = new System.Drawing.Point(219, 124);
            this.Txt_nit.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_nit.Name = "Txt_nit";
            this.Txt_nit.Size = new System.Drawing.Size(169, 23);
            this.Txt_nit.TabIndex = 11;
            // 
            // Txt_telefono
            // 
            this.Txt_telefono.Location = new System.Drawing.Point(219, 97);
            this.Txt_telefono.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_telefono.Name = "Txt_telefono";
            this.Txt_telefono.Size = new System.Drawing.Size(169, 23);
            this.Txt_telefono.TabIndex = 10;
            this.Txt_telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_telefono_KeyPress);
            // 
            // Txt_nombre
            // 
            this.Txt_nombre.Location = new System.Drawing.Point(219, 64);
            this.Txt_nombre.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_nombre.Name = "Txt_nombre";
            this.Txt_nombre.Size = new System.Drawing.Size(169, 23);
            this.Txt_nombre.TabIndex = 9;
            // 
            // Txt_codigoacreedor
            // 
            this.Txt_codigoacreedor.Location = new System.Drawing.Point(219, 32);
            this.Txt_codigoacreedor.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_codigoacreedor.Name = "Txt_codigoacreedor";
            this.Txt_codigoacreedor.Size = new System.Drawing.Size(169, 23);
            this.Txt_codigoacreedor.TabIndex = 8;
            // 
            // Lbl_estado
            // 
            this.Lbl_estado.AutoSize = true;
            this.Lbl_estado.Location = new System.Drawing.Point(524, 127);
            this.Lbl_estado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_estado.Name = "Lbl_estado";
            this.Lbl_estado.Size = new System.Drawing.Size(52, 17);
            this.Lbl_estado.TabIndex = 7;
            this.Lbl_estado.Text = "Estado";
            // 
            // Lbl_calidadservicio
            // 
            this.Lbl_calidadservicio.AutoSize = true;
            this.Lbl_calidadservicio.Location = new System.Drawing.Point(524, 97);
            this.Lbl_calidadservicio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_calidadservicio.Name = "Lbl_calidadservicio";
            this.Lbl_calidadservicio.Size = new System.Drawing.Size(129, 17);
            this.Lbl_calidadservicio.TabIndex = 6;
            this.Lbl_calidadservicio.Text = "Calidad de Servicio";
            // 
            // Lbl_direccion
            // 
            this.Lbl_direccion.AutoSize = true;
            this.Lbl_direccion.Location = new System.Drawing.Point(524, 64);
            this.Lbl_direccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_direccion.Name = "Lbl_direccion";
            this.Lbl_direccion.Size = new System.Drawing.Size(67, 17);
            this.Lbl_direccion.TabIndex = 5;
            this.Lbl_direccion.Text = "Dirección";
            // 
            // Lbl_email
            // 
            this.Lbl_email.AutoSize = true;
            this.Lbl_email.Location = new System.Drawing.Point(524, 34);
            this.Lbl_email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_email.Name = "Lbl_email";
            this.Lbl_email.Size = new System.Drawing.Size(42, 17);
            this.Lbl_email.TabIndex = 4;
            this.Lbl_email.Text = "Email";
            // 
            // Lbl_nit
            // 
            this.Lbl_nit.AutoSize = true;
            this.Lbl_nit.Location = new System.Drawing.Point(78, 127);
            this.Lbl_nit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_nit.Name = "Lbl_nit";
            this.Lbl_nit.Size = new System.Drawing.Size(25, 17);
            this.Lbl_nit.TabIndex = 3;
            this.Lbl_nit.Text = "Nit";
            // 
            // Lbl_telefono
            // 
            this.Lbl_telefono.AutoSize = true;
            this.Lbl_telefono.Location = new System.Drawing.Point(78, 97);
            this.Lbl_telefono.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_telefono.Name = "Lbl_telefono";
            this.Lbl_telefono.Size = new System.Drawing.Size(64, 17);
            this.Lbl_telefono.TabIndex = 2;
            this.Lbl_telefono.Text = "Teléfono";
            // 
            // Lbl_nombre
            // 
            this.Lbl_nombre.AutoSize = true;
            this.Lbl_nombre.Location = new System.Drawing.Point(78, 67);
            this.Lbl_nombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_nombre.Name = "Lbl_nombre";
            this.Lbl_nombre.Size = new System.Drawing.Size(58, 17);
            this.Lbl_nombre.TabIndex = 1;
            this.Lbl_nombre.Text = "Nombre";
            // 
            // Lbl_codigoacreedor
            // 
            this.Lbl_codigoacreedor.AutoSize = true;
            this.Lbl_codigoacreedor.Location = new System.Drawing.Point(78, 37);
            this.Lbl_codigoacreedor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_codigoacreedor.Name = "Lbl_codigoacreedor";
            this.Lbl_codigoacreedor.Size = new System.Drawing.Size(137, 17);
            this.Lbl_codigoacreedor.TabIndex = 0;
            this.Lbl_codigoacreedor.Text = "Codigo del Acreedor";
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
            this.Btn_consultar.TabIndex = 81;
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
            this.Btn_borrar.TabIndex = 80;
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
            this.Btn_guardar.TabIndex = 79;
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
            this.Btn_editar.TabIndex = 78;
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
            this.Btn_ingresar.TabIndex = 77;
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
            this.Pnl_nombreForm.TabIndex = 76;
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
            this.label1.Size = new System.Drawing.Size(313, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "MANTENIMIENTO DE ACREEDORES";
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
            // Frm_MantAcreedor
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
            this.Name = "Frm_MantAcreedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_MantAcreedor";
            this.gpb_datos.ResumeLayout(false);
            this.gpb_datos.PerformLayout();
            this.Pnl_nombreForm.ResumeLayout(false);
            this.Pnl_nombreForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpb_datos;
        private System.Windows.Forms.ComboBox Cbo_calidadservicio;
        private System.Windows.Forms.ComboBox Cbo_estado;
        private System.Windows.Forms.TextBox Txt_direccion;
        private System.Windows.Forms.TextBox Txt_email;
        private System.Windows.Forms.TextBox Txt_nit;
        private System.Windows.Forms.TextBox Txt_telefono;
        private System.Windows.Forms.TextBox Txt_nombre;
        private System.Windows.Forms.TextBox Txt_codigoacreedor;
        private System.Windows.Forms.Label Lbl_estado;
        private System.Windows.Forms.Label Lbl_calidadservicio;
        private System.Windows.Forms.Label Lbl_direccion;
        private System.Windows.Forms.Label Lbl_email;
        private System.Windows.Forms.Label Lbl_nit;
        private System.Windows.Forms.Label Lbl_telefono;
        private System.Windows.Forms.Label Lbl_nombre;
        private System.Windows.Forms.Label Lbl_codigoacreedor;
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