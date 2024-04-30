// See https://aka.ms/new-console-template for more information
namespace namespace1
{
    public class class1
    {
      public int age;
      public string name;
      protected int num=10;
      private int num2 = 27;
      internal int num3=18;
      protected internal int num4 = 18;
       
        public  void getdetails(int a, string n)
        {
            age = a;
            name = n;
            Console.WriteLine("Public Name is : " + name);
            Console.WriteLine("Public Age is :" + age);
        }
    }
    public class class2:class1
    {
        public void print()
        {
            Console.WriteLine("I Inherit Class1" + num);
            Console.WriteLine("I Inherit Class1" + num3);
            Console.WriteLine("I Inherit Class1"+num4);
        }

    }
}