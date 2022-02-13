using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample_applications
{
    /* 
     * This is a sample comment written to test commits and push
     */
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(fizzbuzz(i));
            }

            Console.ReadKey();
        }

        private static string fizzbuzz(int number)
        {
            string replacement = string.Empty;

            if (number % 3 == 0) replacement += "fizz";
            if (number % 5 == 0) replacement += "buzz";

            return (replacement == string.Empty) ? number.ToString() : replacement;
        }
    }
}
