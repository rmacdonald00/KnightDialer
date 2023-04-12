using System;
using System.Collections.Generic;
using System.Linq;

namespace KnightDialer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Solving LeetCode 935 Knight Dialer");
            Console.WriteLine("https://leetcode.com/problems/knight-dialer/");
            Solution kd = new Solution();

            for (int i = 1; i <= 5000; i++)
            {
                Console.WriteLine($"{i},{kd.KnightDialer(i)}");
            }
        }

    }
}
