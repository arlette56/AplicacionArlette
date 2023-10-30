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
    public partial class FormaProve : Form
    {
        public FormaProve()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormaMenu form = new FormaMenu();
            form.Show();
        }
    }
}
