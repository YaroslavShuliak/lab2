using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address
{
    internal class Address
    {
        //I use sonar to understand how to write code better.
        public int Index { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public string Apartment { get; set; }
        public void DisplayName()
        {
            Console.WriteLine($"Index: {Index}; Country: {Country}; City: {City}; Street: {Street}; House: {House}; Apartment: {Apartment};");
        }
        static void Main()
        {
            Address address = new Address();
            address.Index = 16500;
            address.Country = "Украина";
            address.City = "Бахмач";
            address.Street = "Дружбы";
            address.House = "1";
            address.Apartment = "47";
            address.DisplayName();
        }
    }
}
