using System;

namespace AbstractClassesAndMethods
{
    abstract class ThreeDShape
    {
        //abstract method
        //because there are many ways of finding volumes
        //it does not make sense to provide an implementation of GetVolume
        //but all ThreeDShapes do possess a volume, so it makes sense to declare a method
        public abstract double GetVolume();
    }
    class Sphere : ThreeDShape
    {
        //distance from center
        //to point on surface of sphere
        private double radius;
        public Sphere(double r)
        {
            this.radius = r;//set instance variable
        }
        public override double GetVolume()
        {
            //4/3*pi*r^3
            return (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
        }
    }
    class Cube : ThreeDShape
    {
        private double edge;
        public Cube(double edgeLength) { this.edge = edgeLength; }
        public override double GetVolume()
        {
            //edge^3
            return Math.Pow(edge, 3);
        }
    }
    class UseShapes
    {
        static void Main()
        {
            Console.WriteLine("Volume of Sphere: " + Math.Round(new Sphere(5).GetVolume(), 2));
            Console.WriteLine("Volume of Cube: " + new Cube(5).GetVolume());
        }
    }
}