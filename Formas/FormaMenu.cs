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

namespace Aplicacion_Arlette.Formas
{
    public partial class FormaMenu : Form
    {
        public FormaMenu()
        {
            InitializeComponent();
        }

        private void registrateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaRegistro form = new FormaRegistro();
            form.Show();
        }

        private void computoPantallasYElectronicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaComputo formm = new FormaComputo();
            formm.Show();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaProve form = new FormaProve();
            form.Show();
        }

        private void revistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaRevista FORM = new FormaRevista();
            FORM.Show();

        }

        private void sucursalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaSucursal form = new FormaSucursal();
            form.Show();
        }
    }
}
