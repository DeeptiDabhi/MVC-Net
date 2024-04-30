using System;
using System.Diagnostics.CodeAnalysis;

namespace Base_Keyword
{
   public class A
    {
       public int a = 12;

        //default constructor
        public A()
        {
            Console.WriteLine("Value of Base Class is : " + a);
        }
    }
    public class B:A
    {
        public int b = 91;
        public string fruit;
        public string color;

        //default constructor
        public B() {
            Console.WriteLine("Value of Derived Class is : " + b);
        }
        //parameterized 
        public B(string f, string c)
        {
            fruit = f;
            color = c;
        }
    }
    class C : B
    {
        //default constructor
        public C() {
            Console.WriteLine("Sum of base and derived class : "+(base.b+base.a));
        }

        //parameterized constructor
        public C(string f, string c) 
        {
           base.fruit=f;
           base.color=c;

           Console.WriteLine("Fruit Color is : "+(f+" "+c));
        }
       
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            C c = new C();
            C c1 = new C("Apple","Red");

            //virtual method
            Animal a=new Animal();
            a.Makesound();
            cat cat = new cat();
            cat.Makesound();
            */


            //virtual method
            call c=new call();
            rectengle r=new rectengle(10,7);
            triangle t = new triangle(8, 8);

            c.callarea(r);
            c.callarea(t);

            Console.ReadKey();
        }
    }
}
