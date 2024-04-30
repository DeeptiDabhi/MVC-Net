using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console1
{
    //interface is used to achieve multiple inheritance which can't be achieved by class.
    public interface Drawable
    {
        void draw();
       public void Title()
        {
            Console.WriteLine("Below is output of Interface : ");
        }
    }
    public class rectengle:Drawable
    {
        public void draw()
        {
            Console.WriteLine("Draw Rectengle");
        }
       
    }
    public class circle:Drawable
    {
        public void draw()
        {
            Console.WriteLine("Draw Circle");
        }
    }
    internal class Interface
    {
        
    }

}
