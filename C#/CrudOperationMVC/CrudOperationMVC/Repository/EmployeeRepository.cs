using CrudOperationMVC.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CrudOperationMVC.Repository
{
    public class EmployeeRepository
    {
        private SqlConnection con;

        private void connection()
        {
            string constr = ConfigurationManager.ConnectionStrings["getconnection"].ToString();
            con = new SqlConnection(constr);
        }

        public bool AddEmployee(EmployeeModel EmpMod)
        {
            connection();
            SqlCommand cmd = new SqlCommand("AddnewEmployeeDetails", con);
            cmd.CommandType=CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Name", EmpMod.Name);
            cmd.Parameters.AddWithValue("@Address", EmpMod.Address);
            cmd.Parameters.AddWithValue("@City",EmpMod.City);
            cmd.Parameters.AddWithValue("@Contact", EmpMod.Contact);

            con.Open();
            int exc= cmd.ExecuteNonQuery();
            con.Close();

            if(exc>=1)
            {
                return true;
            }
            else
            {
                return false;
            }   
        }
        public bool UpdateEmployee(EmployeeModel empmod)
        {
            connection();
            SqlCommand cmd = new SqlCommand("UpdateEmployeeDetails",con);
            cmd.CommandType=CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@EmpID", empmod.ID);
            cmd.Parameters.AddWithValue("@Name", empmod.Name);
            cmd.Parameters.AddWithValue("@Address", empmod.Address);
            cmd.Parameters.AddWithValue("@City", empmod.City);
            cmd.Parameters.AddWithValue("@Contact", empmod.Contact);
            con.Open();
            int exc=cmd.ExecuteNonQuery();  
            con.Close();

            if(exc>=1) {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool DeleteEmployee(int id)
        {
            connection();
            SqlCommand cmd = new SqlCommand("DeleteEmployeeDetails", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@EmpID", id);
            con.Open( );
            int exc=cmd.ExecuteNonQuery();
            con.Close( );

            if(exc>=1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public List<EmployeeModel> GetEmployeeList() 
        {
            connection();
            List<EmployeeModel> EmpList=new List<EmployeeModel>();

            SqlCommand cmd = new SqlCommand("ShowEmployeeDetails",con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            con.Open();
            da.Fill(dt);
            con.Close();

            foreach(DataRow dr in dt.Rows)
            {
                EmpList.Add(
                  new EmployeeModel
                  {
                      ID = Convert.ToInt32(dr["ID"]),
                      Name = Convert.ToString(dr["Name"]),
                      Address = Convert.ToString(dr["Address"]),
                      City = Convert.ToString(dr["City"]),
                      Contact = Convert.ToString(dr["Contact"]),
                  }
                );
            }
           return EmpList;
        }

    }
}