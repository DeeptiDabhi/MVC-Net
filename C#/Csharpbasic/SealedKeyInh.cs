using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpbasic
{
    internal class SealedKeyInh
    {

    }
    class A
    { 
        public A() {
            Console.WriteLine("I Am Base Class A");
        }
    }
    class B:A
    {
        public B()
        {
            Console.WriteLine("I Am Derived Class B");
        }
    }
    class C : B
    {
        public C() {
            Console.WriteLine("I Am Derived Class Of Base Class B");
        }
    }
}
