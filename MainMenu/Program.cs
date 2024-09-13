using Helpers;

namespace MainMenu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool keepAlive = true;
            int repeat = 10;
            int split = 3;

            do
            {
                MenuHelpers.ShowMainMenu(repeat, split);
                string input = Console.ReadLine();

                switch (input)
                {
                    case MenuHelpers.End:
                        keepAlive = false;
                        break;
                    case MenuHelpers.Ticket:
                        Console.Clear();
                        int ageGroup = Tickets.AgeGroup();
                        Tickets.PrintTicketPrice(ageGroup);
                        break;
                    case MenuHelpers.Group:
                        Console.Clear();
                        int groupSize = Tickets.GroupSize();
                        Tickets.CalculateGroupPrice(groupSize);
                        break;
                    case MenuHelpers.Repeat:
                        Console.Clear();
                        Words.RepeatWord(repeat);
                        break;
                    case MenuHelpers.Split:
                        Console.Clear();
                        Words.SplitSentence(split);
                        break;
                    default:
                        break;
                }
            } while (keepAlive);
        }
    }
}
