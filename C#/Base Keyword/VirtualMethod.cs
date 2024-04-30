using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Keyword
{
    public class Shape
    {
        protected int width, height;

        public Shape(int a=0,int b=0) { 
            width = a;
            height = b;
        }

        public virtual int area()
        {
            Console.WriteLine("Parent Class Area :");
            return 0;
        }
    }
    public class rectengle:Shape
    {
        public rectengle(int a = 0,int b=0):base(a,b)
        {

        }
        public override int area()
        {
            Console.WriteLine("Rectengle Class Area :");
            return width * height;
        }
    }
    class triangle : Shape
    {
        public triangle(int a=0,int b=0):base(a,b)
        {

        }
        public override int area()
        {
            Console.WriteLine("Triangle Class Area :");
            return (width * height / 2);
        }
    }
    class call
    {
        public void callarea(Shape sh)
        {
            int a;
            a=sh.area();
            Console.WriteLine("The Area is : "+a);
        }
    }


}
