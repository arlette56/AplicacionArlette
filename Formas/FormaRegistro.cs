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
    public partial class FormaRegistro : Form
    {
        public FormaRegistro()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedMembership = comboBox1.Text;
                int membershipCost = 0; // Variable para rastrear el costo de la membresía

                if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text) || string.IsNullOrEmpty(textBox5.Text) || comboBox1.SelectedIndex == -1)
                {
                  
                    MessageBox.Show("Por favor, complete todos los campos antes de agregar la membresía comprada.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                   
                    if (selectedMembership == "Dorada" || selectedMembership == "Negocio")
                    {
                        membershipCost = 500;
                    }
                    else if (selectedMembership == "Dorada Ejecutiva" || selectedMembership == "Ejecutiva")
                    {
                        membershipCost = 1100;
                    }

                    
                    DataGridViewRow renglon = (DataGridViewRow)datamembresia.Rows[0].Clone();

                    renglon.Cells[0].Value = textBox1.Text;
                    renglon.Cells[1].Value = textBox2.Text;
                    renglon.Cells[2].Value = textBox3.Text;
                    renglon.Cells[3].Value = textBox4.Text;
                    renglon.Cells[4].Value = textBox5.Text;
                    renglon.Cells[5].Value = dateTimePicker1.Value;
                    renglon.Cells[6].Value = selectedMembership;

                    datamembresia.Rows.Add(renglon);

                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    dateTimePicker1.Value = DateTime.Now;
                    comboBox1.SelectedIndex = -1;

                    // Mostrar un mensaje con la cantidad a pagar
                    MessageBox.Show("Membresía comprada con éxito. Cantidad a pagar: $" + membershipCost, "Membresía Comprada",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Agregando Comprador",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
            private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }

