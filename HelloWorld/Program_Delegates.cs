using System;

namespace Delegates
{
    public delegate void MathOp(double x, double y);
    static class MathOps
    {
        public static void Add(double x, double y) { Console.WriteLine(x + y); }
        public static void Multiply(double x, double y) { Console.WriteLine(x * y); }
        public static void Divide(double x, double y) { Console.WriteLine((y!=0)? x / y: 0); }
    }
    class Program
    {
        //static void Main()
        //{
        //    MathOp add = MathOps.Add, multiply = MathOps.Multiply, divide = MathOps.Divide, all;
        //    all = add + multiply + divide;
        //    all(4, 5);
        //}
    }
}