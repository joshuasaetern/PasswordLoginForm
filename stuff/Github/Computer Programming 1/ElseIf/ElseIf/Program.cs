using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElseIf
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
        }
        
        static void ElseIf()
        {
            //An else block only executes if previous if check failed
            //Using an else if we can ask another question when the previous
            //Result was false
            int grade = 85;
            //we can assume that grade is between 0 and 100
            if (grade >= 90)
            {
                Console.WriteLine("You got an A");
            }
            else if (grade >= 80)
            {
                Console.WriteLine("You got a B");
            }
            else if (grade >= 70)
            {
                Console.WriteLine("You got a C");
            }
            else if (grade >= 60)
            {
                Console.WriteLine("You got a D");
            }
        }
        static void LogicalOperators()
        {
            int num = 25;
            if (num >= 20 && num <=30)
            {

            }
            // check if num is less than 70 or greater than 80
            if (num < 70 || num > 80)
            {

            }
        }
    }
}
