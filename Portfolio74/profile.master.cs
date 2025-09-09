using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Portfolio74
{
    public partial class profile : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                HttpCookie authCookie = Request.Cookies["AuthUser"];
                if (authCookie != null && !string.IsNullOrEmpty(authCookie.Value))
                {
                    logoutLink.Text = "Log Out";
                }
                else
                {
                    logoutLink.Text = "Log In";
                }
            }
        }
        protected void LogOut(object sender, EventArgs args)
        {
            if (Request.Cookies["AuthUser"] != null)
            {
                HttpCookie authCookie = new HttpCookie("AuthUser");
                authCookie.Expires = DateTime.Now.AddDays(-1);
                Response.Cookies.Add(authCookie);
                Response.Redirect("home.aspx", false);
                Context.ApplicationInstance.CompleteRequest();
            }
            else
            {
                Response.Redirect("login.aspx", false);
                Context.ApplicationInstance.CompleteRequest();
            }
        }
    }
}