using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using BLL;

namespace Registropelicula
{
    public partial class Registrar : Form
    {
        public Registrar()
        {
            InitializeComponent();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {


            Categoria c = new Categoria();
            c.Descripcion = DescripcionRichTextBox.Text;
            c.Insertar();
               
            DescripcionRichTextBox.Clear();
        }
    }
}
