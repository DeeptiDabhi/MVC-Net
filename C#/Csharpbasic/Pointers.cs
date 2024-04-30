using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpbasic
{
    public class myclass
    {
        public  void mymethod()
        {
            unsafe
            {
                
                    int a = 10;
                    int b = 20;
                    int* ptr1 = &a;
                    int* ptr2 = &b;
                    Console.WriteLine("Address of a with ptr1 : " + (int)ptr1);
                    Console.WriteLine("Address of a with ptr2 : " + (int)ptr2);
                    Console.WriteLine("Value of a with ptr1 : " + *ptr1);
                    Console.WriteLine("Value of a with ptr2 : " + *ptr2);
                
            }
        }
       
    }
}
