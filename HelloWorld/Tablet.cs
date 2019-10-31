//This is part of a 3-file example
//1. ComputingDevices
//2. Tablet
//3. Program_AccessModifiers
using System;
namespace HelloWorld
{
    class Tablet:ComputingDevice
    {
        private int screenSize;
        public Tablet(int size)
        {
            screenSize = size;
        }
        public string CaseColor
        {
            get
            {
                return this.caseColor;
            }
        }
        public override void Read()
        {
            Console.WriteLine("Reading finger traces...");
        }
    }
}
