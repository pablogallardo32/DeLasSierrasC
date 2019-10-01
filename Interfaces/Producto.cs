using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNE;
using CapaLN;

namespace Interfaces
{
    public partial class Producto : Form
    {
        ProductoLN ObjetoProductoLN = new ProductoLN();
        ProductoNE ObjetoProductoNE = new ProductoNE();

        public Producto()
        {
            InitializeComponent();
        }

        private void buttonAgregarDetalle_Click(object sender, EventArgs e)
        {
            Detalle detalle = new Detalle();
            detalle.ShowDialog();
        }

        private void buttonAgregarRubro_Click(object sender, EventArgs e)
        {
            Rubro rubro = new Rubro();
            rubro.ShowDialog();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {


            ObjetoProductoNE.IDProducto = Convert.ToInt32(textBoxIdProducto.Text);
            ObjetoProductoNE.Rubro = comboBoxRubro.Text;
            ObjetoProductoNE.Tipo = comboBoxTipodesc.Text;
            ObjetoProductoNE.Marca = comboBoxMarcadesc.Text;
            ObjetoProductoNE.Detalle = comboBoxDetalledesc.Text;
            ObjetoProductoNE.Sabor = comboBoxSabordesc.Text;
            ObjetoProductoNE.Envase = comboBoxEnvasedesc.Text;
            ObjetoProductoNE.Tamaño = textBoxTamaño.Text;
            ObjetoProductoNE.PrecioCosto = Convert.ToDouble(textBoxPrecioCosto.Text);
            ObjetoProductoNE.PrecioVenta = Convert.ToDouble(textBoxPrecioVenta.Text);
            ObjetoProductoNE.StockMinimo = Convert.ToInt32(textBoxStockMinimo.Text);
            if (radioButtonCubicos.Checked == true)
            {
                ObjetoProductoNE.Medicion = "CC";
            }
            else
            {
                if (radioButtonGramos.Checked == true)
                    ObjetoProductoNE.Medicion = "G";
                else
                    if (radioButtonKg.Checked == true)
                        ObjetoProductoNE.Medicion = "KG";
                    else
                        ObjetoProductoNE.Medicion = "U";
            }

            DialogResult r = MessageBox.Show("¿Desea modificar el producto?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                if (textBoxIdProducto.Text != "" && comboBoxRubro.Text != "" && comboBoxTipodesc.Text != "" && comboBoxMarcadesc.Text != "" && comboBoxDetalledesc.Text != "" && comboBoxSabordesc.Text != "" && comboBoxEnvasedesc.Text != "" && comboBoxMarcadesc.Text != "" && textBoxTamaño.Text != "" && textBoxPrecioCosto.Text != "" && textBoxPrecioVenta.Text != "" && textBoxStockMinimo.Text != "")
                {
                    ObjetoProductoLN.ModificarProducto(ObjetoProductoNE);

                    MessageBox.Show("Producto modificado con éxito");
                    limpiarCampos();
                    dataGridViewProducto.DataSource = ObjetoProductoLN.MostrarProducto();
                }
            }
            else
            {
                if (r == DialogResult.No)
                {
                    //   Close();
                }

                else
                {
                    MessageBox.Show("Existen campos vacios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
        }

        private void buttonAgregarTipo_Click(object sender, EventArgs e)
        {
            Tipo tipo = new Tipo();
            tipo.ShowDialog();
        }

        private void buttonAgregarMarca_Click(object sender, EventArgs e)
        {
            Marca marca = new Marca();
            marca.ShowDialog();
        }

        private void buttonAgregarSabor_Click(object sender, EventArgs e)
        {
            Sabor sabor = new Sabor();
            sabor.ShowDialog();
        }

        private void buttonAgregarEnvase_Click(object sender, EventArgs e)
        {
            Envase envase = new Envase();
            envase.ShowDialog();
        }

        private void buttonLimpiarCampos_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        public void limpiarCampos()
        {
            comboBoxRubro.Text = string.Empty;
            textBoxIdProducto.Text = string.Empty;
            comboBoxDetalledesc.Text = string.Empty;
            comboBoxEnvasedesc.Text = string.Empty;
            comboBoxMarcadesc.Text = string.Empty;
            comboBoxSabordesc.Text = string.Empty;
            comboBoxTipodesc.Text = string.Empty;
            radioButtonCubicos.Checked = false;
            radioButtonGramos.Checked = false;
            radioButtonUnidad.Checked = false;
            radioButtonKg.Checked = false;
            textBoxPrecioCosto.Text = string.Empty;
            textBoxPrecioVenta.Text = string.Empty;
            textBoxStockMinimo.Text = string.Empty;
            textBoxTamaño.Text = string.Empty;
        }

        private void radioButtonKg_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void ValidarCodigo(Object o, KeyPressEventArgs e)
        {
            if (Char.IsPunctuation(e.KeyChar) || Char.IsNumber(e.KeyChar))//Si es número
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


        private void ValidarPrecioCosto(Object o, KeyPressEventArgs e)
        {
            if (Char.IsPunctuation(e.KeyChar) || Char.IsNumber(e.KeyChar))//Si es número
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

        private void ValidarPrecioVenta(Object o, KeyPressEventArgs e)
        {
            if (Char.IsPunctuation(e.KeyChar) || Char.IsNumber(e.KeyChar))//Si es número
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

        private void ValidarTamaño(Object o, KeyPressEventArgs e)
        {
            if (Char.IsPunctuation(e.KeyChar) || Char.IsNumber(e.KeyChar))//Si es número
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

        private void ValidarStockMinimo(Object o, KeyPressEventArgs e)
        {
            if (Char.IsPunctuation(e.KeyChar) || Char.IsNumber(e.KeyChar))//Si es número
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

        private void Producto_Load(object sender, EventArgs e)
        {
            dataGridViewProducto.DataSource = ObjetoProductoLN.MostrarProducto();
            textBoxIdProducto.KeyPress += new KeyPressEventHandler(ValidarCodigo);
            textBoxPrecioCosto.KeyPress += new KeyPressEventHandler(ValidarPrecioCosto);
            textBoxPrecioVenta.KeyPress += new KeyPressEventHandler(ValidarPrecioVenta);
            textBoxTamaño.KeyPress += new KeyPressEventHandler(ValidarTamaño);
            textBoxStockMinimo.KeyPress += new KeyPressEventHandler(ValidarStockMinimo);

            comboBoxRubro.DataSource = ObjetoProductoLN.LlenarComboRubro();
            comboBoxRubro.DisplayMember = "NombreRubro";

            comboBoxTipodesc.DataSource = ObjetoProductoLN.LlenarComboTipo();
            comboBoxTipodesc.DisplayMember = "NombreTipo";

            comboBoxMarcadesc.DataSource = ObjetoProductoLN.LlenarComboMarca();
            comboBoxMarcadesc.DisplayMember = "NombreMarca";

            comboBoxDetalledesc.DataSource = ObjetoProductoLN.LlenarComboDetalle();
            comboBoxDetalledesc.DisplayMember = "NombreDetalle";

            comboBoxSabordesc.DataSource = ObjetoProductoLN.LlenarComboSabor();
            comboBoxSabordesc.DisplayMember = "NombreSabor";

            comboBoxEnvasedesc.DataSource = ObjetoProductoLN.LlenarComboEnvase();
            comboBoxEnvasedesc.DisplayMember = "NombreEnvase";

        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {

            if (textBoxIdProducto.Text != "" && comboBoxRubro.Text != "" && comboBoxTipodesc.Text != "" && comboBoxMarcadesc.Text != "" && comboBoxDetalledesc.Text != "" && comboBoxSabordesc.Text != "" && comboBoxEnvasedesc.Text != "" && comboBoxMarcadesc.Text != "" && textBoxTamaño.Text != "" && textBoxPrecioCosto.Text != "" && textBoxPrecioVenta.Text != "" && textBoxStockMinimo.Text != "")
            {

                DialogResult r = MessageBox.Show("¿Desea guardar el producto?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (r == DialogResult.Yes)
                {

                    ObjetoProductoNE.IDProducto = Convert.ToInt32(textBoxIdProducto.Text);
                    ObjetoProductoNE.Rubro = comboBoxRubro.Text;
                    ObjetoProductoNE.Tipo = comboBoxTipodesc.Text;
                    ObjetoProductoNE.Marca = comboBoxMarcadesc.Text;
                    ObjetoProductoNE.Detalle = comboBoxDetalledesc.Text;
                    ObjetoProductoNE.Sabor = comboBoxSabordesc.Text;
                    ObjetoProductoNE.Envase = comboBoxEnvasedesc.Text;
                    ObjetoProductoNE.Tamaño = textBoxTamaño.Text;
                    ObjetoProductoNE.PrecioCosto = Convert.ToDouble(textBoxPrecioCosto.Text);
                    ObjetoProductoNE.PrecioVenta = Convert.ToDouble(textBoxPrecioVenta.Text);
                    ObjetoProductoNE.StockMinimo = Convert.ToInt32(textBoxStockMinimo.Text);
                    if (radioButtonCubicos.Checked == true)
                    {
                        ObjetoProductoNE.Medicion = "CC";
                    }
                    else
                    {
                        if (radioButtonGramos.Checked == true)
                            ObjetoProductoNE.Medicion = "G";
                        else
                            if (radioButtonKg.Checked == true)
                                ObjetoProductoNE.Medicion = "KG";
                            else
                                ObjetoProductoNE.Medicion = "U";
                    }




                    ObjetoProductoLN.AgregarProducto(ObjetoProductoNE);

                    MessageBox.Show("Producto guardado con éxito");
                    dataGridViewProducto.DataSource = ObjetoProductoLN.MostrarProducto();

                    limpiarCampos();
                }


                else if (r == DialogResult.No)
                {
                    // Close();
                }
            }
            else
            {
                MessageBox.Show("Existen campos vacíos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            }

        }
        private void buttonListar_Click(object sender, EventArgs e)
        {
        }

        private void dataGridViewProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxIdProducto.Text = dataGridViewProducto.Rows[e.RowIndex].Cells["IDProducto"].Value.ToString();
            comboBoxRubro.Text = dataGridViewProducto.Rows[e.RowIndex].Cells["Rubro"].Value.ToString();
            comboBoxTipodesc.Text = dataGridViewProducto.Rows[e.RowIndex].Cells["Tipo"].Value.ToString();
            comboBoxMarcadesc.Text = dataGridViewProducto.Rows[e.RowIndex].Cells["Marca"].Value.ToString();
            comboBoxDetalledesc.Text = dataGridViewProducto.Rows[e.RowIndex].Cells["Detalle"].Value.ToString();
            comboBoxSabordesc.Text = dataGridViewProducto.Rows[e.RowIndex].Cells["Sabor"].Value.ToString();
            comboBoxEnvasedesc.Text = dataGridViewProducto.Rows[e.RowIndex].Cells["Envase"].Value.ToString();
            //comboboxMediciondesc.Text = dataGridViewProducto.Rows[e.RowIndex].Cells["Medicion"].Value.ToString();
            textBoxTamaño.Text = dataGridViewProducto.Rows[e.RowIndex].Cells["Tamaño"].Value.ToString();
            textBoxPrecioCosto.Text = dataGridViewProducto.Rows[e.RowIndex].Cells["PrecioCosto"].Value.ToString();
            textBoxPrecioVenta.Text = dataGridViewProducto.Rows[e.RowIndex].Cells["PrecioVenta"].Value.ToString();
            textBoxStockMinimo.Text = dataGridViewProducto.Rows[e.RowIndex].Cells["StockMinimo"].Value.ToString();

            if (dataGridViewProducto.Rows[e.RowIndex].Cells["Medicion"].Value.ToString() == "G")
                radioButtonGramos.Checked = true;

            if (dataGridViewProducto.Rows[e.RowIndex].Cells["Medicion"].Value.ToString() == "KG")
                radioButtonKg.Checked = true;

            if (dataGridViewProducto.Rows[e.RowIndex].Cells["Medicion"].Value.ToString() == "CC")
                radioButtonCubicos.Checked = true;

            if (dataGridViewProducto.Rows[e.RowIndex].Cells["Medicion"].Value.ToString() == "U")
                radioButtonUnidad.Checked = true;


        }

        private void comboBoxTipodesc_TextChanged(object sender, EventArgs e)
        {
            labelDescripcionFinal.Text = comboBoxTipodesc.Text;
        }

        private void comboBoxMarcadesc_TextChanged(object sender, EventArgs e)
        {
            labelDescripcionFinal.Text = comboBoxTipodesc.Text + ", " + comboBoxMarcadesc.Text;
        }

        private void comboBoxDetalledesc_TextChanged(object sender, EventArgs e)
        {
            labelDescripcionFinal.Text = comboBoxTipodesc.Text + ", " + comboBoxMarcadesc.Text + ", " + comboBoxDetalledesc.Text;
        }

        private void comboBoxSabordesc_TextChanged(object sender, EventArgs e)
        {
            labelDescripcionFinal.Text = comboBoxTipodesc.Text + ", " + comboBoxMarcadesc.Text + ", " + comboBoxDetalledesc.Text + ", " + comboBoxSabordesc.Text;

        }

        private void comboBoxEnvasedesc_TextChanged(object sender, EventArgs e)
        {
            labelDescripcionFinal.Text = comboBoxTipodesc.Text + ", " + comboBoxMarcadesc.Text + ", " + comboBoxDetalledesc.Text + ", " + comboBoxSabordesc.Text + ", " + comboBoxEnvasedesc.Text;

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            {

                ObjetoProductoNE.IDProducto = Convert.ToInt32(textBoxIdProducto.Text);
                ObjetoProductoNE.Rubro = comboBoxRubro.Text;
                ObjetoProductoNE.Tipo = comboBoxTipodesc.Text;
                ObjetoProductoNE.Marca = comboBoxMarcadesc.Text;
                ObjetoProductoNE.Detalle = comboBoxDetalledesc.Text;
                ObjetoProductoNE.Sabor = comboBoxSabordesc.Text;
                ObjetoProductoNE.Envase = comboBoxEnvasedesc.Text;
                ObjetoProductoNE.Tamaño = textBoxTamaño.Text;
                ObjetoProductoNE.PrecioCosto = Convert.ToDouble(textBoxPrecioCosto.Text);
                ObjetoProductoNE.PrecioVenta = Convert.ToDouble(textBoxPrecioVenta.Text);
                ObjetoProductoNE.StockMinimo = Convert.ToInt32(textBoxStockMinimo.Text);
                if (radioButtonCubicos.Checked == true)
                {
                    ObjetoProductoNE.Medicion = "CC";
                }
                else
                {
                    if (radioButtonGramos.Checked == true)
                        ObjetoProductoNE.Medicion = "G";
                    else
                        if (radioButtonKg.Checked == true)
                            ObjetoProductoNE.Medicion = "KG";
                        else
                            ObjetoProductoNE.Medicion = "U";
                }

                if (textBoxIdProducto.Text != "" && comboBoxRubro.Text != "" && comboBoxTipodesc.Text != "" && comboBoxMarcadesc.Text != "" && comboBoxDetalledesc.Text != "" && comboBoxSabordesc.Text != "" && comboBoxEnvasedesc.Text != "" && comboBoxMarcadesc.Text != "" && textBoxTamaño.Text != "" && textBoxPrecioCosto.Text != "" && textBoxPrecioVenta.Text != "" && textBoxStockMinimo.Text != "")
                {

                    DialogResult r = MessageBox.Show("¿Desea eliminar el producto?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (r == DialogResult.Yes)
                    {
                        ObjetoProductoLN.EliminarProducto(ObjetoProductoNE);
                        dataGridViewProducto.DataSource = ObjetoProductoLN.MostrarProducto();
                        MessageBox.Show("Producto eliminado con éxito");

                    }


                    else if (r == DialogResult.No)
                    {
                        // Close();
                    }
                }
                else
                {
                    MessageBox.Show("Existen campos vacíos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                }

            }
        }

        private void comboBoxTipodesc_Click(object sender, EventArgs e)
        {
            comboBoxTipodesc.Refresh();
            GroupBox2.Refresh();
        }


    }
    }
