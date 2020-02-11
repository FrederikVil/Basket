using System;

namespace Basket
{
    class Program
    {
        static void Main(string[] args)
        {
            Products Sko = new Products
            {
                Name = "Yeet Sko",
                Price = 210
            };
            Console.WriteLine($"Køb {Sko.Name}. De koster {Sko.Price} kroner");

            Customer MyCustomer = new Customer
            {
                City = "Odense",
                Code = 5250,
                Street = "Ooops 57",
                Name = "Peter Ost"
            };
            Console.WriteLine();
            Console.WriteLine(MyCustomer.Name);
            Console.WriteLine(MyCustomer.City);
            Console.WriteLine(MyCustomer.Code);
            Console.WriteLine(MyCustomer.Street);

        }
    }
}
