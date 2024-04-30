using System;
using System.Collections.Generic;
using System.Linq;

namespace ConLINQ1
{
    class Student
    {
        public int id { get; set; }
        public string name { get; set; }    
        public int age { get; set; }
    }
    class Employee
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public int EmployeeAge { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Query Expression
            //string collection
            IList<string> learn = new List<string>()
            {
                "HTML","CSS","JS","TS","Angular"
            };

            //linq query 
            var Result = from l in learn
                         where l.Contains("Angular")
                         select l;

            foreach (var re in Result)
            {
                Console.WriteLine("Learn : " + re);
            }

            //string collection
            IList<Student> student = new List<Student>()
            {
                new Student() {id=1,name="Deepti",age=22},
                new Student() {id=2,name="Vraj",age=29},
                new Student() {id=3,name="Khushbu",age=33},
                new Student() {id=4,name="Jay",age=34},
                new Student() {id=5,name="Smit",age=26},
                new Student() {id=6,name="Het",age=21},
                new Student() {id=7,name="Harshita",age=20}
            };

            var Result1 = from s in student
                          where s.age >= 20 && s.age <= 30
                          select s;

            foreach (var r in Result1)
            {
                Console.WriteLine(r.id + " " + r.name);
            }

            //method expresion
            //string collection
            IList<string> fruits = new List<string>()
            {
                "Apple",
                "Banana",
                "Graps",
                "Pinaple",
                "Strawberry",
                "Avocado",
                "Mango"
            };

            //linq method
            var result2 = fruits.Where(s => s.Contains("Mango"));

            foreach (var f in result2)
            {
                Console.WriteLine("My Fav Fruit is : " + f);
            }

            //string collection
            IList<Employee> EmpDetails = new List<Employee>()
            {
                new Employee() { EmployeeID = 101, EmployeeName = "Ruchir", EmployeeAge = 26 },
                new Employee() { EmployeeID = 102, EmployeeName = "Nirav", EmployeeAge = 25 },
                new Employee() { EmployeeID = 103, EmployeeName = "Fairy", EmployeeAge = 21 },
                new Employee() { EmployeeID = 104, EmployeeName = "Rajshree", EmployeeAge = 29 },
                new Employee() { EmployeeID = 105, EmployeeName = "Neha", EmployeeAge = 30 },
            };

            var Result3 = EmpDetails.Where(e => e.EmployeeAge > 25);

            foreach(var e in Result3)
            {
                Console.WriteLine(e.EmployeeID + " " + e.EmployeeName);
            }
        }
    }
}
