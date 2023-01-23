namespace Farmacia_Matute.Capa_Presentacion_Formularios.Reportes
{
    partial class Frm_Estadistica_Clientes_X_OS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Estadistica_Clientes_X_OS));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.Rad_btn_Todas_OS = new System.Windows.Forms.RadioButton();
            this.Rad_btn_por_OS = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rv_simple = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Cmb_OS = new Farmacia_Matute.Clases.ComboBox01();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.Cmb_OS);
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(806, 553);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estadísticas";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(7, 117);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(793, 430);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rv_simple);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(785, 401);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Distribucion de Clientes por Obra Social";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Btn_Salir);
            this.groupBox2.Controls.Add(this.Btn_Buscar);
            this.groupBox2.Controls.Add(this.btn_limpiar);
            this.groupBox2.Controls.Add(this.Rad_btn_Todas_OS);
            this.groupBox2.Controls.Add(this.Rad_btn_por_OS);
            this.groupBox2.Location = new System.Drawing.Point(429, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(368, 102);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtros";
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Salir.BackgroundImage")));
            this.Btn_Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Salir.Location = new System.Drawing.Point(300, 54);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(52, 36);
            this.Btn_Salir.TabIndex = 2;
            this.Btn_Salir.UseVisualStyleBackColor = true;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click_1);
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Buscar.BackgroundImage")));
            this.Btn_Buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Buscar.Location = new System.Drawing.Point(231, 54);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(52, 36);
            this.Btn_Buscar.TabIndex = 2;
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click_1);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(137, 56);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(72, 32);
            this.btn_limpiar.TabIndex = 2;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click_1);
            // 
            // Rad_btn_Todas_OS
            // 
            this.Rad_btn_Todas_OS.AutoSize = true;
            this.Rad_btn_Todas_OS.Location = new System.Drawing.Point(169, 25);
            this.Rad_btn_Todas_OS.Name = "Rad_btn_Todas_OS";
            this.Rad_btn_Todas_OS.Size = new System.Drawing.Size(183, 20);
            this.Rad_btn_Todas_OS.TabIndex = 1;
            this.Rad_btn_Todas_OS.TabStop = true;
            this.Rad_btn_Todas_OS.Text = "Todas las Obras Sociales";
            this.Rad_btn_Todas_OS.UseVisualStyleBackColor = true;
            // 
            // Rad_btn_por_OS
            // 
            this.Rad_btn_por_OS.AutoSize = true;
            this.Rad_btn_por_OS.Location = new System.Drawing.Point(24, 25);
            this.Rad_btn_por_OS.Name = "Rad_btn_por_OS";
            this.Rad_btn_por_OS.Size = new System.Drawing.Size(121, 20);
            this.Rad_btn_por_OS.TabIndex = 0;
            this.Rad_btn_por_OS.TabStop = true;
            this.Rad_btn_por_OS.Text = "Por Obra Social";
            this.Rad_btn_por_OS.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 44;
            this.label1.Text = "Obra Social";
            // 
            // rv_simple
            // 
            this.rv_simple.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rv_simple.LocalReport.ReportEmbeddedResource = "Farmacia_Matute.Capa_Presentacion_Formularios.Reportes.Reporte_Estad_Client_x_OS." +
    "rdlc";
            this.rv_simple.Location = new System.Drawing.Point(3, 3);
            this.rv_simple.Name = "rv_simple";
            this.rv_simple.ServerReport.BearerToken = null;
            this.rv_simple.Size = new System.Drawing.Size(779, 395);
            this.rv_simple.TabIndex = 0;
            // 
            // Cmb_OS
            // 
            this.Cmb_OS.FormattingEnabled = true;
            this.Cmb_OS.Location = new System.Drawing.Point(118, 36);
            this.Cmb_OS.Name = "Cmb_OS";
            this.Cmb_OS.Pp_Display = "descripcion";
            this.Cmb_OS.Pp_mensajeError = null;
            this.Cmb_OS.Pp_nombre_campo = null;
            this.Cmb_OS.Pp_nombre_tabla = null;
            this.Cmb_OS.Pp_seleccionado = false;
            this.Cmb_OS.Pp_Tabla = "Obra_Social";
            this.Cmb_OS.Pp_validable = false;
            this.Cmb_OS.Pp_Value = "id_ob_soc";
            this.Cmb_OS.Size = new System.Drawing.Size(159, 24);
            this.Cmb_OS.TabIndex = 1;
            // 
            // Frm_Estadistica_Clientes_X_OS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(830, 577);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Estadistica_Clientes_X_OS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Estadistica_Clientes_X_OS";
            this.Load += new System.EventHandler(this.Frm_Estadistica_Clientes_X_OS_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.RadioButton Rad_btn_Todas_OS;
        private System.Windows.Forms.RadioButton Rad_btn_por_OS;
        private Microsoft.Reporting.WinForms.ReportViewer rv_simple;
        private Clases.ComboBox01 Cmb_OS;
    }
}