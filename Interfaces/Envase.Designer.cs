﻿namespace Interfaces
{
    partial class Envase
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
            this.dataGridViewEnvase = new System.Windows.Forms.DataGridView();
            this.textBoxNombreEnvase = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.comboBoxIDEnvase = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEnvase)).BeginInit();
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
            // dataGridViewEnvase
            // 
            this.dataGridViewEnvase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEnvase.Location = new System.Drawing.Point(21, 138);
            this.dataGridViewEnvase.Name = "dataGridViewEnvase";
            this.dataGridViewEnvase.Size = new System.Drawing.Size(284, 120);
            this.dataGridViewEnvase.TabIndex = 29;
            this.dataGridViewEnvase.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEnvase_CellClick);
            // 
            // textBoxNombreEnvase
            // 
            this.textBoxNombreEnvase.Location = new System.Drawing.Point(77, 74);
            this.textBoxNombreEnvase.Name = "textBoxNombreEnvase";
            this.textBoxNombreEnvase.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombreEnvase.TabIndex = 23;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(18, 77);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(46, 13);
            this.Label2.TabIndex = 21;
            this.Label2.Text = "Envase:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(18, 42);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(60, 13);
            this.Label1.TabIndex = 20;
            this.Label1.Text = "ID Envase:";
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
            // comboBoxIDEnvase
            // 
            this.comboBoxIDEnvase.Enabled = false;
            this.comboBoxIDEnvase.FormattingEnabled = true;
            this.comboBoxIDEnvase.Location = new System.Drawing.Point(77, 42);
            this.comboBoxIDEnvase.Name = "comboBoxIDEnvase";
            this.comboBoxIDEnvase.Size = new System.Drawing.Size(100, 21);
            this.comboBoxIDEnvase.TabIndex = 30;
            // 
            // Envase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 281);
            this.Controls.Add(this.comboBoxIDEnvase);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.dataGridViewEnvase);
            this.Controls.Add(this.textBoxNombreEnvase);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.buttonGuardar);
            this.Name = "Envase";
            this.Text = "Envase";
            this.Load += new System.EventHandler(this.Envase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEnvase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.DataGridView dataGridViewEnvase;
        internal System.Windows.Forms.TextBox textBoxNombreEnvase;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button buttonSalir;
        internal System.Windows.Forms.Button buttonLimpiar;
        internal System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.ComboBox comboBoxIDEnvase;
    }
}