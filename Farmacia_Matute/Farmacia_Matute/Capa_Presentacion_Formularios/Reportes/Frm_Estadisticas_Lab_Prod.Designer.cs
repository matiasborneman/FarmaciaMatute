namespace Farmacia_Matute.Capa_Presentacion_Formularios.Reportes
{
    partial class Frm_Estad_Lab_Prod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Estad_Lab_Prod));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.Rad_btn_Todos_Lab = new System.Windows.Forms.RadioButton();
            this.Rad_btn_por_Lab = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Cmb_Lab = new Farmacia_Matute.Clases.ComboBox01();
            this.rv_simple = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Cmb_Lab);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(806, 553);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estadísticas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 46;
            this.label1.Text = "Laboratorio";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Btn_Salir);
            this.groupBox2.Controls.Add(this.Btn_Buscar);
            this.groupBox2.Controls.Add(this.btn_limpiar);
            this.groupBox2.Controls.Add(this.Rad_btn_Todos_Lab);
            this.groupBox2.Controls.Add(this.Rad_btn_por_Lab);
            this.groupBox2.Location = new System.Drawing.Point(428, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(368, 102);
            this.groupBox2.TabIndex = 44;
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
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(137, 56);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(72, 32);
            this.btn_limpiar.TabIndex = 2;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // Rad_btn_Todos_Lab
            // 
            this.Rad_btn_Todos_Lab.AutoSize = true;
            this.Rad_btn_Todos_Lab.Location = new System.Drawing.Point(169, 25);
            this.Rad_btn_Todos_Lab.Name = "Rad_btn_Todos_Lab";
            this.Rad_btn_Todos_Lab.Size = new System.Drawing.Size(166, 20);
            this.Rad_btn_Todos_Lab.TabIndex = 1;
            this.Rad_btn_Todos_Lab.TabStop = true;
            this.Rad_btn_Todos_Lab.Text = "Todos los Laboratorios";
            this.Rad_btn_Todos_Lab.UseVisualStyleBackColor = true;
            // 
            // Rad_btn_por_Lab
            // 
            this.Rad_btn_por_Lab.AutoSize = true;
            this.Rad_btn_por_Lab.Location = new System.Drawing.Point(24, 25);
            this.Rad_btn_por_Lab.Name = "Rad_btn_por_Lab";
            this.Rad_btn_por_Lab.Size = new System.Drawing.Size(119, 20);
            this.Rad_btn_por_Lab.TabIndex = 0;
            this.Rad_btn_por_Lab.TabStop = true;
            this.Rad_btn_por_Lab.Text = "Por Laboratorio";
            this.Rad_btn_por_Lab.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(7, 115);
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
            this.tabPage1.Text = "Relación de Laboratorios y Productos ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Cmb_Lab
            // 
            this.Cmb_Lab.FormattingEnabled = true;
            this.Cmb_Lab.Location = new System.Drawing.Point(105, 33);
            this.Cmb_Lab.Name = "Cmb_Lab";
            this.Cmb_Lab.Pp_Display = "Razon_Social";
            this.Cmb_Lab.Pp_mensajeError = null;
            this.Cmb_Lab.Pp_nombre_campo = null;
            this.Cmb_Lab.Pp_nombre_tabla = null;
            this.Cmb_Lab.Pp_seleccionado = false;
            this.Cmb_Lab.Pp_Tabla = "Laboratorios";
            this.Cmb_Lab.Pp_validable = false;
            this.Cmb_Lab.Pp_Value = "CUIT_Laboratorio";
            this.Cmb_Lab.Size = new System.Drawing.Size(163, 24);
            this.Cmb_Lab.TabIndex = 45;
            // 
            // rv_simple
            // 
            this.rv_simple.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rv_simple.LocalReport.ReportEmbeddedResource = "Farmacia_Matute.Capa_Presentacion_Formularios.Reportes.Reporte_Estadistica_Laorat" +
    "orios_x_Productos.rdlc";
            this.rv_simple.Location = new System.Drawing.Point(3, 3);
            this.rv_simple.Name = "rv_simple";
            this.rv_simple.ServerReport.BearerToken = null;
            this.rv_simple.Size = new System.Drawing.Size(779, 395);
            this.rv_simple.TabIndex = 0;
            // 
            // Frm_Estad_Lab_Prod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(830, 577);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Estad_Lab_Prod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estadisticas de Laboratorios y Productos";
            this.Load += new System.EventHandler(this.Frm_Estad_Lab_Prod_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private Clases.ComboBox01 Cmb_Lab;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.RadioButton Rad_btn_Todos_Lab;
        private System.Windows.Forms.RadioButton Rad_btn_por_Lab;
        private Microsoft.Reporting.WinForms.ReportViewer rv_simple;
    }
}