using Entidades;
using Logica;
using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Entidades;

namespace Servicios
{
    /// <summary>
    /// Descripción breve de WSCategorias
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]

    public class WSCategorias : System.Web.Services.WebService
    {
        Logica_categorias cd = new Logica_categorias();
       

        [WebMethod]
        public int Insertar(Categoria cate)
        {

            int ret = 0;
            try
            {
               ret = cd.InsertarCategoria(cate);
            }
            catch (Exception)
            {

                throw;
            }
            return ret;
        }


        Logica_productos cdm = new Logica_productos();


        [WebMethod]
        public int InsertarPro(Productos pro)
        {

            int ret = 0;
            try
            {
                ret = cdm.InsertarProducto(pro);
            }
            catch (Exception)
            {

                throw;
            }
            return ret;
        }
        [WebMethod]
        public int ModificarProducto(Productos pro)
        {

            int ret = 0;
            try
            {
                ret = cdm.ModificarProducto(pro);
            }
            catch (Exception)
            {

                throw;
            }
            return ret;
        }

        [WebMethod]
        public int EliminarProducto(Productos pro)
        {

            int ret = 0;
            try
            {
                ret = cdm.ElimanrProducto(pro);
            }
            catch (Exception)
            {

                throw;
            }
            return ret;
        }

        [WebMethod]
        public int ModificarCate(Categoria cat )
        {

            int ret = 0;
            try
            {
                ret = cd.ModificarCategoria(cat);
            }
            catch (Exception)
            {

                throw;
            }
            return ret;
        }

        [WebMethod]
        public int EliminarCate(Categoria cat)
        {

            int ret = 0;
            try
            {
                ret = cd.EliminarCategoria(cat);
            }
            catch (Exception)
            {

                throw;
            }
            return ret;
        }

        [WebMethod]
        public string Login(string usuario, string password)
        {
            SqlConnection conn = new SqlConnection();
            string sql;
            conn.ConnectionString = "Data Source=MEILYN;Initial Catalog=PruebaPay;"
            + "Integrated Security=true;";
            sql = "select COUNT(*) from usuario where usuario.usuario='" + usuario + "'and usuario.password='" + password + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            int verificar = Convert.ToInt16(cmd.ExecuteScalar());
            if(verificar == 1)
            {
                return "correcto";
            }
            else
            {
                return "error al ingresar";
            }

           

        }

    }
}
