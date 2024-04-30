using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console1
{
    internal class Abstract
    {
    }
    //the process to hide the internal details and showing functionality only. 
    public abstract class shape
    {
        public void title()
        {
            Console.WriteLine("Below is output of abstract class with method : ");
        }
        public abstract void draw();
    }
    public class Rectengle:shape
    {
        public override void draw()
        {
            Console.WriteLine("Rectengle");
        }
    }
    public class Circle:shape
    {
        public override void draw() {
            Console.WriteLine("Circle");
        }
    }
}
