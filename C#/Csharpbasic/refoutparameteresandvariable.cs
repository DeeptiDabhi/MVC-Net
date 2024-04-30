using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpbasic
{
    internal class refoutparameteresandvariable
    {
       
        //the ref and out keyword passes  arguments by reference  and it is used in method only
        public int  getnextnamebyref(ref int id)
        {
            id += 1;
            return id;
        }

        public static int getnamebyout(out int id)
        {
            id = 43;
            //id += a;
               //a++ + a++ + ++a + a-- + a++ + ++a + --a;
            return id;
        }
    }

}
