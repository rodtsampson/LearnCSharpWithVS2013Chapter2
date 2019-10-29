using System;

namespace ParamsKeyword
{

    class Program
    {
        //1. params keyword allow us to pass a variable number of values into the method
        //2. Doing this means a single method is more flexible
        static double FindProduct(params double[] values)
        {
            double product = 1; //3.Be sure to start with 1 so the product will not be thrown off

            foreach (var d in values)
                product *= d;//4. Needed to multiply the product and store back to the same variable 

            return product;//5. Send the value of the final product back to the calling code

        }
        //static void Main()
        //{
        //    Console.WriteLine("1*2={0}", FindProduct(1, 2));//5. Calls FindProduct with two values
        //    Console.WriteLine("1*2*3={0}", FindProduct(1, 2, 3));//6. Calls FindProduct with 3 values to show method is flexible
        //}
    }
}