using System;

namespace Accesssp1
{
    class class1
    {
        public int publicvar = 0;
        private string privatevar = "Private";
        protected double protectedvar = 19.8;
        internal bool internalvar = false;
        protected internal char protectedintchar = 'A';
        public void DisplayVariables()
        {
            Console.WriteLine("Public Variable : " + publicvar);
            Console.WriteLine("Private Variable : " + privatevar);
            Console.WriteLine("Protected Variable : " + protectedvar);
            Console.WriteLine("Internal Variable : " + internalvar);
            Console.WriteLine("Protected Internal Variable : " + protectedintchar);

        }
    }
    public class Program
    {

        static void Main(string[] args)
        {
            class1 c1=new class1();
        }
    }
}
