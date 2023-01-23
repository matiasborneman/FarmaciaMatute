namespace Farmacia_Matute.Capa_Presentacion_Formularios.Reportes
{
    partial class Frm_Reporte_Medic_Lab
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Reporte_Medic_Lab));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dSLabMedic01BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Lab_Medic01 = new Farmacia_Matute.Capa_Presentacion_Formularios.Reportes.DS_Lab_Medic01();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.Rad_btn_Lab = new System.Windows.Forms.RadioButton();
            this.Rad_btn_medic = new System.Windows.Forms.RadioButton();
            this.txt_medic = new Farmacia_Matute.Clases.TextBox01();
            this.Cmb_Lab = new Farmacia_Matute.Clases.ComboBox01();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rv_simple = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.dSLabMedic01BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Lab_Medic01)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dSLabMedic01BindingSource
            // 
            this.dSLabMedic01BindingSource.DataSource = this.dS_Lab_Medic01;
            this.dSLabMedic01BindingSource.Position = 0;
            // 
            // dS_Lab_Medic01
            // 
            this.dS_Lab_Medic01.DataSetName = "DS_Lab_Medic01";
            this.dS_Lab_Medic01.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txt_medic);
            this.groupBox1.Controls.Add(this.Cmb_Lab);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(721, 527);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Laboratorios por Medicamentos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Btn_Salir);
            this.groupBox2.Controls.Add(this.Btn_Buscar);
            this.groupBox2.Controls.Add(this.btn_limpiar);
            this.groupBox2.Controls.Add(this.Rad_btn_Lab);
            this.groupBox2.Controls.Add(this.Rad_btn_medic);
            this.groupBox2.Location = new System.Drawing.Point(412, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(297, 102);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtros";
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Salir.BackgroundImage")));
            this.Btn_Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Salir.Location = new System.Drawing.Point(230, 54);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(52, 36);
            this.Btn_Salir.TabIndex = 2;
            this.Btn_Salir.UseVisualStyleBackColor = true;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Buscar.BackgroundImage")));
            this.Btn_Buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Buscar.Location = new System.Drawing.Point(169, 54);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(52, 36);
            this.Btn_Buscar.TabIndex = 2;
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(24, 58);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(72, 32);
            this.btn_limpiar.TabIndex = 2;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // Rad_btn_Lab
            // 
            this.Rad_btn_Lab.AutoSize = true;
            this.Rad_btn_Lab.Location = new System.Drawing.Point(169, 25);
            this.Rad_btn_Lab.Name = "Rad_btn_Lab";
            this.Rad_btn_Lab.Size = new System.Drawing.Size(102, 20);
            this.Rad_btn_Lab.TabIndex = 1;
            this.Rad_btn_Lab.TabStop = true;
            this.Rad_btn_Lab.Text = "Laboratorios";
            this.Rad_btn_Lab.UseVisualStyleBackColor = true;
            // 
            // Rad_btn_medic
            // 
            this.Rad_btn_medic.AutoSize = true;
            this.Rad_btn_medic.Location = new System.Drawing.Point(24, 25);
            this.Rad_btn_medic.Name = "Rad_btn_medic";
            this.Rad_btn_medic.Size = new System.Drawing.Size(115, 20);
            this.Rad_btn_medic.TabIndex = 0;
            this.Rad_btn_medic.TabStop = true;
            this.Rad_btn_medic.Text = "Medicamentos";
            this.Rad_btn_medic.UseVisualStyleBackColor = true;
            // 
            // txt_medic
            // 
            this.txt_medic.Location = new System.Drawing.Point(116, 26);
            this.txt_medic.Name = "txt_medic";
            this.txt_medic.Pp_mensajeError = null;
            this.txt_medic.Pp_nombre_campo = null;
            this.txt_medic.Pp_nombre_tabla = null;
            this.txt_medic.Pp_validable = false;
            this.txt_medic.Size = new System.Drawing.Size(168, 22);
            this.txt_medic.TabIndex = 41;
            // 
            // Cmb_Lab
            // 
            this.Cmb_Lab.FormattingEnabled = true;
            this.Cmb_Lab.Location = new System.Drawing.Point(116, 63);
            this.Cmb_Lab.Name = "Cmb_Lab";
            this.Cmb_Lab.Pp_Display = "Razon_Social";
            this.Cmb_Lab.Pp_mensajeError = null;
            this.Cmb_Lab.Pp_nombre_campo = null;
            this.Cmb_Lab.Pp_nombre_tabla = null;
            this.Cmb_Lab.Pp_seleccionado = false;
            this.Cmb_Lab.Pp_Tabla = "Laboratorios";
            this.Cmb_Lab.Pp_validable = false;
            this.Cmb_Lab.Pp_Value = "CUIT_Laboratorio";
            this.Cmb_Lab.Size = new System.Drawing.Size(168, 24);
            this.Cmb_Lab.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 38;
            this.label1.Text = "Medicamento";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 66);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 16);
            this.label10.TabIndex = 39;
            this.label10.Text = "Laboratorio";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(8, 113);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(705, 400);
            this.tabControl1.TabIndex = 37;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rv_simple);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(697, 371);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Medicamentos por Laboratorio";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rv_simple
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.dSLabMedic01BindingSource;
            this.rv_simple.LocalReport.DataSources.Add(reportDataSource1);
            this.rv_simple.LocalReport.ReportEmbeddedResource = "Farmacia_Matute.Capa_Presentacion_Formularios.Reportes.Reporte_Lab_Medic01.rdlc";
            this.rv_simple.Location = new System.Drawing.Point(0, 0);
            this.rv_simple.Name = "rv_simple";
            this.rv_simple.ServerReport.BearerToken = null;
            this.rv_simple.Size = new System.Drawing.Size(697, 422);
            this.rv_simple.TabIndex = 0;
            // 
            // Frm_Reporte_Medic_Lab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(745, 551);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Reporte_Medic_Lab";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Medicamento por Laboratorios";
            this.Load += new System.EventHandler(this.Frm_Reporte_Medic_Lab_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSLabMedic01BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Lab_Medic01)).EndInit();
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
        private Clases.TextBox01 txt_medic;
        private Clases.ComboBox01 Cmb_Lab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private Microsoft.Reporting.WinForms.ReportViewer rv_simple;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.RadioButton Rad_btn_Lab;
        private System.Windows.Forms.RadioButton Rad_btn_medic;
        private System.Windows.Forms.BindingSource dSLabMedic01BindingSource;
        private DS_Lab_Medic01 dS_Lab_Medic01;
    }
}