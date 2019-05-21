using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PM.scripts.admin.userControls
{
    public partial class autenticacao : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            autenticarUsuario();
        }

        public void autenticarUsuario()
        {
            if (Session["coren"] != null)
            {

                if (String.IsNullOrEmpty(Session["coren"].ToString()))
                {
                    Response.Redirect("/scripts/admin/login.aspx");
               
                }
                else
                {
                    string coren = Session["coren"].ToString();
                }
            }
            else
            {
                Response.Redirect("/scripts/admin/login.aspx");
            }

        }
    }
}