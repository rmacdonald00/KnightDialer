using System;
using System.Collections.Generic;
using System.Text;

namespace KnightDialer
{
    static class PhonePadGraphGenerator
    {
        //this assumes were using a standard phone pad as our grid


        //Gonna decide Pawns can only move 1 place always, not 2
        public static List<int>[] GetGraph(ChessPiece pieceType)
        {
            var graph = new List<int>[10];
            switch (pieceType)
            {
                case ChessPiece.Knight:
                    graph[0] = new List<int> { 4, 6 };
                    graph[1] = new List<int> { 6, 8 };
                    graph[2] = new List<int> { 7, 9 };
                    graph[3] = new List<int> { 4, 8 };
                    graph[4] = new List<int> { 3, 9, 0 };
                    graph[5] = new List<int> { };
                    graph[6] = new List<int> { 7, 1, 0 };
                    graph[7] = new List<int> { 2, 6 };
                    graph[8] = new List<int> { 1, 3 };
                    graph[9] = new List<int> { 2, 4 };
                    break;
                case ChessPiece.Bishop:
                    graph[0] = new List<int> { 9, 7 };
                    graph[1] = new List<int> { 5, 9 };
                    graph[2] = new List<int> { 4, 6 };
                    graph[3] = new List<int> { 5, 7 };
                    graph[4] = new List<int> { 2, 8 };
                    graph[5] = new List<int> { 1, 3, 7, 9 };
                    graph[6] = new List<int> { 2, 8 };
                    graph[7] = new List<int> { 3, 5 };
                    graph[8] = new List<int> { 4, 6 };
                    graph[9] = new List<int> { 1, 5 };
                    break;
                case ChessPiece.King:
                    graph[0] = new List<int> { 7, 8, 9 };
                    graph[1] = new List<int> { 2, 4, 5 };
                    graph[2] = new List<int> { 1, 3, 4, 5, 6 };
                    graph[3] = new List<int> { 2, 5, 6 };
                    graph[4] = new List<int> { 1, 2, 5, 7, 8 };
                    graph[5] = new List<int> { 1, 2, 3, 4, 6, 7, 8, 9 };
                    graph[6] = new List<int> { 2, 3, 5, 8, 9 };
                    graph[7] = new List<int> { 4, 5, 8, 0 };
                    graph[8] = new List<int> { 4, 5, 6, 7, 9, 0 };
                    graph[9] = new List<int> { 5, 6, 8, 0 };
                    break;
                case ChessPiece.Queen:
                    graph[0] = new List<int> { 2, 5, 8, 7, 9 };
                    graph[1] = new List<int> { 2, 3, 4, 7, 5, 9 };
                    graph[2] = new List<int> { 1, 3, 5, 8, 0 };
                    graph[3] = new List<int> { 1, 2, 5, 6, 7, 9 };
                    graph[4] = new List<int> { 1, 7, 5, 6, 2, 8 };
                    graph[5] = new List<int> { 1, 2, 3, 4, 6, 7, 8, 9, 0 };
                    graph[6] = new List<int> { 2, 3, 4, 5, 8, 9 };
                    graph[7] = new List<int> { 1, 4, 5, 3, 8, 9, 0 };
                    graph[8] = new List<int> { 2, 4, 5, 6, 7, 9, 0 };
                    graph[9] = new List<int> { 1, 3, 5, 6, 7, 8, 0 };
                    break;
                case ChessPiece.Rook:
                    graph[0] = new List<int> { 2, 5, 8 };
                    graph[1] = new List<int> { 2, 3, 4, 7 };
                    graph[2] = new List<int> { 1, 3, 5, 8, 0 };
                    graph[3] = new List<int> { 1, 2, 6, 9 };
                    graph[4] = new List<int> { 1, 7, 5, 6 };
                    graph[5] = new List<int> { 2, 4, 6, 8, 0 };
                    graph[6] = new List<int> { 3, 4, 5, 9 };
                    graph[7] = new List<int> { 1, 4, 8, 9 };
                    graph[8] = new List<int> { 2, 5, 7, 9, 0 };
                    graph[9] = new List<int> { 3, 6, 7, 8 };
                    break;
                case ChessPiece.PawnUp:
                    graph[0] = new List<int> { 8 };
                    graph[1] = new List<int> { };
                    graph[2] = new List<int> { };
                    graph[3] = new List<int> { };
                    graph[4] = new List<int> { 1 };
                    graph[5] = new List<int> { 2 };
                    graph[6] = new List<int> { 3 };
                    graph[7] = new List<int> { 4 };
                    graph[8] = new List<int> { 5 };
                    graph[9] = new List<int> { 6 };
                    break;
                case ChessPiece.PawnDown:
                    graph[0] = new List<int> { };
                    graph[1] = new List<int> { 4 };
                    graph[2] = new List<int> { 5 };
                    graph[3] = new List<int> { 6 };
                    graph[4] = new List<int> { 7 };
                    graph[5] = new List<int> { 8 };
                    graph[6] = new List<int> { 9 };
                    graph[7] = new List<int> { };
                    graph[8] = new List<int> { 0 };
                    graph[9] = new List<int> { };
                    break;
                case ChessPiece.PawnRight:
                    graph[0] = new List<int> { };
                    graph[1] = new List<int> { 2 };
                    graph[2] = new List<int> { 3 };
                    graph[3] = new List<int> { };
                    graph[4] = new List<int> { 5 };
                    graph[5] = new List<int> { 6 };
                    graph[6] = new List<int> { };
                    graph[7] = new List<int> { 8 };
                    graph[8] = new List<int> { 9 };
                    graph[9] = new List<int> { };
                    break;
                case ChessPiece.PawnLeft:
                    graph[0] = new List<int> { };
                    graph[1] = new List<int> { };
                    graph[2] = new List<int> { 1 };
                    graph[3] = new List<int> { 2 };
                    graph[4] = new List<int> { };
                    graph[5] = new List<int> { 4 };
                    graph[6] = new List<int> { 5 };
                    graph[7] = new List<int> { };
                    graph[8] = new List<int> { 7 };
                    graph[9] = new List<int> { 8 };
                    break;
            }
            return graph;
        }
    }
}
