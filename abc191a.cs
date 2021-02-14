using System;

namespace namespace1
{
    class Program
    {
        static void Main()
        {
            string[] R = Console.ReadLine().Split();
            int v = int.Parse(R[0]);
            int t = int.Parse(R[1]);
            int s = int.Parse(R[2]);
            int d = int.Parse(R[3]);

            if(d < v * t || v * s < d)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            return;
        }
    }
}