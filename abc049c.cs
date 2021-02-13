using System;
using System.Collections.Generic;
using System.Linq;
 
namespace namespace1
{
    class Program
    {
        static void Main()
        {
            string[] divide = new string[] { "dream", "dreamer", "erase", "eraser" };
            string s = Console.ReadLine();
            
            // 重複してる文字が沢山あるため、後ろから考える
            s = string.Concat(s.Reverse());
            for(int i = 0; i < 4; i++)
            {
                divide[i] = string.Concat(divide[i].Reverse());
            }

            bool can = true;
            for (int i = 0; i < s.Length;)
            {
                bool can2 = false;
                for(int j = 0; j < 4; j++)
                {
                    string d = divide[j];
                    if (s.Length - i < d.Length) continue;
                    if (s.Substring(i, d.Length) == d)
                    {
                        i += d.Length;
                        can2 = true;
                        break;
                    }
                }
                if (!can2)
                {
                    can = false;
                    break;
                }
            }
            
            Console.WriteLine(can ? "YES" : "NO");
            return;
        }
    }
}