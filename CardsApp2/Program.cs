namespace CardsApp2;

class Program
{
    static void Main(string[] args)
    {
        var minFarge = (Suit)1;
        var minVerdi = (Rank)2; 
        
        Card myCard = new Card(minVerdi, minFarge);

        Console.WriteLine($"The card is {myCard.Verdi} of {myCard.Farge}");

    }
}