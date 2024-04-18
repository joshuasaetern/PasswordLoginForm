using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> ints = new List<int>();
            ints.Add(5);
            ints.Add(10);
            ints.AddRange(new int[] { 1, 2, 3 });
            for(int k = 0; k < ints.Count; k++)
            {
                Console.WriteLine(ints[k]);
            }
            ints.Remove()
            Console.ReadLine();
        }
    }
}
