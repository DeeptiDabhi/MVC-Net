using System;

namespace ConLambdaDelegate
{

    delegate bool IsTenenager(Student stud);

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //anonymous function
            IsTenenager teen = delegate (Student s)
            {
                return s.Age > 12 && s.Age < 20;
            };

            Student s = new Student() { Age = 25 };

            Console.WriteLine(teen(s));

        }
    }
}
