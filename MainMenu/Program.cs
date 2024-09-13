using Helpers;

namespace MainMenu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool keepAlive = true;

            do
            {
                MenuHelpers.ShowMainMenu();
                string input = Console.ReadLine().ToUpper();

                switch (input)
                {
                    case MenuHelpers.End:
                        keepAlive = false;
                        break;
                    case MenuHelpers.Ticket:
                        int ageGroup = Tickets.DetermineAgeGroup();
                        Tickets.PrintTicketPrice(ageGroup);
                        break;
                    case MenuHelpers.Group:
                        break;
                    case MenuHelpers.Repeat:
                        break;
                    case MenuHelpers.Third:
                        break;
                    default:
                        break;
                }
            } while (keepAlive);
        }
    }
}
