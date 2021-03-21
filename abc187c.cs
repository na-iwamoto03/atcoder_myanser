using System;
using System.Collections.Generic;

namespace namespace1
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, bool> s1 = new Dictionary<string, bool>();
            
            for (int i = 0; i < n; i++)
            {
                string s = Console.ReadLine();

                bool useb = false;
                if (s[0] == '!')
                {
                    s = s.Substring(1);
                    useb = true;
                }

                if(!s1.ContainsKey(s))
                {
                    s1.Add(s, useb);
                    continue;
                }

                if(s1[s] ^ useb)
                {
                    Console.WriteLine(s);
                    return;
                }
            }
            
            Console.WriteLine("satisfiable");
            return;
        }
    }
}