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
            List<int> dialableNumbers = new List<int>();

            var startTime = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
            for (int i = 1; i <= 5000; i++)
            {
                dialableNumbers.Add(kd.KnightDialer(i));
            }
            var endTime = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();


            for (int i = 0; i <= 4999; i++)
            {
                Console.WriteLine($"{i},{dialableNumbers[i]}");
            }

            /*
             * Runs in ~7-9 ms
             */

            Console.WriteLine($"Start: {startTime}\nEnd: {endTime}\nDifference: {endTime - startTime}ms");
        }

    }
}
