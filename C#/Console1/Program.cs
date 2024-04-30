using System;

namespace Console1
{
    //virtual override and sealed
    class A
    {
        public virtual void display() {
            Console.WriteLine("I Am Base Class A");
        }   

        public virtual void show()
        {
            Console.WriteLine("I Am Show Method");
        }
    }
    class B : A { 
        public override void display() {
            Console.WriteLine("I Am Derive Class B");
        }

        //sealed method
        public sealed override void show() 
        {
            Console.WriteLine("I am sealed show method nobody can override me");
        }
    }
    class C : A{
        public override void display()
        {
            Console.WriteLine("I Am Derive Class C");

        }

        public override void show()
        {
            Console.WriteLine("I try to override show method from b class");
        }
    }
    //abstarct class and method
    abstract class c1
    {
        public abstract void display();
        public virtual void show()
        {
            Console.WriteLine("I Am Method Of Abstract Class");
        }
    }
    class c2:c1
    {
        public override void display() {
            Console.WriteLine("i am c2 class , I override abstract method of abstarct class");
        }
        public override void show()
        {
            Console.WriteLine("i am c2 class , i override normal method of abstract class");
        }
    }
    class c3 : c1
    {
        public override void display()
        {
           Console.WriteLine("i am c3 method display");
        }

        public override void show()
        {
            Console.WriteLine("i am c3 method show");
        }
    }
    public partial class partialclass
    {
       public void diplayname()
        {
            Console.WriteLine("name of index 1 is : "+name[1]);
        }
    }
   
    internal class Program
    {
        static void Main(string[] args)
        {
            //virtual override with sealed method
            A a1=new A();
            a1.display();    

            B b1=new B();
            b1.display();

            C c1=new C();
            c1.display();
            c1.show();

            //abstract class
            c1 c = new c3();
            c.display();
            c.show();

            /*
            //virtal, override and new

            Class1 c1=new Class1();
            c1.display();

            class2 c2 = new class2();
            c2.getval(12, 3);
            c2.display();

            class3 c3 = new class3();  
            c3.getval(12, 3);
            c3.display();
             */

            //partial class 
            partialclass pc = new partialclass();
            pc.diplayname();


            //interface
            Drawable d;
            d = new rectengle();
            d.Title();
            d.draw();
            d = new circle();
            d.draw();

            //abstarct class
            shape s;
            s = new Rectengle();
            s.title();
            s.draw();
            s =new Circle();
            s.draw();

            Console.ReadLine();
        }
    }
}
