using System;

namespace StaticClass
{
    static class FinMath//1. This class functions as a container for some math operations
    {
        public static decimal GetInterest(decimal amount) //2. This method allows us to find the interest
        {                                                 //3. on money invested. Interest=Amount*rate. This is one year.
            return amount * 0.05M;
        }
    }

    class Program
    {
        //static void Main()
        //{
        //    //4.Display prompt to user
        //    Console.WriteLine("Enter Amount:");
        //    //5. On the right, we use method nesting. ReadLine is nested in Parse. ReadLine runs first, and that value
        //    //6. is then fed into Parse. That value is then saved to amt. 
        //    decimal amt = decimal.Parse(Console.ReadLine());

        //    //7. GetInterest is called directly on the class because it's a static method
        //    Console.WriteLine("After one year, the interest is {0:C}", FinMath.GetInterest(amt));

        //}
    }
}