using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Make an instance of the Product class
            //JavaScript way
            Product p1 = new Product()
            {
                Name = "Iphone",
                Price = 1000.00m,
            };
            //Other way
            //Make an empty product then set properties
            Product p2 = new Product();
            p2.Name = "4090";
            p2.Price = 2000.00m;
            //Vehichle class
            Vehicle car = new Vehicle()
            {
                Name = "car",
                Year = 2009,
                Price = 1000.00,
            };
            Console.WriteLine(car.ToString());
            car.DiscountTenPercent(car);
            Console.WriteLine(car.ToString());
            //Keep terminal open
            Console.ReadLine();
        }
    }
    /*
    public static void DiscountTenPercent(Vehicle vehicle)
    {
        vehicle.Price *= 0.10;
    }
    */
    //A class is like a blueprint
    class Product
    {
        public decimal Price { get; set; }
        public string Name { get; set; }
    }
    class Vehicle
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }
        public override string ToString()
        {
            return $"Name: {Name}, Year: {Year} Price: {Price}";
        }
        public Vehicle DiscountTenPercent(Vehicle vehicle)
        {
            vehicle.Price *= 0.10;
            return vehicle;
        }
    }
}
}
