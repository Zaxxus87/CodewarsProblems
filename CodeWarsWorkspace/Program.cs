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
            Console.WriteLine(NbDig(0, 0));
                  

        }

        public static int ContainsDig(int num, int digit)
        {
            int count = 0;
            while (num > 0)
            {
                if (num % 10 == digit)
                    count++;
                num /= 10;
            }
            return count;
        }

        public static int NbDig(int n, int d)
        {
            int count = 0;
            for (int i = 0; i < n + 1; i++)
                count += (ContainsDig(i * i, d));
            return count;

        }
    }
}
