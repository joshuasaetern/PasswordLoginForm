using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lecture4
{
    internal class Product
    {
        // Fields
        public String title { get; set; }
        public String director { get; set; }
        public double rating { get; set; }
        public decimal price { get; set; }
        // Default Constructor
        public Product()
        {
            title = "defaultTitle";
            director = "defaultDirector";
            rating = 0.00;
            price = 0.00m;
        }
        // Constructor
        public Product(String title, String director, double rating, decimal price)
        {
            this.title = title;
            this.director = director;
            this.rating = rating;
            this.price = price;
        }
        public override string ToString()
        {
            return $"Title: {title} Director: {director} Rating: {rating} Price: {price}";
        }
    }
}
