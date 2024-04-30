using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Keyword
{
    public class Animal
    {
        //virtaul method can be overridden in a derive class when a method
        //is declared as a virtual in a base class
        public virtual void Makesound()
        {
            Console.WriteLine("The Animal Makes a Sound");
        }
    }
    public class cat:Animal
    {
        public override void Makesound()
        {
            Console.WriteLine("The Cat Meows");
        }
    }
}
