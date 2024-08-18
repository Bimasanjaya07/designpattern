namespace Roti;

public class RotiBagel : IRoti // Concrete Product
{

    public void Resep()
    {
        Console.WriteLine("Resep Roti Bagel");
    }
    public void Panggang()
    {
        Console.WriteLine("Panggang Roti Bagel");
    }
}