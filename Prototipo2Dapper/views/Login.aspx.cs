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
    public partial class Login1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void login_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.usuario = username.Text != null ? username.Text : "";
            usuario.clave = password.Text != null ? password.Text : "";
            UsuarioLN lnUsuario = new UsuarioLN();

            usuario = lnUsuario.Login(usuario);
            if (usuario != null)
            {
                //guarda datos en session 
                //si se logeo corectamente
                Session["logeado"] = true;
                Session["ID"] = usuario.ID;
                Session["usuario"] = usuario.usuario;
                Session["clave"] = usuario.clave;
                // Response.Redirect("HomeAdmin.aspx");
                Response.Redirect(GetRouteUrl("MainRoute", null));
            }
            else
            {
                //string script = @"<script type='text/javascript'>
                //                alert('Error En Nombre de Usuario o Contraseña ');
                //            </script>";
                ////el script esta en js / app / appAlers.js
                //ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "errorAlertLogin();", true);
                //ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "AlertRedirect('Actualización','Correcta','success','OK','Register');", true);
                ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "AlertNoRedirect('Error!','Usuario o Contraseña Incorrectos','error','OK');", true);
                //ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "AlertReload('Error!','Usuario o Contraseña Incorrectos','error','OK');", true);
            }
        }
    }
}