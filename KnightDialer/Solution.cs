using System.Collections.Generic;

namespace KnightDialer
{
    public class Solution
    {
        private readonly KnightDialerClass _kd;
        public Solution()
        {
            _kd = new KnightDialerClass();
        }
        public int KnightDialer(int n)
        {
            return (int)_kd.GetAmountOfDistinctNumbersOfLengthN(n);
        }

        private class KnightDialerClass
        {
            private List<int>[] graphNeighbors = new List<int>[10]
            {
                new List<int> {4,6},
                new List<int> {6,8},
                new List<int> {7,9},
                new List<int> {4,8},
                new List<int> {3,9,0},
                new List<int> {},
                new List<int> {7,1,0},
                new List<int> {2,6},
                new List<int> {1,3},
                new List<int> {2,4}
            };

            private long?[,] memoryArray = new long?[10, 5000];
            private long modulus = 1000000007;

            private long GetCountStartingOnKeyForN(int n, int startingKey)
            {
                if (n == 0)
                {
                    return 1;
                }

                var memory = memoryArray[startingKey, n];
                if (memory != null)
                {
                    return (int)memory;
                }
                else
                {
                    var neighbors = graphNeighbors[startingKey];
                    long totalOfNeighbors = 0;
                    foreach (var neighbor in neighbors)
                    {
                        totalOfNeighbors += (GetCountStartingOnKeyForN(n - 1, neighbor));
                    }
                    var modValue = totalOfNeighbors % modulus;
                    memoryArray[startingKey, n] = modValue;
                    return modValue;
                }
            }

            public long GetAmountOfDistinctNumbersOfLengthN(int n)
            {
                long total = 0;
                for (int i = 0; i <= 9; i++)
                {
                    total += GetCountStartingOnKeyForN(n - 1, i);
                    total = total % modulus;
                }
                return total;
            }
        }
    }
}
