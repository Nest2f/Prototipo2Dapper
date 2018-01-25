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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void login_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.nombre = login_username.Text != null ? login_username.Text : "";
            usuario.apellidos = login_password.Text != null ? login_password.Text : "";
            UsuarioLN lnUsuario = new UsuarioLN();

            usuario = lnUsuario.Login(usuario);
            if (usuario != null)
            {
                //guarda datos en session 
                //si se logeo corectamente
                Session["logeado"] = true;
                Session["ID"] = usuario.ID;
                Session["nombres"] = usuario.nombre;
                Session["apellidos"] = usuario.apellidos;
                // Response.Redirect("HomeAdmin.aspx");
                Response.Redirect(GetRouteUrl("LoginRoute", null));
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