using System;

namespace Inheritence
{
    class Vehicle//1. Declares Vehicle class as a place to store common characteristics
    {
        private string make;//2. We imagine make as a common feature of all vehicles so make will be inherited
        protected Vehicle(string mk)//3. protected means this constructor can be run only from within child or derived classes
        {
            make = mk;//4. This runs to set the value of  the make of a vehicle
        }
        public string Make//5. Make property will be inherited by derived or child classes
        {
            get { return make; }//6. Gets the value of the make backing field
        }
    }

    class GasCar : Vehicle //7. The field called "make" and the property called "Make" pass into GasCar
    {
        private double tankCapacity;//8. This line adds a degree of refinement to the Gas Car class
        public GasCar(double capacity, string mk) : base(mk)//9. base(mk) means call the base class constructor to set the value of the make
        {
            tankCapacity = capacity;//10. Sets the tank capacity for a gas car
        }
        public double Capacity//11. Property gets the value of the tankCapacity backing field
        {
            get { return tankCapacity; }
        }
    }

    class Program
    {
        //static void Main()
        //{
        //    GasCar gc = new GasCar(15, "Honda");//12. Creates a new gas car object
        //    Console.WriteLine("Capacity is " + gc.Capacity);//13. Shows capacity of gas car
        //    Console.WriteLine("Make of car is " + gc.Make);//14. Uses Make property 
        //}
    }
}
