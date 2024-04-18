using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertTO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            String input = Console.ReadLine();
            decimal num1 = Convert.ToDecimal(input);
            Console.WriteLine($"The decimal number is {num1}");
            Console.WriteLine($"The data type is {num1.GetType()}");
            float num2 = Convert.ToSingle(input);
            Console.WriteLine($"The data type is {num2.GetType()}");
            int num3 = Convert.ToInt32(input);
            Console.WriteLine($"The data type is {num3.GetType()}");

            Console.ReadLine(); 
        }
    }
}
