using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace namespace1
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int players = (int)Math.Pow(2, n);
            
            int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] b = new int[players / 2];
            int[] c = new int[players / 2];

            for(int i = 0; i < players / 2; i++)
            {
                b[i] = a[i];
                c[i] = a[players / 2 + i];
            }

            int answer = 0;
            int bmax = b.Max();
            int cmax = c.Max();
            if(bmax > cmax)
            {
                for(int i = 0; i < players / 2; i++)
                {
                    if(c[i] == cmax)
                    {
                        answer = players / 2 + i;
                    }
                }
            }
            else
            {
                for (int i = 0; i < players / 2; i++)
                {
                    if (b[i] == bmax)
                    {
                        answer = i;
                    }
                }
            }

            Console.WriteLine(answer + 1);
            return;
        }
    }
}