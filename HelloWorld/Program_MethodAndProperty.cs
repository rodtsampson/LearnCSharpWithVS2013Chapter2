using System;

namespace MethodAndProperty
{
    class Person//1. Person class functions as a template for making person objects
    {
        private static int instanceCount = 0;//2. Static instance variable instanceCount keeps track of the number of instance of a class
        private double height;//3. Instance variable stores information about each person object
                              //4. private keeps it secure
        public Person()
        {
            instanceCount++;//5. Runs every time a person instance is made, so instanceCount increases by 1
                            //6. Referenced by all instances of class
        }
        public static int Count
        {
            get
            {
                return instanceCount;//7. Gets value of total instance count 
            }
        }
        public double Height//9.Height property controls access to height backing field
        {
            get
            {
                return height;  //10. This "get" simply returns the value of the height fields when the property is called
            }
            set
            {
                if (value > 0) //11. Bit of logic ensures value of height field is sensibly set
                    height = value;
            }
        }
        public void ThrowThunderBolt()//8. Method expresses an action to be performed
        {
            Console.WriteLine("Hey, watch out!");
        }
    }
    class Program
    {
        //static void Main()
        //{
        //    Person thunder = new Person();
        //    thunder.ThrowThunderBolt();//8. Makes thunder throw thunderbolts
        //    thunder.Height = 65;//9. This uses the "set" portion of the property
        //    Person jagger = new Person();
        //    Person bob = new Person();//5. Creates two objects
        //    Console.WriteLine("The number of people is " + Person.Count);//6. Uses the get portion of Count to get number of instances of a class
        //    Console.WriteLine("I'm Thunder and I'm " + thunder.Height);//10. thunder.Height calls the "get" portion of the property
        //}
    }
}