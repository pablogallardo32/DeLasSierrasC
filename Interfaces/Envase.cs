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
            textBoxIDEnvase.Text = string.Empty;
            textBoxNombreEnvase.Text = string.Empty;
        }

        private void Envase_Load(object sender, EventArgs e)
        {
            textBoxIDEnvase.KeyPress += new KeyPressEventHandler(ValidarIDEnvase);

            dataGridViewEnvase.DataSource = ObjetoEnvaseLN.MostrarEnvase();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {

            ObjetoEnvaseNE.IDEnvase = Convert.ToInt32(textBoxIDEnvase.Text);
            ObjetoEnvaseNE.NombreEnvase = textBoxNombreEnvase.Text;

            DialogResult r = MessageBox.Show("¿Desea guardar el envase?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                if (textBoxIDEnvase.Text != "" && textBoxNombreEnvase.Text != "")
                {
                    ObjetoEnvaseLN.AgregarEnvase(ObjetoEnvaseNE);

                    MessageBox.Show("Envase guardado con éxito");
                    dataGridViewEnvase.DataSource = ObjetoEnvaseLN.MostrarEnvase();
                    textBoxNombreEnvase.Text = string.Empty;
                    textBoxIDEnvase.Text = string.Empty;
                }
            }
            else if (r == DialogResult.No)
            {
                // Close();
            }

            else
            {
                MessageBox.Show("Ingrese el ID y el nombre del envase", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            }
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            ObjetoEnvaseNE.IDEnvase = Convert.ToInt32(textBoxIDEnvase.Text);
            ObjetoEnvaseNE.NombreEnvase = textBoxNombreEnvase.Text;

            DialogResult r = MessageBox.Show("¿Desea modificar el envase?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                if (textBoxIDEnvase.Text != "" && textBoxNombreEnvase.Text != "")
                {
                    ObjetoEnvaseLN.ModificarEnvase(ObjetoEnvaseNE);

                    MessageBox.Show("Envase modificado con éxito");
                    dataGridViewEnvase.DataSource = ObjetoEnvaseLN.MostrarEnvase();

                    textBoxIDEnvase.Text = string.Empty;
                    textBoxNombreEnvase.Text = string.Empty;
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
            ObjetoEnvaseNE.IDEnvase = Convert.ToInt32(textBoxIDEnvase.Text);
            ObjetoEnvaseNE.NombreEnvase = textBoxNombreEnvase.Text;

            if (textBoxIDEnvase.Text != "")
            {
                ObjetoEnvaseLN.EliminarEnvase(ObjetoEnvaseNE);
                dataGridViewEnvase.DataSource = ObjetoEnvaseLN.MostrarEnvase();
                MessageBox.Show("Envase eliminado con éxito");

                 textBoxIDEnvase.Text = string.Empty;
                    textBoxNombreEnvase.Text = string.Empty;

            }
            else
            {
                MessageBox.Show("Seleccione un envase");
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
        }
    }

