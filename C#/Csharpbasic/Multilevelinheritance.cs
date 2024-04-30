using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpbasic
{
    internal class Multilevelinheritance
    {
    }
    class GrandFather
    {
        public GrandFather() 
        {
            Console.WriteLine("I Am GrandFather");
        }
    }
    class Father:GrandFather
    {
        public Father()
        {
            Console.WriteLine("I Am Father");
        }
    }
    class Son:Father
    {
        public Son()
        {
            Console.WriteLine("I Am Son");
        }
    }
}
