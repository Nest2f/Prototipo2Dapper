using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prototipo2Dapper
{
    public partial class View : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SetCurrentPage();
        }
        private void SetCurrentPage()
        {
            var pageName = GetPageName();

            switch (pageName)
            {
                case "/views/Index.aspx":
                    home.Attributes["class"] = "active";
                    break;
                case "/views/Requirement.aspx":
                    service.Attributes["class"] = "active";
                    break;
                case "views/Login.aspx":
                    login.Attributes["class"] = "active";
                    break;



            }
        }
        private string GetPageName()
        {
            return Request.Url.ToString().Split('/').Last();
        }
    }
}