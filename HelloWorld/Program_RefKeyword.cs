using System;

namespace RefKeyword
{
    class Program
    {
        //1. ref is a keyword that allows us to pass simple data types by reference
        static void Swap(ref double x, ref double y)
        {
            //Big Idea: Whatever changes are made here to x and y are also visible inside the body of Main
            //          and this is NOT normally the case when using data types like double for x and y
            double temp = x;//1. Stores x value to a temporary holding location
            x = y;//2. Store the value of y to x
            y = temp;//3. Store value of x back to y
        }
        //static void Main()
        //{
        //    double x = 5, y = 10;//4. These are the variables we want to swap
        //    Swap(ref x, ref y);//5. Make sure ref is included so call matches the method header
        //    Console.WriteLine("x={0}, y={1}", x, y);//6. Prints the values of x and y
        //}
    }
}
