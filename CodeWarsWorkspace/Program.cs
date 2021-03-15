using System;
using System.Text.RegularExpressions;

namespace CodeWarsWorkspace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(calculate("1+2"));
        }

        public static double calculate(String s)
        {
            double ans = 0.0;
            foreach (Char c in s)
                if (Char.IsDigit(c))
                    ans += c;
            return ans;
        }
    }
}
