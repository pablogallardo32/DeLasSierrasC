using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaces
{
    public partial class Producto : Form
    {
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
    }
}
