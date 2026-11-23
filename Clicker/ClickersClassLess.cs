namespace Clicker;

public class ClickersClassLess
{
    public static void Run()
    {
        int[] Clickers = new int[3];

        while (true)
        {
            Console.WriteLine("Choose clicker (1-3)");
            var userChoice = Console.ReadLine().Trim().ToUpper();
            if (!int.TryParse(userChoice, out int number) || number < 1 || number > 3)
            {
                Console.WriteLine("Please enter a valid number");
                continue;
            }
            
            int index = number - 1;

            Console.WriteLine("""
                              Press I to increase Points
                              Press S to show Points
                              Press Q to quit
                              """);
            var userInput = Console.ReadLine().Trim().ToUpper();

            if (userInput == "Q")
            {
                break;
            }

            if (userInput == "I")
            {
                Clickers[index] += 1;
            }
            else if (userInput == "S")
            {
                Console.WriteLine($"Clicker {number}: has {Clickers[index]} points");
            }
        }
    
    
    }
}