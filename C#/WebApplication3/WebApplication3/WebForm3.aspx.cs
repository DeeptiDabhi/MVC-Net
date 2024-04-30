using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication3
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-J9UGAK9\\SQLEXPRESS01;Database=TEMPDB1;Integrated Security=SSPI"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from EmployeeInfo",con);
                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                DataSet ds=new DataSet();
                adpt.Fill(ds);
                GridView1.DataSource = ds;
                GridView1.DataBind();
            }
        }

        protected void Insert_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-J9UGAK9\\SQLEXPRESS01;Database=TEMPDB1;Integrated Security=SSPI"))
            {
                SqlCommand cmd = new SqlCommand("Masterinsertupdatedelete", con);
                cmd.CommandType =System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@StatementType", "Insert");
                cmd.Parameters.AddWithValue("@empid",int.Parse(TextBox1.Text));
                cmd.Parameters.AddWithValue("@name", TextBox2.Text);
                cmd.Parameters.AddWithValue("@dob", TextBox3.Text);
                cmd.Parameters.AddWithValue("@salary", TextBox4.Text);
                cmd.Parameters.AddWithValue("@gender", TextBox5.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                Response.Write("Value Added");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-J9UGAK9\\SQLEXPRESS01;Database=TEMPDB1;Integrated Security=SSPI"))
            {
                SqlCommand cmd = new SqlCommand("Masterinsertupdatedelete", con);
                cmd.CommandType=System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@StatementType", "Update");
                cmd.Parameters.AddWithValue("@empid", TextBox1.Text);
                cmd.Parameters.AddWithValue("@name", TextBox2.Text);
                cmd.Parameters.AddWithValue("@dob", TextBox3.Text);
                cmd.Parameters.AddWithValue("@salary", TextBox4.Text);
                cmd.Parameters.AddWithValue("@gender", TextBox5.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                Response.Write("Updated Successfully");
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            using(SqlConnection con = new SqlConnection("Data Source=DESKTOP-J9UGAK9\\SQLEXPRESS01;Database=TEMPDB1;Integrated Security=SSPI"))
            {
                SqlCommand cmd = new SqlCommand("Masterinsertupdatedelete", con);
                cmd.CommandType=System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@StatementType", "Delete");
                cmd.Parameters.AddWithValue("@empid", int.Parse(TextBox1.Text));
                cmd.Parameters.AddWithValue("@name", TextBox2.Text);
                cmd.Parameters.AddWithValue("@dob", TextBox3.Text);
                cmd.Parameters.AddWithValue("@salary", TextBox4.Text);
                cmd.Parameters.AddWithValue("@gender", TextBox5.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();    
            }
        }
    }
}