using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Portfolio74
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void RedirectLinkedIn(object sender, EventArgs e)
        {
            Response.Redirect("https://www.linkedin.com/in/ziadul-hasan-7ab52a346/");
        }
    }
}