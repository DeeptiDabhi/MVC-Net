using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpbasic
{
    internal class Paramarray
    {
        public int AddElements(params int[] arr)
        {
            //if you are not sure about how many arguments you are taking then use parram 
            int sum = 0;
            
            foreach(int i in arr)
            {
                sum += i;
            }
            return sum;
        }
    }
}
