namespace Farmacia_Matute.Capa_Presentacion_Formularios.Estadisticas
{
    partial class Frm_EstadisticasCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_EstadisticasCompras));
            this.grb_estadisticasCompras = new System.Windows.Forms.GroupBox();
            this.rv_simple = new Microsoft.Reporting.WinForms.ReportViewer();
            this.grb_datos = new System.Windows.Forms.GroupBox();
            this.rb_PorLaboratorio = new System.Windows.Forms.RadioButton();
            this.rb_PorMedicamentos = new System.Windows.Forms.RadioButton();
            this.grb_restriccion = new System.Windows.Forms.GroupBox();
            this.rb_Periodo = new System.Windows.Forms.RadioButton();
            this.rb_Empleado = new System.Windows.Forms.RadioButton();
            this.rb_Fecha = new System.Windows.Forms.RadioButton();
            this.lblt_fecha = new Farmacia_Matute.Clases.LabelText01();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.cmb_tipo_doc = new Farmacia_Matute.Clases.ComboBox01();
            this.txt_nrodoc = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_tipoDocumento = new System.Windows.Forms.Label();
            this.grb_estadisticasCompras.SuspendLayout();
            this.grb_datos.SuspendLayout();
            this.grb_restriccion.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb_estadisticasCompras
            // 
            this.grb_estadisticasCompras.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.grb_estadisticasCompras.Controls.Add(this.rv_simple);
            this.grb_estadisticasCompras.Controls.Add(this.grb_datos);
            this.grb_estadisticasCompras.Controls.Add(this.grb_restriccion);
            this.grb_estadisticasCompras.Controls.Add(this.lblt_fecha);
            this.grb_estadisticasCompras.Controls.Add(this.btn_buscar);
            this.grb_estadisticasCompras.Controls.Add(this.cmb_tipo_doc);
            this.grb_estadisticasCompras.Controls.Add(this.txt_nrodoc);
            this.grb_estadisticasCompras.Controls.Add(this.label4);
            this.grb_estadisticasCompras.Controls.Add(this.lbl_tipoDocumento);
            this.grb_estadisticasCompras.Location = new System.Drawing.Point(11, 12);
            this.grb_estadisticasCompras.Name = "grb_estadisticasCompras";
            this.grb_estadisticasCompras.Size = new System.Drawing.Size(697, 520);
            this.grb_estadisticasCompras.TabIndex = 0;
            this.grb_estadisticasCompras.TabStop = false;
            this.grb_estadisticasCompras.Text = "Estadisticas";
            // 
            // rv_simple
            // 
            this.rv_simple.Location = new System.Drawing.Point(10, 152);
            this.rv_simple.Name = "rv_simple";
            this.rv_simple.ServerReport.BearerToken = null;
            this.rv_simple.Size = new System.Drawing.Size(671, 362);
            this.rv_simple.TabIndex = 6;
            // 
            // grb_datos
            // 
            this.grb_datos.Controls.Add(this.rb_PorLaboratorio);
            this.grb_datos.Controls.Add(this.rb_PorMedicamentos);
            this.grb_datos.Location = new System.Drawing.Point(282, 30);
            this.grb_datos.Name = "grb_datos";
            this.grb_datos.Size = new System.Drawing.Size(144, 69);
            this.grb_datos.TabIndex = 3;
            this.grb_datos.TabStop = false;
            this.grb_datos.Text = "Datos ";
            // 
            // rb_PorLaboratorio
            // 
            this.rb_PorLaboratorio.AutoSize = true;
            this.rb_PorLaboratorio.Location = new System.Drawing.Point(18, 47);
            this.rb_PorLaboratorio.Name = "rb_PorLaboratorio";
            this.rb_PorLaboratorio.Size = new System.Drawing.Size(102, 17);
            this.rb_PorLaboratorio.TabIndex = 1;
            this.rb_PorLaboratorio.Text = "Por Laboratorios";
            this.rb_PorLaboratorio.UseVisualStyleBackColor = true;
            // 
            // rb_PorMedicamentos
            // 
            this.rb_PorMedicamentos.AutoSize = true;
            this.rb_PorMedicamentos.Location = new System.Drawing.Point(18, 19);
            this.rb_PorMedicamentos.Name = "rb_PorMedicamentos";
            this.rb_PorMedicamentos.Size = new System.Drawing.Size(113, 17);
            this.rb_PorMedicamentos.TabIndex = 0;
            this.rb_PorMedicamentos.Text = "Por Medicamentos";
            this.rb_PorMedicamentos.UseVisualStyleBackColor = true;
            // 
            // grb_restriccion
            // 
            this.grb_restriccion.Controls.Add(this.rb_Periodo);
            this.grb_restriccion.Controls.Add(this.rb_Empleado);
            this.grb_restriccion.Controls.Add(this.rb_Fecha);
            this.grb_restriccion.Location = new System.Drawing.Point(455, 30);
            this.grb_restriccion.Name = "grb_restriccion";
            this.grb_restriccion.Size = new System.Drawing.Size(116, 95);
            this.grb_restriccion.TabIndex = 4;
            this.grb_restriccion.TabStop = false;
            this.grb_restriccion.Text = "Restriccion ";
            // 
            // rb_Periodo
            // 
            this.rb_Periodo.AutoSize = true;
            this.rb_Periodo.Location = new System.Drawing.Point(35, 22);
            this.rb_Periodo.Name = "rb_Periodo";
            this.rb_Periodo.Size = new System.Drawing.Size(61, 17);
            this.rb_Periodo.TabIndex = 0;
            this.rb_Periodo.Text = "Periodo";
            this.rb_Periodo.UseVisualStyleBackColor = true;
            // 
            // rb_Empleado
            // 
            this.rb_Empleado.AutoSize = true;
            this.rb_Empleado.Location = new System.Drawing.Point(35, 68);
            this.rb_Empleado.Name = "rb_Empleado";
            this.rb_Empleado.Size = new System.Drawing.Size(72, 17);
            this.rb_Empleado.TabIndex = 2;
            this.rb_Empleado.Text = "Empleado";
            this.rb_Empleado.UseVisualStyleBackColor = true;
            // 
            // rb_Fecha
            // 
            this.rb_Fecha.AutoSize = true;
            this.rb_Fecha.Checked = true;
            this.rb_Fecha.Location = new System.Drawing.Point(35, 45);
            this.rb_Fecha.Name = "rb_Fecha";
            this.rb_Fecha.Size = new System.Drawing.Size(55, 17);
            this.rb_Fecha.TabIndex = 1;
            this.rb_Fecha.TabStop = true;
            this.rb_Fecha.Text = "Fecha";
            this.rb_Fecha.UseVisualStyleBackColor = true;
            // 
            // lblt_fecha
            // 
            this.lblt_fecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblt_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblt_fecha.Location = new System.Drawing.Point(10, 94);
            this.lblt_fecha.Margin = new System.Windows.Forms.Padding(4);
            this.lblt_fecha.Name = "lblt_fecha";
            this.lblt_fecha.Pp_Etiqueta = "Fecha:";
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
            // btn_buscar
            // 
            this.btn_buscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_buscar.BackgroundImage")));
            this.btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar.Location = new System.Drawing.Point(616, 83);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(45, 47);
            this.btn_buscar.TabIndex = 5;
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // cmb_tipo_doc
            // 
            this.cmb_tipo_doc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipo_doc.FormattingEnabled = true;
            this.cmb_tipo_doc.Location = new System.Drawing.Point(164, 32);
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
            // txt_nrodoc
            // 
            this.txt_nrodoc.Location = new System.Drawing.Point(164, 60);
            this.txt_nrodoc.Mask = "99999999";
            this.txt_nrodoc.Name = "txt_nrodoc";
            this.txt_nrodoc.Size = new System.Drawing.Size(59, 20);
            this.txt_nrodoc.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 63);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = "Número de Documento";
            // 
            // lbl_tipoDocumento
            // 
            this.lbl_tipoDocumento.AutoSize = true;
            this.lbl_tipoDocumento.Location = new System.Drawing.Point(40, 35);
            this.lbl_tipoDocumento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_tipoDocumento.Name = "lbl_tipoDocumento";
            this.lbl_tipoDocumento.Size = new System.Drawing.Size(101, 13);
            this.lbl_tipoDocumento.TabIndex = 47;
            this.lbl_tipoDocumento.Text = "Tipo de Documento";
            // 
            // Frm_EstadisticasCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(720, 544);
            this.Controls.Add(this.grb_estadisticasCompras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_EstadisticasCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ESTADISTICAS DE COMPRAS";
            this.Load += new System.EventHandler(this.Frm_EstadisticasCompras_Load);
            this.grb_estadisticasCompras.ResumeLayout(false);
            this.grb_estadisticasCompras.PerformLayout();
            this.grb_datos.ResumeLayout(false);
            this.grb_datos.PerformLayout();
            this.grb_restriccion.ResumeLayout(false);
            this.grb_restriccion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_estadisticasCompras;
        private System.Windows.Forms.GroupBox grb_datos;
        private System.Windows.Forms.RadioButton rb_PorLaboratorio;
        private System.Windows.Forms.RadioButton rb_PorMedicamentos;
        private System.Windows.Forms.GroupBox grb_restriccion;
        private System.Windows.Forms.RadioButton rb_Periodo;
        private System.Windows.Forms.RadioButton rb_Empleado;
        private System.Windows.Forms.RadioButton rb_Fecha;
        private Clases.LabelText01 lblt_fecha;
        private System.Windows.Forms.Button btn_buscar;
        private Clases.ComboBox01 cmb_tipo_doc;
        private System.Windows.Forms.MaskedTextBox txt_nrodoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_tipoDocumento;
        private Microsoft.Reporting.WinForms.ReportViewer rv_simple;
    }
}