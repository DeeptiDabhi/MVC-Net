using ExtensionMethods;
using System;
using System.Text;

namespace ExtensionMethodConsole
{
    public static class A
    {
        public static void mymethod1(this ExtensionMeth ex)
        {
            Console.WriteLine("Hello I am extended method");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           ExtensionMeth ex=new ExtensionMeth();
            ex.mymethod1();
            ex.print();
            ex.display();
            Console.ReadKey();
        }
    }
}
