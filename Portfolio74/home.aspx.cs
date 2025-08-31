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
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadProjects();
            }
        }
        protected void RedirectLinkedIn(object sender, EventArgs e)
        {
            Response.Redirect("https://www.linkedin.com/in/ziadul-hasan-7ab52a346/");
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