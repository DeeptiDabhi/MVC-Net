using Microsoft.Data.SqlClient;
using System;
using System.Data.SqlClient;
using System.Net;

namespace Createconnandtab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program p=new Program();
            //p.CreateTable();

            //p.InsertData();

            p.RetrieveData();

           //p.DeleteData();
        }
        public void CreateTable()
        {
            SqlConnection con = null;
            //create connection
           con = new SqlConnection("data source=DESKTOP-J9UGAK9\\SQLEXPRESS01;database=Practice;integrated security=SSPI;Encrypt=False");

            //writing sql query
            SqlCommand cmd = new SqlCommand("Create Table StudentDetails(StuID int not null,name varchar(20) not null,DOB date,Address varchar(50),Contact_No varchar(10))",con);
            
            //opening connection
            con.Open();

            //executing sql query
            cmd.ExecuteNonQuery();

            //display message
            Console.WriteLine("Table Created Successfully");

            //close connection
            con.Close();
        }
        public void InsertData()
        {
            //create connection
            SqlConnection con = new SqlConnection("data source=DESKTOP-J9UGAK9\\SQLEXPRESS01;database=Practice;integrated security=SSPI;Encrypt=False");

            //writing sql query
            SqlCommand cmd = new SqlCommand("insert into StudentDetails(StuID,name,DOB,Address,Contact_No)Values(5,'Nimita','1997-8-18','RajmahelRoad','8897486181')",con);

            //opening connection
            con.Open();

            //executing query
            cmd.ExecuteNonQuery();

            //Display message
            Console.WriteLine("1 Row Inserted To StudentDetails");

            //close connection
            con.Close() ;   
           
        }
        //Retrive Data
        public void RetrieveData()
        {
            //creating connection
            SqlConnection con =new SqlConnection("data source=DESKTOP-J9UGAK9\\SQLEXPRESS01;database=Practice;integrated security=SSPI;Encrypt=False");

            //writing sql query
            SqlCommand cmd = new SqlCommand("Select * From StudentDetails", con);

            //opening connection
            con.Open();

            //executing query
            SqlDataReader sdr=cmd.ExecuteReader();

            //Select Which Data To be display
            while(sdr.Read())
            {
                Console.WriteLine(sdr["StuID"] + " " + sdr["name"] + " " + sdr["DOB"] + " " + sdr["Contact_No"]);
            }

            //connection close
            con.Close ();
        }
        //Deleting Data
        public void DeleteData()
        {
            SqlConnection con = new SqlConnection("data source=DESKTOP-J9UGAK9\\SQLEXPRESS01;database=Practice;Integrated Security=SSPI;Encrypt=False");

            SqlCommand cmd = new SqlCommand("Delete From StudentDetails Where StuID='4'",con);

            con.Open();

            cmd.ExecuteNonQuery();

            Console.WriteLine("Record Delete Successfully");

        }

    }
}
