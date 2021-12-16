using System;

namespace CSharpBefore10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var person = new
            {
                Age = 1,
                Name = "Test"
            };

            var person2 = person with { Age = 2 };
        }

        static void TryNewPropertyPattern()
        {
            var personWithAddress = new Person
            {
                Address = new Address
                {
                    Apartment = "1"
                }
            };
            var hasApartment = personWithAddress switch
            {
                { Address: {Apartment: { Length: > 0 } } } => true,
                _ => false
            };
        }
    }
}
