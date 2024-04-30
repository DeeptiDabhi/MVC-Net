using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpbasic
{
    internal class Constructoroverloading
    {
    }
    class Add
    {
        int x, y;
        double f;
        float s;

        public Add(int a,int b)
        {
            x = a;
            y = b;
        }
        public void addone()
        {
            Console.WriteLine("Addition Of Value x and y : "+(x+y));
        }
        public Add(double f,float s)
        {
            f = f;
            s = s;
        }
        public void addtwo()
        {
            Console.WriteLine("Addition of f and s : " + (f + s));
        }
    }
}
