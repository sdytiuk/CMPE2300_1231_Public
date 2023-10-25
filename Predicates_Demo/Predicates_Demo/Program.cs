using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predicates_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Something> someList = new List<Something>();

            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                someList.Add(new Something(random.Next(1,10)));

            }

            //print the values
            someList.ForEach(x =>  Console.Write($"{x},") );

            //are all numbers greater than five?
            Console.WriteLine("Are all numbers greater than 5?: " + someList.TrueForAll(Something.IsBiggerThan5));

            //are some numbers greater than five?
            Console.WriteLine("Are some numbers greater than 5?: " + !someList.TrueForAll(
                delegate (Something s) { return s.myNum < 6; }));

            //remove all the ones less than 6
            someList.RemoveAll(itemFromList => itemFromList.myNum < 6);

            //print the values
            someList.ForEach(x => Console.Write($"{x},")); 

            //are all numbers greater than five?
            Console.WriteLine("Are all numbers greater than 5?: " + someList.TrueForAll(Something.IsBiggerThan5));

            //are some numbers greater than five?
            Console.WriteLine("Are some numbers greater than 5?: " + !someList.TrueForAll(
                delegate (Something s) { return s.myNum < 6; }));

            //sort the values
            someList.Sort( (right, left) => left.myNum.CompareTo(right.myNum));

            //print the values
            someList.ForEach(x => Console.Write($"{x},"));

            Console.Read();
        }
    }
}
