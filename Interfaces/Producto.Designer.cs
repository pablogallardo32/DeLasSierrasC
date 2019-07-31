namespace Interfaces
{
    partial class Producto
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Producto));
            this.gpbNuevoPro = new System.Windows.Forms.GroupBox();
            this.textBoxIdProducto = new System.Windows.Forms.TextBox();
            this.comboBoxRubro = new System.Windows.Forms.ComboBox();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonListar = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonLimpiarCampos = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonAgregarRubro = new System.Windows.Forms.Button();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxEnvasedesc = new System.Windows.Forms.ComboBox();
            this.comboBoxSabordesc = new System.Windows.Forms.ComboBox();
            this.comboBoxDetalledesc = new System.Windows.Forms.ComboBox();
            this.comboBoxMarcadesc = new System.Windows.Forms.ComboBox();
            this.comboBoxTipodesc = new System.Windows.Forms.ComboBox();
            this.Label37 = new System.Windows.Forms.Label();
            this.dataGridViewProducto = new System.Windows.Forms.DataGridView();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.GroupBox4 = new System.Windows.Forms.GroupBox();
            this.labelDescripcionFinal = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Label25 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.textBoxPrecioCosto = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.textBoxPrecioVenta = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.textBoxStockMinimo = new System.Windows.Forms.TextBox();
            this.Label17 = new System.Windows.Forms.Label();
            this.Label16 = new System.Windows.Forms.Label();
            this.buttonAgregarTipo = new System.Windows.Forms.Button();
            this.Label23 = new System.Windows.Forms.Label();
            this.Label24 = new System.Windows.Forms.Label();
            this.Label21 = new System.Windows.Forms.Label();
            this.Label22 = new System.Windows.Forms.Label();
            this.buttonAgregarSabor = new System.Windows.Forms.Button();
            this.Label13 = new System.Windows.Forms.Label();
            this.radioButtonKg = new System.Windows.Forms.RadioButton();
            this.textBoxTamaño = new System.Windows.Forms.TextBox();
            this.radioButtonGramos = new System.Windows.Forms.RadioButton();
            this.radioButtonCubicos = new System.Windows.Forms.RadioButton();
            this.radioButtonUnidad = new System.Windows.Forms.RadioButton();
            this.Label19 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.buttonAgregarDetalle = new System.Windows.Forms.Button();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label18 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.buttonAgregarMarca = new System.Windows.Forms.Button();
            this.buttonAgregarEnvase = new System.Windows.Forms.Button();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label15 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.gpbNuevoPro.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.GroupBox4.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbNuevoPro
            // 
            this.gpbNuevoPro.Controls.Add(this.textBoxIdProducto);
            this.gpbNuevoPro.Controls.Add(this.comboBoxRubro);
            this.gpbNuevoPro.Controls.Add(this.GroupBox3);
            this.gpbNuevoPro.Controls.Add(this.buttonAgregarRubro);
            this.gpbNuevoPro.Controls.Add(this.GroupBox2);
            this.gpbNuevoPro.Controls.Add(this.Label5);
            this.gpbNuevoPro.Controls.Add(this.Label7);
            this.gpbNuevoPro.Controls.Add(this.Label15);
            this.gpbNuevoPro.Controls.Add(this.Label11);
            this.gpbNuevoPro.Controls.Add(this.Label6);
            this.gpbNuevoPro.Location = new System.Drawing.Point(12, 12);
            this.gpbNuevoPro.Name = "gpbNuevoPro";
            this.gpbNuevoPro.Size = new System.Drawing.Size(756, 675);
            this.gpbNuevoPro.TabIndex = 21;
            this.gpbNuevoPro.TabStop = false;
            this.gpbNuevoPro.Text = "Registrar nuevo producto";
            // 
            // textBoxIdProducto
            // 
            this.textBoxIdProducto.Location = new System.Drawing.Point(87, 53);
            this.textBoxIdProducto.Name = "textBoxIdProducto";
            this.textBoxIdProducto.Size = new System.Drawing.Size(259, 20);
            this.textBoxIdProducto.TabIndex = 150;
            // 
            // comboBoxRubro
            // 
            this.comboBoxRubro.FormattingEnabled = true;
            this.comboBoxRubro.Location = new System.Drawing.Point(87, 18);
            this.comboBoxRubro.Name = "comboBoxRubro";
            this.comboBoxRubro.Size = new System.Drawing.Size(259, 21);
            this.comboBoxRubro.TabIndex = 149;
            // 
            // GroupBox3
            // 
            this.GroupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.GroupBox3.Controls.Add(this.buttonListar);
            this.GroupBox3.Controls.Add(this.buttonSalir);
            this.GroupBox3.Controls.Add(this.buttonGuardar);
            this.GroupBox3.Controls.Add(this.buttonModificar);
            this.GroupBox3.Controls.Add(this.buttonLimpiarCampos);
            this.GroupBox3.Controls.Add(this.buttonEliminar);
            this.GroupBox3.Location = new System.Drawing.Point(550, 14);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(198, 195);
            this.GroupBox3.TabIndex = 148;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "OPCIONES";
            // 
            // buttonListar
            // 
            this.buttonListar.Location = new System.Drawing.Point(15, 132);
            this.buttonListar.Name = "buttonListar";
            this.buttonListar.Size = new System.Drawing.Size(178, 23);
            this.buttonListar.TabIndex = 122;
            this.buttonListar.Text = "Listar";
            this.buttonListar.UseVisualStyleBackColor = true;
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(15, 161);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(178, 23);
            this.buttonSalir.TabIndex = 90;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(15, 14);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(178, 24);
            this.buttonGuardar.TabIndex = 88;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            // 
            // buttonModificar
            // 
            this.buttonModificar.Location = new System.Drawing.Point(15, 44);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(178, 24);
            this.buttonModificar.TabIndex = 89;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // buttonLimpiarCampos
            // 
            this.buttonLimpiarCampos.Location = new System.Drawing.Point(15, 103);
            this.buttonLimpiarCampos.Name = "buttonLimpiarCampos";
            this.buttonLimpiarCampos.Size = new System.Drawing.Size(178, 23);
            this.buttonLimpiarCampos.TabIndex = 23;
            this.buttonLimpiarCampos.Text = "Limpiar campos";
            this.buttonLimpiarCampos.UseVisualStyleBackColor = true;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(15, 74);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(178, 23);
            this.buttonEliminar.TabIndex = 124;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            // 
            // buttonAgregarRubro
            // 
            this.buttonAgregarRubro.Location = new System.Drawing.Point(375, 18);
            this.buttonAgregarRubro.Name = "buttonAgregarRubro";
            this.buttonAgregarRubro.Size = new System.Drawing.Size(26, 23);
            this.buttonAgregarRubro.TabIndex = 120;
            this.buttonAgregarRubro.Text = "+";
            this.buttonAgregarRubro.UseVisualStyleBackColor = true;
            this.buttonAgregarRubro.Click += new System.EventHandler(this.buttonAgregarRubro_Click);
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.comboBoxEnvasedesc);
            this.GroupBox2.Controls.Add(this.comboBoxSabordesc);
            this.GroupBox2.Controls.Add(this.comboBoxDetalledesc);
            this.GroupBox2.Controls.Add(this.comboBoxMarcadesc);
            this.GroupBox2.Controls.Add(this.comboBoxTipodesc);
            this.GroupBox2.Controls.Add(this.Label37);
            this.GroupBox2.Controls.Add(this.dataGridViewProducto);
            this.GroupBox2.Controls.Add(this.PictureBox1);
            this.GroupBox2.Controls.Add(this.GroupBox4);
            this.GroupBox2.Controls.Add(this.GroupBox1);
            this.GroupBox2.Controls.Add(this.buttonAgregarTipo);
            this.GroupBox2.Controls.Add(this.Label23);
            this.GroupBox2.Controls.Add(this.Label24);
            this.GroupBox2.Controls.Add(this.Label21);
            this.GroupBox2.Controls.Add(this.Label22);
            this.GroupBox2.Controls.Add(this.buttonAgregarSabor);
            this.GroupBox2.Controls.Add(this.Label13);
            this.GroupBox2.Controls.Add(this.radioButtonKg);
            this.GroupBox2.Controls.Add(this.textBoxTamaño);
            this.GroupBox2.Controls.Add(this.radioButtonGramos);
            this.GroupBox2.Controls.Add(this.radioButtonCubicos);
            this.GroupBox2.Controls.Add(this.radioButtonUnidad);
            this.GroupBox2.Controls.Add(this.Label19);
            this.GroupBox2.Controls.Add(this.Label12);
            this.GroupBox2.Controls.Add(this.Label10);
            this.GroupBox2.Controls.Add(this.buttonAgregarDetalle);
            this.GroupBox2.Controls.Add(this.Label4);
            this.GroupBox2.Controls.Add(this.Label18);
            this.GroupBox2.Controls.Add(this.Label8);
            this.GroupBox2.Controls.Add(this.Label9);
            this.GroupBox2.Controls.Add(this.buttonAgregarMarca);
            this.GroupBox2.Controls.Add(this.buttonAgregarEnvase);
            this.GroupBox2.Location = new System.Drawing.Point(25, 91);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(731, 578);
            this.GroupBox2.TabIndex = 122;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Agregar descripcion (*)";
            // 
            // comboBoxEnvasedesc
            // 
            this.comboBoxEnvasedesc.FormattingEnabled = true;
            this.comboBoxEnvasedesc.Location = new System.Drawing.Point(63, 140);
            this.comboBoxEnvasedesc.Name = "comboBoxEnvasedesc";
            this.comboBoxEnvasedesc.Size = new System.Drawing.Size(259, 21);
            this.comboBoxEnvasedesc.TabIndex = 177;
            // 
            // comboBoxSabordesc
            // 
            this.comboBoxSabordesc.FormattingEnabled = true;
            this.comboBoxSabordesc.Location = new System.Drawing.Point(62, 113);
            this.comboBoxSabordesc.Name = "comboBoxSabordesc";
            this.comboBoxSabordesc.Size = new System.Drawing.Size(259, 21);
            this.comboBoxSabordesc.TabIndex = 176;
            // 
            // comboBoxDetalledesc
            // 
            this.comboBoxDetalledesc.FormattingEnabled = true;
            this.comboBoxDetalledesc.Location = new System.Drawing.Point(62, 86);
            this.comboBoxDetalledesc.Name = "comboBoxDetalledesc";
            this.comboBoxDetalledesc.Size = new System.Drawing.Size(259, 21);
            this.comboBoxDetalledesc.TabIndex = 175;
            // 
            // comboBoxMarcadesc
            // 
            this.comboBoxMarcadesc.FormattingEnabled = true;
            this.comboBoxMarcadesc.Location = new System.Drawing.Point(63, 57);
            this.comboBoxMarcadesc.Name = "comboBoxMarcadesc";
            this.comboBoxMarcadesc.Size = new System.Drawing.Size(259, 21);
            this.comboBoxMarcadesc.TabIndex = 174;
            // 
            // comboBoxTipodesc
            // 
            this.comboBoxTipodesc.FormattingEnabled = true;
            this.comboBoxTipodesc.Location = new System.Drawing.Point(62, 26);
            this.comboBoxTipodesc.Name = "comboBoxTipodesc";
            this.comboBoxTipodesc.Size = new System.Drawing.Size(259, 21);
            this.comboBoxTipodesc.TabIndex = 173;
            // 
            // Label37
            // 
            this.Label37.AutoSize = true;
            this.Label37.ForeColor = System.Drawing.Color.Red;
            this.Label37.Location = new System.Drawing.Point(480, 401);
            this.Label37.Name = "Label37";
            this.Label37.Size = new System.Drawing.Size(134, 13);
            this.Label37.TabIndex = 172;
            this.Label37.Text = "(*) CAMPO OBLIGATORIO";
            // 
            // dataGridViewProducto
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProducto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewProducto.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewProducto.Location = new System.Drawing.Point(13, 420);
            this.dataGridViewProducto.Name = "dataGridViewProducto";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProducto.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewProducto.Size = new System.Drawing.Size(705, 152);
            this.dataGridViewProducto.TabIndex = 21;
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(186, 208);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(460, 113);
            this.PictureBox1.TabIndex = 168;
            this.PictureBox1.TabStop = false;
            // 
            // GroupBox4
            // 
            this.GroupBox4.Controls.Add(this.labelDescripcionFinal);
            this.GroupBox4.Location = new System.Drawing.Point(186, 327);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new System.Drawing.Size(460, 40);
            this.GroupBox4.TabIndex = 167;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "DESCRIPCION";
            // 
            // labelDescripcionFinal
            // 
            this.labelDescripcionFinal.AutoSize = true;
            this.labelDescripcionFinal.Location = new System.Drawing.Point(6, 20);
            this.labelDescripcionFinal.Name = "labelDescripcionFinal";
            this.labelDescripcionFinal.Size = new System.Drawing.Size(47, 13);
            this.labelDescripcionFinal.TabIndex = 165;
            this.labelDescripcionFinal.Text = "Ninguna";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Label25);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.textBoxPrecioCosto);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.textBoxPrecioVenta);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.textBoxStockMinimo);
            this.GroupBox1.Controls.Add(this.Label17);
            this.GroupBox1.Controls.Add(this.Label16);
            this.GroupBox1.Location = new System.Drawing.Point(27, 365);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(447, 49);
            this.GroupBox1.TabIndex = 121;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Precios y stock minimo";
            // 
            // Label25
            // 
            this.Label25.AutoSize = true;
            this.Label25.ForeColor = System.Drawing.Color.Red;
            this.Label25.Location = new System.Drawing.Point(278, 30);
            this.Label25.Name = "Label25";
            this.Label25.Size = new System.Drawing.Size(17, 13);
            this.Label25.TabIndex = 117;
            this.Label25.Text = "(*)";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(6, 30);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(69, 13);
            this.Label1.TabIndex = 34;
            this.Label1.Text = "Precio costo:";
            // 
            // textBoxPrecioCosto
            // 
            this.textBoxPrecioCosto.Location = new System.Drawing.Point(81, 23);
            this.textBoxPrecioCosto.Name = "textBoxPrecioCosto";
            this.textBoxPrecioCosto.Size = new System.Drawing.Size(41, 20);
            this.textBoxPrecioCosto.TabIndex = 6;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(155, 29);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(70, 13);
            this.Label2.TabIndex = 35;
            this.Label2.Text = "Precio venta:";
            // 
            // textBoxPrecioVenta
            // 
            this.textBoxPrecioVenta.Location = new System.Drawing.Point(231, 26);
            this.textBoxPrecioVenta.Name = "textBoxPrecioVenta";
            this.textBoxPrecioVenta.Size = new System.Drawing.Size(41, 20);
            this.textBoxPrecioVenta.TabIndex = 36;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(296, 30);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(73, 13);
            this.Label3.TabIndex = 37;
            this.Label3.Text = "Stock minimo:";
            // 
            // textBoxStockMinimo
            // 
            this.textBoxStockMinimo.Location = new System.Drawing.Point(371, 23);
            this.textBoxStockMinimo.Name = "textBoxStockMinimo";
            this.textBoxStockMinimo.Size = new System.Drawing.Size(41, 20);
            this.textBoxStockMinimo.TabIndex = 38;
            // 
            // Label17
            // 
            this.Label17.AutoSize = true;
            this.Label17.ForeColor = System.Drawing.Color.Red;
            this.Label17.Location = new System.Drawing.Point(132, 29);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(17, 13);
            this.Label17.TabIndex = 116;
            this.Label17.Text = "(*)";
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.ForeColor = System.Drawing.Color.Red;
            this.Label16.Location = new System.Drawing.Point(418, 29);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(17, 13);
            this.Label16.TabIndex = 115;
            this.Label16.Text = "(*)";
            // 
            // buttonAgregarTipo
            // 
            this.buttonAgregarTipo.Location = new System.Drawing.Point(350, 24);
            this.buttonAgregarTipo.Name = "buttonAgregarTipo";
            this.buttonAgregarTipo.Size = new System.Drawing.Size(26, 23);
            this.buttonAgregarTipo.TabIndex = 162;
            this.buttonAgregarTipo.Text = "+";
            this.buttonAgregarTipo.UseVisualStyleBackColor = true;
            this.buttonAgregarTipo.Click += new System.EventHandler(this.buttonAgregarTipo_Click);
            // 
            // Label23
            // 
            this.Label23.AutoSize = true;
            this.Label23.ForeColor = System.Drawing.Color.Red;
            this.Label23.Location = new System.Drawing.Point(327, 30);
            this.Label23.Name = "Label23";
            this.Label23.Size = new System.Drawing.Size(17, 13);
            this.Label23.TabIndex = 160;
            this.Label23.Text = "(*)";
            // 
            // Label24
            // 
            this.Label24.AutoSize = true;
            this.Label24.Location = new System.Drawing.Point(18, 29);
            this.Label24.Name = "Label24";
            this.Label24.Size = new System.Drawing.Size(34, 13);
            this.Label24.TabIndex = 158;
            this.Label24.Text = "Tipo: ";
            // 
            // Label21
            // 
            this.Label21.AutoSize = true;
            this.Label21.ForeColor = System.Drawing.Color.Red;
            this.Label21.Location = new System.Drawing.Point(328, 116);
            this.Label21.Name = "Label21";
            this.Label21.Size = new System.Drawing.Size(17, 13);
            this.Label21.TabIndex = 157;
            this.Label21.Text = "(*)";
            // 
            // Label22
            // 
            this.Label22.AutoSize = true;
            this.Label22.Location = new System.Drawing.Point(18, 116);
            this.Label22.Name = "Label22";
            this.Label22.Size = new System.Drawing.Size(38, 13);
            this.Label22.TabIndex = 152;
            this.Label22.Text = "Sabor:";
            // 
            // buttonAgregarSabor
            // 
            this.buttonAgregarSabor.Location = new System.Drawing.Point(350, 110);
            this.buttonAgregarSabor.Name = "buttonAgregarSabor";
            this.buttonAgregarSabor.Size = new System.Drawing.Size(26, 24);
            this.buttonAgregarSabor.TabIndex = 153;
            this.buttonAgregarSabor.Text = "+";
            this.buttonAgregarSabor.UseVisualStyleBackColor = true;
            this.buttonAgregarSabor.Click += new System.EventHandler(this.buttonAgregarSabor_Click);
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Location = new System.Drawing.Point(3, 219);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(53, 13);
            this.Label13.TabIndex = 151;
            this.Label13.Text = "Medición:";
            // 
            // radioButtonKg
            // 
            this.radioButtonKg.AutoSize = true;
            this.radioButtonKg.Location = new System.Drawing.Point(58, 286);
            this.radioButtonKg.Name = "radioButtonKg";
            this.radioButtonKg.Size = new System.Drawing.Size(100, 17);
            this.radioButtonKg.TabIndex = 150;
            this.radioButtonKg.TabStop = true;
            this.radioButtonKg.Text = "Kilogramos (KG)";
            this.radioButtonKg.UseVisualStyleBackColor = true;
            // 
            // textBoxTamaño
            // 
            this.textBoxTamaño.Location = new System.Drawing.Point(67, 325);
            this.textBoxTamaño.Name = "textBoxTamaño";
            this.textBoxTamaño.Size = new System.Drawing.Size(59, 20);
            this.textBoxTamaño.TabIndex = 149;
            // 
            // radioButtonGramos
            // 
            this.radioButtonGramos.AutoSize = true;
            this.radioButtonGramos.Location = new System.Drawing.Point(58, 240);
            this.radioButtonGramos.Name = "radioButtonGramos";
            this.radioButtonGramos.Size = new System.Drawing.Size(78, 17);
            this.radioButtonGramos.TabIndex = 148;
            this.radioButtonGramos.TabStop = true;
            this.radioButtonGramos.Text = "Gramos (G)";
            this.radioButtonGramos.UseVisualStyleBackColor = true;
            // 
            // radioButtonCubicos
            // 
            this.radioButtonCubicos.AutoSize = true;
            this.radioButtonCubicos.Location = new System.Drawing.Point(58, 263);
            this.radioButtonCubicos.Name = "radioButtonCubicos";
            this.radioButtonCubicos.Size = new System.Drawing.Size(66, 17);
            this.radioButtonCubicos.TabIndex = 147;
            this.radioButtonCubicos.TabStop = true;
            this.radioButtonCubicos.Text = "Cm³ (CC)";
            this.radioButtonCubicos.UseVisualStyleBackColor = true;
            // 
            // radioButtonUnidad
            // 
            this.radioButtonUnidad.AutoSize = true;
            this.radioButtonUnidad.Location = new System.Drawing.Point(58, 217);
            this.radioButtonUnidad.Name = "radioButtonUnidad";
            this.radioButtonUnidad.Size = new System.Drawing.Size(76, 17);
            this.radioButtonUnidad.TabIndex = 146;
            this.radioButtonUnidad.TabStop = true;
            this.radioButtonUnidad.Text = "Unidad (U)";
            this.radioButtonUnidad.UseVisualStyleBackColor = true;
            // 
            // Label19
            // 
            this.Label19.AutoSize = true;
            this.Label19.ForeColor = System.Drawing.Color.Red;
            this.Label19.Location = new System.Drawing.Point(328, 142);
            this.Label19.Name = "Label19";
            this.Label19.Size = new System.Drawing.Size(17, 13);
            this.Label19.TabIndex = 144;
            this.Label19.Text = "(*)";
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.ForeColor = System.Drawing.Color.Red;
            this.Label12.Location = new System.Drawing.Point(327, 89);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(17, 13);
            this.Label12.TabIndex = 143;
            this.Label12.Text = "(*)";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.ForeColor = System.Drawing.Color.Red;
            this.Label10.Location = new System.Drawing.Point(328, 60);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(17, 13);
            this.Label10.TabIndex = 117;
            this.Label10.Text = "(*)";
            // 
            // buttonAgregarDetalle
            // 
            this.buttonAgregarDetalle.Location = new System.Drawing.Point(350, 83);
            this.buttonAgregarDetalle.Name = "buttonAgregarDetalle";
            this.buttonAgregarDetalle.Size = new System.Drawing.Size(26, 24);
            this.buttonAgregarDetalle.TabIndex = 132;
            this.buttonAgregarDetalle.Text = "+";
            this.buttonAgregarDetalle.UseVisualStyleBackColor = true;
            this.buttonAgregarDetalle.Click += new System.EventHandler(this.buttonAgregarDetalle_Click);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(18, 60);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(40, 13);
            this.Label4.TabIndex = 0;
            this.Label4.Text = "Marca:";
            // 
            // Label18
            // 
            this.Label18.AutoSize = true;
            this.Label18.Location = new System.Drawing.Point(18, 89);
            this.Label18.Name = "Label18";
            this.Label18.Size = new System.Drawing.Size(43, 13);
            this.Label18.TabIndex = 130;
            this.Label18.Text = "Detalle:";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(12, 332);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(49, 13);
            this.Label8.TabIndex = 1;
            this.Label8.Text = "Tamaño:";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(18, 142);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(46, 13);
            this.Label9.TabIndex = 2;
            this.Label9.Text = "Envase:";
            // 
            // buttonAgregarMarca
            // 
            this.buttonAgregarMarca.Location = new System.Drawing.Point(350, 54);
            this.buttonAgregarMarca.Name = "buttonAgregarMarca";
            this.buttonAgregarMarca.Size = new System.Drawing.Size(26, 24);
            this.buttonAgregarMarca.TabIndex = 125;
            this.buttonAgregarMarca.Text = "+";
            this.buttonAgregarMarca.UseVisualStyleBackColor = true;
            this.buttonAgregarMarca.Click += new System.EventHandler(this.buttonAgregarMarca_Click);
            // 
            // buttonAgregarEnvase
            // 
            this.buttonAgregarEnvase.Location = new System.Drawing.Point(350, 137);
            this.buttonAgregarEnvase.Name = "buttonAgregarEnvase";
            this.buttonAgregarEnvase.Size = new System.Drawing.Size(26, 24);
            this.buttonAgregarEnvase.TabIndex = 126;
            this.buttonAgregarEnvase.Text = "+";
            this.buttonAgregarEnvase.UseVisualStyleBackColor = true;
            this.buttonAgregarEnvase.Click += new System.EventHandler(this.buttonAgregarEnvase_Click);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.ForeColor = System.Drawing.Color.Red;
            this.Label5.Location = new System.Drawing.Point(352, 57);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(17, 13);
            this.Label5.TabIndex = 119;
            this.Label5.Text = "(*)";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(22, 57);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(46, 13);
            this.Label7.TabIndex = 117;
            this.Label7.Text = "Codigo :";
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.ForeColor = System.Drawing.Color.Red;
            this.Label15.Location = new System.Drawing.Point(352, 22);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(17, 13);
            this.Label15.TabIndex = 114;
            this.Label15.Text = "(*)";
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.ForeColor = System.Drawing.Color.Red;
            this.Label11.Location = new System.Drawing.Point(476, 525);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(134, 13);
            this.Label11.TabIndex = 112;
            this.Label11.Text = "(*) CAMPO OBLIGATORIO";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(29, 27);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(39, 13);
            this.Label6.TabIndex = 5;
            this.Label6.Text = "Rubro:";
            // 
            // Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 699);
            this.Controls.Add(this.gpbNuevoPro);
            this.Name = "Producto";
            this.Text = "Producto";
            this.gpbNuevoPro.ResumeLayout(false);
            this.gpbNuevoPro.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox4.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox gpbNuevoPro;
        internal System.Windows.Forms.TextBox textBoxIdProducto;
        internal System.Windows.Forms.ComboBox comboBoxRubro;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.Button buttonListar;
        internal System.Windows.Forms.Button buttonSalir;
        internal System.Windows.Forms.Button buttonGuardar;
        internal System.Windows.Forms.Button buttonModificar;
        internal System.Windows.Forms.Button buttonLimpiarCampos;
        internal System.Windows.Forms.Button buttonEliminar;
        internal System.Windows.Forms.Button buttonAgregarRubro;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.ComboBox comboBoxEnvasedesc;
        internal System.Windows.Forms.ComboBox comboBoxSabordesc;
        internal System.Windows.Forms.ComboBox comboBoxDetalledesc;
        internal System.Windows.Forms.ComboBox comboBoxMarcadesc;
        internal System.Windows.Forms.ComboBox comboBoxTipodesc;
        internal System.Windows.Forms.Label Label37;
        internal System.Windows.Forms.DataGridView dataGridViewProducto;
        internal System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.GroupBox GroupBox4;
        internal System.Windows.Forms.Label labelDescripcionFinal;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label Label25;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox textBoxPrecioCosto;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox textBoxPrecioVenta;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox textBoxStockMinimo;
        internal System.Windows.Forms.Label Label17;
        internal System.Windows.Forms.Label Label16;
        internal System.Windows.Forms.Button buttonAgregarTipo;
        internal System.Windows.Forms.Label Label23;
        internal System.Windows.Forms.Label Label24;
        internal System.Windows.Forms.Label Label21;
        internal System.Windows.Forms.Label Label22;
        internal System.Windows.Forms.Button buttonAgregarSabor;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.RadioButton radioButtonKg;
        internal System.Windows.Forms.TextBox textBoxTamaño;
        internal System.Windows.Forms.RadioButton radioButtonGramos;
        internal System.Windows.Forms.RadioButton radioButtonCubicos;
        internal System.Windows.Forms.RadioButton radioButtonUnidad;
        internal System.Windows.Forms.Label Label19;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Button buttonAgregarDetalle;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label18;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Button buttonAgregarMarca;
        internal System.Windows.Forms.Button buttonAgregarEnvase;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label Label6;

    }
}

