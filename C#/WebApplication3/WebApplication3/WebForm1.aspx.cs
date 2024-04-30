using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls.WebParts;


namespace WebApplication3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("data source=DESKTOP-J9UGAK9\\SQLEXPRESS01; database=TEMPDB1; integrated security=SSPI"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select [User ID],[First Name],[Last Name] From Usertab", con);
                SqlDataReader dr = cmd.ExecuteReader();
                GridView1.DataSource = dr;
                GridView1.DataBind();
            }
        }
    }
}