using System;

namespace VirtualMethods
{
    class Product//1. Class is used as a container for storing features common to all products, like fields and methods
    {
        private decimal price;//2. Price field is centralized so it can be easily inherited later by child classes
        protected Product(decimal p)
        {
            price = p;//3. Sets value of price for each product
        }
        public virtual string GetDescrption()//4. Method is virtual because it gets the price, which is common to all product types
        {
            return "Price: " + price;//5. The showing of the price is common to all product, so place it here
        }
    }
    class Book : Product //6. This line means that book inherits from Products, so that the price field passes into Book class
    {
        private string title;//7. This line stores a feature that is specific to books
        public Book(string t, decimal p) : base(p)//8. base(p) calls the base class constructor to set the value of the inherited price field
        {
            title = t;//9. Sets value of title becasue titles are specific to books
        }
        public override string GetDescrption()//10. OVerrides the base defintion of GetDescrption in Product class
        {
            return base.GetDescrption() + "\nTitle: " + title;//11. This line calls the base GetDescrption method to reuse code in the form
                                                        //    of getting the price. Then also it adds a touch of refinement by
                                                        //    displaying the title, which is specific to books
        }
    }

    class Program
    {
        //static void Main()
        //{
        //    Book bk = new Book("Tales From Long Ago...", 25.99M);//12. Creates a book item
        //    Console.WriteLine(bk.GetDescrption());//13. Calls GetDescrption to show description of book
        //}
    }
}