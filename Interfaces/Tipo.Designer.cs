namespace Interfaces
{
    partial class Tipo
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
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.dataGridViewTipo = new System.Windows.Forms.DataGridView();
            this.textBoxNombreTipo = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.comboBoxIDTipo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTipo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(311, 80);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminar.TabIndex = 38;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonModificar
            // 
            this.buttonModificar.Location = new System.Drawing.Point(311, 51);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(75, 23);
            this.buttonModificar.TabIndex = 35;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click_1);
            // 
            // dataGridViewTipo
            // 
            this.dataGridViewTipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTipo.Location = new System.Drawing.Point(21, 138);
            this.dataGridViewTipo.Name = "dataGridViewTipo";
            this.dataGridViewTipo.Size = new System.Drawing.Size(284, 120);
            this.dataGridViewTipo.TabIndex = 39;
            this.dataGridViewTipo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTipo_CellClick);
            this.dataGridViewTipo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTipo_CellContentClick);
            // 
            // textBoxNombreTipo
            // 
            this.textBoxNombreTipo.Location = new System.Drawing.Point(77, 74);
            this.textBoxNombreTipo.Name = "textBoxNombreTipo";
            this.textBoxNombreTipo.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombreTipo.TabIndex = 33;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(18, 77);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(31, 13);
            this.Label2.TabIndex = 31;
            this.Label2.Text = "Tipo:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(18, 42);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(45, 13);
            this.Label1.TabIndex = 30;
            this.Label1.Text = "ID Tipo:";
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(311, 138);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(75, 23);
            this.buttonSalir.TabIndex = 37;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click_1);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(311, 109);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpiar.TabIndex = 36;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click_1);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(311, 22);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 34;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click_1);
            // 
            // comboBoxIDTipo
            // 
            this.comboBoxIDTipo.Enabled = false;
            this.comboBoxIDTipo.FormattingEnabled = true;
            this.comboBoxIDTipo.Location = new System.Drawing.Point(77, 39);
            this.comboBoxIDTipo.Name = "comboBoxIDTipo";
            this.comboBoxIDTipo.Size = new System.Drawing.Size(100, 21);
            this.comboBoxIDTipo.TabIndex = 40;
            // 
            // Tipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 281);
            this.Controls.Add(this.comboBoxIDTipo);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.dataGridViewTipo);
            this.Controls.Add(this.textBoxNombreTipo);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.buttonGuardar);
            this.Name = "Tipo";
            this.Text = "Tipo";
            this.Load += new System.EventHandler(this.Tipo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTipo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.DataGridView dataGridViewTipo;
        internal System.Windows.Forms.TextBox textBoxNombreTipo;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button buttonSalir;
        internal System.Windows.Forms.Button buttonLimpiar;
        internal System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.ComboBox comboBoxIDTipo;
    }
}