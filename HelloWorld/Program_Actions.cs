//idny
using System;
using System.Collections.Generic;

namespace Actions
{
    class ActionSample
    {
        private static void Print(string s)
        {
            Console.WriteLine(s);
        }
        private static void Reverse(string s)
        {
            //great, 5 as the length, 0 to 4 on indices
            for (int i = s.Length - 1; i >= 0; i--)
            {
                //taerg
                Console.Write(s.Substring(i, 1));
            }
            Console.WriteLine();
        }
        //static void Main()
        //{
        //        Action<string> PrintIt = Print;
        //        //assign action to a function
        //        Action<string> ReverseIt = Reverse;
        //        List<string> myList = new List<string>();
        //        myList.Add("John");
        //        myList.Add("Mary");
        //        myList.Add("Smith");
        //        myList.ForEach(PrintIt + ReverseIt);
        //}
    }
}