// See https://aka.ms/new-console-template for more information
using first;
using second;
using System.Runtime.Intrinsics.Arm;


public class hellofirst
{
   

    public static void Main()
    {
        first.firsthello f1 = new first.firsthello();
        second.secondhello s2 = new second.secondhello();
        Console.WriteLine("Addition of a and b from Namespace first, class firsthello is : "+(f1.a+f1.b));
        Console.WriteLine("Get name and age from Namespace second, class secondhello is : " + s2.name + " " + s2.age);
    }
}
