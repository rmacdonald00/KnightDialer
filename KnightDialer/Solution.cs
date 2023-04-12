using System.Collections.Generic;

namespace KnightDialer
{
    public class Solution
    {
        private readonly KnightDialerClass _kd;
        public Solution(ChessPiece pieceType)
        {
            var knightNeighbors = PhonePadGraphGenerator.GetGraph(pieceType);
            long modulus = 1000000007;


            _kd = new KnightDialerClass(knightNeighbors, 5000, modulus);
        }
        public int KnightDialer(int n)
        {
            int[] validStartingNodes = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            return (int)_kd.GetAmountOfDistinctNumbersOfLengthN(n, validStartingNodes);
        }

        private class KnightDialerClass
        {
            private readonly List<int>[] _graphNeighbors;
            private readonly long _modulus;
            private long?[,] _memoryArray;

            public KnightDialerClass(List<int>[] graphAdjList, int maxN, long modulus)
            {
                _graphNeighbors = graphAdjList;
                _memoryArray = new long?[graphAdjList.Length, maxN];
                _modulus = modulus;
            }
           


            private long GetCountStartingOnKeyForN(int n, int startingKey)
            {
                if (n == 0)
                {
                    return 1;
                }

                var memory = _memoryArray[startingKey, n];
                if (memory != null)
                {
                    return (int)memory;
                }
                else
                {
                    var neighbors = _graphNeighbors[startingKey];
                    long totalOfNeighbors = 0;
                    foreach (var neighbor in neighbors)
                    {
                        totalOfNeighbors += (GetCountStartingOnKeyForN(n - 1, neighbor));
                    }
                    var modValue = totalOfNeighbors % _modulus;
                    _memoryArray[startingKey, n] = modValue;
                    return modValue;
                }
            }

            public long GetAmountOfDistinctNumbersOfLengthN(int n, int[] validStartingNodes)
            {
                long total = 0;
                foreach (var node in validStartingNodes)
                {
                    total += GetCountStartingOnKeyForN(n - 1, node);
                    total = total % _modulus;
                }
                return total;
            }
        }
    }
}
