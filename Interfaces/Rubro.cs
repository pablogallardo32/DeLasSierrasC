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
            textBoxNombreRubro.Text = string.Empty;
            buttonGuardar.Enabled = true;

            comboBoxIDRubro.DataSource = ObjetoRubroLN.TraerUltimoIDRubro();
            comboBoxIDRubro.DisplayMember = "IDRubro";
        }

        private void ButtonGuardar_Click(object sender, EventArgs e)
        {

            ObjetoRubroNE.IDRubro = Convert.ToInt32(comboBoxIDRubro.Text);
            ObjetoRubroNE.NombreRubro = textBoxNombreRubro.Text;

            DialogResult r = MessageBox.Show("¿Desea guardar el rubro?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                if (comboBoxIDRubro.Text != "" && textBoxNombreRubro.Text != "")
                {
                    ObjetoRubroLN.AgregarRubro(ObjetoRubroNE);

                    MessageBox.Show("Rubro guardado con éxito");
                    dataGridViewRubro.DataSource = ObjetoRubroLN.MostrarRubro();
                    textBoxNombreRubro.Text = string.Empty;
                    comboBoxIDRubro.Text = string.Empty;

                    comboBoxIDRubro.DataSource = ObjetoRubroLN.TraerUltimoIDRubro();
                    comboBoxIDRubro.DisplayMember = "IDRubro";
                }
                else
                    MessageBox.Show("Ingrese el nombre del rubro", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else if (r == DialogResult.No)
            {
            } 
        }
        

        private void Rubro_Load(object sender, EventArgs e)
        {


            comboBoxIDRubro.KeyPress += new KeyPressEventHandler(ValidarIDRubro);
          
            dataGridViewRubro.DataSource = ObjetoRubroLN.MostrarRubro();

            comboBoxIDRubro.DataSource = ObjetoRubroLN.TraerUltimoIDRubro();
            comboBoxIDRubro.DisplayMember = "IDRubro";

            buttonModificar.Enabled = false;
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            ObjetoRubroNE.IDRubro = Convert.ToInt32(comboBoxIDRubro.Text);
            ObjetoRubroNE.NombreRubro = textBoxNombreRubro.Text;

            DialogResult r = MessageBox.Show("¿Desea modificar el rubro?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                if (comboBoxIDRubro.Text != "" && textBoxNombreRubro.Text != "")
                {
                    ObjetoRubroLN.ModificarRubro(ObjetoRubroNE);

                    MessageBox.Show("Rubro modificado con éxito");
                    dataGridViewRubro.DataSource = ObjetoRubroLN.MostrarRubro();

                    comboBoxIDRubro.DataSource = ObjetoRubroLN.TraerUltimoIDRubro();
                    comboBoxIDRubro.DisplayMember = "IDRubro";
                }
            }
            else
            {
                if (r == DialogResult.No)
                {
                }

                else
                {
                    MessageBox.Show("Ingrese nombre del rubro", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
        }

        public void dataGridViewRubro2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBoxIDRubro.Text = dataGridViewRubro.Rows[e.RowIndex].Cells["IDRubro"].Value.ToString();
            textBoxNombreRubro.Text = dataGridViewRubro.Rows[e.RowIndex].Cells["NombreRubro"].Value.ToString();

            buttonGuardar.Enabled = false;
            buttonModificar.Enabled = true;

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
             DialogResult r = MessageBox.Show("¿Desea eliminar el rubro?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                ObjetoRubroNE.IDRubro = Convert.ToInt32(comboBoxIDRubro.Text);
            ObjetoRubroNE.NombreRubro = textBoxNombreRubro.Text;
                    if (comboBoxIDRubro.Text != "")
            {
                ObjetoRubroLN.EliminarRubro(ObjetoRubroNE);
                dataGridViewRubro.DataSource = ObjetoRubroLN.MostrarRubro();
                MessageBox.Show("Rubro eliminado con éxito");

                comboBoxIDRubro.DataSource = ObjetoRubroLN.TraerUltimoIDRubro();
                comboBoxIDRubro.DisplayMember = "IDRubro";
            }
                 else
                
                    MessageBox.Show("Seleccione rubro", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (r == DialogResult.No)
                {
                   
                }

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
