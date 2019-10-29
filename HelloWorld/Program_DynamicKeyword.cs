//dynamic keyword
//operations of this type are resolved at run type
using System;

namespace DynamicKeyword
{
    class DynamicCalc
    {
        public dynamic Add(dynamic x, dynamic y)
        {
            return x + y;
        }
        public dynamic Divide(dynamic x, dynamic y)
        {
            //check for division by 0 with
            //ternary operator
            return y != 0 ? x / y : 0;
        }
    }
    class Program
    {
        //static void Main()
        //{
        //    DynamicCalc myCalc = new DynamicCalc();
        //    //treats 4,5 as integers
        //    Console.WriteLine("Sum is " + myCalc.Add(4, 5));
        //    //treats as long, and double
        //    Console.WriteLine("Ratio is " + myCalc.Divide(45798353543, 56565.45));
        //}
    }
}