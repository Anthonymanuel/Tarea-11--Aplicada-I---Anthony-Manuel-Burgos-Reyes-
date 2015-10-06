using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BLL;

namespace Registropelicula
{
    public partial class Consultar : Form
    {
        SqlDataAdapter adapter;
        SqlConnection cn = new SqlConnection("Data Source =.\\SQLEXPRESS; Initial Catalog =Pelicula ; Integrated Security = True");
        SqlCommand cm = new SqlCommand();
        DataTable dt = new DataTable();
        public Consultar()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {

            Categoria c = new Categoria();
            c.CategoriaId = Convert.ToInt32(IdTextBox.Text);
            PeliculaDataGridView.DataSource = c.Buscar();
            IdTextBox.Clear();



        }

        private void ActulizarButton_Click(object sender, EventArgs e)
        {

            Categoria c = new Categoria();
            c.CategoriaId = Convert.ToInt32(IdTextBox.Text);
            c.Descripcion = DescripcionRichTextBox.Text;
            PeliculaDataGridView.DataSource = c.Actualizar();
            IdTextBox.Clear();
            DescripcionRichTextBox.Clear();

            MessageBox.Show("La base de dato ha sido actualizada");


        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            Categoria c = new Categoria();
            c.CategoriaId = Convert.ToInt32(IdTextBox.Text);
            c.Eliminar();
            MessageBox.Show("Se eleminado la categoria");

            IdTextBox.Clear();
            DescripcionRichTextBox.Clear();


        }
    }
}

