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

            
            */
            var y = Primes(1101);
            var x = SameFactRev(2500000);
            foreach(int num in x)
                Console.WriteLine(num);

        }


        public static int[] SameFactRev(int nMax)
        {
            var ans = new List<int>();
            for (int i = 1089; i < nMax; i++)
            {
                if (i != ReverseNum(i))
                {
                    var set1 = new HashSet<int>(Primes(i));
                    var set2 = new HashSet<int>(Primes(ReverseNum(i)));
                    if (set1.SetEquals(set2))
                        ans.Add(i);
                }
                
            }              
            return ans.ToArray();
        }
        
        public static int ReverseNum(int num)
        {
            int ans = 0;
            int i = 0;
            while (num > 0)
            {
                ans = ans * 10 + num % 10;
                i++;
                num /= 10;
            }
            return ans;
        }

        public static int[] Primes(int num)
        {
              List<int> ans = new List<int>();
              int n = num;
              while(n%2 == 0)
              {
                    ans.Add(2);
                    n /= 2;                
              }
            for (int i = 3; i <= Math.Sqrt(n); i = i + 2)
            {
                while (n % i == 0)
                {
                    ans.Add(i);
                    n /= i;
                }
            }
            if (n > 2)
                ans.Add(n);
            
                return ans.ToArray();
            
        }
            public static bool Solve(int a, int b)
            {
                int[] factors = Primes(b);
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
