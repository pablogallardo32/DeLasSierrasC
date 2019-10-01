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
            DataGridViewFactura.DataSource = ObjetoFacturaLN.MostrarFactura();


        //    DataSet ds = new DataSet();

             LlenarComboIDProducto();

       //     LlenarComboNombreProducto(ObjetoItemFacturaNE.IdProducto);

            LlenarComboPrecioProducto(ObjetoItemFacturaNE.IdProducto);

            LlenarComboNumeroProveedor();

           textBoxCantidad.KeyPress += new KeyPressEventHandler(ValidarCantidad);

            //DataTable ds = new DataTable();
            //ds= ObjetoProveedorLN.LlenarComboIDProducto();
            //comboBoxCodigoProducto.DataSource= ds;
   
      
           // comboBoxProducto.DataSource = ObjetoProveedorLN.LlenarComboIDProducto();

          //  comboBoxCodigoProducto.DataSource = ObjetoProveedorLN.LlenarComboIDProducto();
           // comboBoxCodigoProducto.ValueMember = "IDProducto";
            //comboBoxCodigoProducto.DisplayMember = "IDProducto";


       //     comboBoxCodigoProducto.DataSource = ObjetoProveedorLN.LlenarComboIDProducto();
       //     comboBoxCodigoProducto.ValueMember = "IDProducto";
        //   comboBoxCodigoProducto.DisplayMember = "IDProducto";
          //  comboBoxProducto.DisplayMember = "DetalleProducto";





            //comboBoxNombreProveedor.DataSource = ObjetoProveedorLN.LlenarComboProveedor();
           // comboBoxNombreProveedor.DisplayMember = "NombreEmpresa";
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
            textBoxNumeroFactura.Text = string.Empty;
            comboBoxNombreProveedor.Text = string.Empty;
            comboBoxCodigoProducto.Text = string.Empty;
            comboBoxNumeroProveedor.Text = string.Empty;
            comboBoxProducto.Text = string.Empty;
            textBoxCantidad.Text ="0";
            comboBoxPrecioCosto.Text = string.Empty;
            textBoxTotalProducto.Text = string.Empty;
            textBoxNumeroFactura2.Text = string.Empty;
            textBoxTotal.Text = string.Empty;


        }

       

        private void comboBoxProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
          //  LlenarComboIDProducto();     
            LlenarComboNombreProducto(Convert.ToInt32(comboBoxCodigoProducto.Text));



        }

        private void comboBoxCodigoProducto_SelectionChangeCommitted(object sender, EventArgs e)
        {
           // LlenarComboNombreProducto(Convert.ToInt32(comboBoxCodigoProducto.Text));
        }

        private void comboBoxProducto_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //comboBoxCodigoProducto.DataSource = ObjetoProveedorLN.LlenarComboIDProducto();
            //comboBoxCodigoProducto.ValueMember = "IDProducto";
            //comboBoxCodigoProducto.DisplayMember = "IDProducto";
        }

        private void comboBoxCodigoProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
           // LlenarComboNombreProducto(Convert.ToInt32(comboBoxCodigoProducto.Text));

         //   LlenarComboNombreProducto(Convert.ToInt16(comboBoxCodigoProducto.Text));
          // comboBoxProducto.DataSource = ObjetoProveedorLN.LlenarComboIDProducto();
          //       comboBoxProducto.ValueMember = "IDProducto";
          //  comboBoxProducto.DisplayMember = "IDProducto";
         //     comboBoxProducto.DisplayMember = "DetalleProducto";
        }


        public void LlenarComboNombreProducto(int IDProducto)
        {
            
              //  int a = Convert.ToInt16(comboBoxCodigoProducto.Text);
            comboBoxProducto.DataSource = ObjetoFacturaLN.LlenarComboNombreProducto(Convert.ToInt32(comboBoxCodigoProducto.Text));
                comboBoxProducto.ValueMember = "IDProducto";
                comboBoxProducto.DisplayMember = "DetalleProducto";
            
        }
        public void LlenarComboIDProducto()
        {
       
            comboBoxCodigoProducto.DataSource = ObjetoFacturaLN.LlenarComboIDProducto();
            comboBoxCodigoProducto.ValueMember = "IDProducto";
            comboBoxCodigoProducto.DisplayMember = "IDProducto";
           // textBoxPrecioCosto.Text = ObjetoProductoNE.PrecioCosto.ToString();
            
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
            textBoxNumeroFactura2.Text = textBoxNumeroFactura.Text;
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

       

        private void DataGridViewFactura_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
            
       //            Dim ds2 As DataSet
       // Dim objFacturaNE As New FacturaNE
       // Dim objFacturaLN As New FacturaLN
       // Dim objItemLN As New ItemLN
            

       //objFacturaNE.numfac = txtNumFac.Text
       // ds2 = objItemLN.MostrarItem(objFacturaNE)
       // DataGridViewItem.DataSource = ds2.Tables(0)

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
            ObjetoFacturaNE.NumeroFactura = Convert.ToInt32(textBoxNumeroFactura.Text);
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
            }


            //DataGridViewFactura.DataSource = ObjetoFacturaLN.MostrarFactura();
            MessageBox.Show("Factura guardada con éxito");
            DataGridViewFactura.DataSource = ObjetoFacturaLN.MostrarFactura();


            LimpiarCampos();
        }

        private void ButtonNuevoItem_Click_1(object sender, EventArgs e)
        {
            dataGridViewItem.Rows.Add(comboBoxCodigoProducto.Text, comboBoxProducto.Text, textBoxCantidad.Text, comboBoxPrecioCosto.Text, textBoxTotalProducto.Text, textBoxNumeroFactura2.Text);

            textBoxTotal.Text = "";
            textBoxTotal.Text += SumarImportes();
        }

        private void ButtonModificarFactura_Click(object sender, EventArgs e)
        {

        }

        private void ButtonLimpiarCampos_Click_1(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void DataGridViewFactura_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTimePickerFecha.Text = DataGridViewFactura.Rows[e.RowIndex].Cells["Fecha"].Value.ToString();
            textBoxNumeroFactura.Text = DataGridViewFactura.Rows[e.RowIndex].Cells["NumeroFactura"].Value.ToString();
            comboBoxNumeroProveedor.Text = DataGridViewFactura.Rows[e.RowIndex].Cells["NumeroProveedor"].Value.ToString();
            comboBoxNombreProveedor.Text = DataGridViewFactura.Rows[e.RowIndex].Cells["NombreProveedor"].Value.ToString();
            textBoxTotal.Text = DataGridViewFactura.Rows[e.RowIndex].Cells["TotalImporte"].Value.ToString();

            //    comboBoxCodigoProducto.Text= DataGridViewItem.Rows[e.RowIndex].Cells["IDProducto"].Value.ToString();

            ObjetoFacturaNE.NumeroFactura = Convert.ToInt32(textBoxNumeroFactura.Text);
            dataGridViewVerItems.DataSource = ObjetoItemFacturaLN.MostrarItemFactura(ObjetoFacturaNE.NumeroFactura);
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
            textBoxTotalProducto.Text = a.ToString();// Convert.ToString(a);
        }

        private void textBoxNumeroFactura_TextChanged_2(object sender, EventArgs e)
        {
            textBoxNumeroFactura2.Text = textBoxNumeroFactura.Text;
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
       //     LlenarComboNombreProducto(Convert.ToInt32(comboBoxCodigoProducto.Text));

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
        }

        private void textBoxTotalProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonEliminarFactura_Click(object sender, EventArgs e)
        {
            ObjetoItemFacturaLN.EliminarItemFactura(Convert.ToInt32(textBoxNumeroFactura.Text));
            DataGridViewFactura.DataSource = ObjetoFacturaLN.MostrarFactura();
            ObjetoFacturaNE.NumeroFactura = Convert.ToInt32(textBoxNumeroFactura.Text);
            ObjetoFacturaLN.EliminarFactura(ObjetoFacturaNE);
  
            MessageBox.Show("Factura eliminada con éxito");
            LimpiarCampos();
        }
    }
}

 



