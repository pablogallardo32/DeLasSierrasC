namespace Interfaces
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.buttonProveedores = new System.Windows.Forms.Button();
            this.buttonProductos = new System.Windows.Forms.Button();
            this.buttonFacturas = new System.Windows.Forms.Button();
            this.buttonEmpleados = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonProveedores
            // 
            this.buttonProveedores.Location = new System.Drawing.Point(57, 49);
            this.buttonProveedores.Name = "buttonProveedores";
            this.buttonProveedores.Size = new System.Drawing.Size(142, 105);
            this.buttonProveedores.TabIndex = 6;
            this.buttonProveedores.Text = "PROVEEDORES";
            this.buttonProveedores.UseVisualStyleBackColor = true;
            this.buttonProveedores.Click += new System.EventHandler(this.buttonProveedores_Click);
            // 
            // buttonProductos
            // 
            this.buttonProductos.Location = new System.Drawing.Point(221, 52);
            this.buttonProductos.Name = "buttonProductos";
            this.buttonProductos.Size = new System.Drawing.Size(142, 105);
            this.buttonProductos.TabIndex = 7;
            this.buttonProductos.Text = "PRODUCTOS";
            this.buttonProductos.UseVisualStyleBackColor = true;
            this.buttonProductos.Click += new System.EventHandler(this.buttonProductos_Click);
            // 
            // buttonFacturas
            // 
            this.buttonFacturas.Location = new System.Drawing.Point(57, 163);
            this.buttonFacturas.Name = "buttonFacturas";
            this.buttonFacturas.Size = new System.Drawing.Size(142, 105);
            this.buttonFacturas.TabIndex = 8;
            this.buttonFacturas.Text = "FACTURAS";
            this.buttonFacturas.UseVisualStyleBackColor = true;
            // 
            // buttonEmpleados
            // 
            this.buttonEmpleados.Location = new System.Drawing.Point(221, 163);
            this.buttonEmpleados.Name = "buttonEmpleados";
            this.buttonEmpleados.Size = new System.Drawing.Size(142, 105);
            this.buttonEmpleados.TabIndex = 9;
            this.buttonEmpleados.Text = "EMPLEADOS";
            this.buttonEmpleados.UseVisualStyleBackColor = true;
            this.buttonEmpleados.Click += new System.EventHandler(this.buttonEmpleados_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(388, 52);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(142, 105);
            this.buttonSalir.TabIndex = 10;
            this.buttonSalir.Text = "SALIR";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(754, 398);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonEmpleados);
            this.Controls.Add(this.buttonFacturas);
            this.Controls.Add(this.buttonProductos);
            this.Controls.Add(this.buttonProveedores);
            this.DoubleBuffered = true;
            this.Name = "MenuPrincipal";
            this.Text = "Menú Principal";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonProveedores;
        private System.Windows.Forms.Button buttonProductos;
        private System.Windows.Forms.Button buttonFacturas;
        private System.Windows.Forms.Button buttonEmpleados;
        private System.Windows.Forms.Button buttonSalir;
    }
}