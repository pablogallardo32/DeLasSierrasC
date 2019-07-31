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
    public partial class Tipo : Form
    {
        TipoLN ObjetoTipoLN = new TipoLN();
        TipoNE ObjetoTipoNE = new TipoNE();

        public Tipo()
        {

            InitializeComponent();
        }

       
        private void Tipo_Load(object sender, EventArgs e)
        {

            textBoxIDTipo.KeyPress += new KeyPressEventHandler(ValidarIDTipo);

            dataGridViewTipo.DataSource = ObjetoTipoLN.MostrarTipo();

        }

        private void ValidarIDTipo(Object o, KeyPressEventArgs e)
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

        private void buttonGuardar_Click_1(object sender, EventArgs e)
        {

            ObjetoTipoNE.IDTipo = Convert.ToInt32(textBoxIDTipo.Text);
            ObjetoTipoNE.NombreTipo = textBoxNombreTipo.Text;

            DialogResult r = MessageBox.Show("¿Desea guardar el tipo?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                if (textBoxIDTipo.Text != "" && textBoxNombreTipo.Text != "")
                {
                    ObjetoTipoLN.AgregarTipo(ObjetoTipoNE);

                    MessageBox.Show("Tipo guardado con éxito");
                    dataGridViewTipo.DataSource = ObjetoTipoLN.MostrarTipo();
                    textBoxNombreTipo.Text = string.Empty;
                    textBoxIDTipo.Text = string.Empty;
                }
            }
        }

        private void buttonModificar_Click_1(object sender, EventArgs e)
        {
             ObjetoTipoNE.IDTipo = Convert.ToInt32(textBoxIDTipo.Text);
            ObjetoTipoNE.NombreTipo = textBoxNombreTipo.Text;

            DialogResult r = MessageBox.Show("¿Desea modificar el tipo?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                if (textBoxIDTipo.Text != "" && textBoxNombreTipo.Text != "")
                {
                    ObjetoTipoLN.ModificarTipo(ObjetoTipoNE);

                    MessageBox.Show("Tipo modificado con éxito");
                    dataGridViewTipo.DataSource = ObjetoTipoLN.MostrarTipo();

                    textBoxIDTipo.Text = string.Empty;
                    textBoxNombreTipo.Text = string.Empty;
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
                    MessageBox.Show("Ingrese el ID y el nombre del tipo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            ObjetoTipoNE.IDTipo = Convert.ToInt32(textBoxIDTipo.Text);
            ObjetoTipoNE.NombreTipo = textBoxNombreTipo.Text;

            if (textBoxIDTipo.Text != "")
            {
                ObjetoTipoLN.EliminarTipo(ObjetoTipoNE);
                dataGridViewTipo.DataSource = ObjetoTipoLN.MostrarTipo();
                MessageBox.Show("Tipo eliminado con éxito");

                textBoxIDTipo.Text = string.Empty;
                textBoxNombreTipo.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Seleccione un tipo");
            }
        }

        private void buttonLimpiar_Click_1(object sender, EventArgs e)
        {
            textBoxIDTipo.Text = string.Empty;
            textBoxNombreTipo.Text = string.Empty;
        }

        private void buttonSalir_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridViewTipo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxIDTipo.Text = dataGridViewTipo.Rows[e.RowIndex].Cells["IDTipo"].Value.ToString();
            textBoxNombreTipo.Text = dataGridViewTipo.Rows[e.RowIndex].Cells["NombreTipo"].Value.ToString();
        }

        }
    }
