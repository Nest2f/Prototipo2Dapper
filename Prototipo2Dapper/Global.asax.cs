using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Routing;

namespace Prototipo2Dapper
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            RegisterRoutes(RouteTable.Routes);
        }
        void RegisterRoutes(RouteCollection routes)
        {
            //como se llama  // como se mostrara en el url // direccion page
            routes.MapPageRoute("LoginRoute", "views/Login", "~/views/Login.aspx");
            routes.MapPageRoute("HomeAdminRoute", "views/HomeAdmin", "~/views/HomeAdmin.aspx");            
            routes.MapPageRoute("RegisterRoute", "views/Register", "~/views/Register.aspx");

            //routes.MapPageRoute("PacientesRoute", "views/PacientesAll", "~/views/Usuarios.aspx");
            //routes.MapPageRoute("GruposRoute", "views/GruposAll", "~/views/Groups.aspx");
            //routes.MapPageRoute("PlantogramaRoute", "views/PlantogramaAll", "~/views/Plantograma.aspx");
            //routes.MapPageRoute("PlantogramaShowRoute", "views/PlantogramaShow", "~/views/PlantogramaVer.aspx");
            //routes.MapPageRoute("viewResltados", "views/viewResltados", "~/views/viewResltados.aspx");
            //ponemos todas las direcciones
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}