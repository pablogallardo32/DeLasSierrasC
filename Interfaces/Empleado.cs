using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using CapaNE;
using CapaLN;


namespace Interfaces
{
    public partial class Empleado : Form
    {

        EmpleadoLN ObjetoEmpleadoLN = new EmpleadoLN();
        EmpleadoNE ObjetoEmpleadoNE = new EmpleadoNE();

        public Empleado()
        {
            InitializeComponent();
        }

        private void textBoxApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonSalir_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void ButtonGuardar_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Desea guardar el empleado?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                if (textBoxNombre.Text != "" && textBoxApellido.Text != "" && textBoxDNI.Text != "" &&  DateTimePeckerFechaNacimiento.Text !="" && DateTimePickerFechaIngreso.Text !="" )
                {
                     ObjetoEmpleadoNE.Nombre = textBoxNombre.Text;
            ObjetoEmpleadoNE.Apellido= textBoxApellido.Text;
            ObjetoEmpleadoNE.DNI =Convert.ToInt32(textBoxDNI.Text);
            ObjetoEmpleadoNE.FechaNacimiento = DateTimePeckerFechaNacimiento.Value;
            ObjetoEmpleadoNE.TelefonoCelular = textBoxTelefonoCelular.Text;
            ObjetoEmpleadoNE.TelefonoFijo = textBoxTelefonoFijo.Text;
            ObjetoEmpleadoNE.Mail = textBoxEMail.Text;
            ObjetoEmpleadoNE.FechaIngreso = DateTimePickerFechaIngreso.Value;
            ObjetoEmpleadoNE.Seccion = comboBoxSeccion.Text;
            ObjetoEmpleadoNE.Calle = textBoxCalle.Text;
            ObjetoEmpleadoNE.Numero = textBoxNumero.Text;
            ObjetoEmpleadoNE.Piso = textBoxPiso.Text;
            ObjetoEmpleadoNE.Depto = textBoxDepto.Text;
            ObjetoEmpleadoNE.Barrio = textBoxBarrio.Text;
            ObjetoEmpleadoNE.Localidad = comboBoxLocalidad.Text;
            ObjetoEmpleadoNE.Provincia = comboBoxProvincia.Text;
            ObjetoEmpleadoNE.CodigoPostal = textBoxCodigoPostal.Text;

                    ObjetoEmpleadoLN.AgregarEmpleado(ObjetoEmpleadoNE);
            DataGridViewEmpleado.DataSource = ObjetoEmpleadoLN.MostrarEmpleado();
            MessageBox.Show("Empleado guardado con éxito");
            limpiarCampos();

            ButtonModificar.Enabled = false;

                }
                else

                    MessageBox.Show("Existen campos vacíos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else if (r == DialogResult.No)
            {
            }

        }

        private void ButtonListar_Click(object sender, EventArgs e)
        {
            DataGridViewEmpleado.DataSource = ObjetoEmpleadoLN.MostrarEmpleado();

        }

        private void ButtonLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();

            ButtonGuardar.Enabled = true;
            ButtonModificar.Enabled = false;
            
        }

        public void limpiarCampos()
        {
            textBoxNombre.Text = string.Empty;
            textBoxApellido.Text = string.Empty;
            textBoxDNI.Text = string.Empty;
            DateTimePeckerFechaNacimiento.Value = DateTime.Now;
            textBoxTelefonoCelular.Text = string.Empty;
            textBoxTelefonoFijo.Text = string.Empty;
            textBoxEMail.Text = string.Empty;
            DateTimePickerFechaIngreso.Value = DateTime.Now;
            comboBoxSeccion.Text = string.Empty;
            textBoxCalle.Text = string.Empty;
            textBoxNumero.Text = string.Empty;
            textBoxPiso.Text = string.Empty;
            textBoxDepto.Text = string.Empty;
            textBoxBarrio.Text = string.Empty;
            comboBoxLocalidad.Text = string.Empty;
            comboBoxProvincia.Text = string.Empty;
            textBoxCodigoPostal.Text = string.Empty;
        }

        public void DataGridViewEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxNombre.Text = DataGridViewEmpleado.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
            textBoxApellido.Text = DataGridViewEmpleado.Rows[e.RowIndex].Cells["Apellido"].Value.ToString();
            textBoxDNI.Text = DataGridViewEmpleado.Rows[e.RowIndex].Cells["DNI"].Value.ToString();
            DateTimePeckerFechaNacimiento.Text = DataGridViewEmpleado.Rows[e.RowIndex].Cells["FechaNacimiento"].Value.ToString();
            textBoxTelefonoCelular.Text = DataGridViewEmpleado.Rows[e.RowIndex].Cells["TelefonoCelular"].Value.ToString();
            textBoxTelefonoFijo.Text = DataGridViewEmpleado.Rows[e.RowIndex].Cells["TelefonoFijo"].Value.ToString();
            textBoxEMail.Text = DataGridViewEmpleado.Rows[e.RowIndex].Cells["Mail"].Value.ToString();
            DateTimePickerFechaIngreso.Text = DataGridViewEmpleado.Rows[e.RowIndex].Cells["FechaIngreso"].Value.ToString();
            comboBoxSeccion.Text = DataGridViewEmpleado.Rows[e.RowIndex].Cells["Seccion"].Value.ToString();
            textBoxCalle.Text = DataGridViewEmpleado.Rows[e.RowIndex].Cells["Calle"].Value.ToString();
            textBoxNumero.Text = DataGridViewEmpleado.Rows[e.RowIndex].Cells["Numero"].Value.ToString();
            textBoxPiso.Text = DataGridViewEmpleado.Rows[e.RowIndex].Cells["Piso"].Value.ToString();
            textBoxDepto.Text = DataGridViewEmpleado.Rows[e.RowIndex].Cells["Depto"].Value.ToString();
            textBoxBarrio.Text = DataGridViewEmpleado.Rows[e.RowIndex].Cells["Barrio"].Value.ToString();
            comboBoxLocalidad.Text = DataGridViewEmpleado.Rows[e.RowIndex].Cells["Localidad"].Value.ToString();
            comboBoxProvincia.Text = DataGridViewEmpleado.Rows[e.RowIndex].Cells["Provincia"].Value.ToString();
            textBoxCodigoPostal.Text = DataGridViewEmpleado.Rows[e.RowIndex].Cells["CodigoPostal"].Value.ToString();

            ButtonGuardar.Enabled = false;
            ButtonModificar.Enabled = true;


        }

        public void ButtonModificar_Click(object sender, EventArgs e)
        {
            
            DialogResult r = MessageBox.Show("¿Desea modificar el empleado?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                if (textBoxDNI.Text != "" )
                {
                ObjetoEmpleadoNE.Nombre = textBoxNombre.Text;
            ObjetoEmpleadoNE.Apellido = textBoxApellido.Text;
            ObjetoEmpleadoNE.DNI = Convert.ToInt32(textBoxDNI.Text);
            ObjetoEmpleadoNE.FechaNacimiento = DateTimePeckerFechaNacimiento.Value;
            ObjetoEmpleadoNE.TelefonoCelular = textBoxTelefonoCelular.Text;
            ObjetoEmpleadoNE.TelefonoFijo = textBoxTelefonoFijo.Text;
            ObjetoEmpleadoNE.Mail = textBoxEMail.Text;
            ObjetoEmpleadoNE.FechaIngreso = DateTimePickerFechaIngreso.Value;
            ObjetoEmpleadoNE.Seccion = comboBoxSeccion.Text;
            ObjetoEmpleadoNE.Calle = textBoxCalle.Text;
            ObjetoEmpleadoNE.Numero = textBoxNumero.Text;
            ObjetoEmpleadoNE.Piso = textBoxPiso.Text;
            ObjetoEmpleadoNE.Depto = textBoxDepto.Text;
            ObjetoEmpleadoNE.Barrio = textBoxBarrio.Text;
            ObjetoEmpleadoNE.Localidad = comboBoxLocalidad.Text;
            ObjetoEmpleadoNE.Provincia = comboBoxProvincia.Text;
            ObjetoEmpleadoNE.CodigoPostal = textBoxCodigoPostal.Text;

                    ObjetoEmpleadoLN.ModificarEmpleado(ObjetoEmpleadoNE);
                MessageBox.Show("Empleado modificado con éxito");
                DataGridViewEmpleado.DataSource = ObjetoEmpleadoLN.MostrarEmpleado();

            limpiarCampos();

            ButtonModificar.Enabled = false;
            ButtonGuardar.Enabled = true;
                }
                else

                    MessageBox.Show("Existen campos vacíos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else if (r == DialogResult.No)
            {
            }



            if (ValidarEmail(ObjetoEmpleadoNE.Mail) == true)
            {

                
            }
            else {
                MessageBox.Show("Formato de E-mail no válido");
            }
            
            
            
        }

        private void Empleado_Load(object sender, EventArgs e)
        {
            textBoxDNI.KeyPress += new KeyPressEventHandler(ValidarDNI);
            textBoxTelefonoCelular.KeyPress += new KeyPressEventHandler(ValidarTelefonoCelular);
            textBoxTelefonoFijo.KeyPress += new KeyPressEventHandler(ValidarTelefonoFijo);
            textBoxNumero.KeyPress += new KeyPressEventHandler(ValidarNumero);// puede ser s/n
            textBoxPiso.KeyPress += new KeyPressEventHandler(ValidarPiso);
            textBoxCodigoPostal.KeyPress += new KeyPressEventHandler(ValidarCodigoPostal);
            textBoxNombre.KeyPress += new KeyPressEventHandler(ValidarNombre);
            textBoxApellido.KeyPress += new KeyPressEventHandler(ValidarApellido);
            string email = textBoxEMail.Text;
          //  textBoxEMail.KeyPress += new KeyPressEventHandler(ValidarEmail(email));
            ValidarEmail(textBoxEMail.Text);

            DataGridViewEmpleado.DataSource = ObjetoEmpleadoLN.MostrarEmpleado();

            ButtonModificar.Enabled = false;
        }

        

        private void ButtonEliminar_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Desea eliminar el empleado?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                if (textBoxDNI.Text != "" && textBoxNombre.Text != "" && textBoxApellido.Text != "" && DateTimePeckerFechaNacimiento.Text != "" && DateTimePickerFechaIngreso.Text != "")
                {

                      ObjetoEmpleadoNE.DNI = Convert.ToInt32(textBoxDNI.Text);
            ObjetoEmpleadoLN.EliminarEmpleado(ObjetoEmpleadoNE);
            DataGridViewEmpleado.DataSource = ObjetoEmpleadoLN.MostrarEmpleado();
            MessageBox.Show("Empleado eliminado con éxito");
            limpiarCampos();

            ButtonModificar.Enabled = false;
            ButtonGuardar.Enabled = true;

           
                }
                 else
                
                    MessageBox.Show("Seleccione empleado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (r == DialogResult.No)
                {                }

                }
            }


        private void ValidarDNI(Object o, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))//Si es número
            {
                e.Handled = false;
            }
            if (Char.IsNumber(e.KeyChar) )//Si es número
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

        private void ValidarTelefonoCelular(Object o, KeyPressEventArgs e)
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

        private void ValidarTelefonoFijo(Object o, KeyPressEventArgs e)
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

        private void ValidarNumero(Object o, KeyPressEventArgs e)
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

        private void ValidarPiso(Object o, KeyPressEventArgs e)
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

        private void ValidarCodigoPostal(Object o, KeyPressEventArgs e)
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


        private void ValidarNombre(Object o, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))//Si es letra
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

        private void ValidarApellido(Object o, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))//Si es letra
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

        public static Boolean ValidarEmail(string email)
        {
            string expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, string.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void GroupBox3_Enter(object sender, EventArgs e)
        {

        }

    }
}
