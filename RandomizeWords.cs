using System;
using System.Linq;

namespace _02.RandomizeWords
{
    class RandomizeWords
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ').ToArray();
            Random word = new Random();
            for (int i = 0; i < words.Length; i++)
            {
                int position = word.Next(0, words.Length);
                string temp = words[i];
                words[i] = words[position];
                words[position] = temp;
            }
            Console.WriteLine(string.Join(Environment.NewLine,words));
        }
    }
}
