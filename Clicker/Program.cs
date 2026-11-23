namespace Clicker;

class Program
{
    static void Main(string[] args)
    {
        // int points = 0;
        // while (true)
        // {
        //     Console.WriteLine("""
        //                       Press I to increase Points
        //                       Press S to show Points
        //                       Press Q to quit
        //                       """);
        //     var userInput = Console.ReadLine().Trim().ToUpper();
        //     if (userInput == "Q")
        //         break;
        //     if (userInput == "I")
        //     {
        //         points += 1;
        //     }
        //     else if (userInput == "S")
        //     {
        //         Console.WriteLine($"Current points: {points}");
        //     }
        // }

        ClickersClassLess.Run();
    }
}