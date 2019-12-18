using System;

namespace Markov
{
    class Program
    {
        static void Main(string[] args)
        {
            SentenceGenerator markov = new SentenceGenerator("white-waterfall.txt");

            for (;;)
            {
                string test = markov.GenerateSentence();
                Console.WriteLine(test);
                Console.ReadKey();
            }
        }
    }
}
