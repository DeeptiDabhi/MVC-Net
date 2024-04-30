using System;
using ClassLibrary3;

namespace Extensionmethod
{
    public static class extensionclass
    {
        public static void method(this Class1 c1)
        {
            Console.WriteLine("Extended method");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 c1 = new Class1();
            c1.display();
            c1.print();
            c1.method();
        }
    }
}
