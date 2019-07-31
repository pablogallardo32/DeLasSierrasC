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
    public partial class Sabor : Form
    {
        SaborLN ObjetoSaborLN = new SaborLN();
        SaborNE ObjetoSaborNE= new SaborNE();
        public Sabor()
        {
            InitializeComponent();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            ObjetoSaborNE.IDSabor = Convert.ToInt32(textBoxIDSabor.Text);
            ObjetoSaborNE.NombreSabor = textBoxNombreSabor.Text;

            DialogResult r = MessageBox.Show("¿Desea guardar el sabor?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                if (textBoxIDSabor.Text != "" && textBoxNombreSabor.Text != "")
                {
                    ObjetoSaborLN.AgregarSabor(ObjetoSaborNE);

                    MessageBox.Show("Sabor guardado con éxito");
                    dataGridViewSabor.DataSource = ObjetoSaborLN.MostrarSabor();
                    textBoxNombreSabor.Text = string.Empty;
                    textBoxIDSabor.Text = string.Empty;
                }
            }
            else if (r == DialogResult.No)
            {
                // Close();
            }

            else
            {
                MessageBox.Show("Ingrese el ID y el nombre del sabor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            }
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
        ObjetoSaborNE.IDSabor = Convert.ToInt32(textBoxIDSabor.Text);
            ObjetoSaborNE.NombreSabor = textBoxNombreSabor.Text;

            DialogResult r = MessageBox.Show("¿Desea modificar el sabor?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                if (textBoxIDSabor.Text != "" && textBoxNombreSabor.Text != "")
                {
                    ObjetoSaborLN.ModificarSabor(ObjetoSaborNE);

                    MessageBox.Show("Sabor modificado con éxito");

                    textBoxIDSabor.Text = string.Empty;
                    textBoxNombreSabor.Text = string.Empty;
                    dataGridViewSabor.DataSource = ObjetoSaborLN.MostrarSabor();
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
                    MessageBox.Show("Ingrese el ID y el nombre del sabor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
             ObjetoSaborNE.IDSabor = Convert.ToInt32(textBoxIDSabor.Text);
            ObjetoSaborNE.NombreSabor = textBoxNombreSabor.Text;

            if (textBoxIDSabor.Text != "")
            {
                ObjetoSaborLN.EliminarSabor(ObjetoSaborNE);
                dataGridViewSabor.DataSource = ObjetoSaborLN.MostrarSabor();
                MessageBox.Show("Sabor eliminado con éxito");

                textBoxIDSabor.Text = string.Empty;
                textBoxNombreSabor.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Seleccione un sabor");
            }
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxIDSabor.Text = string.Empty;
            textBoxNombreSabor.Text = string.Empty;
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void ValidarIDSabor(Object o, KeyPressEventArgs e)
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

        private void dataGridViewSabor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxIDSabor.Text = dataGridViewSabor.Rows[e.RowIndex].Cells["IDSabor"].Value.ToString();
            textBoxNombreSabor.Text = dataGridViewSabor.Rows[e.RowIndex].Cells["NombreSabor"].Value.ToString();
        }

        private void Sabor_Load(object sender, EventArgs e)
        {
            textBoxIDSabor.KeyPress += new KeyPressEventHandler(ValidarIDSabor);

            dataGridViewSabor.DataSource = ObjetoSaborLN.MostrarSabor();

        }
        }      
    }
        
    
