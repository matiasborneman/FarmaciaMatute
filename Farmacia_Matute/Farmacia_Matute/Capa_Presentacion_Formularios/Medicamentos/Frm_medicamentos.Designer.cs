namespace Farmacia_Matute.Capa_Presemtacion_Formularios.Medicamentos
{
    partial class Frm_medicamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_medicamentos));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_grabar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_precio_lista = new System.Windows.Forms.TextBox();
            this.txt_nombre_medicamento = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_cuit_laboratorio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_idmedicamento = new System.Windows.Forms.TextBox();
            this.cmb_laboratorio = new Farmacia_Matute.Clases.ComboBox01();
            this.lblt_fecha = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // btn_salir
            // 
            this.btn_salir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_salir.BackgroundImage")));
            this.btn_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_salir.Location = new System.Drawing.Point(628, 161);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(50, 50);
            this.btn_salir.TabIndex = 10;
            this.toolTip1.SetToolTip(this.btn_salir, "Salir");
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_grabar
            // 
            this.btn_grabar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_grabar.BackgroundImage")));
            this.btn_grabar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_grabar.Location = new System.Drawing.Point(516, 161);
            this.btn_grabar.Name = "btn_grabar";
            this.btn_grabar.Size = new System.Drawing.Size(50, 50);
            this.btn_grabar.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btn_grabar, "Grabar");
            this.btn_grabar.UseVisualStyleBackColor = true;
            this.btn_grabar.Click += new System.EventHandler(this.btn_grabar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_eliminar.BackgroundImage")));
            this.btn_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_eliminar.Location = new System.Drawing.Point(572, 161);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(50, 50);
            this.btn_eliminar.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btn_eliminar, "Eliminar");
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_editar.BackgroundImage")));
            this.btn_editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_editar.Location = new System.Drawing.Point(460, 161);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(50, 50);
            this.btn_editar.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btn_editar, "Editar");
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_nuevo.BackgroundImage")));
            this.btn_nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_nuevo.Location = new System.Drawing.Point(404, 161);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(50, 50);
            this.btn_nuevo.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btn_nuevo, "Nuevo");
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_buscar.BackgroundImage")));
            this.btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar.Location = new System.Drawing.Point(351, 161);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(50, 50);
            this.btn_buscar.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btn_buscar, "Buscar");
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(377, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Laboratorio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(377, 100);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Fecha de Alta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Precio de Lista";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // txt_precio_lista
            // 
            this.txt_precio_lista.Location = new System.Drawing.Point(139, 97);
            this.txt_precio_lista.Margin = new System.Windows.Forms.Padding(4);
            this.txt_precio_lista.Name = "txt_precio_lista";
            this.txt_precio_lista.Size = new System.Drawing.Size(198, 24);
            this.txt_precio_lista.TabIndex = 3;
            // 
            // txt_nombre_medicamento
            // 
            this.txt_nombre_medicamento.Location = new System.Drawing.Point(139, 66);
            this.txt_nombre_medicamento.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nombre_medicamento.Name = "txt_nombre_medicamento";
            this.txt_nombre_medicamento.Size = new System.Drawing.Size(198, 24);
            this.txt_nombre_medicamento.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_cuit_laboratorio);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_idmedicamento);
            this.groupBox1.Controls.Add(this.cmb_laboratorio);
            this.groupBox1.Controls.Add(this.lblt_fecha);
            this.groupBox1.Controls.Add(this.btn_salir);
            this.groupBox1.Controls.Add(this.btn_grabar);
            this.groupBox1.Controls.Add(this.btn_eliminar);
            this.groupBox1.Controls.Add(this.btn_editar);
            this.groupBox1.Controls.Add(this.btn_nuevo);
            this.groupBox1.Controls.Add(this.btn_buscar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_precio_lista);
            this.groupBox1.Controls.Add(this.txt_nombre_medicamento);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(695, 240);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Medicamento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(352, 69);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "CUIT Laboratorio";
            // 
            // txt_cuit_laboratorio
            // 
            this.txt_cuit_laboratorio.Location = new System.Drawing.Point(480, 66);
            this.txt_cuit_laboratorio.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cuit_laboratorio.Name = "txt_cuit_laboratorio";
            this.txt_cuit_laboratorio.ReadOnly = true;
            this.txt_cuit_laboratorio.Size = new System.Drawing.Size(198, 24);
            this.txt_cuit_laboratorio.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 38);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Id:";
            // 
            // txt_idmedicamento
            // 
            this.txt_idmedicamento.Location = new System.Drawing.Point(139, 35);
            this.txt_idmedicamento.Margin = new System.Windows.Forms.Padding(4);
            this.txt_idmedicamento.Name = "txt_idmedicamento";
            this.txt_idmedicamento.Size = new System.Drawing.Size(92, 24);
            this.txt_idmedicamento.TabIndex = 0;
            // 
            // cmb_laboratorio
            // 
            this.cmb_laboratorio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_laboratorio.FormattingEnabled = true;
            this.cmb_laboratorio.Location = new System.Drawing.Point(479, 33);
            this.cmb_laboratorio.Name = "cmb_laboratorio";
            this.cmb_laboratorio.Pp_Display = null;
            this.cmb_laboratorio.Pp_mensajeError = null;
            this.cmb_laboratorio.Pp_nombre_campo = null;
            this.cmb_laboratorio.Pp_nombre_tabla = null;
            this.cmb_laboratorio.Pp_seleccionado = false;
            this.cmb_laboratorio.Pp_Tabla = null;
            this.cmb_laboratorio.Pp_validable = false;
            this.cmb_laboratorio.Pp_Value = null;
            this.cmb_laboratorio.Size = new System.Drawing.Size(199, 26);
            this.cmb_laboratorio.TabIndex = 2;
            this.cmb_laboratorio.SelectionChangeCommitted += new System.EventHandler(this.cmb_laboratorio_SelectionChangeCommitted);
            // 
            // lblt_fecha
            // 
            this.lblt_fecha.Location = new System.Drawing.Point(479, 97);
            this.lblt_fecha.Mask = "00/00/0000";
            this.lblt_fecha.Name = "lblt_fecha";
            this.lblt_fecha.Size = new System.Drawing.Size(87, 24);
            this.lblt_fecha.TabIndex = 4;
            this.lblt_fecha.ValidatingType = typeof(System.DateTime);
            // 
            // Frm_medicamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(721, 267);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_medicamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Medicamentos";
            this.Load += new System.EventHandler(this.Frm_medicamentos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_grabar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_precio_lista;
        private System.Windows.Forms.TextBox txt_nombre_medicamento;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox lblt_fecha;
        private Clases.ComboBox01 cmb_laboratorio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_idmedicamento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_cuit_laboratorio;
    }
}