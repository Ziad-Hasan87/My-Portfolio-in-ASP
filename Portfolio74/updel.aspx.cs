using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Portfolio74
{
    public partial class updel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                HttpCookie authCookie = Request.Cookies["AuthUser"];
                if (authCookie != null && !string.IsNullOrEmpty(authCookie.Value))
                {
                    string title = Request.QueryString["title"];
                    ViewState["tit"]= title;
                    if (!string.IsNullOrEmpty(title))
                    {
                        LoadProject(title);
                        updateBtn.Visible = true;
                        deleteBtn.Visible = true;
                        addBtn.Visible = false;
                    }
                    else
                    {
                        updateBtn.Visible = false;
                        deleteBtn.Visible = false;
                        addBtn.Visible = true;
                    }
                }
                else
                {
                    Response.Redirect("home.aspx", false);
                    Context.ApplicationInstance.CompleteRequest();
                }
            }
        }
        protected void LoadProject(string title)
        {
            string conn = System.Configuration.ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString;
            using(SqlConnection con = new SqlConnection(conn))
            {
                string query = "SELECT Title, Description, GitHub_Link, ImageAddress FROM Projects WHERE Title = @Title";
                using (SqlCommand cmd = new SqlCommand(query, con)) {
                    cmd.Parameters.AddWithValue("@Title", title);
                    con.Open();
                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            titlebox.Text = reader["Title"].ToString();
                            descriptionbox.Text = reader["Description"].ToString();
                            githublinkbox.Text = reader["Github_link"].ToString();
                        }
                    }
                    con.Close();
                }
            }
        }
        protected void AddProject(object sender, EventArgs args)
        {
            string title = titlebox.Text;
            string description = descriptionbox.Text;
            string github = githublinkbox.Text;
            string conn = System.Configuration.ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(conn))
            {
                string query = "INSERT INTO Projects (Title, Description, GitHub_Link)\r\nVALUES (@Title, @Description, @Github)\r\n";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Title", title);
                cmd.Parameters.AddWithValue("@Github", github);
                cmd.Parameters.AddWithValue("@Description", description);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                Response.Redirect("projects.aspx", false);
                Context.ApplicationInstance.CompleteRequest();
            }
        }
        protected void UpdateProject(object sender, EventArgs args)
        {
            string title = titlebox.Text;
            string description = descriptionbox.Text;
            string github = githublinkbox.Text;
            string conn = System.Configuration.ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString;
            using(SqlConnection con = new SqlConnection(conn))
            {
                string query = "UPDATE Projects SET Title = @Title, Description = @Description, GitHub_Link = @Github WHERE Title=@Tit";
                SqlCommand cmd = new SqlCommand(query, con);
                string tit = ViewState["tit"]?.ToString();
                cmd.Parameters.AddWithValue("@Tit", tit);
                cmd.Parameters.AddWithValue("@Title", title);
                cmd.Parameters.AddWithValue("@Github", github);
                cmd.Parameters.AddWithValue("@Description", description);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                Response.Redirect("projects.aspx", false);
                Context.ApplicationInstance.CompleteRequest();
            }
        }
        protected void DeleteProject(object sender, EventArgs args)
        {
            string title = titlebox.Text;
            string conn = System.Configuration.ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(conn))
            {
                string query = "DELETE FROM Projects WHERE Title = @Title";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Title", title);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                Response.Redirect("projects.aspx", false);
                Context.ApplicationInstance.CompleteRequest();
            }
        }
    }
}