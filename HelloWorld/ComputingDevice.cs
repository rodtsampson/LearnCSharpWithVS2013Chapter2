//This is part of a 3-file example
//1. ComputingDevices
//2. Tablet
//3. Program_AccessModifiers
using System;
namespace HelloWorld
{
    class ComputingDevice
    {
        //only child classes can access protected
        protected string caseColor = "black";
        //accessible anywhere
        public virtual void Read()
        {
            Console.WriteLine("Reading Key Strokes...");
        }
    }
}
