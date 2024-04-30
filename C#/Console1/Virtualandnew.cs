using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console1
{
    //virtual ,override and new
    class Class1
    {
       public int a=10;
       public int b=20;
        public virtual void display()
        {
            Console.WriteLine("Addition of value a and b of base class : "+(a+b));
        }
    }
    class class2 : Class1 
    {
        public void getval(int x,int y)
        {
            base.a = x;
            base.b = y;
        }
        public new void display()
        {
            Console.WriteLine("Multiplication of value a and b of Derived class : "+(a*b));
        }
    }
    class class3 :Class1
    {
        public void getval(int x1, int y1)
        {
            base.a = x1;
            base.b = y1;
        }
        public override void display()
        {
            Console.WriteLine("Subtraction of value a and b of derived class : " + (a - b));
        }
    }
    partial class partialclass
    {
        string[] name=new string[5] {"Anish","Raj","Sunita","Rajan","Priti"};
    }
   
    
}
