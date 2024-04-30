using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpbasic
{
    internal class property
    {
        private int x;
        private static int y;


        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public static int Y
        {
            get { return y; }
            set { y= value; }
        }
       
       
    }
}
