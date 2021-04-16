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
            Console.WriteLine(TwiceAsOld(30, 0));
            Console.WriteLine(TwiceAsOld(30, 7));           

        }

        public static int TwiceAsOld(int dadYears, int sonYears)
        {
            var twice = sonYears * 2;
            if (twice < dadYears)
                return dadYears - twice;
            else if (twice > dadYears)
                return twice - dadYears;
            else
                return 0;
        }
    }
}
