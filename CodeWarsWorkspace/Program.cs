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
            Console.WriteLine(High("what time are we climbing up to the volcano"));
            Console.WriteLine(High("a b"));           

        }

        public static string High(string s)
        {   
            var ray = s.Split(" ");
            int max = 0;

            for (int i = 1; i < ray.Length; i++)
                if (PointVal(ray[max]) < PointVal(ray[i]))
                    max = i;
            return ray[max];
        }
        public static int PointVal(string word)
        {
            int points = 0;
            string check = "_abcdefghijklmnopqrstuvwxyz";
            foreach (char c in word)
                points += check.IndexOf(c);
            return points;
        }
    }
}