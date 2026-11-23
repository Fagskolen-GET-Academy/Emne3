namespace Clicker;

public class Clicker
{
    private int points;

    public Clicker()
    {
        points = 0;
    }

    public void increasePoints()
    {
        points++;
    }
    
    public void decreasePoints()
    {
        points--;
    }
    
    public void showPoints()
    {
        Console.WriteLine(points);
    }
}