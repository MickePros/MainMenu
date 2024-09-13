using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helpers;

namespace MainMenu
{
    internal class Words
    {
        public static void RepeatWord(int times)
        {
            string phrase = Utils.ValidateInput($"Enter a phrase you would like me to repeat {times} times for you.", 0);
            for (int i = 1; i < times+1; i++)
            {
                Console.Write($"{i}. {phrase}, ");
            }
        }

        public static void SplitSentence(int split)
        {
            string input = Utils.ValidateInput($"Enter a sentence you would like me to split and return the word in position {split}.", split);
            string[] phrase = input.Split(' ', StringSplitOptions.RemoveEmptyEntries); //We split the input and ignore empty entries
            Console.WriteLine($"{phrase[split - 1]}");
        }
    }
}
