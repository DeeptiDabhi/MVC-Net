using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpbasic
{
    public class vardynamicredvariable
    {
        //var local variable of implicitly type
        public void varlocalvariable()
        {
            var c1 = 'D';
            var n1 = "Deepti";
            var d1 = 1898.77;
            var i1 = 2687;
            var b1 = false;

            Console.WriteLine("Type of c1 is : "+c1.GetType().Name);
            Console.WriteLine("Type of n1 is : "+n1.GetType());
            Console.WriteLine("Type of i1 is : " + d1.GetType());
            Console.WriteLine("Type of i2 is : "+i1.GetType());
            Console.WriteLine("Type of b1 is : "+b1.GetType());  
        }

        //dynamic variable
        public void dynamicvariable()
        {
            dynamic val1 = "HelloWorld";
            dynamic val2 = 27272;
            dynamic val3 = 22.22;
            dynamic val4 = true;
            dynamic val5 = 2.2;

            Console.WriteLine("Type of val1 is : " + val1.GetType().Name);
            Console.WriteLine("Type of val2 is : " +val2.GetType());
            Console.WriteLine("Type of val3 is : " + val3.GetType());
            Console.WriteLine("Type of val4 is : " +val4.GetType());
            Console.WriteLine("Type of val5 is : " +val5.GetType());
        }
    }
}
