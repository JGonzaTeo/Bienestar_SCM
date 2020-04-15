namespace Capa_Diseño_SCM.Consultas
{
    partial class Frm_consultaDisponibilidadDeBodega
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_consultaDisponibilidadDeBodega));
            this.Btn_actualizar = new System.Windows.Forms.Button();
            this.Dgv_consultaDisponibilidadBodega = new System.Windows.Forms.DataGridView();
            this.Pnl_nombreForm = new System.Windows.Forms.Panel();
            this.btn_Ayuda = new System.Windows.Forms.Button();
            this.btn_minimizar = new System.Windows.Forms.Button();
            this.Lbl_ConsultaRuta = new System.Windows.Forms.Label();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.espacio_disponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_consultaDisponibilidadBodega)).BeginInit();
            this.Pnl_nombreForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_actualizar
            // 
            this.Btn_actualizar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_actualizar.FlatAppearance.BorderSize = 3;
            this.Btn_actualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_actualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.Btn_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_actualizar.Location = new System.Drawing.Point(355, 187);
            this.Btn_actualizar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_actualizar.Name = "Btn_actualizar";
            this.Btn_actualizar.Size = new System.Drawing.Size(123, 33);
            this.Btn_actualizar.TabIndex = 91;
            this.Btn_actualizar.Text = "Actualizar";
            this.Btn_actualizar.UseVisualStyleBackColor = true;
            this.Btn_actualizar.Click += new System.EventHandler(this.Btn_actualizar_Click);
            // 
            // Dgv_consultaDisponibilidadBodega
            // 
            this.Dgv_consultaDisponibilidadBodega.AllowUserToAddRows = false;
            this.Dgv_consultaDisponibilidadBodega.AllowUserToDeleteRows = false;
            this.Dgv_consultaDisponibilidadBodega.AllowUserToResizeColumns = false;
            this.Dgv_consultaDisponibilidadBodega.AllowUserToResizeRows = false;
            this.Dgv_consultaDisponibilidadBodega.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_consultaDisponibilidadBodega.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.espacio_disponible});
            this.Dgv_consultaDisponibilidadBodega.Location = new System.Drawing.Point(23, 80);
            this.Dgv_consultaDisponibilidadBodega.Margin = new System.Windows.Forms.Padding(2);
            this.Dgv_consultaDisponibilidadBodega.Name = "Dgv_consultaDisponibilidadBodega";
            this.Dgv_consultaDisponibilidadBodega.RowHeadersVisible = false;
            this.Dgv_consultaDisponibilidadBodega.RowHeadersWidth = 51;
            this.Dgv_consultaDisponibilidadBodega.RowTemplate.Height = 24;
            this.Dgv_consultaDisponibilidadBodega.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_consultaDisponibilidadBodega.Size = new System.Drawing.Size(254, 258);
            this.Dgv_consultaDisponibilidadBodega.TabIndex = 90;
            // 
            // Pnl_nombreForm
            // 
            this.Pnl_nombreForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(40)))), ((int)(((byte)(15)))));
            this.Pnl_nombreForm.Controls.Add(this.btn_Ayuda);
            this.Pnl_nombreForm.Controls.Add(this.btn_minimizar);
            this.Pnl_nombreForm.Controls.Add(this.Lbl_ConsultaRuta);
            this.Pnl_nombreForm.Controls.Add(this.btn_cerrar);
            this.Pnl_nombreForm.Location = new System.Drawing.Point(-1, -1);
            this.Pnl_nombreForm.Margin = new System.Windows.Forms.Padding(2);
            this.Pnl_nombreForm.Name = "Pnl_nombreForm";
            this.Pnl_nombreForm.Size = new System.Drawing.Size(560, 51);
            this.Pnl_nombreForm.TabIndex = 89;
            // 
            // btn_Ayuda
            // 
            this.btn_Ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Ayuda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Ayuda.Image = ((System.Drawing.Image)(resources.GetObject("btn_Ayuda.Image")));
            this.btn_Ayuda.Location = new System.Drawing.Point(463, 8);
            this.btn_Ayuda.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Ayuda.Name = "btn_Ayuda";
            this.btn_Ayuda.Size = new System.Drawing.Size(33, 31);
            this.btn_Ayuda.TabIndex = 77;
            this.btn_Ayuda.UseVisualStyleBackColor = true;
            this.btn_Ayuda.Click += new System.EventHandler(this.btn_Ayuda_Click);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_minimizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_minimizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimizar.Image")));
            this.btn_minimizar.Location = new System.Drawing.Point(427, 8);
            this.btn_minimizar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(33, 31);
            this.btn_minimizar.TabIndex = 5;
            this.btn_minimizar.UseVisualStyleBackColor = true;
            this.btn_minimizar.Click += new System.EventHandler(this.btn_minimizar_Click);
            // 
            // Lbl_ConsultaRuta
            // 
            this.Lbl_ConsultaRuta.AutoSize = true;
            this.Lbl_ConsultaRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ConsultaRuta.ForeColor = System.Drawing.Color.White;
            this.Lbl_ConsultaRuta.Location = new System.Drawing.Point(20, 12);
            this.Lbl_ConsultaRuta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_ConsultaRuta.Name = "Lbl_ConsultaRuta";
            this.Lbl_ConsultaRuta.Size = new System.Drawing.Size(323, 20);
            this.Lbl_ConsultaRuta.TabIndex = 0;
            this.Lbl_ConsultaRuta.Text = "Consulta de Disponibilidad en Bodegas";
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cerrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cerrar.Image")));
            this.btn_cerrar.Location = new System.Drawing.Point(499, 8);
            this.btn_cerrar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(33, 31);
            this.btn_cerrar.TabIndex = 4;
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // espacio_disponible
            // 
            this.espacio_disponible.HeaderText = "Espacio Disponible";
            this.espacio_disponible.MinimumWidth = 6;
            this.espacio_disponible.Name = "espacio_disponible";
            this.espacio_disponible.Width = 125;
            // 
            // Frm_consultaDisponibilidadDeBodega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 366);
            this.Controls.Add(this.Btn_actualizar);
            this.Controls.Add(this.Dgv_consultaDisponibilidadBodega);
            this.Controls.Add(this.Pnl_nombreForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Frm_consultaDisponibilidadDeBodega";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_consultaDisponibilidadDeBodega";
            this.Load += new System.EventHandler(this.Frm_consultaDisponibilidadDeBodega_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_consultaDisponibilidadBodega)).EndInit();
            this.Pnl_nombreForm.ResumeLayout(false);
            this.Pnl_nombreForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_actualizar;
        public System.Windows.Forms.DataGridView Dgv_consultaDisponibilidadBodega;
        private System.Windows.Forms.Panel Pnl_nombreForm;
        private System.Windows.Forms.Button btn_Ayuda;
        private System.Windows.Forms.Button btn_minimizar;
        private System.Windows.Forms.Label Lbl_ConsultaRuta;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn espacio_disponible;
    }
}