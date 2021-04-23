using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;


namespace CodeWarsWorkspace
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test = new int[] { 1, -2, 2, 3, -4 };
            Console.WriteLine(AverageEvens(test));

        }

       
        public static double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
                return 0;
            var evens = numbers.Where(x => x % 2 == 0);
            return (double)evens.Sum() / evens.Count();
        }
    }
}
