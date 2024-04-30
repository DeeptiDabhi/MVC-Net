using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpbasic
{
    internal class nullableandIndexer
    {
        private int[] even = new int[6];
        Nullable<int> a = null;
        int? x = null;
        int? y = 19;
        

        //indexer array
        public int this[int i]
        {
            get
            {
                return even[i];
            }
            set
            {
                even[i] = value;
            }
        }

        public void nullabledatatype()
        {
            int? z;
            z= x * y;
            Console.WriteLine("Multiplication of nullable values : "+z); //null
        }
        public void nullabledatatype1()
        {
            if(x==y)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
        public void nullcoalescingoperator()
        {
            int? a = 55;
            int? b = null;
            int? result;
            result = a ?? b;
            Console.WriteLine("Value nullcoalescing opereator a : "+a);
            Console.WriteLine("Value nullcoalescing opereator b : " + b);
            Console.WriteLine("Value nullcoalescing opereator result : " + result);
        }
        public void nullablewithcompare()
        {
            Console.WriteLine("Value of x"+x);
            Console.WriteLine("Value of y"+y);
            if(Nullable.Compare<int>(x,y)>0)
            {
                Console.WriteLine("x greater y");
            }
            else
            {
                Console.WriteLine("x not greater y");
            }
        }
    }
}
