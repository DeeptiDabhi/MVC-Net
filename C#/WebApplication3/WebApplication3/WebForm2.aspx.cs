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
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-J9UGAK9\\SQLEXPRESS01;Database=EmpDeptMaster;Integrated Security=SSPI"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select EmployeeHistoryID,EmpID,DeptID,DateOfResigning,DateOfReleaving,EmployeeStatus From EmployeeHistory",con);
                SqlDataAdapter sda=new SqlDataAdapter(cmd);
                DataSet ds= new DataSet();
                sda. Fill(ds);
                GridView1.DataSource= ds;
                GridView1.DataBind();
            }
        }

    }
}