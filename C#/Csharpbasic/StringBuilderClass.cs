using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace Csharpbasic
{
    internal class StringBuilderClass
    {
        StringBuilder myname=new StringBuilder("Deepti");
        public void StringBuilderClassmethod()
        {
            Console.WriteLine("Before Append : "+myname);
            myname.Append(" Dabhi");
            myname.AppendLine(" Ketan Kumar");
            myname.AppendLine("Father Name is Ketan Kumar");
            Console.WriteLine("After Append : "+myname);

            StringBuilder s1 = new StringBuilder("Your Total Amount Is : ");
            s1.AppendFormat("{0:C}",50);
            Console.WriteLine(s1);

            myname.Insert(26, "Have a Nice Day");
            Console.WriteLine("After Insert : " + myname);

            myname.Remove(26, 15);
            Console.WriteLine("After Remove : "+myname);

            myname.Replace("Father Name is Ketan Kumar", " ");
            Console.WriteLine("After Replace : "+myname);
        }
    }
}
