using System;
using System.Collections.Generic;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Entidades;

namespace Acceso_Datos
{
    public class productos
    {
        public int InsertarProducto(Productos pro)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=MEILYN;Initial Catalog=PruebaPay;"
            + "Integrated Security=true;";
            int ret = 0;

            using (SqlCommand cnd = new SqlCommand("insertarProducto", conn))
            {
                cnd.CommandType = CommandType.StoredProcedure;
                cnd.Parameters.Add("descripcion", SqlDbType.VarChar, 100).Value = pro.Descripcion;
                cnd.Parameters.Add("id_categoria", SqlDbType.VarChar, 100).Value = pro.Id_Categoria;
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                ret = cnd.ExecuteNonQuery();
            }

            return ret;
        }

        public int Modificar(Productos pro)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=MEILYN;Initial Catalog=PruebaPay;"
            + "Integrated Security=true;";
            int ret = 0;

            using (SqlCommand cnd = new SqlCommand("mofificarProducto", conn))
            {
                cnd.CommandType = CommandType.StoredProcedure;
                cnd.Parameters.Add("id_producto", SqlDbType.VarChar, 100).Value = pro.ID;
                cnd.Parameters.Add("descripcion", SqlDbType.VarChar, 100).Value = pro.Descripcion;
                cnd.Parameters.Add("id_categoria", SqlDbType.VarChar, 100).Value = pro.Id_Categoria;
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                ret = cnd.ExecuteNonQuery();
            }

            return ret;
        }


        public int deleteProducto(Productos pro)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=MEILYN;Initial Catalog=PruebaPay;"
            + "Integrated Security=true;";
            int ret = 0;

            using (SqlCommand cnd = new SqlCommand("eliminarProducto", conn))
            {
                cnd.CommandType = CommandType.StoredProcedure;
                cnd.Parameters.Add("id_producto", SqlDbType.VarChar, 100).Value = pro.id_producto;

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