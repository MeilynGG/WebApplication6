using Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication6
{
    public partial class Interfaz : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }


            protected void btn_guardar_Click(object sender, EventArgs e)
        {
           WSCate.WSCategorias objTest = new WSCate.WSCategorias();
            Categoria cate = new Categoria();
            cate.Tipo= txt_categoria.Text;
           // cate.IdCategoria = Convert.ToInt32(txt_ciudad.Text);

            int ret= objTest.Insertar(cate);
            if (ret > 0)
            {
                Label1.Text = "guardado";
            }
            else
            {
                Label1.Text = "error";
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            WebService1 obj = new WebService1();
          //  int ret = obj.Modificar(Convert.ToInt32(TextBox3.Text), TextBox1.Text, TextBox2.Text);
            /*if (ret > 0)
            {
                Label1.Text = "modificado";
            }
            else
            {
                Label1.Text = "error";
            }*/
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            WebService1 obj = new WebService1();
           // int ret = obj.delete(Convert.ToInt32(TextBox3.Text));
           /* if (ret > 0)
            {
                Label1.Text = "eliminado";
            }
            else
            {
                Label1.Text = "error";
            }*/
        }

        protected void btn_modificar_Click(object sender, EventArgs e)
        {
            WSCate.WSCategorias objTest = new WSCate.WSCategorias();
            Categoria cate = new Categoria();
            cate.Tipo = txt_categoria.Text;
             cate.IdCategoria = Convert.ToInt32(txt_id.Text);

            int ret = objTest.ModificarCate(cate);
            if (ret > 0)
            {
                Label1.Text = "guardado";
            }
            else
            {
                Label1.Text = "error";
            }

           

        }

        protected void btn_gur_Click(object sender, EventArgs e)
        {
            WSCate.WSCategorias objTest = new WSCate.WSCategorias();
            Categoria cate = new Categoria();
            cate.Tipo = txt_categoria.Text;
            // cate.IdCategoria = Convert.ToInt32(txt_ciudad.Text);

            int ret = objTest.Insertar(cate);
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
            Categoria cate = new Categoria();
            cate.Tipo = txt_categoria.Text;
             cate.IdCategoria = Convert.ToInt32(txt_id.Text);

           int ret = objTest.EliminarCate(cate);
            if (ret > 0)
            {
                Label1.Text = "eliminado";
            }
            else
            {
                Label1.Text = "error";
            }
            
        }
    }
}