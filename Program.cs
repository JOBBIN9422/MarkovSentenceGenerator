using System;
using System.Diagnostics;

namespace Markov
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch timer = Stopwatch.StartNew();
            SentenceGenerator markov = new SentenceGenerator("clickbait.txt");
            timer.Stop();
            Console.WriteLine($"Built Markov map in {timer.ElapsedMilliseconds / 1000.0} seconds.");
            Console.WriteLine($"Token Count: {markov.TokenCount}");
            Console.WriteLine($"Key Count  : {markov.KeyCount}");

            for (;;)
            {
                string test = markov.GenerateSentence();
                Console.WriteLine(test);
                Console.ReadKey();
            }
        }
    }
}
