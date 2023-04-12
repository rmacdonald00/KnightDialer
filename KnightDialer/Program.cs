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

            ChessPiece[] pieces = { 
                ChessPiece.King, 
                ChessPiece.Queen, 
                ChessPiece.Knight, 
                ChessPiece.Bishop, 
                ChessPiece.Rook, 
                ChessPiece.PawnUp, 
                ChessPiece.PawnDown, 
                ChessPiece.PawnRight, 
                ChessPiece.PawnLeft };

            var numToRun = 5000;

            long totalTimeForAllPieces = 0;
            foreach(var piece in pieces)
            {

                Solution kd = new Solution(piece);
                List<int> dialableNumbers = new List<int>();

                var startTime = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
                for (int i = 1; i <= numToRun; i++)
                {
                    dialableNumbers.Add(kd.KnightDialer(i));
                }
                var endTime = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();

                totalTimeForAllPieces += endTime - startTime;
                //for (int i = 0; i < dialableNumbers.Count; i++)
                //{
                //    Console.WriteLine($"{i + 1},{dialableNumbers[i]}");
                //}

                /*
                 * Runs in ~7-9 ms
                 */
                Console.WriteLine("-------------------------------------------------------------------------------------------");
                Console.WriteLine($"Piece: {piece}\nN={numToRun}: {dialableNumbers[numToRun-1]}\nStart: {startTime}\nEnd: {endTime}\nDifference: {endTime - startTime}ms");
                Console.WriteLine("-------------------------------------------------------------------------------------------");
            }
            Console.WriteLine($"Total Time Taken: {totalTimeForAllPieces}");
        }

    }
}
