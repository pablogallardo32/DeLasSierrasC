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
    
    public partial class Detalle : Form
    {
        DetalleNE ObjetoDetalleNE = new DetalleNE();
        DetalleLN ObjetoDetalleLN = new DetalleLN();

        public Detalle()
        {
            InitializeComponent();
        }

        private void Detalle_Load(object sender, EventArgs e)
        {

         
           textBoxIDDetalle.KeyPress += new KeyPressEventHandler(ValidarIDDetalle);

            dataGridViewDetalle.DataSource = ObjetoDetalleLN.MostrarDetalle();

        }

        public void dataGridViewDetalle_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            textBoxIDDetalle.Text = dataGridViewDetalle.Rows[e.RowIndex].Cells["IDDetalle"].Value.ToString();
            textBoxNombreDetalle.Text = dataGridViewDetalle.Rows[e.RowIndex].Cells["NombreDetalle"].Value.ToString();
        }

        private void ValidarIDDetalle(Object o, KeyPressEventArgs e)
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

        private void buttonSalir_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonEliminar_Click_1(object sender, EventArgs e)
        {
            ObjetoDetalleNE.IDDetalle = Convert.ToInt32(textBoxIDDetalle.Text);
            ObjetoDetalleNE.NombreDetalle = textBoxNombreDetalle.Text;

            if (textBoxIDDetalle.Text != "")
            {
                ObjetoDetalleLN.EliminarDetalle(ObjetoDetalleNE);
                dataGridViewDetalle.DataSource = ObjetoDetalleLN.MostrarDetalle();
                MessageBox.Show("Detalle eliminado con éxito");

            }
            else
            {
                MessageBox.Show("Seleccione un detalle");
            }
        }

        private void buttonLimpiar_Click_1(object sender, EventArgs e)
        {
            textBoxIDDetalle.Text = string.Empty;
            textBoxNombreDetalle.Text = string.Empty;
        }

        private void buttonModificar_Click_1(object sender, EventArgs e)
        {
            ObjetoDetalleNE.IDDetalle = Convert.ToInt32(textBoxIDDetalle.Text);
            ObjetoDetalleNE.NombreDetalle = textBoxNombreDetalle.Text;

            DialogResult r = MessageBox.Show("¿Desea guardar el detalle?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                if (textBoxIDDetalle.Text != "" && textBoxNombreDetalle.Text != "")
                {
                    ObjetoDetalleLN.ModificarDetalle(ObjetoDetalleNE);

                    MessageBox.Show("Detalle modificado con éxito");
                    dataGridViewDetalle.DataSource = ObjetoDetalleLN.MostrarDetalle();
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
                    MessageBox.Show("Ingrese el ID y el nombre del detalle", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
        }

        private void buttonGuardar_Click_1(object sender, EventArgs e)
        {
            ObjetoDetalleNE.IDDetalle = Convert.ToInt32(textBoxIDDetalle.Text);
            ObjetoDetalleNE.NombreDetalle = textBoxNombreDetalle.Text;

            DialogResult r = MessageBox.Show("¿Desea guardar el detalle?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                if (textBoxIDDetalle.Text != "" && textBoxNombreDetalle.Text != "")
                {
                    ObjetoDetalleLN.AgregarDetalle(ObjetoDetalleNE);

                    MessageBox.Show("Detalle guardado con éxito");
                    dataGridViewDetalle.DataSource = ObjetoDetalleLN.MostrarDetalle();
                    textBoxNombreDetalle.Text = string.Empty;
                    textBoxIDDetalle.Text = string.Empty;
                }
            }
            else if (r == DialogResult.No)
            {
                // Close();
            }

            else
            {
                MessageBox.Show("Ingrese el ID y el nombre del detalle", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            }
        }
        }
    }

