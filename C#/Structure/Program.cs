using System;

namespace Structure
{
    public struct department
    {
        public int deptid;
        public string deptname;
      
    }
    //nesting department
     struct student
    {
       public string name;
       public int age;
       public int weight;

       public department d1;      
    }
   
    internal class Program
    {
        static void Main(string[] args)
        {
            student s1;
            s1.name = "Deepti Dabhi";
            s1.age = Math.Abs(2002-2024);
            s1.weight = 60;
            s1.d1.deptid = 101;
            s1.d1.deptname = "BCA";
            Console.WriteLine("Value Of S1 : ");
            Console.WriteLine(s1.name + " " + s1.age + " " + s1.weight);
            Console.WriteLine(s1.name+" is from "+s1.d1.deptname+" "+ "department");

            //copy values of s1 to s2
            student s2;
            s2 = s1;
            s2.name = "Vraj Bamaniya";
            s2.age =Math.Abs( 1995 - 2024);
            s2.weight = 65;
            s2.d1.deptid = 104;
            s2.d1.deptname = "MBA";
            Console.WriteLine("Value Of S2 : ");
            Console.WriteLine(s2.name + " " + s2.age + " " + s2.weight);
            Console.WriteLine(s2.name + " is from " + s2.d1.deptname + " " + "department");
        }
    }
}
