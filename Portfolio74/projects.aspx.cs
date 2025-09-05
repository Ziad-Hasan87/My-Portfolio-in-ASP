using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Portfolio74
{
    public partial class projects : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                HttpCookie authCookie = Request.Cookies["AuthUser"];
                if (authCookie != null && !string.IsNullOrEmpty(authCookie.Value))
                {
                    LoadProjects();
                }
                else
                {
                    Response.Redirect("home.aspx", false);
                    Context.ApplicationInstance.CompleteRequest();
                }
            }
        }
        private void LoadProjects()
        {
            string connStr = System.Configuration.ConfigurationManager
                               .ConnectionStrings["SqlConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(connStr);
            con.Open();
            string query = "SELECT Title, Description, GitHub_Link, ImageAddress FROM Projects";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            ProjectsRepeater.DataSource = dt;
            ProjectsRepeater.DataBind();
        }
    }
}