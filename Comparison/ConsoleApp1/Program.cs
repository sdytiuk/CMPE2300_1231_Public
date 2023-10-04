using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class CPerson :IComparable //now with comparison via CompareTo
    {
        private int _height;
        private int _weight;

        public CPerson(int height, int weight)
        {
            _height = height;
            _weight = weight;
        }

        //equals
        public override bool Equals(object obj)
        {
            if (!(obj is CPerson p)) return false;
            Console.Write("found an object");
            return Equals(p);
        }

        //optional specialized version
        public bool Equals(CPerson other)
        {
            if (other == null) return false;
            return _height == other._height && _weight == other._weight;
        }

        public override int GetHashCode() 
        {
            return 1; //we won't be using hash algorithms now, so this is OK
        }

        public int CompareTo(object obj)
        {
            if (!(obj is CPerson p))
                throw new ArgumentException($"CPerson:CompareTo:{nameof(obj)} not a valid CPerson!");
            return (_height*_weight).CompareTo(p._height*p._weight);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            CPerson Waldo, Dora;

            Waldo = new CPerson(180, 80);
            Dora = new CPerson(150, 60);

            Console.WriteLine(Waldo.Equals(Dora));
            Console.WriteLine(Waldo.Equals((object)Dora));
            Console.WriteLine(Waldo.CompareTo(Dora));
            Console.Read();
        }
    }
}
