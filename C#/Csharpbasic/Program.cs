using System;
using static Csharpbasic.Structure;

namespace Csharpbasic
{

    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Datatypesandtypecasting D=new Datatypesandtypecasting();
             D.getstudentdetails();
             D.implicittypeconver();
             D.explicittypeconver();

             //Class Boxing and unboxing
             Boxingunboxing_and_enum bue=new Boxingunboxing_and_enum();
             bue.boxing();
             bue.unboxing();
             bue.enumerationofmonths();
             bue.enumerationofshapes();

             //var and dynamic class
             vardynamicredvariable vd1 = new vardynamicredvariable();
             vd1.varlocalvariable();
             vd1.dynamicvariable();

             //ref and out class
             int i = 10;
             refoutparameteresandvariable ro=new refoutparameteresandvariable();

            Console.WriteLine("Before value of i :" + i); //10
             ro.getnextnamebyref(ref i);
             Console.WriteLine("After Value of i : "+ i);//11


             //out
             Console.WriteLine("Value of i Before Out reference : "+i);//11
             refoutparameteresandvariable.getnamebyout(out i);
             Console.WriteLine("Value of i after out reference : " + i);//43

             //struct 
             Student s1 = new Student(101,297891,35000.00);
             Student s2 = new Student(182938);
             s1.Displayvalues();
             Console.WriteLine("Copy Constructor : ");
             s2.Displayvalues(); 

             //stringbuilderclass
             StringBuilderClass sc=new StringBuilderClass();
             sc.StringBuilderClassmethod();

             //param array
             Paramarray pa = new Paramarray();
             int ae= pa.AddElements(12, 13, 16, 14, 15, 46, 13,1828);
             Console.WriteLine("Sum of values : "+ae);

             //default 
             Constructor c = new Constructor();
             //parameter
             Constructor c1= new Constructor("Deepti",22);
             //copy constructor
             Constructor c2 = new Constructor(c1);

             //private constructor
             privateconstructor.count = 18;
             privateconstructor.getcount();
             Console.WriteLine("Value of count"+privateconstructor.count);//19
             privateconstructor.getcount();
             Console.WriteLine("Value of count" + privateconstructor.count);//20  

             //static constructor
             //StaticConstructor stc1=new StaticConstructor();
             StaticConstructor stc2 = new StaticConstructor(i);
             //method of static 
             StaticConstructor.detail("Vraj",19);

            //static class
            Staticmemberclassmethods.calculator();

            //property
            property p=new property();
            p.X=17;
            Console.WriteLine("Value of Property x : "+p.X);
            //static property
            property.Y = 19;
            int prop = property.Y;
            Console.WriteLine("Value of Property y : " + prop);

            //indexer
            nullableandIndexer nid= new nullableandIndexer();
            nid[0] = 2;
            nid[1] = 4;
            nid[2] = 6;
            nid[3] = 8;
            nid[4] = 10;
            nid[5] = 22;
            Console.WriteLine("Value of index 3 is : "+nid[3]);

            //for (int i=0;i<7;i++)
              //{
               //Console.WriteLine(nid[i]);
           //}
         
            nid.nullabledatatype();
            nid.nullabledatatype1();
            nid.nullcoalescingoperator();
            nid.nullablewithcompare();

            */
            //pointer
            myclass mc= new myclass();
            mc.mymethod();

            //has a 
            Address a = new Address("Vadodara","Gujarat");
            Employee e = new Employee(101, "Deepti",a);
            e.display();

            //inheritance
            deriveclass dc=new deriveclass();
            dc.Fruitscolorwithname();

            //multilevel inheritance
            Son son = new Son();

            //constructor overloading
            Add a1 = new Add(100,188);
            a1.addone();

            Add a2 = new Add(92.7,38.8f);
            a1.addtwo();


            //base with default constructor
            C clsc=new C();
        }
    }
}
