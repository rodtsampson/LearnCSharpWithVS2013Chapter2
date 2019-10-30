using System;

namespace CustomDataType
{
    class Truck//type def.
    {
        private string make;
        //added price to original class
        private double price;
        //public double price;
        public Truck(string manufu, double cost)
        {
            //set the make instance variable
            make = manufu;
            price = cost;
        }
        public double Price
        {
            get
            {
                return price;//7. Gets value of total instance count 
            }
        }
    }
    class Dealer
    {
        //instance variables
        //defined as a single dealership
        private Truck[] trucks;
        private int truckCount;
        private double inventoryValue;
        public void AddTrucks(Truck[] trks)
        {
            trucks = trks;
            inventoryValue = 0;
            //increase truck count by length
            //of array
            truckCount += trks.Length;
            foreach (Truck t in trks)
            {
                inventoryValue += t.Price;
            }
        }
        public int TruckCount
        {
            get
            {
                return truckCount;
            }
        }
        public double InventoryValue
        {
            get
            {
                return inventoryValue;
            }
        }
    }
    class Program
    {
        static void Main()
        {
            Dealer dlr = new Dealer();
            dlr.AddTrucks(new Truck[] { new Truck("Ford", 18000), new Truck("Honda", 25000), new Truck("Ford", 23000) });
            Console.WriteLine("Trucks In Stock: " + dlr.TruckCount);
            Console.WriteLine("Dealer Value: " + dlr.InventoryValue);
        }
    }

    //Note: This class can be improved in several ways. This is a very basic example.
}