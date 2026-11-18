using System.Runtime.CompilerServices;

namespace RockPaperScissors;

class Program
{
    static void Main(string[] args)
    {
        // Steg 0 => vi trenger stein,saks,papir
        // Steg 1 => generere tilfeldig tall for cpu/datamaskin
        // Steg 2 => konvertere 1 til stein, 2 til saks, 3 til papir
        // Steg 3 => Ta i mot input fra bruker, bruker får valgene  " 1.stein, 2. saks. 3. papir"
        // Steg 4 => Sammenligne bruker input med cpu/datamaskin
        // Steg 5 => Skrive til console

        int cpuChoice = GenerateRandomNumber();
        Console.WriteLine("Enter your choice: ");
        Console.WriteLine("""
                          1. Rock
                          2. Paper
                          3. Scissors 
                          """);
        string input = Console.ReadLine();
        int userChoice = int.Parse(input);
        Console.WriteLine($"You choose : {input}");

        FindWinner(userChoice, cpuChoice);
    }

    private static void FindWinner(int userChoice, int cpuChoice)
    {
        string userChoiseAsString = NumberToChoice(userChoice);
        string cpuChoiseAsString = NumberToChoice(cpuChoice);
        if (userChoice == cpuChoice)
        {
            Console.WriteLine($"You chose {userChoiseAsString}, cpu chose {cpuChoiseAsString}. Draw");
        }

        else if (userChoice == 1 && cpuChoice == 3)
        {
            Console.WriteLine($"You chose {userChoiseAsString}, cpu chose {cpuChoiseAsString}. You win");
        }

        else if (userChoice == 2 && cpuChoice == 1)
        {
            Console.WriteLine($"You chose {userChoiseAsString}, cpu chose {cpuChoiseAsString}. You win");
        }

        else if (userChoice == 3 && cpuChoice == 2)
        {
            Console.WriteLine($"You chose {userChoiseAsString}, cpu chose {cpuChoiseAsString}. You win");
        }
        else
        {
            Console.WriteLine($"You chose {userChoiseAsString}, cpu chose {cpuChoiseAsString}, You lose");
        }
    }

    private static string NumberToChoice(int choice)
    {
        if (choice == 1)
        {
            return "Rock";
        }
        else if (choice == 2)
        {
            return "Paper";
        }
        else
        {
            return "Scissors";
        }
    }

    private static int GenerateRandomNumber()
    {
        var random = new Random();
        int randomNumber = (random.Next(1, 4));
        return randomNumber;
    }
}