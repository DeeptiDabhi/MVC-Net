using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpbasic
{
    internal class Datatypesandtypecasting
    {
        string Firstname;
        string Lastname;
        int Age;

        
        int value1 = 675;
        int value2 = 2675;
        long sum;


        //method without parameter
        public void getstudentdetails()
        {
            Console.Write("Enter First Name : ");
            Firstname = Console.ReadLine();
            Console.Write("Enter Last Name : ");
            Lastname = Console.ReadLine();
            Console.Write("Enter Age : ");
            Age = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Firstname is : "+Firstname);
            Console.WriteLine("Lastname is : "+Lastname);
            Console.WriteLine("Age is : "+Age);
           
        }

        //implicit type conversion method
        public void implicittypeconver()
        {
            sum = value1 + value2;
            Console.WriteLine("Sum of Value 1 and 2 is : " + sum);
        }
       
        //Explicit typeconversion method
        public void explicittypeconver()
        {
            double db = 7526.98;
             int x;

            x =(int)db;
            Console.WriteLine("Value of  x is :"+x);
        }
    }
}

