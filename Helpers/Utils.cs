using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers
{
    public class Utils
    {
        public static string ValidateInput(string promt, int length)
        {
            string input = "";
            bool valid = false;
            do
            {
                Console.WriteLine(promt);
                input = Console.ReadLine();
                string[] inputArray = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);  //Split sring into array while ignoring additional blank spaces
                if (string.IsNullOrEmpty(input))    //Check if input is empty
                {
                    Console.WriteLine("Empty input, please try again");
                    continue;
                }
                else if (inputArray.Length < length)    //Check if input is long enough
                {
                    Console.WriteLine($"Sentence is too short, sentence need to be at least {length} words long");
                }
                else
                {
                    valid = true;
                }
            } while (!valid);   //Do while valid is set to not true

            return input;
        }

        public static uint ValidateNumber(string prompt)
        {
            do
            {
                string input = ValidateInput(prompt, 0);
                if (uint.TryParse(input, out uint result))  //Check if input is a valid uint (0 to 4,294,967,295)
                {
                    return result;
                }
                else
                {
                    Console.WriteLine($"Please enter a valid number");
                }
            } while (true);
        }
    }
}
