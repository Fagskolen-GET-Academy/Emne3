namespace Demo
{
    internal class Program
    {
         static void Main(string[] args)
        {
            var random = new Random();
            var number = random.Next(1, 100);

            Console.WriteLine("Gjett det hemmelige tallet fra 1 til 100");
            Console.WriteLine("Skriv ditt nummer");
            var input = Console.ReadLine();

            int result = Convert.ToInt32(input);

            Console.WriteLine("Du skrev "+ result);
            if (result == number)
            {
                Console.WriteLine("Du gjettet riktig");
            }
            else
            {
                Console.WriteLine("Du gjettet feil :(");
            }

        }
    }
}
