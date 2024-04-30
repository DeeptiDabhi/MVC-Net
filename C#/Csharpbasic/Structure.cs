using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpbasic
{
    public  class Structure
    {
        //struct similar to classes and it has behaviour and attributes as a value type
        public struct Student
        {
           public int id;
           int zipcode;
           double salary;

            //initialize like this way 1
            public Student(int id, int zipcode, double salary)
            {
                this.id = id;
                this.zipcode = zipcode;
                this.salary = salary;
            }
            //initialize like this way 2
            public Student(int zipcode)
            {
                this.id = 101;
                this.zipcode = zipcode;
                this.salary = 60000.00;
            }         
            // struct can also have copy constructor but have to be fully initialzed  
            public Student(Student x)
            {
                this.id=x.id;   
                this.zipcode = x.zipcode;   
                this.salary=x.salary;   
            }
            public void  Displayvalues()
            {
                Console.WriteLine("ID : "+ this.id);
                Console.WriteLine("Zipcode : " +this. zipcode);
                Console.WriteLine("Salary : "+this.salary);
            }
        }
    }
}
