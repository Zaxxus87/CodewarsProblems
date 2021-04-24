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
            string guess = Buddy(48, 50);
            foreach (var item in collection)
            {

            }

            //{ 20, 20, 19, 16, 10, 0 });

        }


        public static string Buddy(long start, long limit)
        {
            List<int> buddy1 = new List<int>() { 1 };
            List<int> buddy2 = new List<int>() { 1 };
            for (int i = (int)start; i <= limit; i++)
            {
                int stop = (int)(Math.Sqrt(i));
                for (int j = 2; j < stop; j++)
                    if (i % j == 0)
                    {
                        buddy1.Add(j);
                        buddy2.Add(i / j);
                    }
            }
            return buddy1.ToString();
        }
    }
}
