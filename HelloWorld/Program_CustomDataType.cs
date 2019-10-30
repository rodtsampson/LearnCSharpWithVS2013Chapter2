using System;

namespace CustomDataType
{
    class Truck//type def.
    {
        private string make;
        //add price
        public Truck(string manufu)
        {
            //set the make instance variable
            make = manufu;
        }
    }
    class Dealer
    {
        //instance variables
        //defined as a single dealership
        private Truck[] trucks;
        private int truckCount;
        public void AddTrucks(Truck[] trks)
        {
            trucks = trks;
            //increase truck count by length
            //of array
            truckCount += trks.Length;
        }
        public int TruckCount
        {
            get
            {
                return truckCount;
            }
        }
    }
    class Program
    {
        static void Main()
        {
            Dealer dlr = new Dealer();
            dlr.AddTrucks(new Truck[] { new Truck("Ford"), new Truck("Honda"), new Truck("Ford") });
            Console.WriteLine("Truck In Stock: " + dlr.TruckCount);
        }
    }

    //Note: This class can be improved in several ways. This is a very basic example.
}