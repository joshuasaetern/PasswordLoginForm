using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Blocks_better
{
    internal class Program
    {
        static void Main(string[] args)
        {// This is the start of the Main() Code block
            // Varibale declared in the scope of a code block can only be used there
            int num1 = 1;
            //num 1 is in scope
            num1++;
            Console.WriteLine($"Num1 is {num1}");

            {
                //Example of a variable which can only be used in a scope
                int num2 = 2;
            }
            //num2 is out of scope so the code will not compile
            num2++;


            Console.ReadLine();
        }// This is the end of the main Code Block
    }
}
