using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion_Arlette.Formas
{
    public partial class FormaComputo : Form
    {

        public FormaComputo()
        {
            InitializeComponent();
        }

        private void FormaComputo_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow renglon = (DataGridViewRow)dataCompra.Rows[0].Clone();

                renglon.Cells[0].Value = textBox2.Text;
                renglon.Cells[1].Value = textBox4.Text;
                renglon.Cells[2].Value = numericUpDown1.Value;


                dataCompra.Rows.Add(renglon);

                textBox2.Clear();
                textBox4.Clear();
                numericUpDown1.Value = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Agregando Comprador",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Inicializar el total de la compra
            decimal totalCompra = 0;

            // Crear un mensaje para mostrar los detalles de las compras
            string mensajeCompra = "Detalles de las compras:\n";

            foreach (DataGridViewRow row in dataCompra.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[1].Value != null && row.Cells[2].Value != null)
                {
                    string producto = row.Cells[0].Value.ToString();
                    decimal precio = Convert.ToDecimal(row.Cells[1].Value);
                    int cantidad = Convert.ToInt32(row.Cells[2].Value);

                    decimal subtotal = precio * cantidad;
                    totalCompra += subtotal;

                    mensajeCompra += $"Producto: {producto}, Precio: {precio:C}, Cantidad: {cantidad}, Subtotal: {subtotal:C}\n";
                }
            }

            // Crear un mensaje para mostrar los detalles de los registros
            string mensajeRegistro = "Detalles de los registros:\n";

            foreach (DataGridViewRow row in dataRegistro.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[1].Value != null && row.Cells[2].Value != null && row.Cells[3].Value != null && row.Cells[4].Value != null)
                {
                    string cliente = row.Cells[0].Value.ToString();
                    string direccion = row.Cells[1].Value.ToString();
                    DateTime fecha = Convert.ToDateTime(row.Cells[2].Value);
                    string referencias = row.Cells[3].Value.ToString();
                    string membresia = row.Cells[4].Value.ToString();

                    mensajeRegistro += $"Cliente: {cliente}, Direccion: {direccion}, Fecha: {fecha}, Referencias: {referencias}, Membresia: {membresia}\n";
                }
            }

            // Agregar el total de la compra al mensaje
            mensajeRegistro += $"Total de la compra: {totalCompra:C}\n";

            // Mostrar ambos mensajes en el MessageBox
            string mensajeFinal = mensajeCompra + "\n" + mensajeRegistro;
            MessageBox.Show(mensajeFinal, "Detalles de Compras y Registros", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow renglon = (DataGridViewRow)dataRegistro.Rows[0].Clone();

                
                renglon.Cells[0].Value = textBox5.Text;
                renglon.Cells[1].Value = textBox1.Text;
                renglon.Cells[2].Value = dateTimePicker1.Value; // Agrega el valor del DateTimePicker
                renglon.Cells[3].Value = textBox3.Text;
                renglon.Cells[4].Value = comboBox0.Text;

                dataRegistro.Rows.Add(renglon);

                textBox5.Clear();
                textBox1.Clear();
                dateTimePicker1.Value = DateTime.Now;
                textBox3.Clear();
                comboBox0.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Agregando Comprador",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

    }
}


