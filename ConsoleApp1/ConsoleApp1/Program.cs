using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(5);
            List<int> list2 = list; //what does this do?
            List<int> list3 = new List<int>(list);
            list2[0] = 6;
            Console.WriteLine("List[0] X: " + list[0]);
            Console.WriteLine("List2[0] Y: " + list2[0]);
            Console.WriteLine("List3[0] Z: " + list3[0]);
            Console.Read();
        }
    }
}
