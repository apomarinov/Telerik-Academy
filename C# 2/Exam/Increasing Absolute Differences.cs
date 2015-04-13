using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2___Increasing_Absolute_Differences
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            //int T = 5;
            string[] numbers = new string[T];
            Dictionary<int, List<int>> absSeq = new Dictionary<int, List<int>>();
            bool[] isInc = new bool[T];


            //numbers[0] = "0 1 2 3 5";
            //numbers[1] = "2 4 7";
            //numbers[2] = "4 7 4";
            //numbers[3] = "5 7 4";
            //numbers[4] = "3 2 4 8";

            for (int i = 0; i < T; i++)
            {
                numbers[i] = Console.ReadLine();
            }

            string[] chars;
            for (int i = 0; i < T; i++)
            {
                chars = numbers[i].Split(' ');
                absSeq[i] = new List<int>(chars.Length);
                for (int j = 0; j < chars.Length - 1; j++)
                {
                    absSeq[i].Add(Math.Abs(int.Parse(chars[j]) - int.Parse(chars[j + 1])));
                }
            }

     
            for (int i = 0; i < T; i++)
            {
                isInc[i] = IsIncreasing(absSeq[i]);

            }

            for (int i = 0; i < isInc.Length; i++)
            {
                Console.WriteLine(isInc[i]);
            }
        }

        static bool IsIncreasing(List<int> seq)
        {
            for (int j = 0; j < seq.Count - 1; j++)
            {
                if (Math.Abs(seq[j] - seq[j + 1]) != 1 && Math.Abs(seq[j] - seq[j + 1]) != 0 || seq[j] > seq[j + 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}