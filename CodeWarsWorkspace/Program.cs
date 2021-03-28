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
            int[] test = new int[] { 1, 2, 3, 4, 5, 6 };
            int[] answer = PartsSums(test);

            foreach(int num in answer)
                Console.Write($"{num} ");
        }

        
        public static int[] PartsSums(int[] ls)
        {
            return ls.Reverse().Aggregate(Enumerable.Repeat(0, 1), (a, i) => a.Prepend(a.First() + i)).ToArray();
        }
    }
}
