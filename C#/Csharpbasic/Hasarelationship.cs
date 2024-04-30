using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpbasic
{
    internal class Hasarelationship
    {

    }
    public class Address
    {
        public string city,state;
        public Address(string city,string state) 
        {
            this.city = city;
            this.state = state;
        }
    }
    public class Employee
    {
        public int id;
        public string name;
        //has a relationship
        public Address address;

        public Employee(int id,string name, Address address)
        {
            this.id = id;
            this.name = name;
            this.address = address;    
        }
        public void display()
        {
            Console.WriteLine(id+" "+name+" "+address.city+" "+address.state);
        }
    }
   
}
