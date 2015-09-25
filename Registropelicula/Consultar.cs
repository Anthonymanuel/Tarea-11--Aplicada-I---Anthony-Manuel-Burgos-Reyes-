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
           
            try
            {
                cn.Open();
                cm.Connection = cn;
                adapter = new SqlDataAdapter("select * from Categoria where Id='"+IdTextBox.Text+"'",cn);
                adapter.Fill(dt);


            }
            catch (Exception )
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
            PeliculaDataGridView.DataSource = dt;
            IdTextBox.Clear();
            


        }

        private void ActulizarButton_Click(object sender, EventArgs e)
        {
            
            try
            {
                cn.Open();
                cm.Connection = cn;
                adapter = new SqlDataAdapter("Update Categoria set Descripcion='"+DescripcionRichTextBox.Text+"'  where Id='"+IdTextBox.Text+ "'",cn);
                adapter.Fill(dt);


            }
            catch (Exception )
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
           
            IdTextBox.Clear();
            DescripcionRichTextBox.Clear();
            MessageBox.Show("La base de dato ha sido actualizada");
            

        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            PeliculaDataGridView.ClearSelection();
            try
            {
                cn.Open();
                cm.Connection = cn;
                adapter = new SqlDataAdapter("delete from  Categoria where Id='" + IdTextBox.Text + "'", cn);
                adapter.Fill(dt);


            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
            MessageBox.Show("Se eleminado la categoria");

            IdTextBox.Clear();
            DescripcionRichTextBox.Clear();
           
        }
    }
    }

