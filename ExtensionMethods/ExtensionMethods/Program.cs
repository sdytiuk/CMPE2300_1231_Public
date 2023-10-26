using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random rand = new Random();
            List<int> aList = new List<int>();
            List<int> bList = new List<int>();
            

            for (int i = 0; i< 10; i++)
            {
                aList.Add(rand.Next(10));
                bList.Add(rand.Next(10));
            }
            Console.WriteLine("Both lists aList, bList");
            aList.ForEach(x=>Console.Write(x + " "));
            Console.WriteLine();
            bList.ForEach(x=>Console.Write(x + " "));
            Console.WriteLine();
            Console.WriteLine(aList.Aggregate(10, (x, sum) => sum + x));
            Console.WriteLine(aList.Sum());

            //concat
            IEnumerable<int> AandB = aList.Concat(bList);
            Console.WriteLine("Concat list A and B");

            //Dealing with IEnumerable Return Collections
            
            //Option 1: Use IEnumerable as a collection
            foreach (int x in AandB)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine("using for loop (regalo para Pablo:");
            //Option 1b:
            for (int x = 0; x < AandB.Count(); x++) 
            {
                Console.Write(AandB.ElementAt(x) + " ");
            }

            //Option 2: Use the collection constructor overloads to make a 
            // new list
            List<int> ListAB = new List<int>(aList.Concat(bList));
            //you could replace a list this way:
            aList = new List<int>(aList.Concat(bList));

            //Option 3: use one of the toXXXX helpers like ToList()
            aList = aList.Concat(bList).ToList();

            //How to use some of the methods
            aList.Clear();
            bList.Clear();
            for (int i = 0; i < 10; i++)
            {
                aList.Add(rand.Next(10));
                bList.Add(rand.Next(10));
            }

            Console.WriteLine("\nWhat are the lists now? A B:");
            aList.ForEach(x => Console.Write(x + " "));
            Console.WriteLine();
            bList.ForEach(x => Console.Write(x + " "));
            Console.WriteLine();

            Console.WriteLine("Intersect members:");
            //we only want the matching members between A and B
            //note: distinct is only finding distinct members of A list
            //aList.Distinct();
            foreach (int x in aList.Intersect(bList))
            {
                Console.Write(x + " ");
            }

            Console.WriteLine("Elements in A not in B:");
            //we only want the members in A that aren't in B
            foreach (int x in aList.Except(bList))
            {
                Console.Write(x + " ");
            }

            

            Console.ReadLine();
        }
    }
}
