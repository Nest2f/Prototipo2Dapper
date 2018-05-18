using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using LogicaNegocios;

namespace Prototipo2Dapper.views
{
	public partial class RegisterUser1 : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}
        protected void register_Click(object sender, EventArgs e)
        {
            UsuarioLN data = new UsuarioLN();
            Usuario item = new Usuario();
            List<Usuario> lst = data.Mostrar();
            Boolean noExiste = true;
            item.ID = 0;
            item.nombrecompleto = register_nombres.Text;
            item.email = register_email.Text;
            item.usuario = register_user.Text;
            item.clave = register_pass.Text;
            item.rol = register_rol.Text;
            foreach (Usuario ite in lst)
            {
                if (ite.usuario.Equals(item.usuario))
                {
                    noExiste = false;
                }

            }
            if (noExiste)
            {
                data.Insertar(item);//inserta y se va home 
                ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "successCreateAcount();", true);
                //  Response.Redirect(GetRouteUrl("LoginRoute", null));
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "errorAlertUsuarioExiste();", true);
            }
        }
	}
}