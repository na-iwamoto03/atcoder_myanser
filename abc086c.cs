using System;
using System.Collections.Generic;
using System.Linq;

namespace namespace1
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] s = null;
            int[] t = new int[n + 1];
            int[] x = new int[n + 1];
            int[] y = new int[n + 1];
            for(int i = 0; i < n; i++)
            {
                s = Console.ReadLine().Split();
                t[i + 1] = int.Parse(s[0]);
                x[i + 1] = int.Parse(s[1]);
                y[i + 1] = int.Parse(s[2]);
            }

            bool can = true;
            for (int i = 0; i < n; i++)
            {
                int dt = Math.Abs(t[i] - t[i + 1]);
                int dp = Math.Abs(x[i] - x[i + 1]) + Math.Abs(y[i] - y[i + 1]);
                
                if(dp > dt || dt % 2 != dp % 2)
                {
                    can = false;
                    break;
                }
            }
            
            Console.WriteLine(can ? "Yes" : "No");
            return;
        }
    }
}