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
            long x = findNb(1846180868795488225);
            Console.WriteLine(x);


        }

        public static long findNb(long m)
        {
            long cubes = 0;
            int n = 1;
            while (m > 0)
            {
                cubes += 1;
                m = (long)(m - (long)(Math.Pow(n, 3)));
                Console.WriteLine($"{n} - {m}");
                if (n == 10)
                    Console.ReadLine();
                n++;
            }
            if (m == 0)
                return cubes;
            return -1;
        }

        public static List<int> Primes(int num)
            {
                List<int> ans = new List<int>();
                int n = num;
                for(int i = 2; i<=n; i++)
                {
                   while(n%i == 0)
                   {
                      ans.Add(i);
                      n /= i;
                   }
                }

                return ans;
            }
            public static bool Solve(int a, int b)
            {
                List<int> factors = Primes(b);
                foreach (int factor in factors)
                    if (a % factor != 0)
                        return false;
                return true;
            }
        
        public static int Pairwise(int[] arr, int n)
        {
            int total = 0;
            for (int i = 0; i < arr.Length; i++)
                for (int j = i + 1; j < arr.Length; j++)
                    if (arr[i] + arr[j] == n)
                    {
                        total = total + i + j;
                        arr[j] = n + 1;
                    }

            return total;
        }

        private static List<int> OptionsGen(string digit)
        {
            List<int> ans = new List<int>();
            if(digit == "1")
            {
                ans.Add(1);
                ans.Add(2);
                ans.Add(4);
            }
            if (digit == "2")
            {
                ans.Add(1);
                ans.Add(2);
                ans.Add(3);
                ans.Add(5);
            }
            if (digit == "3")
            {
                ans.Add(3);
                ans.Add(2);
                ans.Add(6);
            }
            if (digit == "4")
            {
                ans.Add(1);
                ans.Add(4);
                ans.Add(5);
                ans.Add(7);
            }
            if (digit == "5")
            {
                ans.Add(2);
                ans.Add(4);
                ans.Add(5);
                ans.Add(6);
                ans.Add(6);
            }
            if (digit == "6")
            {
                ans.Add(3);
                ans.Add(4);
                ans.Add(6);
                ans.Add(9);
            }
            if (digit == "7")
            {
                ans.Add(4);
                ans.Add(7);
                ans.Add(8);
            }
            if (digit == "8")
            {
                ans.Add(5);
                ans.Add(7);
                ans.Add(8);
                ans.Add(9);
                ans.Add(0);
            }
            if (digit == "9")
            {
                ans.Add(6);
                ans.Add(8);
                ans.Add(9);
            }
            if (digit == "0")
            {
                ans.Add(0);
                ans.Add(8);
            }
            return ans;
        }

        public static string[] GetPINs(string observed)
        {
            string[] opp = new string[observed.Length];
            for (int i = 0; i < observed.Length; i ++)
            {
                opp[i] = observed.Substring(i, 1);
            }
            return opp;
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
