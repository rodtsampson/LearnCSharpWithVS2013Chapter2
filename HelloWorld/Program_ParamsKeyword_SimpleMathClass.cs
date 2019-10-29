using System;

namespace ParamsKeyword_SimpleMathClass
{
    static class SimpleMath
    {
        //1. params keyword allow us to pass a variable number of values into the method
        //2. Doing this means a single method is more flexible
        public static double FindProduct(params double[] values)
        {
            double product = 1; //3.Be sure to start with 1 so the product will not be thrown off

            foreach (var d in values)
                product *= d;//4. Needed to multiply the product and store back to the same variable 

            return product;//5. Send the value of the final product back to the calling code

        }
        //6. params keyword allows us to pass a variable number of values into a method
        //7. Doing this means a single method is more flexible
        public static double FindSum(params double[] values)
        {
            double sum = 0;//8. Be sure to start with 0 so the sum will not be thrown off

            foreach (var d in values)
                sum += d;//9. sum+=d adds up the values in the array as the loop runs

            return sum;//10. Send total value or sum back to the body of Main
        }
    }
    class Program
    {
        //static void Main()
        //{
        //    Console.WriteLine("1*2={0}", SimpleMath.FindProduct(1, 2));//5. Calls FindProduct with two values
        //    Console.WriteLine("1*2*3={0}", SimpleMath.FindProduct(1, 2, 3));//6. Calls FindProduct with 3 values to show method is flexible
        //    Console.WriteLine("1+2={0}", SimpleMath.FindSum(1, 2));//6. Calls FindSum with 1,2
        //    Console.WriteLine("4+5+10={0}", SimpleMath.FindSum(4, 5, 10));//7. Now FindSum works with 4,5, and 10
        //}
    }
}