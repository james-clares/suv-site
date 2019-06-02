using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PM.userControls
{
    public partial class autenticacao : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            autenticarUsuario();
        }

        

        public void autenticarUsuario()
        {
            if (Session["nome"] != null)
            {

                if (String.IsNullOrEmpty(Session["nome"].ToString()))
                {
                    Response.Redirect("../default.aspx");
                }
                else
                {
                    string nomeUsuario = Session["nome"].ToString();
                }
            }
            else
            {
                Response.Redirect("../default.aspx");
            }
           
        }
    }
}