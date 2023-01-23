namespace Farmacia_Matute.Capa_Presentacion_Formularios.Compras
{
    partial class Frm_FacturaCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_FacturaCompra));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.lbl_nrofac = new System.Windows.Forms.Label();
            this.txt_nrofac = new Farmacia_Matute.Clases.TextBox01();
            this.lbl_tipofac = new System.Windows.Forms.Label();
            this.cmb_tipo_factura = new Farmacia_Matute.Clases.ComboBox01();
            this.lblt_fecha = new Farmacia_Matute.Clases.LabelText01();
            this.txt_total = new Farmacia_Matute.Clases.TextBox01();
            this.lbl_total = new System.Windows.Forms.Label();
            this.grid_detalle = new Farmacia_Matute.Clases.Grid01();
            this.btn_grabar = new System.Windows.Forms.Button();
            this.lbl_detalle = new System.Windows.Forms.Label();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_cantidadmedicamentos = new Farmacia_Matute.Clases.TextBox01();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmb_medicamentos = new Farmacia_Matute.Clases.ComboBox01();
            this.txt_cuitlaboratorio = new Farmacia_Matute.Clases.TextBox01();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_laboratorio = new Farmacia_Matute.Clases.ComboBox01();
            this.txt_cuitfarmacia = new Farmacia_Matute.Clases.TextBox01();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_farmacia = new Farmacia_Matute.Clases.ComboBox01();
            this.txt_nombre = new Farmacia_Matute.Clases.TextBox01();
            this.txt_apellido = new Farmacia_Matute.Clases.TextBox01();
            this.cmb_tipo_doc = new Farmacia_Matute.Clases.ComboBox01();
            this.txt_nrodoc = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_detalle)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBox1.Controls.Add(this.btn_nuevo);
            this.groupBox1.Controls.Add(this.lbl_nrofac);
            this.groupBox1.Controls.Add(this.txt_nrofac);
            this.groupBox1.Controls.Add(this.lbl_tipofac);
            this.groupBox1.Controls.Add(this.cmb_tipo_factura);
            this.groupBox1.Controls.Add(this.lblt_fecha);
            this.groupBox1.Controls.Add(this.txt_total);
            this.groupBox1.Controls.Add(this.lbl_total);
            this.groupBox1.Controls.Add(this.grid_detalle);
            this.groupBox1.Controls.Add(this.btn_grabar);
            this.groupBox1.Controls.Add(this.lbl_detalle);
            this.groupBox1.Controls.Add(this.btn_agregar);
            this.groupBox1.Controls.Add(this.btn_buscar);
            this.groupBox1.Controls.Add(this.txt_cantidadmedicamentos);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cmb_medicamentos);
            this.groupBox1.Controls.Add(this.txt_cuitlaboratorio);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cmb_laboratorio);
            this.groupBox1.Controls.Add(this.txt_cuitfarmacia);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmb_farmacia);
            this.groupBox1.Controls.Add(this.txt_nombre);
            this.groupBox1.Controls.Add(this.txt_apellido);
            this.groupBox1.Controls.Add(this.cmb_tipo_doc);
            this.groupBox1.Controls.Add(this.txt_nrodoc);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbl_apellido);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(580, 452);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Factura Compra";
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_nuevo.BackgroundImage")));
            this.btn_nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_nuevo.Location = new System.Drawing.Point(386, 396);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(50, 50);
            this.btn_nuevo.TabIndex = 9;
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // lbl_nrofac
            // 
            this.lbl_nrofac.AutoSize = true;
            this.lbl_nrofac.Location = new System.Drawing.Point(135, 130);
            this.lbl_nrofac.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nrofac.Name = "lbl_nrofac";
            this.lbl_nrofac.Size = new System.Drawing.Size(63, 13);
            this.lbl_nrofac.TabIndex = 39;
            this.lbl_nrofac.Text = "Nro Factura";
            // 
            // txt_nrofac
            // 
            this.txt_nrofac.Location = new System.Drawing.Point(205, 128);
            this.txt_nrofac.Name = "txt_nrofac";
            this.txt_nrofac.Pp_mensajeError = null;
            this.txt_nrofac.Pp_nombre_campo = null;
            this.txt_nrofac.Pp_nombre_tabla = null;
            this.txt_nrofac.Pp_validable = false;
            this.txt_nrofac.ReadOnly = true;
            this.txt_nrofac.Size = new System.Drawing.Size(52, 20);
            this.txt_nrofac.TabIndex = 38;
            // 
            // lbl_tipofac
            // 
            this.lbl_tipofac.AutoSize = true;
            this.lbl_tipofac.Location = new System.Drawing.Point(264, 130);
            this.lbl_tipofac.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_tipofac.Name = "lbl_tipofac";
            this.lbl_tipofac.Size = new System.Drawing.Size(67, 13);
            this.lbl_tipofac.TabIndex = 37;
            this.lbl_tipofac.Text = "Tipo Factura";
            // 
            // cmb_tipo_factura
            // 
            this.cmb_tipo_factura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipo_factura.FormattingEnabled = true;
            this.cmb_tipo_factura.Location = new System.Drawing.Point(338, 126);
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
            this.cmb_tipo_factura.TabIndex = 5;
            // 
            // lblt_fecha
            // 
            this.lblt_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblt_fecha.Location = new System.Drawing.Point(338, 125);
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
            this.lblt_fecha.Size = new System.Drawing.Size(228, 28);
            this.lblt_fecha.TabIndex = 35;
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(302, 393);
            this.txt_total.Name = "txt_total";
            this.txt_total.Pp_mensajeError = null;
            this.txt_total.Pp_nombre_campo = null;
            this.txt_total.Pp_nombre_tabla = null;
            this.txt_total.Pp_validable = false;
            this.txt_total.ReadOnly = true;
            this.txt_total.Size = new System.Drawing.Size(69, 20);
            this.txt_total.TabIndex = 33;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(261, 396);
            this.lbl_total.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(34, 13);
            this.lbl_total.TabIndex = 32;
            this.lbl_total.Text = "Total:";
            // 
            // grid_detalle
            // 
            this.grid_detalle.AllowUserToAddRows = false;
            this.grid_detalle.AllowUserToDeleteRows = false;
            this.grid_detalle.AllowUserToResizeColumns = false;
            this.grid_detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_detalle.Location = new System.Drawing.Point(21, 203);
            this.grid_detalle.Name = "grid_detalle";
            this.grid_detalle.Pp_Formato = null;
            this.grid_detalle.Size = new System.Drawing.Size(518, 187);
            this.grid_detalle.TabIndex = 31;
            this.grid_detalle.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_detalle_CellDoubleClick);
            // 
            // btn_grabar
            // 
            this.btn_grabar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_grabar.BackgroundImage")));
            this.btn_grabar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_grabar.Location = new System.Drawing.Point(442, 396);
            this.btn_grabar.Name = "btn_grabar";
            this.btn_grabar.Size = new System.Drawing.Size(50, 50);
            this.btn_grabar.TabIndex = 10;
            this.btn_grabar.UseVisualStyleBackColor = true;
            this.btn_grabar.Click += new System.EventHandler(this.btn_grabar_Click);
            // 
            // lbl_detalle
            // 
            this.lbl_detalle.AutoSize = true;
            this.lbl_detalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_detalle.Location = new System.Drawing.Point(12, 127);
            this.lbl_detalle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_detalle.Name = "lbl_detalle";
            this.lbl_detalle.Size = new System.Drawing.Size(75, 16);
            this.lbl_detalle.TabIndex = 30;
            this.lbl_detalle.Text = "DETALLE";
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(434, 175);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_agregar.TabIndex = 8;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_buscar.BackgroundImage")));
            this.btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar.Location = new System.Drawing.Point(521, 81);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(45, 47);
            this.btn_buscar.TabIndex = 2;
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // txt_cantidadmedicamentos
            // 
            this.txt_cantidadmedicamentos.Location = new System.Drawing.Point(338, 160);
            this.txt_cantidadmedicamentos.Name = "txt_cantidadmedicamentos";
            this.txt_cantidadmedicamentos.Pp_mensajeError = null;
            this.txt_cantidadmedicamentos.Pp_nombre_campo = null;
            this.txt_cantidadmedicamentos.Pp_nombre_tabla = null;
            this.txt_cantidadmedicamentos.Pp_validable = false;
            this.txt_cantidadmedicamentos.Size = new System.Drawing.Size(69, 20);
            this.txt_cantidadmedicamentos.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(282, 162);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Cantidad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(49, 162);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Medicamento";
            // 
            // cmb_medicamentos
            // 
            this.cmb_medicamentos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_medicamentos.FormattingEnabled = true;
            this.cmb_medicamentos.Location = new System.Drawing.Point(127, 159);
            this.cmb_medicamentos.Name = "cmb_medicamentos";
            this.cmb_medicamentos.Pp_Display = null;
            this.cmb_medicamentos.Pp_mensajeError = null;
            this.cmb_medicamentos.Pp_nombre_campo = null;
            this.cmb_medicamentos.Pp_nombre_tabla = null;
            this.cmb_medicamentos.Pp_seleccionado = false;
            this.cmb_medicamentos.Pp_Tabla = null;
            this.cmb_medicamentos.Pp_validable = false;
            this.cmb_medicamentos.Pp_Value = null;
            this.cmb_medicamentos.Size = new System.Drawing.Size(134, 21);
            this.cmb_medicamentos.TabIndex = 6;
            // 
            // txt_cuitlaboratorio
            // 
            this.txt_cuitlaboratorio.Location = new System.Drawing.Point(338, 101);
            this.txt_cuitlaboratorio.Name = "txt_cuitlaboratorio";
            this.txt_cuitlaboratorio.Pp_mensajeError = null;
            this.txt_cuitlaboratorio.Pp_nombre_campo = null;
            this.txt_cuitlaboratorio.Pp_nombre_tabla = null;
            this.txt_cuitlaboratorio.Pp_validable = false;
            this.txt_cuitlaboratorio.ReadOnly = true;
            this.txt_cuitlaboratorio.Size = new System.Drawing.Size(93, 20);
            this.txt_cuitlaboratorio.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(299, 101);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "CUIT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 106);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Laboratorio";
            // 
            // cmb_laboratorio
            // 
            this.cmb_laboratorio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_laboratorio.FormattingEnabled = true;
            this.cmb_laboratorio.Location = new System.Drawing.Point(69, 98);
            this.cmb_laboratorio.Name = "cmb_laboratorio";
            this.cmb_laboratorio.Pp_Display = null;
            this.cmb_laboratorio.Pp_mensajeError = null;
            this.cmb_laboratorio.Pp_nombre_campo = null;
            this.cmb_laboratorio.Pp_nombre_tabla = null;
            this.cmb_laboratorio.Pp_seleccionado = false;
            this.cmb_laboratorio.Pp_Tabla = null;
            this.cmb_laboratorio.Pp_validable = false;
            this.cmb_laboratorio.Pp_Value = null;
            this.cmb_laboratorio.Size = new System.Drawing.Size(134, 21);
            this.cmb_laboratorio.TabIndex = 4;
            this.cmb_laboratorio.SelectionChangeCommitted += new System.EventHandler(this.cmb_laboratorio_SelectionChangeCommitted);
            // 
            // txt_cuitfarmacia
            // 
            this.txt_cuitfarmacia.Location = new System.Drawing.Point(338, 75);
            this.txt_cuitfarmacia.Name = "txt_cuitfarmacia";
            this.txt_cuitfarmacia.Pp_mensajeError = null;
            this.txt_cuitfarmacia.Pp_nombre_campo = null;
            this.txt_cuitfarmacia.Pp_nombre_tabla = null;
            this.txt_cuitfarmacia.Pp_validable = false;
            this.txt_cuitfarmacia.ReadOnly = true;
            this.txt_cuitfarmacia.Size = new System.Drawing.Size(93, 20);
            this.txt_cuitfarmacia.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(299, 78);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "CUIT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Farmacia";
            // 
            // cmb_farmacia
            // 
            this.cmb_farmacia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_farmacia.FormattingEnabled = true;
            this.cmb_farmacia.Location = new System.Drawing.Point(69, 73);
            this.cmb_farmacia.Name = "cmb_farmacia";
            this.cmb_farmacia.Pp_Display = null;
            this.cmb_farmacia.Pp_mensajeError = null;
            this.cmb_farmacia.Pp_nombre_campo = null;
            this.cmb_farmacia.Pp_nombre_tabla = null;
            this.cmb_farmacia.Pp_seleccionado = false;
            this.cmb_farmacia.Pp_Tabla = null;
            this.cmb_farmacia.Pp_validable = false;
            this.cmb_farmacia.Pp_Value = null;
            this.cmb_farmacia.Size = new System.Drawing.Size(134, 21);
            this.cmb_farmacia.TabIndex = 3;
            this.cmb_farmacia.SelectionChangeCommitted += new System.EventHandler(this.cmb_farmacia_SelectionChangeCommitted);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(69, 49);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Pp_mensajeError = null;
            this.txt_nombre.Pp_nombre_campo = null;
            this.txt_nombre.Pp_nombre_tabla = null;
            this.txt_nombre.Pp_validable = false;
            this.txt_nombre.ReadOnly = true;
            this.txt_nombre.Size = new System.Drawing.Size(134, 20);
            this.txt_nombre.TabIndex = 14;
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(69, 23);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Pp_mensajeError = null;
            this.txt_apellido.Pp_nombre_campo = null;
            this.txt_apellido.Pp_nombre_tabla = null;
            this.txt_apellido.Pp_validable = false;
            this.txt_apellido.ReadOnly = true;
            this.txt_apellido.Size = new System.Drawing.Size(134, 20);
            this.txt_apellido.TabIndex = 7;
            // 
            // cmb_tipo_doc
            // 
            this.cmb_tipo_doc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipo_doc.FormattingEnabled = true;
            this.cmb_tipo_doc.Location = new System.Drawing.Point(338, 22);
            this.cmb_tipo_doc.Name = "cmb_tipo_doc";
            this.cmb_tipo_doc.Pp_Display = null;
            this.cmb_tipo_doc.Pp_mensajeError = null;
            this.cmb_tipo_doc.Pp_nombre_campo = null;
            this.cmb_tipo_doc.Pp_nombre_tabla = null;
            this.cmb_tipo_doc.Pp_seleccionado = false;
            this.cmb_tipo_doc.Pp_Tabla = null;
            this.cmb_tipo_doc.Pp_validable = false;
            this.cmb_tipo_doc.Pp_Value = null;
            this.cmb_tipo_doc.Size = new System.Drawing.Size(134, 21);
            this.cmb_tipo_doc.TabIndex = 1;
            // 
            // txt_nrodoc
            // 
            this.txt_nrodoc.Location = new System.Drawing.Point(338, 49);
            this.txt_nrodoc.Mask = "99999999";
            this.txt_nrodoc.Name = "txt_nrodoc";
            this.txt_nrodoc.Size = new System.Drawing.Size(59, 20);
            this.txt_nrodoc.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 52);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Número de Documento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(230, 26);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Tipo de Documento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre/s";
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.Location = new System.Drawing.Point(18, 26);
            this.lbl_apellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(44, 13);
            this.lbl_apellido.TabIndex = 10;
            this.lbl_apellido.Text = "Apellido";
            // 
            // Frm_FacturaCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(602, 476);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Frm_FacturaCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FACTURA COMPRA";
            this.Load += new System.EventHandler(this.Frm_FacturaCompra_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_detalle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Clases.TextBox01 txt_cantidadmedicamentos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private Clases.ComboBox01 cmb_medicamentos;
        private Clases.TextBox01 txt_cuitlaboratorio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Clases.TextBox01 txt_cuitfarmacia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private Clases.ComboBox01 cmb_farmacia;
        private Clases.TextBox01 txt_nombre;
        private Clases.TextBox01 txt_apellido;
        private Clases.ComboBox01 cmb_tipo_doc;
        private System.Windows.Forms.MaskedTextBox txt_nrodoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label lbl_detalle;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_grabar;
        private Clases.Grid01 grid_detalle;
        private Clases.TextBox01 txt_total;
        private System.Windows.Forms.Label lbl_total;
        private Clases.LabelText01 lblt_fecha;
        private Clases.ComboBox01 cmb_tipo_factura;
        private System.Windows.Forms.Label lbl_nrofac;
        private Clases.TextBox01 txt_nrofac;
        private System.Windows.Forms.Label lbl_tipofac;
        private Clases.ComboBox01 cmb_laboratorio;
        private System.Windows.Forms.Button btn_nuevo;
    }
}