using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1_Classes
{
    public class Birdie
    {
        //PRIVATE MEMBERS
        private const int _iTweets = 100;
        private readonly int _iBeaks; //modifiable in the Constructor
        private int _iSeeds;

        //if you want access to the private members, you can define this using properties
        public int iTweets
        {
            get { return _iTweets; }
            
        }

        //this property will restrict how iSeeds can be modified:
        public int iSeeds
        {
            get { return _iSeeds; }
            set { 
                //validating user input to be bound to my constraints
                if (value > 100)
                    _iSeeds = 100;
                else if (value < 0)
                    _iSeeds = 1;
                else _iSeeds = value;
            }
        }

        //custom constructor
        public Birdie(int iSeeds)
        {
            _iBeaks = 12;

            //note, this sets the private member directly
            //and does not use the property we created!!
            _iSeeds = iSeeds;
        }

        //default constructor getting overridden
        public Birdie() : this(54)
        {
            //set additional things after the custom constructor called
            //no body required
        }

        //method time!!
        public void Chirp()
        {
            for(int i = 0; i < _iSeeds; i++)
            {
                Console.Write("*");
                Console.Beep();
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Birdie x = new Birdie(); //default constructor invoked
            Birdie y = new Birdie(152); //user defined constructor invoked

            int something = x.iTweets;
            //below doesn't work because property only accepts READ operation
            //x.iTweets++;

            x.Chirp();

            //now it's time to review arrays, lists, etc
            Birdie[] ArrBirds; //ArrBirds is null
            ArrBirds = new Birdie[8]; //all the spots in the array are null
            //will throw an error
            //Console.Write(ArrBirds[0].iTweets);

            for (int i = 0; i < ArrBirds.Length;i++) 
            {
                ArrBirds[i] = new Birdie(i);
            }

            //use a list now
            List<Birdie> Birdies = new List<Birdie>(); //empty list of birdies (no birdies exist)

            //create one birdie and add to list
            Birdie newB = new Birdie();

            Birdies.Add(newB); //1 birdie in the list

            //how to add birdies until there are 10 in the list?
            while (Birdies.Count < 10)
            {
                Birdies.Add(new Birdie());
            }

            Console.ReadLine();
        }
    }
}
