namespace Interfaces
{
    partial class Empleado
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
            this.DataGridViewEmpleado = new System.Windows.Forms.DataGridView();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxSeccion = new System.Windows.Forms.ComboBox();
            this.Label26 = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxProvincia = new System.Windows.Forms.ComboBox();
            this.textBoxCodigoPostal = new System.Windows.Forms.TextBox();
            this.comboBoxLocalidad = new System.Windows.Forms.ComboBox();
            this.textBoxBarrio = new System.Windows.Forms.TextBox();
            this.textBoxDepto = new System.Windows.Forms.TextBox();
            this.textBoxPiso = new System.Windows.Forms.TextBox();
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.Label21 = new System.Windows.Forms.Label();
            this.Label20 = new System.Windows.Forms.Label();
            this.Label19 = new System.Windows.Forms.Label();
            this.Label18 = new System.Windows.Forms.Label();
            this.textBoxCalle = new System.Windows.Forms.TextBox();
            this.Label17 = new System.Windows.Forms.Label();
            this.Label16 = new System.Windows.Forms.Label();
            this.Label15 = new System.Windows.Forms.Label();
            this.Label14 = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.Label22 = new System.Windows.Forms.Label();
            this.Label24 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.textBoxTelefonoFijo = new System.Windows.Forms.TextBox();
            this.Label23 = new System.Windows.Forms.Label();
            this.DateTimePickerFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.textBoxTelefonoCelular = new System.Windows.Forms.TextBox();
            this.DateTimePeckerFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.textBoxEMail = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.textBoxDNI = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.ButtonModificar = new System.Windows.Forms.Button();
            this.ButtonLimpiar = new System.Windows.Forms.Button();
            this.ButtonGuardar = new System.Windows.Forms.Button();
            this.ButtonSalir = new System.Windows.Forms.Button();
            this.ButtonEliminar = new System.Windows.Forms.Button();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewEmpleado)).BeginInit();
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridViewEmpleado
            // 
            this.DataGridViewEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewEmpleado.Location = new System.Drawing.Point(12, 421);
            this.DataGridViewEmpleado.Name = "DataGridViewEmpleado";
            this.DataGridViewEmpleado.Size = new System.Drawing.Size(728, 155);
            this.DataGridViewEmpleado.TabIndex = 156;
            this.DataGridViewEmpleado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewEmpleados_CellClick);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.comboBoxSeccion);
            this.GroupBox1.Controls.Add(this.Label26);
            this.GroupBox1.Controls.Add(this.GroupBox2);
            this.GroupBox1.Controls.Add(this.Label13);
            this.GroupBox1.Controls.Add(this.Label22);
            this.GroupBox1.Controls.Add(this.Label24);
            this.GroupBox1.Controls.Add(this.Label8);
            this.GroupBox1.Controls.Add(this.textBoxTelefonoFijo);
            this.GroupBox1.Controls.Add(this.Label23);
            this.GroupBox1.Controls.Add(this.DateTimePickerFechaIngreso);
            this.GroupBox1.Controls.Add(this.textBoxTelefonoCelular);
            this.GroupBox1.Controls.Add(this.DateTimePeckerFechaNacimiento);
            this.GroupBox1.Controls.Add(this.textBoxEMail);
            this.GroupBox1.Controls.Add(this.Label10);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.textBoxDNI);
            this.GroupBox1.Controls.Add(this.Label6);
            this.GroupBox1.Controls.Add(this.textBoxApellido);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.textBoxNombre);
            this.GroupBox1.Controls.Add(this.Label7);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Location = new System.Drawing.Point(12, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(529, 403);
            this.GroupBox1.TabIndex = 154;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Datos Personales";
            // 
            // comboBoxSeccion
            // 
            this.comboBoxSeccion.FormattingEnabled = true;
            this.comboBoxSeccion.Items.AddRange(new object[] {
            "Encargado",
            "Empleado"});
            this.comboBoxSeccion.Location = new System.Drawing.Point(111, 318);
            this.comboBoxSeccion.Name = "comboBoxSeccion";
            this.comboBoxSeccion.Size = new System.Drawing.Size(123, 21);
            this.comboBoxSeccion.TabIndex = 89;
            // 
            // Label26
            // 
            this.Label26.AutoSize = true;
            this.Label26.ForeColor = System.Drawing.Color.Red;
            this.Label26.Location = new System.Drawing.Point(123, 378);
            this.Label26.Name = "Label26";
            this.Label26.Size = new System.Drawing.Size(134, 13);
            this.Label26.TabIndex = 121;
            this.Label26.Text = "(*) CAMPO OBLIGATORIO";
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.comboBoxProvincia);
            this.GroupBox2.Controls.Add(this.textBoxCodigoPostal);
            this.GroupBox2.Controls.Add(this.comboBoxLocalidad);
            this.GroupBox2.Controls.Add(this.textBoxBarrio);
            this.GroupBox2.Controls.Add(this.textBoxDepto);
            this.GroupBox2.Controls.Add(this.textBoxPiso);
            this.GroupBox2.Controls.Add(this.textBoxNumero);
            this.GroupBox2.Controls.Add(this.Label21);
            this.GroupBox2.Controls.Add(this.Label20);
            this.GroupBox2.Controls.Add(this.Label19);
            this.GroupBox2.Controls.Add(this.Label18);
            this.GroupBox2.Controls.Add(this.textBoxCalle);
            this.GroupBox2.Controls.Add(this.Label17);
            this.GroupBox2.Controls.Add(this.Label16);
            this.GroupBox2.Controls.Add(this.Label15);
            this.GroupBox2.Controls.Add(this.Label14);
            this.GroupBox2.Location = new System.Drawing.Point(290, 30);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(223, 361);
            this.GroupBox2.TabIndex = 114;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Direccón";
            // 
            // comboBoxProvincia
            // 
            this.comboBoxProvincia.FormattingEnabled = true;
            this.comboBoxProvincia.Items.AddRange(new object[] {
            "CORDOBA",
            "SANTIAGO DEL ESTERO",
            "CATAMARCA",
            "BUENOS AIRES",
            "SANTA FE",
            "LA PAMPA",
            "TUCUMAN"});
            this.comboBoxProvincia.Location = new System.Drawing.Point(80, 270);
            this.comboBoxProvincia.Name = "comboBoxProvincia";
            this.comboBoxProvincia.Size = new System.Drawing.Size(121, 21);
            this.comboBoxProvincia.TabIndex = 152;
            // 
            // textBoxCodigoPostal
            // 
            this.textBoxCodigoPostal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxCodigoPostal.Location = new System.Drawing.Point(80, 325);
            this.textBoxCodigoPostal.Name = "textBoxCodigoPostal";
            this.textBoxCodigoPostal.Size = new System.Drawing.Size(48, 20);
            this.textBoxCodigoPostal.TabIndex = 52;
            // 
            // comboBoxLocalidad
            // 
            this.comboBoxLocalidad.FormattingEnabled = true;
            this.comboBoxLocalidad.Items.AddRange(new object[] {
            "CORDOBA (CAPITAL)",
            "CARLOS PAZ",
            "JESUS MARIA",
            "ARROYITO",
            "RIO TERCERO",
            "PILAR"});
            this.comboBoxLocalidad.Location = new System.Drawing.Point(80, 228);
            this.comboBoxLocalidad.Name = "comboBoxLocalidad";
            this.comboBoxLocalidad.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLocalidad.TabIndex = 151;
            // 
            // textBoxBarrio
            // 
            this.textBoxBarrio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxBarrio.Location = new System.Drawing.Point(80, 188);
            this.textBoxBarrio.Name = "textBoxBarrio";
            this.textBoxBarrio.Size = new System.Drawing.Size(121, 20);
            this.textBoxBarrio.TabIndex = 46;
            // 
            // textBoxDepto
            // 
            this.textBoxDepto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxDepto.Location = new System.Drawing.Point(80, 144);
            this.textBoxDepto.Name = "textBoxDepto";
            this.textBoxDepto.Size = new System.Drawing.Size(48, 20);
            this.textBoxDepto.TabIndex = 44;
            // 
            // textBoxPiso
            // 
            this.textBoxPiso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxPiso.Location = new System.Drawing.Point(80, 104);
            this.textBoxPiso.Name = "textBoxPiso";
            this.textBoxPiso.Size = new System.Drawing.Size(48, 20);
            this.textBoxPiso.TabIndex = 42;
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxNumero.Location = new System.Drawing.Point(80, 65);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(48, 20);
            this.textBoxNumero.TabIndex = 40;
            // 
            // Label21
            // 
            this.Label21.AutoSize = true;
            this.Label21.Location = new System.Drawing.Point(10, 328);
            this.Label21.Name = "Label21";
            this.Label21.Size = new System.Drawing.Size(64, 13);
            this.Label21.TabIndex = 31;
            this.Label21.Text = "Cód. Postal:";
            // 
            // Label20
            // 
            this.Label20.AutoSize = true;
            this.Label20.Location = new System.Drawing.Point(20, 278);
            this.Label20.Name = "Label20";
            this.Label20.Size = new System.Drawing.Size(54, 13);
            this.Label20.TabIndex = 29;
            this.Label20.Text = "Provincia:";
            // 
            // Label19
            // 
            this.Label19.AutoSize = true;
            this.Label19.Location = new System.Drawing.Point(18, 236);
            this.Label19.Name = "Label19";
            this.Label19.Size = new System.Drawing.Size(56, 13);
            this.Label19.TabIndex = 27;
            this.Label19.Text = "Localidad:";
            // 
            // Label18
            // 
            this.Label18.AutoSize = true;
            this.Label18.Location = new System.Drawing.Point(40, 191);
            this.Label18.Name = "Label18";
            this.Label18.Size = new System.Drawing.Size(37, 13);
            this.Label18.TabIndex = 25;
            this.Label18.Text = "Barrio:";
            // 
            // textBoxCalle
            // 
            this.textBoxCalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxCalle.Location = new System.Drawing.Point(80, 26);
            this.textBoxCalle.Name = "textBoxCalle";
            this.textBoxCalle.Size = new System.Drawing.Size(121, 20);
            this.textBoxCalle.TabIndex = 39;
            // 
            // Label17
            // 
            this.Label17.AutoSize = true;
            this.Label17.Location = new System.Drawing.Point(44, 147);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(33, 13);
            this.Label17.TabIndex = 23;
            this.Label17.Text = "Dpto:";
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.Location = new System.Drawing.Point(44, 107);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(30, 13);
            this.Label16.TabIndex = 21;
            this.Label16.Text = "Piso:";
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Location = new System.Drawing.Point(27, 68);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(47, 13);
            this.Label15.TabIndex = 19;
            this.Label15.Text = "Numero:";
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Location = new System.Drawing.Point(41, 29);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(33, 13);
            this.Label14.TabIndex = 18;
            this.Label14.Text = "Calle:";
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.ForeColor = System.Drawing.Color.Red;
            this.Label13.Location = new System.Drawing.Point(240, 98);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(17, 13);
            this.Label13.TabIndex = 85;
            this.Label13.Text = "(*)";
            // 
            // Label22
            // 
            this.Label22.AutoSize = true;
            this.Label22.ForeColor = System.Drawing.Color.Red;
            this.Label22.Location = new System.Drawing.Point(240, 65);
            this.Label22.Name = "Label22";
            this.Label22.Size = new System.Drawing.Size(17, 13);
            this.Label22.TabIndex = 86;
            this.Label22.Text = "(*)";
            // 
            // Label24
            // 
            this.Label24.AutoSize = true;
            this.Label24.ForeColor = System.Drawing.Color.Red;
            this.Label24.Location = new System.Drawing.Point(240, 32);
            this.Label24.Name = "Label24";
            this.Label24.Size = new System.Drawing.Size(17, 13);
            this.Label24.TabIndex = 87;
            this.Label24.Text = "(*)";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(16, 321);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(88, 13);
            this.Label8.TabIndex = 56;
            this.Label8.Text = "Seccion o cargo:";
            // 
            // textBoxTelefonoFijo
            // 
            this.textBoxTelefonoFijo.Location = new System.Drawing.Point(111, 204);
            this.textBoxTelefonoFijo.Name = "textBoxTelefonoFijo";
            this.textBoxTelefonoFijo.Size = new System.Drawing.Size(123, 20);
            this.textBoxTelefonoFijo.TabIndex = 54;
            // 
            // Label23
            // 
            this.Label23.AutoSize = true;
            this.Label23.Location = new System.Drawing.Point(8, 130);
            this.Label23.Name = "Label23";
            this.Label23.Size = new System.Drawing.Size(96, 13);
            this.Label23.TabIndex = 40;
            this.Label23.Text = "Fecha Nacimiento:";
            // 
            // DateTimePickerFechaIngreso
            // 
            this.DateTimePickerFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePickerFechaIngreso.Location = new System.Drawing.Point(112, 279);
            this.DateTimePickerFechaIngreso.Name = "DateTimePickerFechaIngreso";
            this.DateTimePickerFechaIngreso.Size = new System.Drawing.Size(122, 20);
            this.DateTimePickerFechaIngreso.TabIndex = 38;
            // 
            // textBoxTelefonoCelular
            // 
            this.textBoxTelefonoCelular.Location = new System.Drawing.Point(112, 167);
            this.textBoxTelefonoCelular.Name = "textBoxTelefonoCelular";
            this.textBoxTelefonoCelular.Size = new System.Drawing.Size(122, 20);
            this.textBoxTelefonoCelular.TabIndex = 55;
            // 
            // DateTimePeckerFechaNacimiento
            // 
            this.DateTimePeckerFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePeckerFechaNacimiento.Location = new System.Drawing.Point(112, 124);
            this.DateTimePeckerFechaNacimiento.Name = "DateTimePeckerFechaNacimiento";
            this.DateTimePeckerFechaNacimiento.Size = new System.Drawing.Size(122, 20);
            this.DateTimePeckerFechaNacimiento.TabIndex = 39;
            // 
            // textBoxEMail
            // 
            this.textBoxEMail.Location = new System.Drawing.Point(113, 242);
            this.textBoxEMail.Name = "textBoxEMail";
            this.textBoxEMail.Size = new System.Drawing.Size(121, 20);
            this.textBoxEMail.TabIndex = 31;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(27, 285);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(78, 13);
            this.Label10.TabIndex = 18;
            this.Label10.Text = "Fecha Ingreso:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(58, 36);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(47, 13);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Nombre:";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(65, 170);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(42, 13);
            this.Label5.TabIndex = 8;
            this.Label5.Text = "Celular:";
            // 
            // textBoxDNI
            // 
            this.textBoxDNI.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxDNI.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxDNI.Location = new System.Drawing.Point(111, 94);
            this.textBoxDNI.Name = "textBoxDNI";
            this.textBoxDNI.Size = new System.Drawing.Size(123, 20);
            this.textBoxDNI.TabIndex = 23;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(65, 249);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(39, 13);
            this.Label6.TabIndex = 10;
            this.Label6.Text = "E-Mail:";
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxApellido.Location = new System.Drawing.Point(111, 62);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(123, 20);
            this.textBoxApellido.TabIndex = 21;
            this.textBoxApellido.TextChanged += new System.EventHandler(this.textBoxApellido_TextChanged);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(57, 65);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(47, 13);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "Apellido:";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxNombre.Location = new System.Drawing.Point(111, 29);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(123, 20);
            this.textBoxNombre.TabIndex = 19;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(34, 207);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(71, 13);
            this.Label7.TabIndex = 12;
            this.Label7.Text = "Teléfono Fijo:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(75, 97);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(29, 13);
            this.Label4.TabIndex = 6;
            this.Label4.Text = "DNI:";
            // 
            // ButtonModificar
            // 
            this.ButtonModificar.Location = new System.Drawing.Point(6, 49);
            this.ButtonModificar.Name = "ButtonModificar";
            this.ButtonModificar.Size = new System.Drawing.Size(181, 24);
            this.ButtonModificar.TabIndex = 119;
            this.ButtonModificar.Text = "Modificar ";
            this.ButtonModificar.UseVisualStyleBackColor = true;
            this.ButtonModificar.Click += new System.EventHandler(this.ButtonModificar_Click);
            // 
            // ButtonLimpiar
            // 
            this.ButtonLimpiar.Location = new System.Drawing.Point(6, 109);
            this.ButtonLimpiar.Name = "ButtonLimpiar";
            this.ButtonLimpiar.Size = new System.Drawing.Size(181, 24);
            this.ButtonLimpiar.TabIndex = 116;
            this.ButtonLimpiar.Text = "Limpiar campos";
            this.ButtonLimpiar.UseVisualStyleBackColor = true;
            this.ButtonLimpiar.Click += new System.EventHandler(this.ButtonLimpiar_Click);
            // 
            // ButtonGuardar
            // 
            this.ButtonGuardar.Location = new System.Drawing.Point(6, 19);
            this.ButtonGuardar.Name = "ButtonGuardar";
            this.ButtonGuardar.Size = new System.Drawing.Size(181, 24);
            this.ButtonGuardar.TabIndex = 115;
            this.ButtonGuardar.Text = "Guardar";
            this.ButtonGuardar.UseVisualStyleBackColor = true;
            this.ButtonGuardar.Click += new System.EventHandler(this.ButtonGuardar_Click);
            // 
            // ButtonSalir
            // 
            this.ButtonSalir.Location = new System.Drawing.Point(6, 139);
            this.ButtonSalir.Name = "ButtonSalir";
            this.ButtonSalir.Size = new System.Drawing.Size(181, 23);
            this.ButtonSalir.TabIndex = 120;
            this.ButtonSalir.Text = "Salir";
            this.ButtonSalir.UseVisualStyleBackColor = true;
            this.ButtonSalir.Click += new System.EventHandler(this.ButtonSalir_Click);
            // 
            // ButtonEliminar
            // 
            this.ButtonEliminar.Location = new System.Drawing.Point(6, 80);
            this.ButtonEliminar.Name = "ButtonEliminar";
            this.ButtonEliminar.Size = new System.Drawing.Size(181, 23);
            this.ButtonEliminar.TabIndex = 121;
            this.ButtonEliminar.Text = "Eliminar";
            this.ButtonEliminar.UseVisualStyleBackColor = true;
            this.ButtonEliminar.Click += new System.EventHandler(this.ButtonEliminar_Click);
            // 
            // GroupBox3
            // 
            this.GroupBox3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.GroupBox3.Controls.Add(this.ButtonEliminar);
            this.GroupBox3.Controls.Add(this.ButtonSalir);
            this.GroupBox3.Controls.Add(this.ButtonGuardar);
            this.GroupBox3.Controls.Add(this.ButtonLimpiar);
            this.GroupBox3.Controls.Add(this.ButtonModificar);
            this.GroupBox3.Location = new System.Drawing.Point(547, 12);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(194, 170);
            this.GroupBox3.TabIndex = 155;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "OPCIONES";
            this.GroupBox3.Enter += new System.EventHandler(this.GroupBox3_Enter);
            // 
            // Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 581);
            this.Controls.Add(this.DataGridViewEmpleado);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.GroupBox1);
            this.Name = "Empleado";
            this.Text = "Empleado";
            this.Load += new System.EventHandler(this.Empleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewEmpleado)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.DataGridView DataGridViewEmpleado;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.ComboBox comboBoxSeccion;
        internal System.Windows.Forms.Label Label26;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.ComboBox comboBoxProvincia;
        internal System.Windows.Forms.TextBox textBoxCodigoPostal;
        internal System.Windows.Forms.ComboBox comboBoxLocalidad;
        internal System.Windows.Forms.TextBox textBoxBarrio;
        internal System.Windows.Forms.TextBox textBoxDepto;
        internal System.Windows.Forms.TextBox textBoxPiso;
        internal System.Windows.Forms.TextBox textBoxNumero;
        internal System.Windows.Forms.Label Label21;
        internal System.Windows.Forms.Label Label20;
        internal System.Windows.Forms.Label Label19;
        internal System.Windows.Forms.Label Label18;
        internal System.Windows.Forms.TextBox textBoxCalle;
        internal System.Windows.Forms.Label Label17;
        internal System.Windows.Forms.Label Label16;
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.Label Label22;
        internal System.Windows.Forms.Label Label24;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.TextBox textBoxTelefonoFijo;
        internal System.Windows.Forms.Label Label23;
        internal System.Windows.Forms.DateTimePicker DateTimePickerFechaIngreso;
        internal System.Windows.Forms.TextBox textBoxTelefonoCelular;
        internal System.Windows.Forms.DateTimePicker DateTimePeckerFechaNacimiento;
        internal System.Windows.Forms.TextBox textBoxEMail;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox textBoxDNI;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox textBoxApellido;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox textBoxNombre;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Button ButtonModificar;
        internal System.Windows.Forms.Button ButtonLimpiar;
        internal System.Windows.Forms.Button ButtonGuardar;
        internal System.Windows.Forms.Button ButtonSalir;
        internal System.Windows.Forms.Button ButtonEliminar;
        internal System.Windows.Forms.GroupBox GroupBox3;
    }
}