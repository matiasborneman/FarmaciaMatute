namespace Farmacia_Matute.Capa_Presentacion_Formularios.Reportes
{
    partial class Frm_ReportesClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ReportesClientes));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dSClientesObSoc01BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Clientes_Ob_Soc_01 = new Farmacia_Matute.Capa_Presentacion_Formularios.Reportes.DS_Clientes_Ob_Soc_01();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.Rad_btn_Ob_Soc = new System.Windows.Forms.RadioButton();
            this.Rad_btn_Tipo_Nro_Doc = new System.Windows.Forms.RadioButton();
            this.txt_Nro_Doc = new Farmacia_Matute.Clases.TextBox01();
            this.Cmb_Tipo_Doc = new Farmacia_Matute.Clases.ComboBox01();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Cmb_Obra_Soc = new Farmacia_Matute.Clases.ComboBox01();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rv_simple = new Microsoft.Reporting.WinForms.ReportViewer();
            this.clienteObSocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dSClientesObSoc01BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Clientes_Ob_Soc_01)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteObSocBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dSClientesObSoc01BindingSource
            // 
            this.dSClientesObSoc01BindingSource.DataSource = this.dS_Clientes_Ob_Soc_01;
            this.dSClientesObSoc01BindingSource.Position = 0;
            // 
            // dS_Clientes_Ob_Soc_01
            // 
            this.dS_Clientes_Ob_Soc_01.DataSetName = "DS_Clientes_Ob_Soc_01";
            this.dS_Clientes_Ob_Soc_01.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txt_Nro_Doc);
            this.groupBox1.Controls.Add(this.Cmb_Tipo_Doc);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.Cmb_Obra_Soc);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(719, 525);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reportes de Clientes";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Btn_Salir);
            this.groupBox2.Controls.Add(this.Btn_Buscar);
            this.groupBox2.Controls.Add(this.btn_limpiar);
            this.groupBox2.Controls.Add(this.Rad_btn_Ob_Soc);
            this.groupBox2.Controls.Add(this.Rad_btn_Tipo_Nro_Doc);
            this.groupBox2.Location = new System.Drawing.Point(413, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(297, 102);
            this.groupBox2.TabIndex = 34;
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
            this.btn_limpiar.Location = new System.Drawing.Point(24, 56);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(72, 36);
            this.btn_limpiar.TabIndex = 2;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // Rad_btn_Ob_Soc
            // 
            this.Rad_btn_Ob_Soc.AutoSize = true;
            this.Rad_btn_Ob_Soc.Location = new System.Drawing.Point(169, 25);
            this.Rad_btn_Ob_Soc.Name = "Rad_btn_Ob_Soc";
            this.Rad_btn_Ob_Soc.Size = new System.Drawing.Size(89, 19);
            this.Rad_btn_Ob_Soc.TabIndex = 1;
            this.Rad_btn_Ob_Soc.TabStop = true;
            this.Rad_btn_Ob_Soc.Text = "Obra Social";
            this.Rad_btn_Ob_Soc.UseVisualStyleBackColor = true;
            // 
            // Rad_btn_Tipo_Nro_Doc
            // 
            this.Rad_btn_Tipo_Nro_Doc.AutoSize = true;
            this.Rad_btn_Tipo_Nro_Doc.Location = new System.Drawing.Point(24, 25);
            this.Rad_btn_Tipo_Nro_Doc.Name = "Rad_btn_Tipo_Nro_Doc";
            this.Rad_btn_Tipo_Nro_Doc.Size = new System.Drawing.Size(111, 19);
            this.Rad_btn_Tipo_Nro_Doc.TabIndex = 0;
            this.Rad_btn_Tipo_Nro_Doc.TabStop = true;
            this.Rad_btn_Tipo_Nro_Doc.Text = "Tipo y Nro. Doc.";
            this.Rad_btn_Tipo_Nro_Doc.UseVisualStyleBackColor = true;
            // 
            // txt_Nro_Doc
            // 
            this.txt_Nro_Doc.Location = new System.Drawing.Point(109, 56);
            this.txt_Nro_Doc.Name = "txt_Nro_Doc";
            this.txt_Nro_Doc.Pp_mensajeError = null;
            this.txt_Nro_Doc.Pp_nombre_campo = null;
            this.txt_Nro_Doc.Pp_nombre_tabla = null;
            this.txt_Nro_Doc.Pp_validable = false;
            this.txt_Nro_Doc.Size = new System.Drawing.Size(121, 21);
            this.txt_Nro_Doc.TabIndex = 33;
            // 
            // Cmb_Tipo_Doc
            // 
            this.Cmb_Tipo_Doc.FormattingEnabled = true;
            this.Cmb_Tipo_Doc.Location = new System.Drawing.Point(109, 24);
            this.Cmb_Tipo_Doc.Name = "Cmb_Tipo_Doc";
            this.Cmb_Tipo_Doc.Pp_Display = "Descripcion";
            this.Cmb_Tipo_Doc.Pp_mensajeError = null;
            this.Cmb_Tipo_Doc.Pp_nombre_campo = null;
            this.Cmb_Tipo_Doc.Pp_nombre_tabla = null;
            this.Cmb_Tipo_Doc.Pp_seleccionado = false;
            this.Cmb_Tipo_Doc.Pp_Tabla = "Tipo_Documento";
            this.Cmb_Tipo_Doc.Pp_validable = false;
            this.Cmb_Tipo_Doc.Pp_Value = "Id_Tipo_Doc";
            this.Cmb_Tipo_Doc.Size = new System.Drawing.Size(121, 23);
            this.Cmb_Tipo_Doc.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 59);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 30;
            this.label4.Text = "Nro. Doc.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 27);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 15);
            this.label8.TabIndex = 31;
            this.label8.Text = "Tipo Doc.";
            // 
            // Cmb_Obra_Soc
            // 
            this.Cmb_Obra_Soc.FormattingEnabled = true;
            this.Cmb_Obra_Soc.Location = new System.Drawing.Point(109, 86);
            this.Cmb_Obra_Soc.Name = "Cmb_Obra_Soc";
            this.Cmb_Obra_Soc.Pp_Display = "descripcion";
            this.Cmb_Obra_Soc.Pp_mensajeError = null;
            this.Cmb_Obra_Soc.Pp_nombre_campo = null;
            this.Cmb_Obra_Soc.Pp_nombre_tabla = null;
            this.Cmb_Obra_Soc.Pp_seleccionado = false;
            this.Cmb_Obra_Soc.Pp_Tabla = "Obra_Social";
            this.Cmb_Obra_Soc.Pp_validable = false;
            this.Cmb_Obra_Soc.Pp_Value = "id_ob_soc";
            this.Cmb_Obra_Soc.Size = new System.Drawing.Size(168, 23);
            this.Cmb_Obra_Soc.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 89);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 15);
            this.label10.TabIndex = 28;
            this.label10.Text = "Obra social";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(7, 118);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(705, 400);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rv_simple);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(697, 372);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Padron de Clientes por Obra Social";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rv_simple
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.dSClientesObSoc01BindingSource;
            this.rv_simple.LocalReport.DataSources.Add(reportDataSource1);
            this.rv_simple.LocalReport.ReportEmbeddedResource = "Farmacia_Matute.Capa_Presentacion_Formularios.Reportes.Reporte_Clientes_Ob_Soc_01" +
    ".rdlc";
            this.rv_simple.Location = new System.Drawing.Point(0, 1);
            this.rv_simple.Name = "rv_simple";
            this.rv_simple.ServerReport.BearerToken = null;
            this.rv_simple.Size = new System.Drawing.Size(697, 368);
            this.rv_simple.TabIndex = 0;
            // 
            // clienteObSocBindingSource
            // 
            this.clienteObSocBindingSource.DataMember = "Cliente _Ob_Soc";
            this.clienteObSocBindingSource.DataSource = this.dSClientesObSoc01BindingSource;
            // 
            // Frm_ReportesClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(745, 551);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_ReportesClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes Clientes";
            this.Load += new System.EventHandler(this.Frm_ReportesClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSClientesObSoc01BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Clientes_Ob_Soc_01)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clienteObSocBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Clases.TextBox01 txt_Nro_Doc;
        private Clases.ComboBox01 Cmb_Tipo_Doc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private Clases.ComboBox01 Cmb_Obra_Soc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton Rad_btn_Tipo_Nro_Doc;
        private System.Windows.Forms.RadioButton Rad_btn_Ob_Soc;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button Btn_Salir;
        private Microsoft.Reporting.WinForms.ReportViewer rv_simple;
        private System.Windows.Forms.BindingSource dSClientesObSoc01BindingSource;
        private DS_Clientes_Ob_Soc_01 dS_Clientes_Ob_Soc_01;
        private System.Windows.Forms.BindingSource clienteObSocBindingSource;
    }
}