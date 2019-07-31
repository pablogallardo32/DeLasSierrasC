using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaces
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void ProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Proveedor proveedor = new Proveedor();
            proveedor.ShowDialog();
        }

        private void EmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado();
            empleado.ShowDialog();
        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonProveedores_Click(object sender, EventArgs e)
        {
            Proveedor proveedor = new Proveedor();
            proveedor.ShowDialog();
        }

        private void buttonEmpleados_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado();
            empleado.ShowDialog();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonProductos_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            producto.ShowDialog();
        }
    }
}
