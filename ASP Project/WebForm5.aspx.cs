using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace ASP_Project
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string Username=TextBox1.Text;
            string Roomtype=RadioButton1.Text;
            string Aminites=CheckBox1.Text;
             //string uname = "";
            // uname = Session["username"] as string;
            Session["username"] = Username;
            Session["roomtype"]=Roomtype;
            Session["aminities"] =Aminites;

            int finalcoast = 0, Acoast = 0, Roomrent = 0;
            if(RadioButton1.Checked==true)
            {
                Roomtype = RadioButton1.Text;
                Roomrent = 3000;
            }
            if(RadioButton2.Checked == true)
            {
                Roomtype = RadioButton2.Text;
                Roomrent = 2000;
            }
            if(CheckBox1.Checked == true)
            {
                Aminites = CheckBox1.Text;
                Acoast = Acoast + 800;
            }
            if (CheckBox2.Checked == true)
            {
                Aminites = CheckBox2.Text;
                Acoast = Acoast + 500;
            }
            finalcoast=Acoast+Roomrent;
           Label5.Text=TextBox1.Text+"you have to pay"+finalcoast;
           //if(Username==uname)
            
                SqlConnection con=new SqlConnection("data source=DESKTOP-KL9O9K9;database=amazon;integrated security=yes");
                con.Open();
                string query = "insert into hoteldetails values('" + Username + "','" + Roomtype + "','" + Aminites + "','" + finalcoast + "')";
                SqlCommand cmd=new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                Response.Redirect("WebForm6.aspx");

            
        }
    }
}