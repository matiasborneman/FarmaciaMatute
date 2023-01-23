namespace Farmacia_Matute.Capa_Presentacion_Formularios.Reportes
{
    partial class Frm_ReporteCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ReporteCompras));
            this.lbl_nrofac = new System.Windows.Forms.Label();
            this.lbl_tipofac = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_nrodoc = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.grb_reportes = new System.Windows.Forms.GroupBox();
            this.grb_restriccion = new System.Windows.Forms.GroupBox();
            this.rb_Factura = new System.Windows.Forms.RadioButton();
            this.rb_Fecha = new System.Windows.Forms.RadioButton();
            this.rb_Periodo = new System.Windows.Forms.RadioButton();
            this.rb_Empleado = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rv_simple = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lblt_fecha = new Farmacia_Matute.Clases.LabelText01();
            this.cmb_tipo_doc = new Farmacia_Matute.Clases.ComboBox01();
            this.txt_nrofac = new Farmacia_Matute.Clases.TextBox01();
            this.cmb_tipo_factura = new Farmacia_Matute.Clases.ComboBox01();
            this.grb_reportes.SuspendLayout();
            this.grb_restriccion.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_nrofac
            // 
            this.lbl_nrofac.AutoSize = true;
            this.lbl_nrofac.Location = new System.Drawing.Point(40, 94);
            this.lbl_nrofac.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nrofac.Name = "lbl_nrofac";
            this.lbl_nrofac.Size = new System.Drawing.Size(63, 13);
            this.lbl_nrofac.TabIndex = 44;
            this.lbl_nrofac.Text = "Nro Factura";
            // 
            // lbl_tipofac
            // 
            this.lbl_tipofac.AutoSize = true;
            this.lbl_tipofac.Location = new System.Drawing.Point(169, 95);
            this.lbl_tipofac.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_tipofac.Name = "lbl_tipofac";
            this.lbl_tipofac.Size = new System.Drawing.Size(67, 13);
            this.lbl_tipofac.TabIndex = 42;
            this.lbl_tipofac.Text = "Tipo Factura";
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_buscar.BackgroundImage")));
            this.btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar.Location = new System.Drawing.Point(560, 97);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(45, 47);
            this.btn_buscar.TabIndex = 6;
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // txt_nrodoc
            // 
            this.txt_nrodoc.Location = new System.Drawing.Point(164, 53);
            this.txt_nrodoc.Mask = "99999999";
            this.txt_nrodoc.Name = "txt_nrodoc";
            this.txt_nrodoc.Size = new System.Drawing.Size(59, 20);
            this.txt_nrodoc.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 56);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = "Número de Documento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 28);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 13);
            this.label8.TabIndex = 47;
            this.label8.Text = "Tipo de Documento";
            // 
            // grb_reportes
            // 
            this.grb_reportes.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.grb_reportes.Controls.Add(this.grb_restriccion);
            this.grb_reportes.Controls.Add(this.tabControl1);
            this.grb_reportes.Controls.Add(this.btn_buscar);
            this.grb_reportes.Controls.Add(this.lblt_fecha);
            this.grb_reportes.Controls.Add(this.cmb_tipo_doc);
            this.grb_reportes.Controls.Add(this.txt_nrodoc);
            this.grb_reportes.Controls.Add(this.label4);
            this.grb_reportes.Controls.Add(this.label8);
            this.grb_reportes.Controls.Add(this.lbl_nrofac);
            this.grb_reportes.Controls.Add(this.txt_nrofac);
            this.grb_reportes.Controls.Add(this.lbl_tipofac);
            this.grb_reportes.Controls.Add(this.cmb_tipo_factura);
            this.grb_reportes.Location = new System.Drawing.Point(12, 3);
            this.grb_reportes.Name = "grb_reportes";
            this.grb_reportes.Size = new System.Drawing.Size(621, 501);
            this.grb_reportes.TabIndex = 0;
            this.grb_reportes.TabStop = false;
            this.grb_reportes.Text = "Reportes";
            // 
            // grb_restriccion
            // 
            this.grb_restriccion.Controls.Add(this.rb_Factura);
            this.grb_restriccion.Controls.Add(this.rb_Fecha);
            this.grb_restriccion.Controls.Add(this.rb_Periodo);
            this.grb_restriccion.Controls.Add(this.rb_Empleado);
            this.grb_restriccion.Location = new System.Drawing.Point(347, 88);
            this.grb_restriccion.Name = "grb_restriccion";
            this.grb_restriccion.Size = new System.Drawing.Size(189, 70);
            this.grb_restriccion.TabIndex = 5;
            this.grb_restriccion.TabStop = false;
            this.grb_restriccion.Text = "Restriccion";
            // 
            // rb_Factura
            // 
            this.rb_Factura.AutoSize = true;
            this.rb_Factura.Location = new System.Drawing.Point(120, 42);
            this.rb_Factura.Name = "rb_Factura";
            this.rb_Factura.Size = new System.Drawing.Size(61, 17);
            this.rb_Factura.TabIndex = 3;
            this.rb_Factura.TabStop = true;
            this.rb_Factura.Text = "Factura";
            this.rb_Factura.UseVisualStyleBackColor = true;
            // 
            // rb_Fecha
            // 
            this.rb_Fecha.AutoSize = true;
            this.rb_Fecha.Location = new System.Drawing.Point(120, 19);
            this.rb_Fecha.Name = "rb_Fecha";
            this.rb_Fecha.Size = new System.Drawing.Size(55, 17);
            this.rb_Fecha.TabIndex = 2;
            this.rb_Fecha.TabStop = true;
            this.rb_Fecha.Text = "Fecha";
            this.rb_Fecha.UseVisualStyleBackColor = true;
            // 
            // rb_Periodo
            // 
            this.rb_Periodo.AutoSize = true;
            this.rb_Periodo.Location = new System.Drawing.Point(16, 19);
            this.rb_Periodo.Name = "rb_Periodo";
            this.rb_Periodo.Size = new System.Drawing.Size(61, 17);
            this.rb_Periodo.TabIndex = 0;
            this.rb_Periodo.TabStop = true;
            this.rb_Periodo.Text = "Periodo";
            this.rb_Periodo.UseVisualStyleBackColor = true;
            // 
            // rb_Empleado
            // 
            this.rb_Empleado.AutoSize = true;
            this.rb_Empleado.Location = new System.Drawing.Point(16, 42);
            this.rb_Empleado.Name = "rb_Empleado";
            this.rb_Empleado.Size = new System.Drawing.Size(72, 17);
            this.rb_Empleado.TabIndex = 1;
            this.rb_Empleado.TabStop = true;
            this.rb_Empleado.Text = "Empleado";
            this.rb_Empleado.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(15, 150);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(600, 345);
            this.tabControl1.TabIndex = 50;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rv_simple);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(592, 319);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Simple";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rv_simple
            // 
            this.rv_simple.LocalReport.ReportEmbeddedResource = "Farmacia_Matute.Capa_Presentacion_Formularios.Reportes.ReporteCompras1.rdlc";
            this.rv_simple.Location = new System.Drawing.Point(3, 6);
            this.rv_simple.Name = "rv_simple";
            this.rv_simple.ServerReport.BearerToken = null;
            this.rv_simple.Size = new System.Drawing.Size(583, 310);
            this.rv_simple.TabIndex = 0;
            // 
            // lblt_fecha
            // 
            this.lblt_fecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblt_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblt_fecha.Location = new System.Drawing.Point(309, 20);
            this.lblt_fecha.Margin = new System.Windows.Forms.Padding(4);
            this.lblt_fecha.Name = "lblt_fecha";
            this.lblt_fecha.Pp_Etiqueta = "Fecha";
            this.lblt_fecha.Pp_mask = "99/99/9999";
            this.lblt_fecha.Pp_mensajeError = null;
            this.lblt_fecha.Pp_nombre_campo = null;
            this.lblt_fecha.Pp_nombre_tabla = null;
            this.lblt_fecha.Pp_ReadOnly = false;
            this.lblt_fecha.Pp_Text = "  /  /";
            this.lblt_fecha.Pp_validable = false;
            this.lblt_fecha.Size = new System.Drawing.Size(227, 28);
            this.lblt_fecha.TabIndex = 2;
            // 
            // cmb_tipo_doc
            // 
            this.cmb_tipo_doc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipo_doc.FormattingEnabled = true;
            this.cmb_tipo_doc.Location = new System.Drawing.Point(164, 25);
            this.cmb_tipo_doc.Name = "cmb_tipo_doc";
            this.cmb_tipo_doc.Pp_Display = null;
            this.cmb_tipo_doc.Pp_mensajeError = null;
            this.cmb_tipo_doc.Pp_nombre_campo = null;
            this.cmb_tipo_doc.Pp_nombre_tabla = null;
            this.cmb_tipo_doc.Pp_seleccionado = false;
            this.cmb_tipo_doc.Pp_Tabla = null;
            this.cmb_tipo_doc.Pp_validable = false;
            this.cmb_tipo_doc.Pp_Value = null;
            this.cmb_tipo_doc.Size = new System.Drawing.Size(112, 21);
            this.cmb_tipo_doc.TabIndex = 0;
            // 
            // txt_nrofac
            // 
            this.txt_nrofac.Location = new System.Drawing.Point(105, 91);
            this.txt_nrofac.Name = "txt_nrofac";
            this.txt_nrofac.Pp_mensajeError = null;
            this.txt_nrofac.Pp_nombre_campo = null;
            this.txt_nrofac.Pp_nombre_tabla = null;
            this.txt_nrofac.Pp_validable = false;
            this.txt_nrofac.Size = new System.Drawing.Size(52, 20);
            this.txt_nrofac.TabIndex = 3;
            // 
            // cmb_tipo_factura
            // 
            this.cmb_tipo_factura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipo_factura.FormattingEnabled = true;
            this.cmb_tipo_factura.Location = new System.Drawing.Point(243, 91);
            this.cmb_tipo_factura.Name = "cmb_tipo_factura";
            this.cmb_tipo_factura.Pp_Display = null;
            this.cmb_tipo_factura.Pp_mensajeError = null;
            this.cmb_tipo_factura.Pp_nombre_campo = null;
            this.cmb_tipo_factura.Pp_nombre_tabla = null;
            this.cmb_tipo_factura.Pp_seleccionado = false;
            this.cmb_tipo_factura.Pp_Tabla = null;
            this.cmb_tipo_factura.Pp_validable = false;
            this.cmb_tipo_factura.Pp_Value = null;
            this.cmb_tipo_factura.Size = new System.Drawing.Size(98, 21);
            this.cmb_tipo_factura.TabIndex = 4;
            // 
            // Frm_ReporteCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(645, 516);
            this.Controls.Add(this.grb_reportes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_ReporteCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REPORTES COMPRAS";
            this.Load += new System.EventHandler(this.Frm_ReporteCompras_Load);
            this.grb_reportes.ResumeLayout(false);
            this.grb_reportes.PerformLayout();
            this.grb_restriccion.ResumeLayout(false);
            this.grb_restriccion.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_nrofac;
        private Clases.TextBox01 txt_nrofac;
        private System.Windows.Forms.Label lbl_tipofac;
        private Clases.ComboBox01 cmb_tipo_factura;
        private Clases.LabelText01 lblt_fecha;
        private System.Windows.Forms.Button btn_buscar;
        private Clases.ComboBox01 cmb_tipo_doc;
        private System.Windows.Forms.MaskedTextBox txt_nrodoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox grb_reportes;
        private System.Windows.Forms.RadioButton rb_Factura;
        private System.Windows.Forms.RadioButton rb_Fecha;
        private System.Windows.Forms.TabControl tabControl1;
        private Microsoft.Reporting.WinForms.ReportViewer rv_simple;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RadioButton rb_Empleado;
        private System.Windows.Forms.RadioButton rb_Periodo;
        private System.Windows.Forms.GroupBox grb_restriccion;
    }
}