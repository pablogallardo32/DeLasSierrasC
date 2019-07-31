namespace Interfaces
{
    partial class Proveedor
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxRubro = new System.Windows.Forms.ComboBox();
            this.textBoxNombreEmpresa = new System.Windows.Forms.TextBox();
            this.textBoxNumeroProveedor = new System.Windows.Forms.TextBox();
            this.textBoxTelefonoVendedor = new System.Windows.Forms.TextBox();
            this.textBoxTelefonoRepartidor = new System.Windows.Forms.TextBox();
            this.dataGridViewProveedor = new System.Windows.Forms.DataGridView();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.ButtonImprimir = new System.Windows.Forms.Button();
            this.ButtonListar = new System.Windows.Forms.Button();
            this.ButtonEliminar = new System.Windows.Forms.Button();
            this.ButtonSalir = new System.Windows.Forms.Button();
            this.ButtonGuardar = new System.Windows.Forms.Button();
            this.ButtonLimpiar = new System.Windows.Forms.Button();
            this.ButtonModificar = new System.Windows.Forms.Button();
            this.buttonRubro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProveedor)).BeginInit();
            this.GroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de la empresa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número de proveedor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rubro:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Teléfono del vendedor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Teléfono del reparidor:";
            // 
            // comboBoxRubro
            // 
            this.comboBoxRubro.FormattingEnabled = true;
            this.comboBoxRubro.Location = new System.Drawing.Point(154, 101);
            this.comboBoxRubro.Name = "comboBoxRubro";
            this.comboBoxRubro.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRubro.TabIndex = 5;
            // 
            // textBoxNombreEmpresa
            // 
            this.textBoxNombreEmpresa.Location = new System.Drawing.Point(154, 36);
            this.textBoxNombreEmpresa.Name = "textBoxNombreEmpresa";
            this.textBoxNombreEmpresa.Size = new System.Drawing.Size(121, 20);
            this.textBoxNombreEmpresa.TabIndex = 6;
            // 
            // textBoxNumeroProveedor
            // 
            this.textBoxNumeroProveedor.Location = new System.Drawing.Point(154, 68);
            this.textBoxNumeroProveedor.Name = "textBoxNumeroProveedor";
            this.textBoxNumeroProveedor.Size = new System.Drawing.Size(121, 20);
            this.textBoxNumeroProveedor.TabIndex = 7;
            // 
            // textBoxTelefonoVendedor
            // 
            this.textBoxTelefonoVendedor.Location = new System.Drawing.Point(154, 135);
            this.textBoxTelefonoVendedor.Name = "textBoxTelefonoVendedor";
            this.textBoxTelefonoVendedor.Size = new System.Drawing.Size(121, 20);
            this.textBoxTelefonoVendedor.TabIndex = 8;
            // 
            // textBoxTelefonoRepartidor
            // 
            this.textBoxTelefonoRepartidor.Location = new System.Drawing.Point(154, 170);
            this.textBoxTelefonoRepartidor.Name = "textBoxTelefonoRepartidor";
            this.textBoxTelefonoRepartidor.Size = new System.Drawing.Size(121, 20);
            this.textBoxTelefonoRepartidor.TabIndex = 9;
            // 
            // dataGridViewProveedor
            // 
            this.dataGridViewProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProveedor.Location = new System.Drawing.Point(24, 270);
            this.dataGridViewProveedor.Name = "dataGridViewProveedor";
            this.dataGridViewProveedor.Size = new System.Drawing.Size(459, 150);
            this.dataGridViewProveedor.TabIndex = 10;
            this.dataGridViewProveedor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProveedor_CellClick);
            // 
            // GroupBox3
            // 
            this.GroupBox3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.GroupBox3.Controls.Add(this.ButtonImprimir);
            this.GroupBox3.Controls.Add(this.ButtonListar);
            this.GroupBox3.Controls.Add(this.ButtonEliminar);
            this.GroupBox3.Controls.Add(this.ButtonSalir);
            this.GroupBox3.Controls.Add(this.ButtonGuardar);
            this.GroupBox3.Controls.Add(this.ButtonLimpiar);
            this.GroupBox3.Controls.Add(this.ButtonModificar);
            this.GroupBox3.Location = new System.Drawing.Point(309, 12);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(194, 238);
            this.GroupBox3.TabIndex = 156;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "OPCIONES";
            // 
            // ButtonImprimir
            // 
            this.ButtonImprimir.Location = new System.Drawing.Point(8, 167);
            this.ButtonImprimir.Name = "ButtonImprimir";
            this.ButtonImprimir.Size = new System.Drawing.Size(179, 23);
            this.ButtonImprimir.TabIndex = 123;
            this.ButtonImprimir.Text = "Imprimir";
            this.ButtonImprimir.UseVisualStyleBackColor = true;
            // 
            // ButtonListar
            // 
            this.ButtonListar.Location = new System.Drawing.Point(8, 139);
            this.ButtonListar.Name = "ButtonListar";
            this.ButtonListar.Size = new System.Drawing.Size(180, 23);
            this.ButtonListar.TabIndex = 122;
            this.ButtonListar.Text = "Listar";
            this.ButtonListar.UseVisualStyleBackColor = true;
            this.ButtonListar.Click += new System.EventHandler(this.ButtonListar_Click);
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
            // ButtonSalir
            // 
            this.ButtonSalir.Location = new System.Drawing.Point(8, 194);
            this.ButtonSalir.Name = "ButtonSalir";
            this.ButtonSalir.Size = new System.Drawing.Size(181, 23);
            this.ButtonSalir.TabIndex = 120;
            this.ButtonSalir.Text = "Salir";
            this.ButtonSalir.UseVisualStyleBackColor = true;
            this.ButtonSalir.Click += new System.EventHandler(this.ButtonSalir_Click);
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
            // buttonRubro
            // 
            this.buttonRubro.Location = new System.Drawing.Point(276, 101);
            this.buttonRubro.Name = "buttonRubro";
            this.buttonRubro.Size = new System.Drawing.Size(27, 23);
            this.buttonRubro.TabIndex = 157;
            this.buttonRubro.Text = "+";
            this.buttonRubro.UseVisualStyleBackColor = true;
            this.buttonRubro.Click += new System.EventHandler(this.buttonRubro_Click);
            // 
            // Proveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 432);
            this.Controls.Add(this.buttonRubro);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.dataGridViewProveedor);
            this.Controls.Add(this.textBoxTelefonoRepartidor);
            this.Controls.Add(this.textBoxTelefonoVendedor);
            this.Controls.Add(this.textBoxNumeroProveedor);
            this.Controls.Add(this.textBoxNombreEmpresa);
            this.Controls.Add(this.comboBoxRubro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Proveedor";
            this.Text = "Proveedor";
            this.Load += new System.EventHandler(this.Proveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProveedor)).EndInit();
            this.GroupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxRubro;
        private System.Windows.Forms.TextBox textBoxNombreEmpresa;
        private System.Windows.Forms.TextBox textBoxNumeroProveedor;
        private System.Windows.Forms.TextBox textBoxTelefonoVendedor;
        private System.Windows.Forms.TextBox textBoxTelefonoRepartidor;
        private System.Windows.Forms.DataGridView dataGridViewProveedor;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.Button ButtonImprimir;
        internal System.Windows.Forms.Button ButtonListar;
        internal System.Windows.Forms.Button ButtonEliminar;
        internal System.Windows.Forms.Button ButtonSalir;
        internal System.Windows.Forms.Button ButtonGuardar;
        internal System.Windows.Forms.Button ButtonLimpiar;
        internal System.Windows.Forms.Button ButtonModificar;
        private System.Windows.Forms.Button buttonRubro;
    }
}