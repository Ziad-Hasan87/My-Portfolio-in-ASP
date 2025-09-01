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
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void LogIn(object sender, EventArgs args)
        {
            string connStr = System.Configuration.ConfigurationManager
                               .ConnectionStrings["SqlConnection"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                string sql = "SELECT COUNT(*) FROM admins WHERE username=@un AND password=@pw";

                using (SqlCommand query = new SqlCommand(sql, conn))
                {
                    query.Parameters.Add("@un", SqlDbType.VarChar, 50).Value = usernamebox.Text.Trim();
                    query.Parameters.Add("@pw", SqlDbType.VarChar, 50).Value = passwordbox.Text.Trim();

                    int userCount = (int)query.ExecuteScalar();

                    if (userCount > 0)
                    {
                        // Login successful
                        Response.Redirect("updel.aspx", false);
                        Context.ApplicationInstance.CompleteRequest();
                    }
                    else
                    {
                        errorlabel.Text = "Invalid username or password.";
                    }
                }
            }
        }




    }
}