using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_Project
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string firstname, lastname, username, password, confirmpassowd, gender, email, phone, address,
            age, languageknow, contry;
            firstname = TextBox1.Text;
            lastname = TextBox2.Text;
            username = TextBox3.Text;
            password = TextBox4.Text;
            confirmpassowd = TextBox5.Text;
            gender=string.Empty;
            if(RadioButton1.Checked)
            {
                gender=RadioButton1.Text;
            }
            else
            {
                gender=RadioButton2.Text;
            }
            email = TextBox6.Text;
            phone = TextBox7.Text;
            address = TextBox9.Text;
            age=TextBox8.Text;
            languageknow=string.Empty;
            if(CheckBox1.Checked==true)
            {
                languageknow = languageknow + CheckBox1.Text + " ";
            }
            if(CheckBox2.Checked==true)
            {
                languageknow=languageknow + CheckBox2.Text + " ";
            }
            if(CheckBox3.Checked==true)
            {
                languageknow=languageknow+ CheckBox3.Text + " ";
            }
            contry = DropDownList1.SelectedValue.ToString();
            SqlConnection con = new SqlConnection("data source=DESKTOP-KL9O9K9;database=amazon;integrated security=yes");
            con.Open();
            string query= "insert into ASP values('" + TextBox1.Text+ "','" + TextBox2.Text + "','" + TextBox3.Text + "','" +
                            TextBox4.Text + "','" + TextBox5.Text + "','" + gender + "','" + TextBox6.Text + "','" + TextBox7.Text + "','" +
                            TextBox9.Text + "','" + TextBox8.Text + "','" + languageknow + "','" + contry + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            Response.Write(" " + cmd.ExecuteNonQuery());
            con.Close();
            Response.Write("register success fully!!");
            Response.Redirect("/WebForm2.aspx");
        }
    }
}