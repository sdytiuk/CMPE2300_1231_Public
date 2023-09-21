using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DistyBall;

namespace Demo3_Static
{

    class Test
    {
        //random...should always be static because we talked about it in class!!
        public static Random _rand = null;
        private static int iStaticValue = 20;

        //static property bound to iStaticValue
        public static int Value => iStaticValue;

        public static int GetRandomNumber(short upperLimit)
        {
            return _rand.Next(upperLimit);
        }

        public static string Complain()
        {
            string[] messages = { "Do I have to?", "I'm too tired", "I don't care..." };
            return messages[GetRandomNumber((short)messages.Length)]; //use static method here
        }

        //static constructor
        static Test()
        {
            _rand = new Random();
        }
    }
    internal class Program
    {
        //this degenerates to a static because there was only ever one instance open...!
        //Random r = new Random();
        static void Main(string[] args)
        {
            int iVal = Test.Value;
            Console.WriteLine(Test.Complain());
            Console.WriteLine(Test.GetRandomNumber(7));
            Console.WriteLine(CDistyBall.myNum);
            Console.Read();
        }
    }
}
