using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
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
            LimpiarCampos();
            ButtonModificar.Enabled = false;
            ButtonGuardar.Enabled = true;
        }

        private void LimpiarCampos()
        {
            
            textBoxNombreEmpresa.Text = string.Empty;
            comboBoxRubro.Text = string.Empty;
            textBoxTelefonoVendedor.Text = string.Empty;
            textBoxTelefonoRepartidor.Text = string.Empty;

            comboBoxNumeroProveedor.DataSource = ObjetoProveedorLN.TraerUltimoNumeroProveedor();
            comboBoxNumeroProveedor.DisplayMember = "NumeroProveedor";
        }

        private void ButtonGuardar_Click(object sender, EventArgs e)
        {
           

            DialogResult r = MessageBox.Show("¿Desea guardar el proveedor?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                if (textBoxNombreEmpresa.Text != "" && comboBoxRubro.Text != "" && textBoxTelefonoVendedor.Text != "" && textBoxTelefonoRepartidor.Text != "")
                {
                    ObjetoProveedorNE.NombreEmpresa = textBoxNombreEmpresa.Text;
                    ObjetoProveedorNE.NumeroProveedor = comboBoxNumeroProveedor.Text;
                    ObjetoProveedorNE.Rubro = comboBoxRubro.Text;
                    ObjetoProveedorNE.TelefonoVendedor = Convert.ToInt32(textBoxTelefonoVendedor.Text);
                    ObjetoProveedorNE.TelefonoRepartidor = Convert.ToInt32(textBoxTelefonoRepartidor.Text);

                    ObjetoProveedorLN.AgregarProveedor(ObjetoProveedorNE);
                    MessageBox.Show("Proveedor guardado con éxito");
                    LimpiarCampos();
                    dataGridViewProveedor.DataSource = ObjetoProveedorLN.MostrarProveedor();

                    
                    LimpiarCampos();

                   
                }
                else

                    MessageBox.Show("Existen campos vacíos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else if (r == DialogResult.No)
            {
            }
            
        }

        private void Proveedor_Load(object sender, EventArgs e)
        {
            comboBoxNumeroProveedor.DataSource = ObjetoProveedorLN.TraerUltimoNumeroProveedor();
            comboBoxNumeroProveedor.DisplayMember = "NumeroProveedor";

            textBoxTelefonoVendedor.KeyPress += new KeyPressEventHandler(ValidarTelefonoVendedor);
            textBoxTelefonoRepartidor.KeyPress += new KeyPressEventHandler(ValidarTelefonoRepartidor);

            dataGridViewProveedor.DataSource = ObjetoProveedorLN.MostrarProveedor();
            comboBoxRubro.DataSource = ObjetoProveedorLN.LlenarComboRubro();
            comboBoxRubro.DisplayMember = "NombreRubro";

            ButtonModificar.Enabled = false;

        }

        private void ButtonModificar_Click(object sender, EventArgs e)
        {

            DialogResult r = MessageBox.Show("¿Desea modificar el proveedor?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                if (textBoxNombreEmpresa.Text != "" && comboBoxRubro.Text != "" && textBoxTelefonoVendedor.Text != "" && textBoxTelefonoRepartidor.Text != "")
                {
            ObjetoProveedorNE.NombreEmpresa = textBoxNombreEmpresa.Text;
            ObjetoProveedorNE.NumeroProveedor = comboBoxNumeroProveedor.Text;
            ObjetoProveedorNE.Rubro = comboBoxRubro.Text;
            ObjetoProveedorNE.TelefonoVendedor = Convert.ToInt32(textBoxTelefonoVendedor.Text);
            ObjetoProveedorNE.TelefonoRepartidor = Convert.ToInt32(textBoxTelefonoRepartidor.Text);


            ObjetoProveedorLN.ModificarProveedor(ObjetoProveedorNE);
            MessageBox.Show("Proveedor modificado con éxito");

            dataGridViewProveedor.DataSource = ObjetoProveedorLN.MostrarProveedor();
            LimpiarCampos();

            comboBoxNumeroProveedor.DataSource = ObjetoProveedorLN.TraerUltimoNumeroProveedor();
            comboBoxNumeroProveedor.DisplayMember = "NumeroProveedor";

            ButtonModificar.Enabled = false;
            ButtonGuardar.Enabled = true;
                }
                else

                    MessageBox.Show("Existen campos vacíos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else if (r == DialogResult.No)
            {
            }
        }

        private void dataGridViewProveedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxNombreEmpresa.Text = dataGridViewProveedor.Rows[e.RowIndex].Cells["NombreEmpresa"].Value.ToString();
            comboBoxNumeroProveedor.Text = dataGridViewProveedor.Rows[e.RowIndex].Cells["NumeroProveedor"].Value.ToString();
            comboBoxRubro.Text = dataGridViewProveedor.Rows[e.RowIndex].Cells["Rubro"].Value.ToString();
            textBoxTelefonoVendedor.Text = dataGridViewProveedor.Rows[e.RowIndex].Cells["TelefonoVendedor"].Value.ToString();
            textBoxTelefonoRepartidor.Text = dataGridViewProveedor.Rows[e.RowIndex].Cells["TelefonoRepartidor"].Value.ToString();

            ButtonGuardar.Enabled = false;
            ButtonModificar.Enabled = true;

        }

        private void ButtonEliminar_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Desea eliminar el proveedor?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                if ( textBoxNombreEmpresa.Text != "" && comboBoxNumeroProveedor.Text != "" && comboBoxRubro.Text != "" && textBoxTelefonoVendedor.Text != "" && textBoxTelefonoRepartidor.Text != "")
                {

            ObjetoProveedorNE.NombreEmpresa = textBoxNombreEmpresa.Text;
            ObjetoProveedorNE.NumeroProveedor = comboBoxNumeroProveedor.Text;
            ObjetoProveedorNE.Rubro = comboBoxRubro.Text;
            ObjetoProveedorNE.TelefonoVendedor = Convert.ToInt32(textBoxTelefonoVendedor.Text);
            ObjetoProveedorNE.TelefonoRepartidor = Convert.ToInt32(textBoxTelefonoRepartidor.Text);

                ObjetoProveedorLN.EliminarProveedor(ObjetoProveedorNE);
                dataGridViewProveedor.DataSource = ObjetoProveedorLN.MostrarProveedor();
                MessageBox.Show("Proveedor eliminado con éxito");

                LimpiarCampos();

                comboBoxNumeroProveedor.DataSource = ObjetoProveedorLN.TraerUltimoNumeroProveedor();
            comboBoxNumeroProveedor.DisplayMember = "NumeroProveedor";

            ButtonModificar.Enabled = false;
            ButtonGuardar.Enabled = true;
                }
                 else
                
                    MessageBox.Show("Seleccione proveedor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (r == DialogResult.No)
                {
                }
                }
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
