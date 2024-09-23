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
        public const int InfantPrice = 0;
        public const int JuniorPrice = 80;
        public const int AdultPrice = 120;
        public const int ElderlyPrice = 90;
        public const int CorpsePrice = 0;

        public static int AgeGroup()
        {
            uint age = Utils.ValidateNumber("How old are you?");
            if (age < 5)
            {
                return InfantPrice;
            }
            else if (age < 21)
            {
                return JuniorPrice;
            }
            else if (age > 100)
            {
                return CorpsePrice;
            }
            else if (age > 64)
            {
                return ElderlyPrice;
            }
            else
            {
                return AdultPrice;
            }
        }

        public static void PrintTicketPrice(int price)
        {
            switch (price)
            {
                case 0:
                    Console.WriteLine($"Bebisar och Odödliga går gratis: {price}kr");
                    break;
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

        public static uint GroupSize()
        {
            return Utils.ValidateNumber("How many are you?");
        }

        public static void CalculateGroupPrice(uint groupSize)
        {
            double groupPrice = 0; // using double in cases where 4,294,967,295 people want to go as a group.
            for (int i = 1; i <= groupSize; i++)
            {
                Console.WriteLine($"Person {i}");
                groupPrice += AgeGroup();
            }
            Console.WriteLine($"For your group containing {groupSize} people, the group price is calculated to {groupPrice}kr.");
        }
    }
}
