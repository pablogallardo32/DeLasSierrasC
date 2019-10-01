namespace Interfaces
{
    partial class Sabor
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
            this.dataGridViewSabor = new System.Windows.Forms.DataGridView();
            this.textBoxNombreSabor = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.comboBoxIDSabor = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSabor)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(311, 80);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminar.TabIndex = 28;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonModificar
            // 
            this.buttonModificar.Location = new System.Drawing.Point(311, 51);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(75, 23);
            this.buttonModificar.TabIndex = 25;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // dataGridViewSabor
            // 
            this.dataGridViewSabor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSabor.Location = new System.Drawing.Point(21, 138);
            this.dataGridViewSabor.Name = "dataGridViewSabor";
            this.dataGridViewSabor.Size = new System.Drawing.Size(284, 120);
            this.dataGridViewSabor.TabIndex = 29;
            this.dataGridViewSabor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSabor_CellClick);
            this.dataGridViewSabor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSabor_CellContentClick);
            // 
            // textBoxNombreSabor
            // 
            this.textBoxNombreSabor.Location = new System.Drawing.Point(77, 74);
            this.textBoxNombreSabor.Name = "textBoxNombreSabor";
            this.textBoxNombreSabor.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombreSabor.TabIndex = 23;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(18, 77);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(38, 13);
            this.Label2.TabIndex = 21;
            this.Label2.Text = "Sabor:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(18, 42);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(52, 13);
            this.Label1.TabIndex = 20;
            this.Label1.Text = "ID Sabor:";
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(311, 138);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(75, 23);
            this.buttonSalir.TabIndex = 27;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(311, 109);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpiar.TabIndex = 26;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(311, 22);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 24;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // comboBoxIDSabor
            // 
            this.comboBoxIDSabor.Enabled = false;
            this.comboBoxIDSabor.FormattingEnabled = true;
            this.comboBoxIDSabor.Location = new System.Drawing.Point(77, 39);
            this.comboBoxIDSabor.Name = "comboBoxIDSabor";
            this.comboBoxIDSabor.Size = new System.Drawing.Size(100, 21);
            this.comboBoxIDSabor.TabIndex = 30;
            // 
            // Sabor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 281);
            this.Controls.Add(this.comboBoxIDSabor);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.dataGridViewSabor);
            this.Controls.Add(this.textBoxNombreSabor);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.buttonGuardar);
            this.Name = "Sabor";
            this.Text = "Sabor";
            this.Load += new System.EventHandler(this.Sabor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSabor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.DataGridView dataGridViewSabor;
        internal System.Windows.Forms.TextBox textBoxNombreSabor;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button buttonSalir;
        internal System.Windows.Forms.Button buttonLimpiar;
        internal System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.ComboBox comboBoxIDSabor;
    }
}