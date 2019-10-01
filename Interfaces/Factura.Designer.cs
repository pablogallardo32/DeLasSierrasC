namespace Interfaces
{
    partial class Factura
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
            this.Label13 = new System.Windows.Forms.Label();
            this.tabControlCargarFactura = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dataGridViewVerItems = new System.Windows.Forms.DataGridView();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewItem = new System.Windows.Forms.DataGridView();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumFac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.DataGridViewFactura = new System.Windows.Forms.DataGridView();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxNumeroProveedor = new System.Windows.Forms.ComboBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.textBoxNumeroFactura = new System.Windows.Forms.TextBox();
            this.Label22 = new System.Windows.Forms.Label();
            this.comboBoxNombreProveedor = new System.Windows.Forms.ComboBox();
            this.DataTimePickerFecha = new System.Windows.Forms.DateTimePicker();
            this.GroupBox4 = new System.Windows.Forms.GroupBox();
            this.comboBoxPrecioCosto = new System.Windows.Forms.ComboBox();
            this.textBoxNumeroFactura2 = new System.Windows.Forms.TextBox();
            this.ButtonEliminarItem = new System.Windows.Forms.Button();
            this.ButtonModificarItem = new System.Windows.Forms.Button();
            this.comboBoxCodigoProducto = new System.Windows.Forms.ComboBox();
            this.comboBoxProducto = new System.Windows.Forms.ComboBox();
            this.Label20 = new System.Windows.Forms.Label();
            this.textBoxTotalProducto = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.GroupBox5 = new System.Windows.Forms.GroupBox();
            this.ButtonNuevoItem = new System.Windows.Forms.Button();
            this.ButtonGuardarFactura = new System.Windows.Forms.Button();
            this.ButtonModificarFactura = new System.Windows.Forms.Button();
            this.ButtonEliminarFactura = new System.Windows.Forms.Button();
            this.ButtonSalir = new System.Windows.Forms.Button();
            this.ButtonLimpiarCampos = new System.Windows.Forms.Button();
            this.ButtonCrearProducto = new System.Windows.Forms.Button();
            this.Label16 = new System.Windows.Forms.Label();
            this.Label15 = new System.Windows.Forms.Label();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControlCargarFactura.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVerItems)).BeginInit();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItem)).BeginInit();
            this.GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewFactura)).BeginInit();
            this.GroupBox3.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            this.GroupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Location = new System.Drawing.Point(312, 539);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(0, 13);
            this.Label13.TabIndex = 138;
            // 
            // tabControlCargarFactura
            // 
            this.tabControlCargarFactura.Controls.Add(this.tabPage1);
            this.tabControlCargarFactura.Controls.Add(this.tabPage2);
            this.tabControlCargarFactura.Location = new System.Drawing.Point(0, 3);
            this.tabControlCargarFactura.Name = "tabControlCargarFactura";
            this.tabControlCargarFactura.SelectedIndex = 0;
            this.tabControlCargarFactura.Size = new System.Drawing.Size(799, 575);
            this.tabControlCargarFactura.TabIndex = 139;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox6);
            this.tabPage1.Controls.Add(this.textBoxTotal);
            this.tabPage1.Controls.Add(this.GroupBox1);
            this.tabPage1.Controls.Add(this.GroupBox2);
            this.tabPage1.Controls.Add(this.GroupBox3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(791, 549);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cargar Factura";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dataGridViewVerItems);
            this.groupBox6.Location = new System.Drawing.Point(8, 321);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(383, 199);
            this.groupBox6.TabIndex = 144;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Seleccione facura para ver sus items aquí";
            // 
            // dataGridViewVerItems
            // 
            this.dataGridViewVerItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVerItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewVerItems.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewVerItems.Name = "dataGridViewVerItems";
            this.dataGridViewVerItems.Size = new System.Drawing.Size(377, 180);
            this.dataGridViewVerItems.TabIndex = 0;
            this.dataGridViewVerItems.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewVerItems_CellClick);
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Enabled = false;
            this.textBoxTotal.Location = new System.Drawing.Point(356, 526);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(114, 20);
            this.textBoxTotal.TabIndex = 143;
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.GroupBox1.Controls.Add(this.dataGridViewItem);
            this.GroupBox1.Location = new System.Drawing.Point(400, 321);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(383, 199);
            this.GroupBox1.TabIndex = 142;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Items de factura a guardar";
            // 
            // dataGridViewItem
            // 
            this.dataGridViewItem.AllowUserToOrderColumns = true;
            this.dataGridViewItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProducto,
            this.NombreProducto,
            this.Cantidad,
            this.PrecioCosto,
            this.Monto,
            this.NumFac});
            this.dataGridViewItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewItem.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewItem.Name = "dataGridViewItem";
            this.dataGridViewItem.Size = new System.Drawing.Size(377, 180);
            this.dataGridViewItem.TabIndex = 1;
            // 
            // IdProducto
            // 
            this.IdProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.IdProducto.HeaderText = "IdProducto";
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.Width = 21;
            // 
            // NombreProducto
            // 
            this.NombreProducto.HeaderText = "NombreProducto";
            this.NombreProducto.Name = "NombreProducto";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // PrecioCosto
            // 
            this.PrecioCosto.HeaderText = "PrecioCosto";
            this.PrecioCosto.Name = "PrecioCosto";
            // 
            // Monto
            // 
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            // 
            // NumFac
            // 
            this.NumFac.HeaderText = "NumFac";
            this.NumFac.Name = "NumFac";
            // 
            // GroupBox2
            // 
            this.GroupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.GroupBox2.Controls.Add(this.DataGridViewFactura);
            this.GroupBox2.Location = new System.Drawing.Point(3, 134);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(363, 175);
            this.GroupBox2.TabIndex = 141;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Factura";
            this.GroupBox2.Enter += new System.EventHandler(this.GroupBox2_Enter);
            // 
            // DataGridViewFactura
            // 
            this.DataGridViewFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewFactura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewFactura.Location = new System.Drawing.Point(3, 16);
            this.DataGridViewFactura.Name = "DataGridViewFactura";
            this.DataGridViewFactura.Size = new System.Drawing.Size(357, 156);
            this.DataGridViewFactura.TabIndex = 0;
            this.DataGridViewFactura.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewFactura_CellClick);
            this.DataGridViewFactura.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewFactura_CellContentClick);
            this.DataGridViewFactura.Click += new System.EventHandler(this.DataGridViewFactura_Click);
            // 
            // GroupBox3
            // 
            this.GroupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.GroupBox3.Controls.Add(this.label4);
            this.GroupBox3.Controls.Add(this.label1);
            this.GroupBox3.Controls.Add(this.comboBoxNumeroProveedor);
            this.GroupBox3.Controls.Add(this.Button1);
            this.GroupBox3.Controls.Add(this.textBoxNumeroFactura);
            this.GroupBox3.Controls.Add(this.Label22);
            this.GroupBox3.Controls.Add(this.comboBoxNombreProveedor);
            this.GroupBox3.Controls.Add(this.DataTimePickerFecha);
            this.GroupBox3.Controls.Add(this.GroupBox4);
            this.GroupBox3.Controls.Add(this.Label3);
            this.GroupBox3.Location = new System.Drawing.Point(7, 2);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(776, 316);
            this.GroupBox3.TabIndex = 140;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Enter += new System.EventHandler(this.GroupBox3_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-3, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 140;
            this.label4.Text = "Número de factura:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 139;
            this.label1.Text = "Numero Proveedor";
            // 
            // comboBoxNumeroProveedor
            // 
            this.comboBoxNumeroProveedor.FormattingEnabled = true;
            this.comboBoxNumeroProveedor.Location = new System.Drawing.Point(99, 78);
            this.comboBoxNumeroProveedor.Name = "comboBoxNumeroProveedor";
            this.comboBoxNumeroProveedor.Size = new System.Drawing.Size(237, 21);
            this.comboBoxNumeroProveedor.TabIndex = 3;
            this.comboBoxNumeroProveedor.SelectionChangeCommitted += new System.EventHandler(this.comboBoxNumeroProveedor_SelectionChangeCommitted);
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(340, 47);
            this.Button1.Margin = new System.Windows.Forms.Padding(2);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(19, 19);
            this.Button1.TabIndex = 137;
            this.Button1.Text = "Button1";
            this.Button1.UseVisualStyleBackColor = true;
            // 
            // textBoxNumeroFactura
            // 
            this.textBoxNumeroFactura.Location = new System.Drawing.Point(99, 49);
            this.textBoxNumeroFactura.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNumeroFactura.Name = "textBoxNumeroFactura";
            this.textBoxNumeroFactura.Size = new System.Drawing.Size(237, 20);
            this.textBoxNumeroFactura.TabIndex = 2;
            this.textBoxNumeroFactura.TextChanged += new System.EventHandler(this.textBoxNumeroFactura_TextChanged_2);
            // 
            // Label22
            // 
            this.Label22.AutoSize = true;
            this.Label22.Location = new System.Drawing.Point(31, 108);
            this.Label22.Name = "Label22";
            this.Label22.Size = new System.Drawing.Size(59, 13);
            this.Label22.TabIndex = 135;
            this.Label22.Text = "Proveedor:";
            // 
            // comboBoxNombreProveedor
            // 
            this.comboBoxNombreProveedor.FormattingEnabled = true;
            this.comboBoxNombreProveedor.Location = new System.Drawing.Point(99, 105);
            this.comboBoxNombreProveedor.Name = "comboBoxNombreProveedor";
            this.comboBoxNombreProveedor.Size = new System.Drawing.Size(237, 21);
            this.comboBoxNombreProveedor.TabIndex = 4;
            // 
            // DataTimePickerFecha
            // 
            this.DataTimePickerFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DataTimePickerFecha.Location = new System.Drawing.Point(99, 25);
            this.DataTimePickerFecha.Name = "DataTimePickerFecha";
            this.DataTimePickerFecha.Size = new System.Drawing.Size(237, 20);
            this.DataTimePickerFecha.TabIndex = 1;
            // 
            // GroupBox4
            // 
            this.GroupBox4.Controls.Add(this.comboBoxPrecioCosto);
            this.GroupBox4.Controls.Add(this.textBoxNumeroFactura2);
            this.GroupBox4.Controls.Add(this.ButtonEliminarItem);
            this.GroupBox4.Controls.Add(this.ButtonModificarItem);
            this.GroupBox4.Controls.Add(this.comboBoxCodigoProducto);
            this.GroupBox4.Controls.Add(this.comboBoxProducto);
            this.GroupBox4.Controls.Add(this.Label20);
            this.GroupBox4.Controls.Add(this.textBoxTotalProducto);
            this.GroupBox4.Controls.Add(this.Label9);
            this.GroupBox4.Controls.Add(this.GroupBox5);
            this.GroupBox4.Controls.Add(this.ButtonCrearProducto);
            this.GroupBox4.Controls.Add(this.Label16);
            this.GroupBox4.Controls.Add(this.Label15);
            this.GroupBox4.Controls.Add(this.textBoxCantidad);
            this.GroupBox4.Controls.Add(this.Label5);
            this.GroupBox4.Controls.Add(this.Label2);
            this.GroupBox4.Location = new System.Drawing.Point(364, 19);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new System.Drawing.Size(406, 288);
            this.GroupBox4.TabIndex = 120;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "Items de factura";
            // 
            // comboBoxPrecioCosto
            // 
            this.comboBoxPrecioCosto.FormattingEnabled = true;
            this.comboBoxPrecioCosto.Location = new System.Drawing.Point(89, 78);
            this.comboBoxPrecioCosto.Name = "comboBoxPrecioCosto";
            this.comboBoxPrecioCosto.Size = new System.Drawing.Size(100, 21);
            this.comboBoxPrecioCosto.TabIndex = 143;
            this.comboBoxPrecioCosto.SelectedIndexChanged += new System.EventHandler(this.comboBoxPrecioCosto_SelectedIndexChanged);
            // 
            // textBoxNumeroFactura2
            // 
            this.textBoxNumeroFactura2.Enabled = false;
            this.textBoxNumeroFactura2.Location = new System.Drawing.Point(89, 129);
            this.textBoxNumeroFactura2.Name = "textBoxNumeroFactura2";
            this.textBoxNumeroFactura2.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumeroFactura2.TabIndex = 10;
            this.textBoxNumeroFactura2.Visible = false;
            // 
            // ButtonEliminarItem
            // 
            this.ButtonEliminarItem.Location = new System.Drawing.Point(14, 203);
            this.ButtonEliminarItem.Name = "ButtonEliminarItem";
            this.ButtonEliminarItem.Size = new System.Drawing.Size(170, 23);
            this.ButtonEliminarItem.TabIndex = 142;
            this.ButtonEliminarItem.Text = "Eliminar item de factura";
            this.ButtonEliminarItem.UseVisualStyleBackColor = true;
            this.ButtonEliminarItem.Visible = false;
            // 
            // ButtonModificarItem
            // 
            this.ButtonModificarItem.Location = new System.Drawing.Point(14, 174);
            this.ButtonModificarItem.Name = "ButtonModificarItem";
            this.ButtonModificarItem.Size = new System.Drawing.Size(171, 23);
            this.ButtonModificarItem.TabIndex = 142;
            this.ButtonModificarItem.Text = "Modificar item";
            this.ButtonModificarItem.UseVisualStyleBackColor = true;
            this.ButtonModificarItem.Visible = false;
            // 
            // comboBoxCodigoProducto
            // 
            this.comboBoxCodigoProducto.FormattingEnabled = true;
            this.comboBoxCodigoProducto.Location = new System.Drawing.Point(89, 22);
            this.comboBoxCodigoProducto.Name = "comboBoxCodigoProducto";
            this.comboBoxCodigoProducto.Size = new System.Drawing.Size(64, 21);
            this.comboBoxCodigoProducto.TabIndex = 5;
            this.comboBoxCodigoProducto.SelectedIndexChanged += new System.EventHandler(this.comboBoxCodigoProducto_SelectedIndexChanged_1);
            this.comboBoxCodigoProducto.SelectionChangeCommitted += new System.EventHandler(this.comboBoxCodigoProducto_SelectionChangeCommitted_1);
            // 
            // comboBoxProducto
            // 
            this.comboBoxProducto.FormattingEnabled = true;
            this.comboBoxProducto.Location = new System.Drawing.Point(157, 22);
            this.comboBoxProducto.Name = "comboBoxProducto";
            this.comboBoxProducto.Size = new System.Drawing.Size(243, 21);
            this.comboBoxProducto.TabIndex = 6;
            // 
            // Label20
            // 
            this.Label20.AutoSize = true;
            this.Label20.Location = new System.Drawing.Point(0, 106);
            this.Label20.Name = "Label20";
            this.Label20.Size = new System.Drawing.Size(89, 13);
            this.Label20.TabIndex = 135;
            this.Label20.Text = "Total Producto: $";
            // 
            // textBoxTotalProducto
            // 
            this.textBoxTotalProducto.Location = new System.Drawing.Point(89, 104);
            this.textBoxTotalProducto.Name = "textBoxTotalProducto";
            this.textBoxTotalProducto.Size = new System.Drawing.Size(100, 20);
            this.textBoxTotalProducto.TabIndex = 9;
            this.textBoxTotalProducto.TextChanged += new System.EventHandler(this.textBoxTotalProducto_TextChanged);
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.ForeColor = System.Drawing.Color.Red;
            this.Label9.Location = new System.Drawing.Point(19, 262);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(134, 13);
            this.Label9.TabIndex = 119;
            this.Label9.Text = "(*) CAMPO OBLIGATORIO";
            // 
            // GroupBox5
            // 
            this.GroupBox5.BackColor = System.Drawing.SystemColors.Control;
            this.GroupBox5.Controls.Add(this.ButtonNuevoItem);
            this.GroupBox5.Controls.Add(this.ButtonGuardarFactura);
            this.GroupBox5.Controls.Add(this.ButtonModificarFactura);
            this.GroupBox5.Controls.Add(this.ButtonEliminarFactura);
            this.GroupBox5.Controls.Add(this.ButtonSalir);
            this.GroupBox5.Controls.Add(this.ButtonLimpiarCampos);
            this.GroupBox5.Location = new System.Drawing.Point(216, 55);
            this.GroupBox5.Name = "GroupBox5";
            this.GroupBox5.Size = new System.Drawing.Size(187, 190);
            this.GroupBox5.TabIndex = 129;
            this.GroupBox5.TabStop = false;
            this.GroupBox5.Text = "OPCIONES";
            // 
            // ButtonNuevoItem
            // 
            this.ButtonNuevoItem.Location = new System.Drawing.Point(6, 46);
            this.ButtonNuevoItem.Name = "ButtonNuevoItem";
            this.ButtonNuevoItem.Size = new System.Drawing.Size(178, 23);
            this.ButtonNuevoItem.TabIndex = 12;
            this.ButtonNuevoItem.Text = "Guardar nuevo item";
            this.ButtonNuevoItem.UseVisualStyleBackColor = true;
            this.ButtonNuevoItem.Click += new System.EventHandler(this.ButtonNuevoItem_Click_1);
            // 
            // ButtonGuardarFactura
            // 
            this.ButtonGuardarFactura.Location = new System.Drawing.Point(6, 15);
            this.ButtonGuardarFactura.Name = "ButtonGuardarFactura";
            this.ButtonGuardarFactura.Size = new System.Drawing.Size(178, 24);
            this.ButtonGuardarFactura.TabIndex = 11;
            this.ButtonGuardarFactura.Text = "Guardar factura";
            this.ButtonGuardarFactura.UseVisualStyleBackColor = true;
            this.ButtonGuardarFactura.Click += new System.EventHandler(this.ButtonGuardarFactura_Click_1);
            // 
            // ButtonModificarFactura
            // 
            this.ButtonModificarFactura.Location = new System.Drawing.Point(6, 74);
            this.ButtonModificarFactura.Name = "ButtonModificarFactura";
            this.ButtonModificarFactura.Size = new System.Drawing.Size(178, 23);
            this.ButtonModificarFactura.TabIndex = 13;
            this.ButtonModificarFactura.Text = "Modificar factura";
            this.ButtonModificarFactura.UseVisualStyleBackColor = true;
            this.ButtonModificarFactura.Click += new System.EventHandler(this.ButtonModificarFactura_Click);
            // 
            // ButtonEliminarFactura
            // 
            this.ButtonEliminarFactura.Location = new System.Drawing.Point(6, 103);
            this.ButtonEliminarFactura.Name = "ButtonEliminarFactura";
            this.ButtonEliminarFactura.Size = new System.Drawing.Size(178, 23);
            this.ButtonEliminarFactura.TabIndex = 14;
            this.ButtonEliminarFactura.Text = "Eliminar factura";
            this.ButtonEliminarFactura.UseVisualStyleBackColor = true;
            this.ButtonEliminarFactura.Click += new System.EventHandler(this.ButtonEliminarFactura_Click);
            // 
            // ButtonSalir
            // 
            this.ButtonSalir.Location = new System.Drawing.Point(6, 160);
            this.ButtonSalir.Name = "ButtonSalir";
            this.ButtonSalir.Size = new System.Drawing.Size(178, 23);
            this.ButtonSalir.TabIndex = 17;
            this.ButtonSalir.Text = "Salir";
            this.ButtonSalir.UseVisualStyleBackColor = true;
            this.ButtonSalir.Click += new System.EventHandler(this.ButtonSalir_Click_1);
            // 
            // ButtonLimpiarCampos
            // 
            this.ButtonLimpiarCampos.Location = new System.Drawing.Point(6, 131);
            this.ButtonLimpiarCampos.Name = "ButtonLimpiarCampos";
            this.ButtonLimpiarCampos.Size = new System.Drawing.Size(178, 23);
            this.ButtonLimpiarCampos.TabIndex = 15;
            this.ButtonLimpiarCampos.Text = "Limpiar campos";
            this.ButtonLimpiarCampos.UseVisualStyleBackColor = true;
            this.ButtonLimpiarCampos.Click += new System.EventHandler(this.ButtonLimpiarCampos_Click_1);
            // 
            // ButtonCrearProducto
            // 
            this.ButtonCrearProducto.Location = new System.Drawing.Point(14, 232);
            this.ButtonCrearProducto.Name = "ButtonCrearProducto";
            this.ButtonCrearProducto.Size = new System.Drawing.Size(171, 23);
            this.ButtonCrearProducto.TabIndex = 20;
            this.ButtonCrearProducto.Text = "Crear producto";
            this.ButtonCrearProducto.UseVisualStyleBackColor = true;
            this.ButtonCrearProducto.Click += new System.EventHandler(this.ButtonCrearProducto_Click);
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.ForeColor = System.Drawing.Color.Red;
            this.Label16.Location = new System.Drawing.Point(193, 59);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(17, 13);
            this.Label16.TabIndex = 123;
            this.Label16.Text = "(*)";
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Location = new System.Drawing.Point(37, 55);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(52, 13);
            this.Label15.TabIndex = 83;
            this.Label15.Text = "Cantidad:";
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Location = new System.Drawing.Point(89, 55);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(100, 20);
            this.textBoxCantidad.TabIndex = 7;
            this.textBoxCantidad.TextChanged += new System.EventHandler(this.textBoxCantidad_TextChanged);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(1, 25);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(88, 13);
            this.Label5.TabIndex = 116;
            this.Label5.Text = "Codigo producto:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(11, 81);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(78, 13);
            this.Label2.TabIndex = 88;
            this.Label2.Text = "Precio costo: $";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(50, 31);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(40, 13);
            this.Label3.TabIndex = 100;
            this.Label3.Text = "Fecha:";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(791, 549);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ver Facturas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 577);
            this.Controls.Add(this.tabControlCargarFactura);
            this.Controls.Add(this.Label13);
            this.Name = "Factura";
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.Factura_Load);
            this.tabControlCargarFactura.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVerItems)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItem)).EndInit();
            this.GroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewFactura)).EndInit();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox4.PerformLayout();
            this.GroupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label13;
        private System.Windows.Forms.TabControl tabControlCargarFactura;
        private System.Windows.Forms.TabPage tabPage1;
        internal System.Windows.Forms.TextBox textBoxTotal;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.DataGridView dataGridViewItem;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.DataGridView DataGridViewFactura;
        internal System.Windows.Forms.GroupBox GroupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxNumeroProveedor;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.TextBox textBoxNumeroFactura;
        internal System.Windows.Forms.Label Label22;
        internal System.Windows.Forms.ComboBox comboBoxNombreProveedor;
        internal System.Windows.Forms.DateTimePicker DataTimePickerFecha;
        internal System.Windows.Forms.GroupBox GroupBox4;
        private System.Windows.Forms.ComboBox comboBoxPrecioCosto;
        internal System.Windows.Forms.TextBox textBoxNumeroFactura2;
        internal System.Windows.Forms.Button ButtonEliminarItem;
        internal System.Windows.Forms.Button ButtonModificarItem;
        internal System.Windows.Forms.ComboBox comboBoxCodigoProducto;
        internal System.Windows.Forms.ComboBox comboBoxProducto;
        internal System.Windows.Forms.Label Label20;
        internal System.Windows.Forms.TextBox textBoxTotalProducto;
        internal System.Windows.Forms.GroupBox GroupBox5;
        internal System.Windows.Forms.Button ButtonNuevoItem;
        internal System.Windows.Forms.Button ButtonGuardarFactura;
        internal System.Windows.Forms.Button ButtonModificarFactura;
        internal System.Windows.Forms.Button ButtonEliminarFactura;
        internal System.Windows.Forms.Button ButtonSalir;
        internal System.Windows.Forms.Button ButtonLimpiarCampos;
        internal System.Windows.Forms.Button ButtonCrearProducto;
        internal System.Windows.Forms.Label Label16;
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.TextBox textBoxCantidad;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCosto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumFac;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dataGridViewVerItems;
        private System.Windows.Forms.Label label4;
    }
}