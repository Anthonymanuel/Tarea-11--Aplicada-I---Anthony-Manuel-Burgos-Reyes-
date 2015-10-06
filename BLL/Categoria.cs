using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
namespace BLL
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string Descripcion { get; set; }

        public Categoria()
        {
            this.CategoriaId = 0;
            this.Descripcion = "";
        }
        public Categoria(int CateID, string Descrip)
        {
            this.CategoriaId = CateID;
            this.Descripcion = Descrip;
        }
        public bool Insertar()
        {
            bool retorno = false;

            Conexion conexion = new Conexion();

            conexion.Ejecutar(String.Format("Insert Into Categoria (Descripcion) Values('{0}')", this.Descripcion));

            return retorno;

        }
        public DataTable Buscar()
        {

            Conexion conexion = new Conexion();

            return conexion.ObtenerDatos(String.Format("select   ID ,Descripcion from Categoria where Id={0}", this.CategoriaId));
        }

        public DataTable Eliminar()
        {
            Conexion conexion = new Conexion();

            return conexion.ObtenerDatos(String.Format("delete  from Categoria where Id={0}", this.CategoriaId));
        }

        public bool Actualizar()
        {
            Conexion conexion = new Conexion();
            bool act = false;
            conexion.Ejecutar(String.Format("update Categoria set Descripcion='{0}' where Id = '{1}'",this.Descripcion, this.CategoriaId));
            return act;
        }
    }
}
