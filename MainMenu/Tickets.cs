using Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMenu
{
    internal class Tickets
    {
        public const int Junior = 80;
        public const int Adult = 120;
        public const int Elderly = 90;

        public static int DetermineAgeGroup()
        {
            Console.Write("How old are you: ");
            int age = int.Parse(Console.ReadLine());
            if (age < 21)
            {
                return Junior;
            }else if (age > 64)
            {
                return Elderly;
            }
            else
            {
                return Adult;
            }
            //int age = uint.TryParse();
            return 0;
        }

        public static void PrintTicketPrice(int price)
        {
            switch (price)
            {
                case 80:
                    Console.WriteLine($"Ungdomspris: {price}kr");
                    break;
                case 120:
                    Console.WriteLine($"Standardpris: {price}kr");
                    break;
                case 90:
                    Console.WriteLine($"Pensionärspris: {price}kr");
                    break;
                default:
                    break;
            }
        }
    }
}
