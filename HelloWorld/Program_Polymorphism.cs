using System;

namespace Polymorphism
{
    //namespaces for lists
    using System.Collections.Generic;
    class ComputingDevice
    {
        //instance variable
        private string name;
        public ComputingDevice(string nam)
        {
            //set instance variable
            name = nam;
        }
        public virtual void AcceptInput()
        {
            Console.WriteLine("Configuring Common Tasks...");
        }
    }
    class LapTop : ComputingDevice
    {
        public LapTop(string name) : base(name) { }
        public override void AcceptInput()
        {
            base.AcceptInput();
            Console.WriteLine("Configuring LapTop...");
        }
    }
    class Tablet : ComputingDevice
    {
        public Tablet(string name) : base(name) { }
        public override void AcceptInput()
        {
            base.AcceptInput();
            Console.WriteLine("Configuring Tablet...");
        }
    }
    //class Program
    //{
    //    static void Main()
    //    {
    //        List<ComputingDevice> myList = new List<ComputingDevice>();
    //        //storing different kinds of objects in a base typed list
    //        //is a form of polymorphism
    //        myList.Add(new Tablet("My Kindle"));
    //        myList.Add(new LapTop("My Toshiba"));
    //        //the fact that method calls are correctly resolved at
    //        //run time is run time polymorphism
    //        foreach (ComputingDevice cd in myList)
    //        {
    //            cd.AcceptInput();
    //        }
    //    }
    //}
}