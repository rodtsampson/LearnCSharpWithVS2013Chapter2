using System;

namespace VarVsDynamic
{
    class Swapper
    {
        public void Swap(ref dynamic x, ref dynamic y) //1. using dynamic in place of double allows for the type to be established at runtime
        {
            //2. using dynamic instead of var allows for variables of different types to be swapped
            dynamic temp = x;//3. copy x into temp
            x = y;//4. copy y into x
            y = temp;//5. copy the original value of x into y
        }
        //static void Main()
        //{
        //    Swapper switcher = new Swapper();
        //    dynamic first = "great"; dynamic second = 10.6M; //6. using dynamic instead of var or strong typing allows for the types to be dynamically changed at runtime
        //    switcher.Swap(ref first, ref second);
        //    Console.Write("first=" + first + "\nsecond=" + second + "\n");
        //}
    }
}