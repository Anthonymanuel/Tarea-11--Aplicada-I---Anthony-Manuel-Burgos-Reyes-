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
     
            SqlConnection cn = new SqlConnection("Data Source =.\\SQLEXPRESS; Initial Catalog =Pelicula ; Integrated Security = True");
            SqlCommand Cm = new SqlCommand();
            try
            {
                cn.Open();
                Cm.Connection = cn;
                Cm.CommandText ="insert into Categoria(Descripcion) values ('"+DescripcionRichTextBox.Text+"')";
                Cm.ExecuteNonQuery();
            }catch(Exception )
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
            DescripcionRichTextBox.Clear();
        }
    }
}
