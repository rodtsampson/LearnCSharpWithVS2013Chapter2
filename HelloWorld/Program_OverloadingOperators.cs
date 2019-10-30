//iwny
//giving operators a new meaning
//a vector is a listing of values
//<1,2,3>+<4,5,6>=<5,7,9>
//<1,2,3>‐<4,5,6>=<‐3,‐3,‐3>
using System;

namespace OverloadingOperators
{
    class Vector
    {
        //instance variables
        private double x, y, z;
        public Vector(double xComp, double yComp, double zComp)
        {
            x = xComp; y = yComp; z = zComp;
        }
        public static Vector operator +(Vector vec1, Vector vec2)
        {
            //new vector sums the x comp, y comp, z comp
            return new Vector(vec1.x + vec2.x, vec1.y + vec2.y, vec1.z + vec2.z);
        }
        public static Vector operator -(Vector vec1, Vector vec2)
        {
            //new vector subtracts the x comp, y comp, z comp
            return new Vector(vec1.x - vec2.x, vec1.y - vec2.y, vec1.z - vec2.z);
        }
        public override string ToString()//needed to printing a vector produces a good looking result
        {
            return "<" + x + "," + y + "," + z + ">";
        }
    }
    class Program
    {
        //static void Main()
        //{
        //    //make a new vector
        //    Vector v1 = new Vector(1, 2, 3);
        //    //make a second vector
        //    Vector v2 = new Vector(4, 5, 6);
        //    Vector sum = v1 + v2;//+operator is invoked
        //    //make a third vector
        //    Vector v3 = new Vector(1, 2, 3);
        //    //make a fourth vector
        //    Vector v4 = new Vector(4, 5, 6);
        //    Vector diff = v4 - v3;//+operator is invoked
        //    System.Console.WriteLine("Sum is " + sum.ToString());
        //    System.Console.WriteLine("Diff is " + diff.ToString());
        //}
    }
}