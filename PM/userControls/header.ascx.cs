using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PM.biblioteca;

namespace PM.userControls
{
    public partial class header : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //mudarVisibilidade();
        }

        /*protected void mudarVisibilidade()
        {
            acessoSistema perfilPaciente = new acessoSistema();
            string teste =  Session["cpf"].ToString();
            bool validaPaciente = perfilPaciente.perfilPaciente(Session["cpf"].ToString());
            bool validaADM = perfilPaciente.perfilADM(Session["cpf"].ToString());

            plhPerfilUsuario.Visible = false;
            plhPerfilADM.Visible = false;

            if (validaPaciente)
            {
                plhPerfilUsuario.Visible = true;
            }
            if (validaADM)
            {
                plhPerfilADM.Visible = true;
            }

            
          

            

        }*/
    }
}