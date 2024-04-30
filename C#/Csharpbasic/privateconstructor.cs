using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpbasic
{
    internal class privateconstructor
    {
        //private constructor
        private privateconstructor() 
        {
        }
        //variable
        public static int count;
        //method
        public static int getcount()
        {
            return ++count;
        }
    }
}
