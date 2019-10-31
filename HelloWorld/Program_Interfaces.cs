//idny
//can be used as 
//interface are usually widely applicable
using System;

namespace Interfaces
{
    interface ISaveable
    {
        //declare methods to implement
        void SaveToPdf();
        void SaveToWord();
    }
    class Invoice : ISaveable
    {
        private object[] details;
        //implements methods in class
        public Invoice(object[] det)
        {
            this.details = det;
        }
        public void SaveToPdf()
        {
            Console.WriteLine("Saving to PDF...");//in real life, you'd have to write each item out to a file
        }
        public void SaveToWord()
        {
            Console.WriteLine("Saving to Word...");//in real life, you'd have to write each item out to a file
        }
    }
    class Program
    {
        //static void Main()
        //{
        //    Invoice iv = new Invoice(new object[] { "garbage", 4500M });
        //    iv.SaveToPdf();
        //    iv.SaveToWord();
        //}
    }
}