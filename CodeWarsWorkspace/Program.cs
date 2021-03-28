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
            /*
            int[] test = new int[] { 1, 2, 3, 4, 5, 6 };
            int[] answer = PartsSums(test);

            foreach(int num in answer)
                Console.Write($"{num} ");
            */

            Console.WriteLine(Thirt(321));
        }
        public static int[] rl = new int[] { 1, 10, 9, 12, 3, 4 };
        public static long Thirt(long n)
        {
            long rs = n.ToString().Reverse().Select((x, i) => rl[i % 6] * (x - 48)).Sum();
            return rs < 100 ? rs : Thirt(rs);
        }
        public static int[] PartsSums(int[] ls)
        {
            return ls.Reverse().Aggregate(Enumerable.Repeat(0, 1), (a, i) => a.Prepend(a.First() + i)).ToArray();
        }
    }
}
