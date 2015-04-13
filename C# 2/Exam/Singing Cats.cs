using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingingCats
{
    class Program
    {
        static void Main(string[] args)
        {
            int cats = int.Parse(Console.ReadLine().Split(' ')[0]);
            int songs = int.Parse(Console.ReadLine().Split(' ')[0]);

            Dictionary<int, List<int>> catSongs = new Dictionary<int, List<int>>();

            string input = Console.ReadLine();

            int key;
            while (input != "Mew!")
            {
                key = int.Parse(input.Split(' ')[1]);
                if (!catSongs.ContainsKey(key))
                {
                    catSongs[key] = new List<int>();
                }
                catSongs[int.Parse(input.Split(' ')[1])].Add(int.Parse(input.Split(' ')[4]));
                input = Console.ReadLine();
            }

            if (catSongs.Count != cats)
            {
                Console.WriteLine("No concert!");
                return;
            }

            int[] min = catSongs[1].ToArray();
            int minSongs = 1;

            for (int i = 2; i <= catSongs.Count; i++)
            {
                min = min.Intersect(catSongs[i].ToArray()).ToArray();
            }

            if (cats > 1)
            {
                if (min.Length == 0)
                {
                    minSongs = songs;
                }
                else
                {
                    minSongs = min.Length;
                }
            }

            //for (int i = 1; i <= catSongs.Count; i++)
            //{
            //    for (int j = 0; j < catSongs[i].Count; j++)
            //    {
            //        Console.WriteLine(i + " " + catSongs[i][j]);   
            //    }
            //}

            Console.WriteLine(minSongs);
        }
    }
}

