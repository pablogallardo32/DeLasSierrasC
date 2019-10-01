using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using CapaLN;
using CapaNE;

namespace Interfaces
{
    public partial class Marca : Form
    {

        MarcaLN ObjetoMarcaLN = new MarcaLN();
        MarcaNE ObjetoMarcaNE = new MarcaNE();

        public Marca()
        {
            InitializeComponent();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
           
            textBoxNombreMarca.Text = string.Empty;
            buttonGuardar.Enabled = true;

            comboBoxIDMarca.DataSource = ObjetoMarcaLN.TraerUltimoIDMarca();
            comboBoxIDMarca.DisplayMember = "IDMarca";

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            ObjetoMarcaNE.IDMarca = Convert.ToInt32(comboBoxIDMarca.Text);
            ObjetoMarcaNE.NombreMarca = textBoxNombreMarca.Text;

            DialogResult r = MessageBox.Show("¿Desea guardar la marca?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                if (comboBoxIDMarca.Text != "" && textBoxNombreMarca.Text != "")
                {
                    ObjetoMarcaLN.AgregarMarca(ObjetoMarcaNE);

                    MessageBox.Show("Marca guardada con éxito");
                    dataGridViewMarca.DataSource = ObjetoMarcaLN.MostrarMarca();
                    textBoxNombreMarca.Text = string.Empty;
                    comboBoxIDMarca.Text = string.Empty;

                    comboBoxIDMarca.DataSource = ObjetoMarcaLN.TraerUltimoIDMarca();
                    comboBoxIDMarca.DisplayMember = "IDMarca";
                }
                else
                    MessageBox.Show("Ingrese el nombre de la marca", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else if (r == DialogResult.No)
            {
                // Close();
            }

        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            ObjetoMarcaNE.IDMarca = Convert.ToInt32(comboBoxIDMarca.Text);
            ObjetoMarcaNE.NombreMarca = textBoxNombreMarca.Text;

            DialogResult r = MessageBox.Show("¿Desea modificar la marca?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                if (comboBoxIDMarca.Text != "" && textBoxNombreMarca.Text != "")
                {
                    ObjetoMarcaLN.ModificarMarca(ObjetoMarcaNE);

                    MessageBox.Show("Marca modificada con éxito");
                    dataGridViewMarca.DataSource = ObjetoMarcaLN.MostrarMarca();
                    textBoxNombreMarca.Text = string.Empty;
                    comboBoxIDMarca.Text = string.Empty;

                    comboBoxIDMarca.DataSource = ObjetoMarcaLN.TraerUltimoIDMarca();
                    comboBoxIDMarca.DisplayMember = "IDMarca";
                }
            }
            else
            {
                if (r == DialogResult.No)
                {
                    //   Close();
                }
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
             DialogResult r = MessageBox.Show("¿Desea eliminar la marca?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                if ( textBoxNombreMarca.Text != "")
                {

                ObjetoMarcaNE.IDMarca = Convert.ToInt32(comboBoxIDMarca.Text);
                ObjetoMarcaNE.NombreMarca = textBoxNombreMarca.Text;

                ObjetoMarcaLN.EliminarMarca(ObjetoMarcaNE);
                dataGridViewMarca.DataSource = ObjetoMarcaLN.MostrarMarca();
                MessageBox.Show("Marca eliminada con éxito");

                textBoxNombreMarca.Text = string.Empty;
                comboBoxIDMarca.Text = string.Empty;

                comboBoxIDMarca.DataSource = ObjetoMarcaLN.TraerUltimoIDMarca();
                comboBoxIDMarca.DisplayMember = "IDMarca";
                }
                 else
                
                    MessageBox.Show("Seleccione marca", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (r == DialogResult.No)
                {
                    //   Close();
                }

                }
            }


        private void Marca_Load(object sender, EventArgs e)
        {
            comboBoxIDMarca.DataSource = ObjetoMarcaLN.TraerUltimoIDMarca();
            comboBoxIDMarca.DisplayMember = "IDMarca";

            comboBoxIDMarca.KeyPress += new KeyPressEventHandler(ValidarIDMarca);

            dataGridViewMarca.DataSource = ObjetoMarcaLN.MostrarMarca();
        }

        private void dataGridViewMarca_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }


        private void ValidarIDMarca(Object o, KeyPressEventArgs e)
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

        private void dataGridViewMarca_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBoxIDMarca.Text = dataGridViewMarca.Rows[e.RowIndex].Cells["IDMarca"].Value.ToString();
            textBoxNombreMarca.Text = dataGridViewMarca.Rows[e.RowIndex].Cells["NombreMarca"].Value.ToString();

            buttonGuardar.Enabled = false;

        }

        }
    }



