using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLN;
using CapaNE;

namespace Interfaces
{
    public partial class Proveedor : Form
    {

        ProveedorLN ObjetoProveedorLN = new ProveedorLN();
        ProveedorNE ObjetoProveedorNE = new ProveedorNE();
        public Proveedor()
        {
            InitializeComponent();
        }

        private void ButtonSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonListar_Click(object sender, EventArgs e)
        {
            dataGridViewProveedor.DataSource = ObjetoProveedorLN.MostrarProveedor();

        }

        private void ButtonLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void limpiar()
        {
            textBoxNombreEmpresa.Text = string.Empty;
            textBoxNumeroProveedor.Text = string.Empty;
            comboBoxRubro.Text = string.Empty;
            textBoxTelefonoVendedor.Text = string.Empty;
            textBoxTelefonoRepartidor.Text = string.Empty;
        }

        private void ButtonGuardar_Click(object sender, EventArgs e)
        {
            ObjetoProveedorNE.NombreEmpresa = textBoxNombreEmpresa.Text;
            ObjetoProveedorNE.NumeroProveedor = textBoxNumeroProveedor.Text;
            ObjetoProveedorNE.Rubro = comboBoxRubro.Text;
            ObjetoProveedorNE.TelefonoVendedor = Convert.ToInt32(textBoxTelefonoVendedor.Text);
            ObjetoProveedorNE.TelefonoRepartidor = Convert.ToInt32(textBoxTelefonoRepartidor.Text);

            ObjetoProveedorLN.AgregarProveedor(ObjetoProveedorNE);
            MessageBox.Show("Proveedor guardado con éxito");
        }

        private void Proveedor_Load(object sender, EventArgs e)
        {

            textBoxNumeroProveedor.KeyPress += new KeyPressEventHandler(ValidarNumeroProveedor);
            textBoxTelefonoVendedor.KeyPress += new KeyPressEventHandler(ValidarTelefonoVendedor);
            textBoxTelefonoRepartidor.KeyPress += new KeyPressEventHandler(ValidarTelefonoRepartidor);


            dataGridViewProveedor.DataSource = ObjetoProveedorLN.MostrarProveedor();

        }

        private void ButtonModificar_Click(object sender, EventArgs e)
        {
            ObjetoProveedorNE.NombreEmpresa = textBoxNombreEmpresa.Text;
            ObjetoProveedorNE.NumeroProveedor = textBoxNumeroProveedor.Text;
            ObjetoProveedorNE.Rubro = comboBoxRubro.Text;
            ObjetoProveedorNE.TelefonoVendedor = Convert.ToInt32(textBoxTelefonoVendedor.Text);
            ObjetoProveedorNE.TelefonoRepartidor = Convert.ToInt32(textBoxTelefonoRepartidor.Text);

            ObjetoProveedorLN.ModificarProveedor(ObjetoProveedorNE);
            MessageBox.Show("Proveedor modificado con éxito");

            dataGridViewProveedor.DataSource = ObjetoProveedorLN.MostrarProveedor();
            limpiar();
        }

        private void dataGridViewProveedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxNombreEmpresa.Text = dataGridViewProveedor.Rows[e.RowIndex].Cells["NombreEmpresa"].Value.ToString();
            textBoxNumeroProveedor.Text = dataGridViewProveedor.Rows[e.RowIndex].Cells["NumeroProveedor"].Value.ToString();
            comboBoxRubro.Text = dataGridViewProveedor.Rows[e.RowIndex].Cells["Rubro"].Value.ToString();
            textBoxTelefonoVendedor.Text = dataGridViewProveedor.Rows[e.RowIndex].Cells["TelefonoVendedor"].Value.ToString();
            textBoxTelefonoRepartidor.Text = dataGridViewProveedor.Rows[e.RowIndex].Cells["TelefonoRepartidor"].Value.ToString();

        }

        private void ButtonEliminar_Click(object sender, EventArgs e)
        {
            ObjetoProveedorNE.NombreEmpresa = textBoxNombreEmpresa.Text;
            ObjetoProveedorNE.NumeroProveedor = textBoxNumeroProveedor.Text;
            ObjetoProveedorNE.Rubro = comboBoxRubro.Text;
            ObjetoProveedorNE.TelefonoVendedor = Convert.ToInt32(textBoxTelefonoVendedor.Text);
            ObjetoProveedorNE.TelefonoRepartidor = Convert.ToInt32(textBoxTelefonoRepartidor.Text);

            ObjetoProveedorLN.EliminarProveedor(ObjetoProveedorNE);
            MessageBox.Show("Proveedor eliminado con éxito");

            dataGridViewProveedor.DataSource = ObjetoProveedorLN.MostrarProveedor();
            limpiar();
        }

        private void ValidarNumeroProveedor(Object o, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))//Si es número
            {
                e.Handled = false;
            }
            else if (e.KeyChar == (char)Keys.Back)//si es tecla borrar
            {
                e.Handled = false;
            }
            else //Si es otra tecla cancelamos
            {
                e.Handled = true;
            }
        }

        private void ValidarTelefonoVendedor(Object o, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))//Si es número
            {
                e.Handled = false;
            }
            else if (e.KeyChar == (char)Keys.Back)//si es tecla borrar
            {
                e.Handled = false;
            }
            else //Si es otra tecla cancelamos
            {
                e.Handled = true;
            }
        }

        private void ValidarTelefonoRepartidor(Object o, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))//Si es número
            {
                e.Handled = false;
            }
            else if (e.KeyChar == (char)Keys.Back)//si es tecla borrar
            {
                e.Handled = false;
            }
            else //Si es otra tecla cancelamos
            {
                e.Handled = true;
            }
        }

        private void buttonRubro_Click(object sender, EventArgs e)
        {
            Rubro rubro = new Rubro();
            rubro.ShowDialog();
            
        }
    }
}
