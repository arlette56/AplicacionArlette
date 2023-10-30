using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aplicacion_Arlette.Formas;

namespace Aplicacion_Arlette
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormaUsuario forma = new FormaUsuario();
            forma.Show();
        }

        private int intentos = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = textBoxUsuario.Text;
            string contraseña = textBoxContraseña.Text;

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("Usuario y contraseña son campos obligatorios.", "Error de Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (usuario.Length < 3)
            {
                MessageBox.Show("El usuario debe tener al menos 3 caracteres.", "Error de Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (usuario == "Arlette" && contraseña == "1234567890")
            {
                MessageBox.Show("¡Bienvenido, Arlette!", "Inicio de Sesión Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Ocultar la ventana de inicio de sesión
                this.Hide();
                // Mostrar la pantalla principal (reemplaza 'FormaMenu' con el nombre de tu ventana principal)
                FormaMenu pantallaPrincipal = new FormaMenu();
                pantallaPrincipal.ShowDialog();
            }
            else
            {
                intentos++;

                if (intentos < 3)
                {
                    if (usuario == "Arlette")
                    {
                        MessageBox.Show("Contraseña incorrecta. Intentos restantes: " + (3 - intentos), "Error de Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (contraseña == "1234567890")
                    {
                        MessageBox.Show("Usuario incorrecto. Intentos restantes: " + (3 - intentos), "Error de Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Usuario y contraseña incorrectos. Intentos restantes: " + (3 - intentos), "Error de Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Se han agotado los intentos. La aplicación se cerrará.", "Error de Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
        }
    }
}
