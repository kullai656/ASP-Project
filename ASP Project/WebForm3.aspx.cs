using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_Project
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string username, password;
                username = TextBox1.Text;
                Session["uname"] = username;
             //   password = TextBox2.Text;
                SqlConnection conn = new SqlConnection("data source=DESKTOP-KL9O9K9;database=amazon;integrated security=yes");
                conn.Open();
                string query = "select password from ASP where username='" + username + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                password = cmd.ExecuteScalar().ToString();

                if (password == TextBox2.Text)
                {
                    Response.Write("Vaild sucessfull");
                    Response.Redirect("/WebForm4.aspx");

                }
                else
                {
                    Response.Write("Invalid Credentials");
                }

            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}