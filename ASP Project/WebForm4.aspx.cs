using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Cryptography.X509Certificates;

namespace ASP_Project
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetData();
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm5.aspx");
        }

        protected void btnclose_Click(object sender, EventArgs e)
        {
            
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex=e.NewEditIndex;
            GetData();
        }
        private void GetData() 
        {
            //string uname = Session["uname"].ToString();
            SqlConnection con = new SqlConnection("data source=DESKTOP-KL9O9K9;database=amazon;integrated security=yes");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from ASP ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "asp");
            GridView1.DataSource = ds;
            GridView1.DataBind();     
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow rows = GridView1.Rows[e.RowIndex];
            Label lbl = (Label)rows.FindControl("Label1");
            SqlConnection con = new SqlConnection("data source=DESKTOP-KL9O9K9;database=amazon;integrated security=yes");
            con.Open();
            string query = "delete from ASP where firstname='" +lbl.Text+ "'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            GetData();

        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row=GridView1.Rows[e.RowIndex];
            //Label t1 = (Label)row.FindControl("TextBox1");
            TextBox TextBox1 = (TextBox)row.FindControl("TextBox1");
            TextBox textBox2 = (TextBox)row.FindControl("TextBox2");
            SqlConnection con = new SqlConnection("data source=DESKTOP-KL9O9K9;database=amazon;integrated security=yes");
            con.Open();
            var query = "update ASP set firstname='" + TextBox1.Text + "'where lastname='" + textBox2.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            GridView1.EditIndex = -1;
            GetData();

        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            GetData();
        }
    }
}