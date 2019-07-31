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
    public partial class Rubro : Form
    {
        RubroLN ObjetoRubroLN = new RubroLN();
        RubroNE ObjetoRubroNE = new RubroNE();

        public Rubro()
        {

          

            InitializeComponent();
        }

        private void ButtonSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxIDRubro.Text = string.Empty;
            textBoxNombreRubro.Text = string.Empty;
        }

        private void ButtonGuardar_Click(object sender, EventArgs e)
        {

            ObjetoRubroNE.IDRubro = Convert.ToInt32(textBoxIDRubro.Text);
            ObjetoRubroNE.NombreRubro = textBoxNombreRubro.Text;

            DialogResult r = MessageBox.Show("¿Desea guardar el rubro?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                if (textBoxIDRubro.Text != "" && textBoxNombreRubro.Text != "")
                {
                    ObjetoRubroLN.AgregarRubro(ObjetoRubroNE);

                    MessageBox.Show("Rubro guardado con éxito");
                    dataGridViewRubro.DataSource = ObjetoRubroLN.MostrarRubro();
                    textBoxNombreRubro.Text = string.Empty;
                    textBoxIDRubro.Text = string.Empty;
                }
            }
            else if (r == DialogResult.No)
            {
                // Close();
            }

            else
            {
                MessageBox.Show("Ingrese el ID y el nombre del rubro", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            }
        }
        

        private void Rubro_Load(object sender, EventArgs e)
        {

         
           
            textBoxIDRubro.KeyPress += new KeyPressEventHandler(ValidarIDRubro);
          
            dataGridViewRubro.DataSource = ObjetoRubroLN.MostrarRubro();

        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            ObjetoRubroNE.IDRubro = Convert.ToInt32(textBoxIDRubro.Text);
            ObjetoRubroNE.NombreRubro = textBoxNombreRubro.Text;

            DialogResult r = MessageBox.Show("¿Desea modificar el rubro?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                if (textBoxIDRubro.Text != "" && textBoxNombreRubro.Text != "")
                {
                    ObjetoRubroLN.ModificarRubro(ObjetoRubroNE);

                    MessageBox.Show("Rubro modificado con éxito");
                    dataGridViewRubro.DataSource = ObjetoRubroLN.MostrarRubro();
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
                    MessageBox.Show("Ingrese el ID y el nombre del rubro", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
        }

        public void dataGridViewRubro2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxIDRubro.Text = dataGridViewRubro.Rows[e.RowIndex].Cells["IDRubro"].Value.ToString();
            textBoxNombreRubro.Text = dataGridViewRubro.Rows[e.RowIndex].Cells["NombreRubro"].Value.ToString();



        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            ObjetoRubroNE.IDRubro = Convert.ToInt32(textBoxIDRubro.Text);
            ObjetoRubroNE.NombreRubro = textBoxNombreRubro.Text;

            if (textBoxIDRubro.Text != "")
            {
                ObjetoRubroLN.EliminarRubro(ObjetoRubroNE);
                dataGridViewRubro.DataSource = ObjetoRubroLN.MostrarRubro();
                MessageBox.Show("Rubro eliminado con éxito");

            }
            else
            {
                MessageBox.Show("Seleccione un rubro");
            }
        }


        private void ValidarIDRubro(Object o, KeyPressEventArgs e)
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

        private void textBoxNombreRubro_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
