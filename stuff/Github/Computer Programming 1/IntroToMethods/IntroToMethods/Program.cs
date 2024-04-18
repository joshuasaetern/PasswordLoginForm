using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToMethods
{
    internal class Program
    {
        static void Main(string[] args) {

            MyFirstMethod();
            AnotherMethod(1, 2);

            Console.ReadLine();
        }

        //Methods are made outside of main but inside the class

        static void MyFirstMethod()
        {
            Console.WriteLine("Hello");
        }
        static void AnotherMethod(int x, int y)
        {
            int sum = x + y;
            Console.WriteLine(sum);
        }
       

    }
}
