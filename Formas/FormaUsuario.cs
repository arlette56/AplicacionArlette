using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace Aplicacion_Arlette.Formas
{
    public partial class FormaUsuario : Form
    {


        public FormaUsuario()
        {
            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow renglon = (DataGridViewRow)dataUsuario.Rows[0].Clone();

                renglon.Cells[0].Value = txtNombre.Text;
                renglon.Cells[1].Value = txtApellido.Text;
                renglon.Cells[2].Value = txtDireccion.Text;
                renglon.Cells[3].Value = comboBox1.Text;
                renglon.Cells[4].Value = txtCorreo.Text;
                renglon.Cells[5].Value = txtCelular.Text;
                renglon.Cells[6].Value = dateTimePicker1.Value; // Agrega el valor del DateTimePicker

                if (radioButton3.Checked)
                {
                    renglon.Cells[7].Value = "Radio 1 seleccionado";
                }
                else if (radioButton2.Checked)
                {
                    renglon.Cells[7].Value = "Radio 2 seleccionado";
                }

                renglon.Cells[8].Value = comboBox2.Text; // Agrega el valor del ComboBox2

                dataUsuario.Rows.Add(renglon);

                // Limpia los campos después de agregar los datos
                txtNombre.Clear();
                txtApellido.Clear();
                txtDireccion.Clear();
                comboBox1.SelectedIndex = -1;
                txtCorreo.Clear();
                txtCelular.Clear();
                dateTimePicker1.Value = DateTime.Now; // Restaura el DateTimePicker a la fecha actual
                radioButton3.Checked = false; // Desmarca los RadioButtons
                radioButton2.Checked = false;
                comboBox2.SelectedIndex = -1; // Restaura el ComboBox2
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Agregando Usuario",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }






        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Puedes manejar eventos del DataGridView aquí si es necesario
        }

        private void MicrosoftYaHei_Enter(object sender, EventArgs e)
        {

        }

        private DataGridViewRow renglonSeleccionado; // Variable para almacenar el renglón seleccionado

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataUsuario.SelectedRows.Count > 0)
            {
                renglonSeleccionado = dataUsuario.SelectedRows[0];

                // Cargar los datos del renglón seleccionado en los controles
                txtNombre.Text = renglonSeleccionado.Cells[0].Value.ToString();
                txtApellido.Text = renglonSeleccionado.Cells[1].Value.ToString();
                txtDireccion.Text = renglonSeleccionado.Cells[2].Value.ToString();
                comboBox1.Text = renglonSeleccionado.Cells[3].Value.ToString();
                txtCorreo.Text = renglonSeleccionado.Cells[4].Value.ToString();
                txtCelular.Text = renglonSeleccionado.Cells[5].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(renglonSeleccionado.Cells[6].Value); // Convierte la celda a DateTime
                                                                                                // Puedes manejar los RadioButtons y ComboBox2 aquí si es necesario
            }
            else
            {
                MessageBox.Show("Debes seleccionar un renglón para modificar", "Modificando Estudiante",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Después de que el usuario haya modificado los datos en los controles, puedes utilizar un botón para guardar los cambios en el DataGridView:

        private void button4_Click(object sender, EventArgs e)
        {
            if (renglonSeleccionado != null)
            {
                // Actualiza los datos en el renglón seleccionado con los valores de los controles
                renglonSeleccionado.Cells[0].Value = txtNombre.Text;
                renglonSeleccionado.Cells[1].Value = txtApellido.Text;
                renglonSeleccionado.Cells[2].Value = txtDireccion.Text;
                renglonSeleccionado.Cells[3].Value = comboBox1.Text;
                renglonSeleccionado.Cells[4].Value = txtCorreo.Text;
                renglonSeleccionado.Cells[5].Value = txtCelular.Text;
                renglonSeleccionado.Cells[6].Value = dateTimePicker1.Value;
                // Actualiza los RadioButtons y ComboBox2 si es necesario

                // Limpia los controles
                txtNombre.Clear();
                txtApellido.Clear();
                txtDireccion.Clear();
                comboBox1.SelectedIndex = -1;
                txtCorreo.Clear();
                txtCelular.Clear();
                dateTimePicker1.Value = DateTime.Now;
                // Limpia los RadioButtons y ComboBox2 si es necesario

                // Limpia la variable renglonSeleccionado
                renglonSeleccionado = null;
            }
        }

    }
}
