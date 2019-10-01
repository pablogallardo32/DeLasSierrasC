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
    public partial class Envase : Form
    {
     EnvaseLN  ObjetoEnvaseLN = new EnvaseLN();
        EnvaseNE ObjetoEnvaseNE = new EnvaseNE();


        public Envase()
        {
            InitializeComponent();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
          //  comboBoxIDEnvase.Text = string.Empty;
            textBoxNombreEnvase.Text = string.Empty;
            buttonGuardar.Enabled = true;

            comboBoxIDEnvase.DataSource = ObjetoEnvaseLN.TraerUltimoIDEnvase();
            comboBoxIDEnvase.DisplayMember = "IDEnvase";
         //   comboBoxIDEnvase.DataSource = ObjetoEnvaseLN.TraerUltimoIDEnvase();
          //  comboBoxIDEnvase.DisplayMember = "IDEnvase";
        }

        private void Envase_Load(object sender, EventArgs e)
        {

            comboBoxIDEnvase.DataSource = ObjetoEnvaseLN.TraerUltimoIDEnvase();
            comboBoxIDEnvase.DisplayMember = "IDEnvase";

            comboBoxIDEnvase.KeyPress += new KeyPressEventHandler(ValidarIDEnvase);

            dataGridViewEnvase.DataSource = ObjetoEnvaseLN.MostrarEnvase();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {

            ObjetoEnvaseNE.IDEnvase = Convert.ToInt32(comboBoxIDEnvase.Text);
            ObjetoEnvaseNE.NombreEnvase = textBoxNombreEnvase.Text;

            DialogResult r = MessageBox.Show("¿Desea guardar el envase?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                if (comboBoxIDEnvase.Text != "" && textBoxNombreEnvase.Text != "")
                {
                    ObjetoEnvaseLN.AgregarEnvase(ObjetoEnvaseNE);

                    MessageBox.Show("Envase guardado con éxito");
                    dataGridViewEnvase.DataSource = ObjetoEnvaseLN.MostrarEnvase();
                    textBoxNombreEnvase.Text = string.Empty;
                    comboBoxIDEnvase.Text = string.Empty;

                    comboBoxIDEnvase.DataSource = ObjetoEnvaseLN.TraerUltimoIDEnvase();
                    comboBoxIDEnvase.DisplayMember = "IDEnvase";
                }
                else
                    MessageBox.Show("Ingrese el nombre del envase", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else if (r == DialogResult.No)
            {
                // Close();
            }

        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            ObjetoEnvaseNE.IDEnvase = Convert.ToInt32(comboBoxIDEnvase.Text);
            ObjetoEnvaseNE.NombreEnvase = textBoxNombreEnvase.Text;

            DialogResult r = MessageBox.Show("¿Desea modificar el envase?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                if (comboBoxIDEnvase.Text != "" && textBoxNombreEnvase.Text != "")
                {
                    ObjetoEnvaseLN.ModificarEnvase(ObjetoEnvaseNE);

                    MessageBox.Show("Envase modificado con éxito");
                    dataGridViewEnvase.DataSource = ObjetoEnvaseLN.MostrarEnvase();

                    comboBoxIDEnvase.Text = string.Empty;
                    textBoxNombreEnvase.Text = string.Empty;

                    comboBoxIDEnvase.DataSource = ObjetoEnvaseLN.TraerUltimoIDEnvase();
                    comboBoxIDEnvase.DisplayMember = "IDEnvase";
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
                    MessageBox.Show("Ingrese el ID y el nombre del envase", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Desea eliminar el envase?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                if ( textBoxNombreEnvase.Text != "")
                {
                  ObjetoEnvaseNE.IDEnvase = Convert.ToInt32(comboBoxIDEnvase.Text);
                  ObjetoEnvaseNE.NombreEnvase = textBoxNombreEnvase.Text;

                  ObjetoEnvaseLN.EliminarEnvase(ObjetoEnvaseNE);
                  dataGridViewEnvase.DataSource = ObjetoEnvaseLN.MostrarEnvase();
                  MessageBox.Show("Envase eliminado con éxito");

                  comboBoxIDEnvase.Text = string.Empty;
                  textBoxNombreEnvase.Text = string.Empty;

                  comboBoxIDEnvase.DataSource = ObjetoEnvaseLN.TraerUltimoIDEnvase();
                  comboBoxIDEnvase.DisplayMember = "IDEnvase";
                }
                 else
                
                    MessageBox.Show("Seleccione envase", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (r == DialogResult.No)
                {
                    //   Close();
                }

                }
            }


        private void ValidarIDEnvase(Object o, KeyPressEventArgs e)
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

        private void dataGridViewEnvase_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBoxIDEnvase.Text = dataGridViewEnvase.Rows[e.RowIndex].Cells["IDEnvase"].Value.ToString();
            textBoxNombreEnvase.Text = dataGridViewEnvase.Rows[e.RowIndex].Cells["NombreEnvase"].Value.ToString();

            buttonGuardar.Enabled = false;

        }
        }
    }

