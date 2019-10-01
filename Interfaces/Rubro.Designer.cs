namespace Interfaces
{
    partial class Rubro
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
            this.textBoxNombreRubro = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.dataGridViewRubro = new System.Windows.Forms.DataGridView();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.comboBoxIDRubro = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRubro)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNombreRubro
            // 
            this.textBoxNombreRubro.Location = new System.Drawing.Point(83, 68);
            this.textBoxNombreRubro.Name = "textBoxNombreRubro";
            this.textBoxNombreRubro.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombreRubro.TabIndex = 13;
            this.textBoxNombreRubro.TextChanged += new System.EventHandler(this.textBoxNombreRubro_TextChanged);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(24, 71);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(39, 13);
            this.Label2.TabIndex = 11;
            this.Label2.Text = "Rubro:";
            this.Label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(24, 36);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(53, 13);
            this.Label1.TabIndex = 10;
            this.Label1.Text = "ID Rubro:";
            this.Label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(317, 132);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(75, 23);
            this.buttonSalir.TabIndex = 17;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.ButtonSalir_Click);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(317, 103);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpiar.TabIndex = 16;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.ButtonLimpiar_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(317, 16);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 14;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.ButtonGuardar_Click);
            // 
            // dataGridViewRubro
            // 
            this.dataGridViewRubro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRubro.Location = new System.Drawing.Point(27, 132);
            this.dataGridViewRubro.Name = "dataGridViewRubro";
            this.dataGridViewRubro.Size = new System.Drawing.Size(284, 120);
            this.dataGridViewRubro.TabIndex = 19;
            this.dataGridViewRubro.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRubro2_CellClick);
            this.dataGridViewRubro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRubro2_CellClick);
            // 
            // buttonModificar
            // 
            this.buttonModificar.Location = new System.Drawing.Point(317, 45);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(75, 23);
            this.buttonModificar.TabIndex = 15;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(317, 74);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminar.TabIndex = 18;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // comboBoxIDRubro
            // 
            this.comboBoxIDRubro.Enabled = false;
            this.comboBoxIDRubro.FormattingEnabled = true;
            this.comboBoxIDRubro.Location = new System.Drawing.Point(84, 33);
            this.comboBoxIDRubro.Name = "comboBoxIDRubro";
            this.comboBoxIDRubro.Size = new System.Drawing.Size(99, 21);
            this.comboBoxIDRubro.TabIndex = 20;
            // 
            // Rubro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 281);
            this.Controls.Add(this.comboBoxIDRubro);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.dataGridViewRubro);
            this.Controls.Add(this.textBoxNombreRubro);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.buttonGuardar);
            this.Name = "Rubro";
            this.Text = "Rubro";
            this.Load += new System.EventHandler(this.Rubro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRubro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void textBoxIDRubro_KeyChar(object sender, System.EventArgs e)
        {
         //   throw new System.NotImplementedException();
        }

        #endregion

        internal System.Windows.Forms.TextBox textBoxNombreRubro;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button buttonSalir;
        internal System.Windows.Forms.Button buttonLimpiar;
        internal System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.DataGridView dataGridViewRubro;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.ComboBox comboBoxIDRubro;
    }
}