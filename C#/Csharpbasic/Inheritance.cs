using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpbasic
{
    internal class Inheritance
    {

    }
    //protected inheritance
    class BaseClass
    {
        protected string[] fruites = { "Graps", "Apple" };
        protected void fruitsname()
        {
            Console.WriteLine("Fruits Are : " + fruites);
        }
    }
    class deriveclass:BaseClass
    {
        public string[] FruitColor = { "Grenn", "Red" };
        public void Fruitscolorwithname()
        {
            Console.WriteLine("Fruit is : " + fruites[0] + " and its " + "Color is " + FruitColor[0]);
            Console.WriteLine("Fruit is : " + fruites[1] + " and its " + "Color is " + FruitColor[1]);
        }
    }
   
}
