using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpbasic
{
    static class Staticmemberclassmethods
    {
        static int a;
        static int b;
        static char calc;

        //static constructor
        static Staticmemberclassmethods()
        {
            var a = 10;
            var b = 'C';
            Console.WriteLine("Check Type of var a : " + a.GetType());
            Console.WriteLine("Check Type of var b : " + b.GetType());
        }

        //static method
        public static void calculator()
        {
            Console.WriteLine("Enter No : ");
            a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter No : ");
            b = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Select Operator : ");
            calc = Convert.ToChar(Console.ReadLine());

            switch (calc)
            {
                case '+':
                    Console.WriteLine("A+b = "+(a + b));
                    break;
                case '-':
                    Console.WriteLine("A-b = "+(a - b));
                    break;
                case '*':
                    Console.WriteLine("A*b = "+(a * b));
                    break;
                case '/':
                    Console.WriteLine("A/b = "+(a/ b));
                    break;
                case '%':
                    Console.WriteLine("A%b = "+(a % b));
                    break;

                default:
                    Console.WriteLine("U Don't Select any operator");
                    break;
            }
        }
    }
   
}
