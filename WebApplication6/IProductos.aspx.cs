using System;
using System.Collections.Generic;
using Entidades;
using Servicios;

using Newtonsoft.Json;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication6
{
    public partial class IProductos : System.Web.UI.Page
    {

       
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }

        protected void btn_modificar_Click(object sender, EventArgs e)
        {
            WSCate.WSCategorias objTest = new WSCate.WSCategorias();
            Productos pro = new Productos();
            pro.ID= Convert.ToInt32(txt_producto.Text);
            pro.Descripcion = txt_descripcion.Text;
            pro.Id_Categoria = Convert.ToInt32(txt_categoria.Text);
            // cate.IdCategoria = Convert.ToInt32(txt_ciudad.Text);

             int ret = objTest.ModificarProducto(pro);
              if (ret > 0)
              {
                  Label1.Text = "guardado";
              }
              else
              {
                  Label1.Text = "error";
              }
        }

        protected void btn_eliminar_Click(object sender, EventArgs e)
        {
            WSCate.WSCategorias objTest = new WSCate.WSCategorias();
            Productos pro = new Productos();
            pro.id_producto = Convert.ToInt32(txt_producto.Text);
            // cate.IdCategoria = Convert.ToInt32(txt_ciudad.Text);

            int ret = objTest.EliminarProducto(pro);
            if (ret > 0)
            {
                Label1.Text = "eliminado";
            }
            else
            {
                Label1.Text = "error";
            }
        }

        protected void btn_guardar_Click(object sender, EventArgs e)
        {
            WSCate.WSCategorias objTest = new WSCate.WSCategorias();
            Productos pro = new Productos();
            pro.Descripcion = txt_descripcion.Text;
            pro.Id_Categoria = Convert.ToInt32(txt_categoria.Text);

            int ret = objTest.InsertarPro(pro);
            if (ret > 0)
            {
                Label1.Text = "guardado";
            }
            else
            {
                Label1.Text = "error";
            }
        }
    }
}