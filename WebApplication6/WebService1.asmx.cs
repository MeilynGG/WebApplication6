using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace WebApplication6
{
    /// <summary>
    /// Descripción breve de WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]

    public class WebService1 : System.Web.Services.WebService
    {
      

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }

        [WebMethod]
        public DataSet WsListado()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=MEILYN;Initial Catalog=BasePrueba;"
        + "Integrated Security=true;";
            SqlDataAdapter da = new SqlDataAdapter("Select * from personas", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        [WebMethod]
        public int Insertar(string nombre, string ciudad)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=MEILYN;Initial Catalog=BasePrueba;"
            + "Integrated Security=true;";
            int ret=0;
           
                using (SqlCommand cnd = new SqlCommand("insertar", conn))
                {
                    cnd.CommandType = CommandType.StoredProcedure;
                    cnd.Parameters.Add("nombre", SqlDbType.VarChar, 100).Value = nombre;
                    cnd.Parameters.Add("ciudad", SqlDbType.VarChar, 100).Value = ciudad;
                    if (conn.State != ConnectionState.Open)
                    {
                        conn.Open();
                    }
                    ret = cnd.ExecuteNonQuery();
                }
            
            return ret;
        }

        [WebMethod]
        public int Modificar(int id_persona,string nombre, string ciudad)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=MEILYN;Initial Catalog=BasePrueba;"
            + "Integrated Security=true;";
            int ret = 0;

            using (SqlCommand cnd = new SqlCommand("modificar", conn))
            {
                cnd.CommandType = CommandType.StoredProcedure;
                cnd.Parameters.Add("id_persona", SqlDbType.VarChar, 100).Value = id_persona;
                cnd.Parameters.Add("nombre", SqlDbType.VarChar, 100).Value = nombre;
                cnd.Parameters.Add("ciudad", SqlDbType.VarChar, 100).Value = ciudad;
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                ret = cnd.ExecuteNonQuery();
            }

            return ret;
        }

        [WebMethod]
        public int delete(int id_persona)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=MEILYN;Initial Catalog=BasePrueba;"
            + "Integrated Security=true;";
            int ret = 0;

            using (SqlCommand cnd = new SqlCommand("eliminar", conn))
            {
                cnd.CommandType = CommandType.StoredProcedure;
                cnd.Parameters.Add("id_persona", SqlDbType.VarChar, 100).Value = id_persona;
           
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                ret = cnd.ExecuteNonQuery();
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
            sql = "select * from usuario where usuario.usuario='" + usuario + "'and usuario.password='" + password + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
         
            cmd = new SqlCommand(sql, conn);
            int verificar=1;/*= Convert.ToInt32(cmd.ExecuteNonQuery());*/
            if (verificar == 1)
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
