using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpbasic
{
    //create enum
    enum month
    {
        Jan=1,
        Feb,
        Mar,
        Apr,
        May
    }
    internal class Boxingunboxing_and_enum
    {
        /*The process of converting a value type variable to references type variable is called boxing*/
        //boxing example
        public void boxing()
        {
            int num = 2024;
            object obj = num; //boxing
            num = 100;
            Console.WriteLine("Value Type value of num is : "+num); //100
            Console.WriteLine("Reference Type value of obj is : " + obj); //2024
        }

       /* The process of converting a references type variable into valuetype is called unboxing */
       //unboxing example
       public void unboxing()
       {
            int num = 22; 
            object obj = num; //boxing
           int i= (int)obj; //unboxing

            Console.WriteLine("Value type value of num is : " + num);//22
            Console.WriteLine("Reference type value of obj is : "+obj);//22
            Console.WriteLine("Value of unboxing of obj i is : " + num);//22

       }
        public void enumerationofmonths()
        {
            Console.WriteLine("The value of jan in month : "+(int)month.Jan);
            Console.WriteLine("The value of feb in month : " + (int)month.Feb);
            Console.WriteLine("The value of mar in month : " + (int)month.Mar);
        }

        //enum in class
        public enum shapes
        {
            circle,
            square,
            rectengle
        }
        public void enumerationofshapes()
        {
            Console.WriteLine("The value of Circle is : " + (int)shapes.circle);
            Console.WriteLine("The value of Square is : " + (int)shapes.square);
            Console.WriteLine("The value of Rectengle is : " + (int)shapes.rectengle);
        }


    }
}
