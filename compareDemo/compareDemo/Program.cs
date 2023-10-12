using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compareDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            List<Thing> list = new List<Thing>();

            

            for (int i = 0; i < rand.Next(10,101); i++)
            {
                list.Add(new Thing(rand.Next(100)));
            }

            //THIS LINE AFFECTS THE DEFAULT SORT ORDER!!
            Thing.SortType = Thing.ESortType.Descending;
            //sort using default comparer
            //default comparer is CompareTo from the class!!
            list.Sort();
            //display the things
            Console.WriteLine("Default Compare:");
            foreach (Thing thing in list)
            {
                Console.Write(thing.X + ", ");
            }
            Console.WriteLine();

            //sort using MyThingCompare
            list.Sort(Thing.MyThingCompare);
            //display the things
            Console.WriteLine("MyThingCompare:");
            foreach (Thing thing in list)
            {
                Console.Write(thing.X + ", ");
            }
            Console.WriteLine();


            //sort using MyThingCompareDesc
            list.Sort(Thing.MyThingCompareDesc);
            //display the things
            Console.WriteLine("MyThingCompareDesc:");

            //display the things
            foreach (Thing thing in list)
            {
                Console.Write(thing.X + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("Even things using defined predicate");
            //only EVEN things!
            foreach (Thing thing in list.FindAll(Thing.IsEven))
            {
                Console.Write(thing.X + ", ");
            }
            Console.WriteLine();

            Console.WriteLine("Odd things using anonymous predicate");
            //only EVEN things!
            foreach (Thing thing in list.FindAll((x) =>  x.X%2==1))
            {
                Console.Write(thing.X + ", ");
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
