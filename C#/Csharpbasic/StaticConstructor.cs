using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpbasic
{
    internal class StaticConstructor
    {
        static StaticConstructor() 
        {
            Console.WriteLine("I am static constructor so no need to create object of class for me");
        }
        public StaticConstructor(int i)
        {
            Console.WriteLine("Value of i : "+i); //1957
        }
        public static string detail(string name,int id)
        {
            return "Name : " + name + " id" + id;
        }
    }
}
