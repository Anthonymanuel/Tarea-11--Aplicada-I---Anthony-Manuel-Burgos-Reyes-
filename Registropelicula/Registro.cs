using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registropelicula
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registrar r = new Registrar();
            r.MdiParent = this;
            r.Show();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultar c = new Consultar();
            c.MdiParent = this;
            c.Show();
        }
    }
}
