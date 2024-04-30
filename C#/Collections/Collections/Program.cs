using System;
using System.Collections.Generic;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //list class used to store and fetch elements
            //create list string
            var names=new List<string>() {"Prachi","Priyanka","Punit","Dharmesh"};
            names.Remove(names[1]);
            foreach (var name in names)
            {
                Console.WriteLine("List Of Names is : " + name);
            }
           
            //hashset store remove and view elements
            var fruits = new HashSet<string>() { "Apple", "Banana", "Strawberry" };

            names.Add("Deepti");
            names.Add("Sunita");
            names.Add("Ali");
            names.Add("Sanjana");
            names.Add("Jhanvi");

            fruits.Add("Pinaple");
            foreach (var fruit in fruits)
            {
                Console.WriteLine("Hashset Fruit is : " + fruit);
            }

            //sortedset store,remove and view elements in sorted manner
            var id = new SortedSet<int>() {15,2,8,27,18};
            id.Add(16);
            id.Add(1);

            foreach (var ids in id)
            {
                Console.WriteLine("ID in Sorted Manner : " + ids);
            }

            //stack used to push and pop element LIFO
            Stack<string> AnimalName = new Stack<string>();
            AnimalName.Push("Tiger");
            AnimalName.Push("Lion");
            AnimalName.Push("Zebra");

            foreach(string aniname in AnimalName)
            {
                Console.WriteLine("Animal Name : " +aniname);
            }

            Console.WriteLine("Peek Element : " + AnimalName.Peek());
            Console.WriteLine("Pop Element : "+AnimalName.Pop());
            Console.WriteLine("After Pop Peek Element : " + AnimalName.Peek());
            Console.WriteLine("After Peek Pop Element : " + AnimalName.Pop());
            Console.WriteLine("After Pop Peek Element : " + AnimalName.Peek());

            //Queue it can have duplicate elements and it used to enqueue and Dequeue FIFO
            Queue<int> evenno = new Queue<int>();
            evenno.Enqueue(2);
            evenno.Enqueue(4);
            evenno.Enqueue(6);
            evenno.Enqueue(8);

            foreach(int evennum in evenno)
            {
                Console.WriteLine("Print Even No : " + evennum);
            }
            Console.WriteLine("Peek One Even : "+evenno.Peek());
            Console.WriteLine("Dequeue Even No : " + evenno.Dequeue());
            Console.WriteLine("After Dequeue Peek even no :" + evenno.Peek());

            //linkedlist it allows insert and delete elements fastly it can have duplicate elements
            var BestFriends = new LinkedList<string>();

            BestFriends.AddFirst("Bhumi");
            BestFriends.AddFirst("Anjana");
            BestFriends.AddFirst("Khushali");

            //insert new element
            LinkedListNode<string> node = BestFriends.Find("Khushali");
            BestFriends.AddBefore(node, "Mansi");

            LinkedListNode<string> node1 = BestFriends.Find("Mansi");
            BestFriends.AddAfter(node1, "Deepti");


            foreach (string bff in BestFriends)
            {
                Console.WriteLine("BestFriends Are : " + bff);
            }

            //dictonary class uses the concept of hashtable it stores values
            //on the basis of key it contains unique key only

            Dictionary<int, string> studentsdetails = new Dictionary<int, string>();
            studentsdetails.Add(1, "Deepti");
            studentsdetails.Add(2, "Vraj");
            studentsdetails.Add(3, "Khushbu");
            studentsdetails.Add(4, "Mansi");
            studentsdetails.Add(5, "Deven");

            foreach(KeyValuePair<int,string> kv in studentsdetails)
            {
                Console.WriteLine(kv.Key + " " + kv.Value);
            }

            //sorteddict and sorted list both are same 
            SortedDictionary<int, string> sportsstu = new SortedDictionary<int, string>();
            sportsstu.Add(1, "Raghav");
            sportsstu.Add(4, "Jhon");
            sportsstu.Add(2, "Vishwa");
            sportsstu.Add(5, "Vraj");
            sportsstu.Add(3, "Jay");

            foreach(KeyValuePair<int,string> skv in sportsstu)
            {
                Console.WriteLine("Sports Students Are : " + skv.Key + " " + skv.Value);
            }


            Console.ReadLine();
        }
    }
}
