using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Portfolio74
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                HttpCookie authCookie = Request.Cookies["AuthUser"];
                if (authCookie != null && !string.IsNullOrEmpty(authCookie.Value))
                {
                    loginLink.Text = authCookie.Value;
                    loginLink.NavigateUrl = "projects.aspx";
                    // Already logged 
                }
                else
                {
                    loginLink.Text = "Log In";
                    loginLink.NavigateUrl = "login.aspx";
                }
            }
        }
    }
}