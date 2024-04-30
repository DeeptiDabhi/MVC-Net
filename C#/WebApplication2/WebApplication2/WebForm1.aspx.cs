using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Web.Services.Description;
using System.Windows.Forms;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data source=DESKTOP-J9UGAK9\\SQLEXPRESS01; database=FullStack; integrated security=SSPI");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            //cmd.Parameters.Add(new SqlParameter("@StuID", SqlDbType.Int));
            //cmd.Parameters["@StuID"].Value = TextBox1.Text;

            cmd.Parameters.Add(new SqlParameter("@Name", SqlDbType.VarChar));
            cmd.Parameters["@Name"].Value = TextBox2.Text;

            cmd.Parameters.Add(new SqlParameter("@Email", SqlDbType.VarChar));
            cmd.Parameters["@Email"].Value = TextBox3.Text;

            cmd.Parameters.Add(new SqlParameter("@Contact", SqlDbType.VarChar));
            cmd.Parameters["@Contact"].Value = TextBox4.Text;

            //cmd.Parameters.Add(new SqlParameter("@DOB", SqlDbType.DateTime));
            //cmd.Parameters["@DOB"].Value = TextBox5.Text;

            cmd.Parameters.Add(new SqlParameter("@Age", SqlDbType.Int));
            cmd.Parameters["@Age"].Value = TextBox6.Text;

            cmd.CommandText = "Insert Into Students Values(@Name,@Email,@Contact,@Age)";

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Record Inserted");

        }
    }
}