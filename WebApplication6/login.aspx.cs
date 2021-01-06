using System;
using System.Collections.Generic;
using Servicios;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication6
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            WebService1 operacion = new WebService1();
            string result = operacion.Login(txt_usuario.Text, txt_password.Text);
            if(result.Equals("correcto"))
            {
                Response.Redirect("Interfaz.aspx");
            }
            else
            {
                Response.Redirect("ERROR.aspx");
            }
        }
    }
}