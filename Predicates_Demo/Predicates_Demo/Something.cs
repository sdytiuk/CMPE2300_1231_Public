using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predicates_Demo
{
    internal class Something
    {
        private int _myNum;

        public int myNum {get { return _myNum; } }

        public Something(int _myNum)
        {
            _myNum = _myNum; //useless because _myNum is the parameter

            this._myNum = _myNum; //use this to differentiate
        }

        //default constructor
        public Something():this(5)  //the default CTOR is leveraging the custom constructor and inputting 5 as the value
        {
        
        }

        public static bool IsBiggerThan5(Something s)
        { 
            return s._myNum > 5; //this predicate can make use of PRIVATE fields!
        }

        public override string ToString()
        {
            return _myNum.ToString();
        }
    }
}
