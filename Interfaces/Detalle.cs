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
            comboBoxIDDetalle.DataSource =  ObjetoDetalleLN.TraerUltimoIDDetalle();
            comboBoxIDDetalle.DisplayMember = "IDDetalle";

            comboBoxIDDetalle.KeyPress += new KeyPressEventHandler(ValidarIDDetalle);

            dataGridViewDetalle.DataSource = ObjetoDetalleLN.MostrarDetalle();

            buttonModificar.Enabled = false;
        }

        public void dataGridViewDetalle_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            comboBoxIDDetalle.Text = dataGridViewDetalle.Rows[e.RowIndex].Cells["IDDetalle"].Value.ToString();
            textBoxNombreDetalle.Text = dataGridViewDetalle.Rows[e.RowIndex].Cells["NombreDetalle"].Value.ToString();

            buttonModificar.Enabled = true;

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

             DialogResult r = MessageBox.Show("¿Desea eliminar el detalle?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                if (comboBoxIDDetalle.Text != "" && textBoxNombreDetalle.Text != "")
                {

                    ObjetoDetalleNE.IDDetalle = Convert.ToInt32(comboBoxIDDetalle.Text);
                    ObjetoDetalleNE.NombreDetalle = textBoxNombreDetalle.Text;

                      ObjetoDetalleLN.EliminarDetalle(ObjetoDetalleNE);
                      dataGridViewDetalle.DataSource = ObjetoDetalleLN.MostrarDetalle();
                      MessageBox.Show("Detalle eliminado con éxito");

                    comboBoxIDDetalle.Text = string.Empty;
                    textBoxNombreDetalle.Text = string.Empty;

                    comboBoxIDDetalle.DataSource = ObjetoDetalleLN.TraerUltimoIDDetalle();
                    comboBoxIDDetalle.DisplayMember = "IDDetalle";
                }
                 else
                
                    MessageBox.Show("Seleccione detalle", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (r == DialogResult.No)
                {
                }

                }
            }


        private void buttonLimpiar_Click_1(object sender, EventArgs e)
        {
            textBoxNombreDetalle.Text = string.Empty;
            buttonGuardar.Enabled = true;

            comboBoxIDDetalle.DataSource = ObjetoDetalleLN.TraerUltimoIDDetalle();
            comboBoxIDDetalle.DisplayMember = "IDDetalle";

        }

        private void buttonModificar_Click_1(object sender, EventArgs e)
        {
           

            DialogResult r = MessageBox.Show("¿Desea modificar el detalle?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                if (comboBoxIDDetalle.Text != "" && textBoxNombreDetalle.Text != "")
                {
                    ObjetoDetalleNE.IDDetalle = Convert.ToInt32(comboBoxIDDetalle.Text);
                    ObjetoDetalleNE.NombreDetalle = textBoxNombreDetalle.Text;

                    ObjetoDetalleLN.ModificarDetalle(ObjetoDetalleNE);

                    MessageBox.Show("Detalle modificado con éxito");
                    dataGridViewDetalle.DataSource = ObjetoDetalleLN.MostrarDetalle();

                    comboBoxIDDetalle.Text = string.Empty;
                    textBoxNombreDetalle.Text = string.Empty;

                    comboBoxIDDetalle.DataSource = ObjetoDetalleLN.TraerUltimoIDDetalle();
                    comboBoxIDDetalle.DisplayMember = "IDDetalle";
                }
                 else
                
                    MessageBox.Show("Ingrese el nombre del detalle", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (r == DialogResult.No)
                {
                }

                }
            }
        

        private void buttonGuardar_Click_1(object sender, EventArgs e)
        {
        
            DialogResult r = MessageBox.Show("¿Desea guardar el detalle?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                if (comboBoxIDDetalle.Text != "" && textBoxNombreDetalle.Text != "")
                {
                    ObjetoDetalleNE.IDDetalle = Convert.ToInt32(comboBoxIDDetalle.Text);
                    ObjetoDetalleNE.NombreDetalle = textBoxNombreDetalle.Text;

                    ObjetoDetalleLN.AgregarDetalle(ObjetoDetalleNE);

                    MessageBox.Show("Detalle guardado con éxito");
                    dataGridViewDetalle.DataSource = ObjetoDetalleLN.MostrarDetalle();
                    textBoxNombreDetalle.Text = string.Empty;
                    comboBoxIDDetalle.Text = string.Empty;

                    comboBoxIDDetalle.DataSource = ObjetoDetalleLN.TraerUltimoIDDetalle();
                    comboBoxIDDetalle.DisplayMember = "IDDetalle";
                }
                 else
            
                MessageBox.Show("Ingrese nombre del detalle", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (r == DialogResult.No)
            {
            }

            }

        private void dataGridViewDetalle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBoxIDDetalle.Text = dataGridViewDetalle.Rows[e.RowIndex].Cells["IDDetalle"].Value.ToString();
            textBoxNombreDetalle.Text = dataGridViewDetalle.Rows[e.RowIndex].Cells["NombreDetalle"].Value.ToString();

            buttonGuardar.Enabled = false;
            buttonModificar.Enabled = true;

        }
        }
        }
    

