using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpbasic
{
    internal class Constructor
    {
        string name;
        int age;
        public static int count;
       

        //default constructor
       public Constructor() {
            //multiplication of 3 values;
           int a = 10;
           int b = 29;
           int c=98;
           int multi = a * b * c;
           Console.WriteLine("Multiplication of 3 values using default constructor : "+multi);           
        }
        //parameterized constructor
        public Constructor(string name, int age)
        {
            this.name = name;
            this.age=age;
            Console.WriteLine("Using Parameter Name is : " + name);
            Console.WriteLine("Using Parameter Age is : " + age);
        }
        //copy constructor
        public Constructor(Constructor c)
        {
            this.name = c.name;
            this.age=c.age;
            Console.WriteLine("Using Copy Name is : " + name);
            Console.WriteLine("Using Copy Age is : " + age);
        }
    }
}
