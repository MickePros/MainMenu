namespace Helpers
{
    public class MenuHelpers
    {
        public const string End = "0";
        public const string Ticket = "1";
        public const string Group = "2";
        public const string Repeat = "3";
        public const string Third = "4";

        public static void ShowMainMenu()
        {
            Console.WriteLine("Welcome to the MainMenu." +
                "\nChoose an action using numbers on your keyboard." +
                $"\n{End}: Close MainMenu." +
                $"\n{Ticket}: How much does a ticket cost?" +
                $"\n{Group}: Group price for tickets?" +
                $"\n{Repeat}: Repeat after me." +
                $"\n{Third}: Single out the third word from a sentence.");
        }
    }
}
