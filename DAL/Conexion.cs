using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace DAL
{
    public class Conexion
    {
        private SqlConnection con;
        private SqlCommand Cmd;

        public Conexion()
        {
            con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Pelicula;Integrated Security=True");
            Cmd = new SqlCommand();
        }

        
        public bool Ejecutar(String Comando)
        {
            bool retorno = false;

            try
            {
                con.Open();
                Cmd.Connection = con;
                Cmd.CommandText = Comando;
                Cmd.ExecuteNonQuery();
                retorno = true;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }

            return retorno;
        }

        public DataTable ObtenerDatos(String Comando)
        {

            SqlDataAdapter adapter;
            DataTable dt = new DataTable();

            try
            {
                con.Open();
                Cmd.Connection = con;
                Cmd.CommandText = Comando;

                adapter = new SqlDataAdapter(Cmd);
                adapter.Fill(dt);

            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                con.Close();
            }

            return dt;
        }
    }
}
