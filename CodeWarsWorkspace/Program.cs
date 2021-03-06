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
            string problem = "\n\n\na\nb\n\n";
            string[] stringRay = problem.Split("\n");
            string[] commentSymbols = new string[] { "#", "!" };
            int index = 0;
            for (int i = 0; i < stringRay.Length; i++)
            {
                for (int j = 0; j < commentSymbols.Length; j++)
                {
                    index = stringRay[i].IndexOf(commentSymbols[j]);
                    if (index >= 0)
                    {
                        stringRay[i] = stringRay[i].Substring(0, index);
                        stringRay[i] = stringRay[i].TrimEnd();
                    }
                }
            }
            string ans = "";
            for (int i = 0; i < stringRay.Length - 1; i++)
                if (String.IsNullOrEmpty(ans))
                    ans += "\n";
                else
                    ans += stringRay[i];
            ans += stringRay[stringRay.Length - 1];

            Console.WriteLine(ans);
            //[15, 135, 49, 18]

        }


        public static int[] Solve(int a, int b, int c, int alpha, int beta, int gamma)
        {
            double pi = 3.14159265358979323846;
            int[] ans = new int[4];
            int zeta = 90 + alpha - beta;
            double zetaR = zeta/180.0*pi;
            double betaR = beta/180.0 * pi;
            double gammaR = gamma/180.0 * pi;
            double K = Math.Sqrt(a * a + b * b - 2 * a * b * Math.Cos(zetaR));
            double Theta = Math.Acos((a * a - K * K - b * b) / (-2 * K * b));
            double Kappa = pi/2 + betaR - Theta - gammaR;
            double d = Math.Sqrt(K*K + c*c -2*K*c*Math.Cos(Kappa));
            ans[0] = (int)Math.Round(d);
            double A2 = (Math.Acos((b * b - a * a - K * K) / (-2 * a * K)))/pi*180.0;
            double A3 = (Math.Acos((c * c - d * d - K * K) / (-2 * d * K)))/pi*180.0;
            double angle = alpha + A2 + A3;
            ans[1] = (int)angle;
            angle = (angle - ans[1])*60;
            ans[2] = (int)angle;
            ans[3] = (int)((angle - ans[2]) * 60);
            return ans;
        }
    }
}
