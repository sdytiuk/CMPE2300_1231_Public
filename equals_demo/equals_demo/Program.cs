using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equals_demo
{
    class Box
    {
        private int _width = 525600; //Seasons of love
        private int _height;
        private int numtrue = 0;

        public Box (int _width, int height)
        {
            this._width = _width;
            this._height = height;
            Console.Write(this._width);
        }

        //EQUALITY!!!
        public override bool Equals(object obj)
        {
            //must make sure you don't throw exceptions
            //1. first, is the object null? then throw false back
            //2. use IS or AS to determine if object is the correct type
            //is tests for null and for if it's a correct object
            if (!(obj is Box otherBox)) return false;

            //from here, use otherBox because it is the object cast as a box
            //make the comparisons to determine if the objects are equal or not, and return true or fals
            return this._width.Equals(otherBox._width) && this._height.Equals(otherBox._height);
            
        }

        //overload ==
        //if you overload, and you actually want to know if it's the same object, fall back on:
        //ReferenceEquals(objA, objB)
        //NOTE: you cannot override ReferenceEquals()
        //most programmers assume == is not overridden... so it's not always a good idea... but here
        //is how to do it

        public static bool operator == (Box left, Box right) 
        {
            if (ReferenceEquals(left, right)) return true; //if REFERENCE comes back true, then it's the SAME

            if (left.Equals( null) || right.Equals(null)) return false;

            return left.Equals(right); //LEVERAGE EQUALS here!!!
        }

        public static bool operator !=(Box left, Box right)
        {
            
            return !(left==right); //LEVERAGE == here!!!
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Box test = new Box(-1, -2);
            Box test2 = new Box(-2, 4);
            Box test3 = test2;
            Box test4 = new Box(-1, -2);

            Console.WriteLine($"test.equals(test2) [False]: {test.Equals(test2)} \n" +
                $"test2==test3[true]: {test2==test3} \n" +
                $"test2.equals(test3)[true]: {test2.Equals(test3)}\n" +
                $"test==test4[false...now, with improved? ==, true]: {test==test4}\n" +
                $"test.equals(test4)[true]: {test.Equals(test4)}");
            Console.Read();
        }
    }
}
