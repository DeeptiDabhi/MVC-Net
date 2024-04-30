using System;

namespace ConDeligatesandanonymous
{
    //start delegate
    public delegate void calldisplay();

    public delegate void calladdition(int x ,int y);

    //end delegate

    //anonymous method start
    public delegate void Anonymousmethod();

    public delegate int Anonymousfunct(int a);

    public delegate void Show(int v);

    internal class Program
    {
        public static void Display()
        {
            Console.WriteLine("I Am Display Method");
        }

        public static void Addition(int a,int b)
        {
            int result = a + b;
            Console.WriteLine("Addition is : "+result);
        }
        public static void Subtraction(int a, int b)
        {
            int result = a - b;
            Console.WriteLine("Subtraction is : " + result);
        }
        public static void Multiplication(int a, int b)
        {
            int result = a * b;
            Console.WriteLine("Multiplication is : " + result);
        }
        public static void Division(int a, int b)
        {
            int result = a / b;
            Console.WriteLine("Division is : " + result);
        }
        public static void Moduls(int a, int b)
        {
            int result = a % b;
            Console.WriteLine("Moduls is : " + result);
        }
        static void Main(string[] args)
        {
            //start delegate
            calldisplay cd = new calldisplay(Program.Display);
            cd();

            calladdition ca = new calladdition(Program.Addition);
            ca(19,17);

            ca = Subtraction;
            ca(17, 9);

            ca = Multiplication;
            ca(18, 5);

            calladdition ca1= new calladdition(Program.Moduls);
            ca1(18, 9);

            //end delegate

            //anonymous function start
            Anonymousmethod am = delegate ()
            {
                Console.WriteLine("Hello i am Anonymous");
            };
            am();

            Anonymousfunct af = delegate (int a)
            {
                a += 188;
                return a;
            };
            Console.WriteLine("Anonymous Function value a is :"+af(2));

            //anonymous function end

            //lambda expression
            Anonymousmethod lm1 = new Anonymousmethod(() =>
            {
                Console.WriteLine("This is Lambda Function Without Parameter");
            });
            lm1();

            Anonymousfunct lm2 = new Anonymousfunct((b) =>
            {
                b = b++ + ++b + 16;
                return b;
            });

            Console.WriteLine("Lambda Expresion b value is : " + lm2(18));

            //lambda function end 
           
            Console.ReadLine(); 
        }
    }
}
