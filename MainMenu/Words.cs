using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMenu
{
    internal class Words
    {
        public static void RepeatWord(int times)
        {
            Console.WriteLine($"Enter a phrase you would like me to repeat {times} times for you.");
            string phrase = Console.ReadLine();
            for (int i = 1; i < times+1; i++)
            {
                Console.Write($"{i}. {phrase}, ");
            }
        }

        public static void SplitSentence(int split)
        {
            Console.WriteLine($"Enter a sentence you would like me to split and return the word in position {split}.");
            string[] phrase = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries); //We split the input and ignore empty entries
            Console.WriteLine($"{phrase[split - 1]}");
        }
    }
}
