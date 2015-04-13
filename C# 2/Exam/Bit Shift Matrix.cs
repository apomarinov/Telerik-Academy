using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _3___Bit_Shift_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int R = int.Parse(Console.ReadLine()),
                C = int.Parse(Console.ReadLine()),
                N = int.Parse(Console.ReadLine());
            string[] moves = Console.ReadLine().Split(' ');

            //int R = 5, C = 6, N = 4;
            //string[] moves = "14 27 1 5".Split(' ');

            BigInteger[,] m = new BigInteger[R, C];
            bool[,] board = new bool[R, C];

            BigInteger cnt = 1, cnt2 = cnt;
            for (int i = m.GetLength(0) - 1; i >= 0; i--, cnt *= 2)
            {
                cnt2 = cnt;
                for (int j = 0; j < m.GetLength(1); j++, cnt2 *= 2)
                {
                    m[i, j] = cnt2;
                }
            }

            int[] pawnPos = new int[2];
            pawnPos[0] = R - 1;
            pawnPos[1] = 0;

            BigInteger sum = m[pawnPos[0], pawnPos[1]];

            int[] dir = new int[2];

            for (int i = 0, move, newI, newJ, coef = Math.Max(R, C); i < moves.Length; i++)
            {
                move = int.Parse(moves[i]);
                newI = move / coef;
                newJ = move % coef;

                if (pawnPos[1] < newJ)
                {
                    dir[0] = 0;
                    dir[1] = 1;
                }
                else if (pawnPos[1] > newJ)
                {
                    dir[0] = 0;
                    dir[1] = -1;
                }

                while (pawnPos[1] != newJ)
                {
                    pawnPos[1] += dir[1];
                    if (board[pawnPos[0], pawnPos[1]] == false)
                    {
                        sum += m[pawnPos[0], pawnPos[1]];
                        board[pawnPos[0], pawnPos[1]] = true;
                    }
                }

                if (pawnPos[0] < newI)
                {
                    dir[0] = 1;
                    dir[1] = 0;
                }
                else if (pawnPos[0] > newI)
                {
                    dir[0] = -1;
                    dir[1] = 0;
                }

                while (pawnPos[0] != newI)
                {
                    pawnPos[0] += dir[0];
                    if (board[pawnPos[0], pawnPos[1]] == false)
                    {
                        sum += m[pawnPos[0], pawnPos[1]];
                        board[pawnPos[0], pawnPos[1]] = true;
                    }
                }
            }

            Console.WriteLine(sum);
        }
    }
}
