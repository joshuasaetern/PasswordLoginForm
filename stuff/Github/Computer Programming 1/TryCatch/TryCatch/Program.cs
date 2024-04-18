using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numString = "3.2";
            
            try
            {
                //This will run an exception error and will immediately go to catch
                int num = Convert.ToInt32(numString);
                //If this somehow compiles then it will return conversion success
                Console.WriteLine("Conversion Success!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Conversion Failed " + ex.Message);
                
            }
        }
        static void GasProblem()
        {
            //Lets prompt the user
            Console.WriteLine("Please enter the miles driven");
            String milesString = Console.ReadLine();
            Console.WriteLine("Please enter the gallons of gas used");
            String gasString = Console.ReadLine();
            Console.WriteLine("Please enter the price of gas");
            string priceString = Console.ReadLine();
            try
            {
                double milesDriven = Convert.ToDouble(milesString);
                double gasUsed = Convert.ToDouble(milesDriven);
                decimal gasPrice = Convert.ToDecimal(priceString);

            }
    }
}
