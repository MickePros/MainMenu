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
        public const int Infant = 0;
        public const int Junior = 80;
        public const int Adult = 120;
        public const int Elderly = 90;
        public const int Corpse = 0;

        public static int AgeGroup()
        {
            Console.Write("How old are you: ");
            int age = int.Parse(Console.ReadLine());
            if (age < 5)
            {
                return Infant;
            }
            else if (age < 21)
            {
                return Junior;
            }
            else if (age > 100)
            {
                return Corpse;
            }
            else if (age > 64)
            {
                return Elderly;
            }
            else
            {
                return Adult;
            }
            //int age = uint.TryParse();
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

        public static int GroupSize()
        {
            Console.Write("How many are you: ");
            return int.Parse(Console.ReadLine());
        }

        public static void CalculateGroupPrice(int groupSize)
        {
            double groupPrice = 0; // using double in cases where 2147483647 people want to go as a group.
            for (int i = 1; i < groupSize+1; i++)
            {
                Console.WriteLine($"Person {i}");
                groupPrice += AgeGroup();
            }
            Console.WriteLine($"For your group containing {groupSize} people, the group price is calculated to {groupPrice}kr.");
        }
    }
}
