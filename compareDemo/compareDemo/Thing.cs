using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compareDemo
{
    internal class Thing : IComparable
    {
        public int X { get; private set; }
        public Thing (int iVal)
        {
            X = iVal;
            SortType = ESortType.Ascending; //default sort
        }
        public enum ESortType { Ascending , Descending }; //possible sort options
        static public ESortType SortType { get; set; }

        public int CompareTo (object obj)
        {
            if (!(obj is Thing thing))
                throw new ArgumentException($"Thing:CompareTo:{nameof(obj)} - not a valid thing");
            return MyThingCompare(this, thing); //Kaiden's suggestion... leverage below :)
        }

        internal static int MyThingCompare (Thing a, Thing b)
        {
            switch (SortType)
            {
                case ESortType.Ascending:
                    if (a == null && b == null) return 0; // null == null so they are the same
                    if (a == null) return -1; //null is LESS than anything
                    if (b == null) return 1;
                    return a.X.CompareTo(b.X); //using INT sort
                case ESortType.Descending:
                    if (a == null && b == null) return 0; // null == null so they are the same
                    if (a == null) return 1; //null is LESS than anything
                    if (b == null) return -1;
                    return -a.X.CompareTo(b.X); //using INT sort
                default:
                    break;
            }
            return 0;// unknown sort
            
        }

        internal static int MyThingCompareDesc(Thing a, Thing b)
        {
            if (a == null && b == null) return 0; // null == null so they are the same
            if (a == null) return 1; //null is LESS than anything
            if (b == null) return -1;
            return -a.X.CompareTo(b.X); //using INT sort
        }

        public static bool IsEven(Thing arg)
        {
            if (arg == null) return false; //null is not even
            return (arg.X % 2) == 0;
        }
    }
}
