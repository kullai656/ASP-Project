using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_Project
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Session["username"] = "guna";
            string username = string.Empty;
             //Session["username"].ToString();
            string roomtype=string.Empty;
            string aminities=string.Empty;
            SqlConnection con = new SqlConnection("data source=DESKTOP-KL9O9K9;database=amazon;integrated security=yes");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from hoteldetails", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds,"hoteldetails");
            GridView1.DataSource = ds;
            GridView1.DataBind();
            getdetails();
        }
        private void getdetails()
        {
            Label1.Text = "Welcome to " + Session["username"].ToString() + "roomtype:" + Session["roomtype"].ToString() + Session["aminities"].ToString();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}