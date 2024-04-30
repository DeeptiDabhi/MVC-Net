using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click1(object sender, EventArgs e)
        {
            string con = "Data Source=DESKTOP-J9UGAK9\\SQLEXPRESS01;database=Practice;integrated security=SSPI;Encrypt=False";

            SqlConnection db=new SqlConnection(con);

            db.Open();

            string insert = "insert into StudentDetails(StuID,name,DOB,Address,Contact_No)values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "')";

            SqlCommand cmd = new SqlCommand(insert, db);

            int m=cmd.ExecuteNonQuery();

            if(m!=0)
            {
                Response.Write("<Script>alert('Data Inserted !!')</Script>");
            }
            else
            {
                Response.Write("<Script>alert('Data Inserted !!')</Script>");
            }
            db.Close();
        }
    }
}