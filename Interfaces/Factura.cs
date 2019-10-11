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
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data.Odbc;
using System.Data.ProviderBase;
using System.Data.Sql;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Interfaces
{

    public partial class Factura : Form
    {
          FacturaLN ObjetoFacturaLN = new FacturaLN();
          FacturaNE ObjetoFacturaNE = new FacturaNE();
          ProductoLN ObjetoProductoLN = new ProductoLN();
          ProductoNE ObjetoProductoNE = new ProductoNE();
          ItemFacturaNE ObjetoItemFacturaNE = new ItemFacturaNE();
          ItemFacturaLN ObjetoItemFacturaLN = new ItemFacturaLN();

      
        ProveedorLN ObjetoProveedorLN = new ProveedorLN();

        public Factura()
        {
            InitializeComponent();
        }

        private void Factura_Load(object sender, EventArgs e)
        {

            comboBoxNumeroFactura.DataSource = ObjetoFacturaLN.TraerUltimoNumeroFactura();
            comboBoxNumeroFactura.DisplayMember = "NumeroFactura";

            DataGridViewFactura.DataSource = ObjetoFacturaLN.MostrarFactura();

             LlenarComboIDProducto();


            LlenarComboPrecioProducto(ObjetoItemFacturaNE.IdProducto);

            LlenarComboNumeroProveedor();

           textBoxCantidad.KeyPress += new KeyPressEventHandler(ValidarCantidad);

           ButtonEliminarFactura.Enabled = false;
           ButtonModificarFactura.Enabled = false;
           ButtonGuardarFactura.Enabled = false;
           textBoxNumeroFactura2.Text = comboBoxNumeroFactura.Text;
       
        }

        private void LlenarComboNumeroProveedor()
        {
            comboBoxNumeroProveedor.DataSource = ObjetoFacturaLN.LlenarComboNumeroProveedor();
            comboBoxNumeroProveedor.ValueMember = "NumeroProveedor";
            comboBoxNumeroProveedor.DisplayMember = "NumeroProveedor";
        }

        
        public void LimpiarCampos()
        {
            DataTimePickerFecha.Value = DateTime.Now;
            comboBoxNumeroFactura.Text = string.Empty;
            textBoxCantidad.Text ="0";
            comboBoxPrecioCosto.Text = string.Empty;
            textBoxTotalProducto.Text = string.Empty;
            textBoxNumeroFactura2.Text = string.Empty;
            textBoxTotal.Text = string.Empty;

            comboBoxNumeroFactura.DataSource = ObjetoFacturaLN.TraerUltimoNumeroFactura();
            comboBoxNumeroFactura.DisplayMember = "NumeroFactura";

            textBoxNumeroFactura2.Text = comboBoxNumeroFactura.Text;
        }

       

        private void comboBoxProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarComboNombreProducto(Convert.ToInt32(comboBoxCodigoProducto.Text));

        }

        private void comboBoxCodigoProducto_SelectionChangeCommitted(object sender, EventArgs e)
        {
        }

        private void comboBoxProducto_SelectionChangeCommitted(object sender, EventArgs e)
        {
        
        }

        private void comboBoxCodigoProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        public void LlenarComboNombreProducto(int IDProducto)
        {
                comboBoxProducto.DataSource = ObjetoFacturaLN.LlenarComboNombreProducto(Convert.ToInt32(comboBoxCodigoProducto.Text));
                comboBoxProducto.ValueMember = "IDProducto";
                comboBoxProducto.DisplayMember = "DetalleProducto";
            
        }
        public void LlenarComboIDProducto()
        {
       
            comboBoxCodigoProducto.DataSource = ObjetoFacturaLN.LlenarComboIDProducto();
            comboBoxCodigoProducto.ValueMember = "IDProducto";
            comboBoxCodigoProducto.DisplayMember = "IDProducto";            
        }

        public void LlenarComboPrecioProducto(int IDProducto)
        {
            comboBoxPrecioCosto.DataSource = ObjetoFacturaLN.LlenarComboBoxPrecioCosto(Convert.ToInt32(comboBoxCodigoProducto.Text));
            comboBoxPrecioCosto.ValueMember = "IDProducto";
            comboBoxPrecioCosto.DisplayMember = "PrecioCosto";
        
        }
       

        private void textBoxCantidad_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void textBoxNumeroFactura_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBoxNumeroFactura_TextChanged_1(object sender, EventArgs e)
        {
            textBoxNumeroFactura2.Text = comboBoxNumeroFactura.Text;
        }
        private void ValidarCantidad(Object o, KeyPressEventArgs e)
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

        public double SumarImportes()
        {
            double suma = 0;
  
            foreach (DataGridViewRow fila in dataGridViewItem.Rows)
            {
                if (fila.Cells[4].Value != null)
                suma += Convert.ToDouble(fila.Cells["Monto"].Value);
            }
          return suma;
        }

        public double SumarImportes2()
        {
            double suma = 0;

            foreach (DataGridViewRow fila in dataGridViewVerItems.Rows)
            {
                if (fila.Cells[4].Value != null)
                    suma += Convert.ToDouble(fila.Cells["Monto"].Value);
            }
            return suma;
        }

       

        private void DataGridViewFactura_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void comboBoxProducto_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            LlenarComboNombreProducto(Convert.ToInt32(comboBoxCodigoProducto.Text));
        }

        private void ButtonSalir_Click_1(object sender, EventArgs e)
        {

           Close();
        }

        private void ButtonGuardarFactura_Click_1(object sender, EventArgs e)
        {

             DialogResult r = MessageBox.Show("¿Desea guardar la factura?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                if (comboBoxNumeroFactura.Text != "" && DataTimePickerFecha.Text != "" && comboBoxNombreProveedor.Text != "" && comboBoxNumeroProveedor.Text != "" && textBoxTotal.Text != "" && comboBoxCodigoProducto.Text!="" && comboBoxProducto.Text!="" && textBoxCantidad.Text!="" && comboBoxPrecioCosto.Text!="" && textBoxTotalProducto.Text!="")
                {
                       ObjetoFacturaNE.NumeroFactura = Convert.ToInt32(comboBoxNumeroFactura.Text);
            ObjetoFacturaNE.Fecha = DataTimePickerFecha.Value;
            ObjetoFacturaNE.NombreProveedor = comboBoxNombreProveedor.Text;
            ObjetoFacturaNE.NumeroProveedor = Convert.ToInt32(comboBoxNumeroProveedor.Text);
            ObjetoFacturaNE.TotalImporte = Convert.ToDouble(SumarImportes()); // Convert.ToInt32(textBoxTotalProducto.Text);
            
            ObjetoFacturaLN.AgregarFactura(ObjetoFacturaNE);

            int i = 0;
            while (i < dataGridViewItem.RowCount - 1)
            {

                ObjetoItemFacturaNE.IdProducto = Convert.ToInt32(dataGridViewItem.Rows[i].Cells[0].Value.ToString());
                ObjetoItemFacturaNE.NombreProducto = dataGridViewItem.Rows[i].Cells[1].Value.ToString();
                ObjetoItemFacturaNE.Cantidad = Convert.ToInt32(dataGridViewItem.Rows[i].Cells[2].Value.ToString());
                ObjetoItemFacturaNE.PrecioCosto = Convert.ToDouble(dataGridViewItem.Rows[i].Cells[3].Value.ToString());
                ObjetoItemFacturaNE.Monto = Convert.ToDouble(dataGridViewItem.Rows[i].Cells[4].Value.ToString());
                ObjetoItemFacturaNE.NumeroFactura = Convert.ToInt32(dataGridViewItem.Rows[i].Cells[5].Value.ToString());

                ObjetoItemFacturaLN.AgregarItemFactura(ObjetoItemFacturaNE);

                i = i + 1;                       
                       
            DataGridViewFactura.DataSource = ObjetoFacturaLN.MostrarFactura();
            ButtonGuardarFactura.Enabled = false;
            }
                }
                else

                    MessageBox.Show("Existen campos vacíos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else if (r == DialogResult.No)
            {
            }
            dataGridViewItem.Rows.Clear();
            LimpiarCampos();
            MessageBox.Show("Factura guardada con éxito");
        
        }

        private void ButtonNuevoItem_Click_1(object sender, EventArgs e)
        {
            

            dataGridViewItem.Rows.Add(  comboBoxCodigoProducto.Text, comboBoxProducto.Text, textBoxCantidad.Text, comboBoxPrecioCosto.Text, textBoxTotalProducto.Text, textBoxNumeroFactura2.Text);

            textBoxTotal.Text = "";
            textBoxTotal.Text += SumarImportes();

            ButtonGuardarFactura.Enabled = true;

        }

        private void ButtonModificarFactura_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Desea modificar la factura?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {

                if (comboBoxNumeroFactura.Text != "")
                {

                    ObjetoFacturaNE.NumeroFactura = Convert.ToInt32(comboBoxNumeroFactura.Text);
                    ObjetoFacturaNE.Fecha = DataTimePickerFecha.Value;
                    ObjetoFacturaNE.NombreProveedor = comboBoxNombreProveedor.Text;
                    ObjetoFacturaNE.NumeroProveedor = Convert.ToInt32(comboBoxNumeroProveedor.Text);
                    ObjetoFacturaNE.TotalImporte = Convert.ToDouble(SumarImportes()); // Convert.ToInt32(textBoxTotalProducto.Text);

                    ObjetoFacturaLN.ModificarFactura(ObjetoFacturaNE);

                    MessageBox.Show("Factura modificada con éxito");
                    DataGridViewFactura.DataSource = ObjetoFacturaLN.MostrarFactura();

                    LimpiarCampos();
                    ButtonModificarFactura.Enabled = false;
                    ButtonGuardarFactura.Enabled = false;
                   
                }
                else

                    MessageBox.Show("Existen campos vacíos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else if (r == DialogResult.No)
            {
            }

        }

        private void ButtonLimpiarCampos_Click_1(object sender, EventArgs e)
        {
            LimpiarCampos();
            ButtonNuevoItem.Enabled = true;
        }

        private void DataGridViewFactura_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTimePickerFecha.Text = DataGridViewFactura.Rows[e.RowIndex].Cells["Fecha"].Value.ToString();
            comboBoxNumeroFactura.Text = DataGridViewFactura.Rows[e.RowIndex].Cells["NumeroFactura"].Value.ToString();
            comboBoxNumeroProveedor.Text = DataGridViewFactura.Rows[e.RowIndex].Cells["NumeroProveedor"].Value.ToString();
            comboBoxNombreProveedor.Text = DataGridViewFactura.Rows[e.RowIndex].Cells["NombreProveedor"].Value.ToString();
            textBoxTotal.Text = DataGridViewFactura.Rows[e.RowIndex].Cells["TotalImporte"].Value.ToString();

            ObjetoFacturaNE.NumeroFactura = Convert.ToInt32(comboBoxNumeroFactura.Text);
            dataGridViewVerItems.DataSource = ObjetoItemFacturaLN.MostrarItemFactura(ObjetoFacturaNE.NumeroFactura);

            ButtonEliminarFactura.Enabled = true;
            ButtonModificarFactura.Enabled = true;
            ButtonGuardarFactura.Enabled = false;
            ButtonNuevoItem.Enabled = false;
        }

        private void comboBoxPrecioCosto_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxCantidad_TextChanged(object sender, EventArgs e)
        {
            double? a;
            double? PrimerNumero = double.Parse(textBoxCantidad.Text);
            double? SegundoNumero = double.Parse(comboBoxPrecioCosto.Text);

            a = (PrimerNumero * SegundoNumero);
            textBoxTotalProducto.Text = a.ToString();
        }

        private void textBoxNumeroFactura_TextChanged_2(object sender, EventArgs e)
        {
            textBoxNumeroFactura2.Text = comboBoxNumeroFactura.Text;
        }

        private void DataGridViewFactura_Click(object sender, EventArgs e)
        {

        }

        private void ButtonListar_Click(object sender, EventArgs e)
        {
            dataGridViewItem.DataSource = null;
          
        }

        private void DataGridViewFactura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBoxCodigoProducto_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBoxCodigoProducto_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            LlenarComboNombreProducto(Convert.ToInt32(comboBoxCodigoProducto.Text));
            LlenarComboPrecioProducto(Convert.ToInt32(comboBoxCodigoProducto.Text));

        }

        private void ButtonCrearProducto_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            producto.ShowDialog();
        }

        private void GroupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void comboBoxNumeroProveedor_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LlenarComboNombreProveedor(Convert.ToInt32(comboBoxNumeroProveedor.Text));
        }

        private void LlenarComboNombreProveedor(int NumeroProveedor)
        {
            comboBoxNombreProveedor.DataSource = ObjetoFacturaLN.LlenarComboNombreProveedor(Convert.ToInt32(comboBoxNumeroProveedor.Text));
                comboBoxNombreProveedor.ValueMember = "NumeroProveedor";
                comboBoxNombreProveedor.DisplayMember = "NombreEmpresa";
        }

        private void dataGridViewVerItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBoxCodigoProducto.Text = dataGridViewVerItems.Rows[e.RowIndex].Cells["IDProducto"].Value.ToString();
            comboBoxProducto.Text = dataGridViewVerItems.Rows[e.RowIndex].Cells["NombreProducto"].Value.ToString();
            textBoxCantidad.Text = dataGridViewVerItems.Rows[e.RowIndex].Cells["Cantidad"].Value.ToString();
            comboBoxPrecioCosto.Text = dataGridViewVerItems.Rows[e.RowIndex].Cells["PrecioCosto"].Value.ToString();
            textBoxTotalProducto.Text = dataGridViewVerItems.Rows[e.RowIndex].Cells["Monto"].Value.ToString();
            textBoxNumeroFactura2.Text = dataGridViewVerItems.Rows[e.RowIndex].Cells["NumeroFactura"].Value.ToString();

            ButtonEliminarFactura.Enabled = true;
            ButtonModificarFactura.Enabled = true;
            ButtonGuardarFactura.Enabled = false;
        }

        private void textBoxTotalProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonEliminarFactura_Click(object sender, EventArgs e)
        {

            DialogResult r = MessageBox.Show("¿Desea eliminar la factura?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                if (comboBoxNumeroFactura.Text != "" && comboBoxNumeroProveedor.Text != "" && comboBoxNombreProveedor.Text != "" && DataTimePickerFecha.Text!="")
                {

             ObjetoItemFacturaLN.EliminarItemFactura(Convert.ToInt32(comboBoxNumeroFactura.Text));
            ObjetoFacturaNE.NumeroFactura = Convert.ToInt32(comboBoxNumeroFactura.Text);
            ObjetoFacturaLN.EliminarFactura(ObjetoFacturaNE);
            DataGridViewFactura.DataSource = ObjetoFacturaLN.MostrarFactura();
            dataGridViewVerItems.DataSource = ObjetoItemFacturaLN.MostrarItemFactura(ObjetoFacturaNE.NumeroFactura);

            MessageBox.Show("Factura eliminada con éxito");
            LimpiarCampos();

            ButtonNuevoItem.Enabled = true;
           
                }
                 else
                
                    MessageBox.Show("Seleccione factura", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (r == DialogResult.No)
                {
                }

                }
            ButtonEliminarFactura.Enabled = false;
            ButtonModificarFactura.Enabled = false;


        }
        // ejemplo para pruebas unitarias 
        //public  int sumar(int numero1, int numero2)
        //{
        //    int suma = 0;
        //    suma = numero1 + numero2;
          
        //        return suma;
        //}

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void ButtonModificarItem_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Desea modificar el item?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {

                if ( comboBoxCodigoProducto.Text!="" && comboBoxProducto.Text!="" && textBoxCantidad.Text!="" && comboBoxPrecioCosto.Text!="" && textBoxTotalProducto.Text!="")   
                {

                    ObjetoItemFacturaNE.IdProducto = Convert.ToInt32(comboBoxCodigoProducto.Text);
                    ObjetoItemFacturaNE.NombreProducto = comboBoxProducto.Text;
                    ObjetoItemFacturaNE.Cantidad =Convert.ToInt32(textBoxCantidad.Text);
                    ObjetoItemFacturaNE.PrecioCosto = Convert.ToDouble(comboBoxPrecioCosto.Text);
                    ObjetoItemFacturaNE.Monto =Convert.ToDouble(textBoxTotalProducto.Text);
                    ObjetoItemFacturaNE.NumeroFactura =Convert.ToInt32(textBoxNumeroFactura2.Text);

                    ObjetoItemFacturaLN.ModificarItemFactura(ObjetoItemFacturaNE);

                    MessageBox.Show("Item modificado con éxito");
                    dataGridViewItem.DataSource = ObjetoItemFacturaLN.MostrarItemFactura(ObjetoItemFacturaNE.NumeroFactura);
                    DataGridViewFactura.DataSource = ObjetoFacturaLN.MostrarFactura();

                    textBoxTotal.Text = "";
                    textBoxTotal.Text += SumarImportes2();

                    ObjetoFacturaNE.NumeroFactura = Convert.ToInt32(comboBoxNumeroFactura.Text);
                    ObjetoFacturaNE.Fecha = DataTimePickerFecha.Value;
                    ObjetoFacturaNE.NombreProveedor = comboBoxNombreProveedor.Text;
                    ObjetoFacturaNE.NumeroProveedor = Convert.ToInt32(comboBoxNumeroProveedor.Text);
                    ObjetoFacturaNE.TotalImporte = Convert.ToDouble(SumarImportes2()); // Convert.ToInt32(textBoxTotalProducto.Text);

                    ObjetoFacturaLN.ModificarFactura(ObjetoFacturaNE);

                    dataGridViewVerItems.DataSource = null;
                    LimpiarCampos();
                    ButtonModificarFactura.Enabled = false;
                    ButtonGuardarFactura.Enabled = false;
                    ButtonNuevoItem.Enabled = true;

                    
                }
                else

                    MessageBox.Show("Existen campos vacíos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else if (r == DialogResult.No)
            {
            }
        }

        private void ButtonEliminarItem_Click(object sender, EventArgs e)
        {

            if (comboBoxCodigoProducto.Text != "" && comboBoxProducto.Text != "" && textBoxCantidad.Text != "" && comboBoxPrecioCosto.Text != "" && textBoxTotalProducto.Text != "")
            {

                ObjetoItemFacturaNE.IdProducto = Convert.ToInt32(comboBoxCodigoProducto.Text);
                ObjetoItemFacturaNE.NombreProducto = comboBoxProducto.Text;
                ObjetoItemFacturaNE.Cantidad = Convert.ToInt32(textBoxCantidad.Text);
                ObjetoItemFacturaNE.PrecioCosto = Convert.ToDouble(comboBoxPrecioCosto.Text);
                ObjetoItemFacturaNE.Monto = Convert.ToDouble(textBoxTotalProducto.Text);
                ObjetoItemFacturaNE.NumeroFactura = Convert.ToInt32(textBoxNumeroFactura2.Text);

                ObjetoItemFacturaLN.EliminarItemFactura(ObjetoItemFacturaNE.NumeroFactura);

            MessageBox.Show("Item eliminado con éxito");
            LimpiarCampos();

            ButtonNuevoItem.Enabled = true;
           
                }
                 else
                
                    MessageBox.Show("Seleccione item", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        private void GroupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void GroupBox4_Enter(object sender, EventArgs e)
        {

        }
        }

    }


 



