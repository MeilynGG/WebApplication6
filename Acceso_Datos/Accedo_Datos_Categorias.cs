using System;
using System.Collections.Generic;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Entidades;

namespace Acceso_Datos
{
    public class Accedo_Datos_Categorias
    {
        public int Insertar(Categoria cate)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=MEILYN;Initial Catalog=PruebaPay;"
            + "Integrated Security=true;";
            int ret = 0;

            using (SqlCommand cnd = new SqlCommand("insertarCategoria", conn))
            {
                cnd.CommandType = CommandType.StoredProcedure;
                cnd.Parameters.Add("tipo", SqlDbType.VarChar, 100).Value = cate.Tipo;
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                ret = cnd.ExecuteNonQuery();
            }

            return ret;
        }
        public int Modificar(Categoria cate)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=MEILYN;Initial Catalog=PruebaPay;"
            + "Integrated Security=true;";
            int ret = 0;

            using (SqlCommand cnd = new SqlCommand("modificarCategoria", conn))
            {
                cnd.CommandType = CommandType.StoredProcedure;
                cnd.Parameters.Add("id_categoria", SqlDbType.VarChar, 100).Value = cate.IdCategoria ;
                cnd.Parameters.Add("tipo", SqlDbType.VarChar, 100).Value = cate.Tipo;
               
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                ret = cnd.ExecuteNonQuery();
            }

            return ret;
        }

        
        public int deleteCategoria(Categoria cate)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=MEILYN;Initial Catalog=PruebaPay;"
            + "Integrated Security=true;";
            int ret = 0;

            using (SqlCommand cnd = new SqlCommand("eliminarCategoria", conn))
            {
                cnd.CommandType = CommandType.StoredProcedure;
                cnd.Parameters.Add("id_categoria", SqlDbType.VarChar, 100).Value = cate.IdCategoria;

                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                ret = cnd.ExecuteNonQuery();
            }

            return ret;
        }
    }
}