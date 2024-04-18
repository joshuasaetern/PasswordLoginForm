using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalOperators2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ticket();
            Console.ReadLine();
        }
        static void EmployeeAttendance()
        {
            //check if it is a weekday/holiday/onLeave
            bool holiday = true;
            bool onLeave = false;
            String dayOfTheWeek = "monday";
            //variable for result
            String result = "";
            if (holiday || onLeave)
            {
                result = "Employee does not have to be at work.";
            }
        }
        static void Ticket()
        {
            int speedLimit = 35;
            int actualSpeed = 55;
            bool suspendedLicense = false;
            int speedDifference = actualSpeed - speedLimit;

            //Check if speedDifference is slower than ten
            if (speedDifference > 9)
            { 
                //runs if speed difference is greater than 30 or suspended license
                if (suspendedLicense || speedDifference >= 30)
                {
                    Console.WriteLine("Go to Court");
                }
                //runs if speed difference is less than 20
                else if (speedDifference < 20)
                {
                    Console.WriteLine("You have to pay $40");
                }
                //Runs if speed difference is greater than 20
                else
                {
                    Console.WriteLine("You have to pay $100");
                }
            }
            //Runs if speedDifference was lower than 10
            else
            {
                Console.WriteLine("Warning");
            }
        }
    } 
}
