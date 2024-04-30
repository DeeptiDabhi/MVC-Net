// See https://aka.ms/new-console-template for more information
using System;
using first;
using second;


namespace first
{
    public class firsthello
    {
       public int a=10;
       public int b=19;

        public void sayhello()
        {
            Console.WriteLine("Hello First namespace");
        }
    }
}
namespace second
{
    public class secondhello
    {
        public string name="Deepti";
        public int age=22;
        public void sayhello()
        {
            Console.WriteLine("Hello Second namespace");
        }
    }
}
public class testnamespace
{
    public static void Main()
    {
        firsthello h1=new firsthello();
        secondhello h2=new secondhello();
        h1.sayhello();
        h2.sayhello();
    }
}
