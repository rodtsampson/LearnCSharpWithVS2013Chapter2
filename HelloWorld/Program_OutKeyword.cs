using System;

namespace OutKeyword
{
    class Program
    {
        //1. out keyword means we can set multiple values inside a method
        //2. These values can then be accessed outside the method
        //3. This approach makes SummarizeArray more powerful than it would be otherwise
        static void SummarizeArray(double[] arr, out double max, out double min)
        {
            Array.Sort(arr);//4. Sorts array so that the max and min values can be easily found
            min = arr[0];//5. Stores the min value inside the array to the parameter named min
            max = arr[arr.Length - 1];//6. arr.Length-1 gives automatically the last index
        }

        //static void Main()
        //{
        //    double[] arr = { 5, -1, 4 };//7. This is the array we wish to summarize
        //    double max, min;//8. These will be set inside SummarizeArray, so they don't have to be set here
        //    SummarizeArray(arr, out max, out min);//9. Call to method to summarize array
        //    Console.WriteLine("max={0}, min={1}", max, min);//10. SHows values to user of program
        //}
    }
}