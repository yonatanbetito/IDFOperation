namespace IDFOperationFirstStrike.IDF;

public class F16 : Strike

{
    private int bombType;
    private string affectiveTarget;

    public F16() : base("F16", "full", true, 8)
    {
        bombType = 1;
        affectiveTarget = "buildings";
    }

public void PrintDetails()
    {
        Console.WriteLine($"F16 Details:");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Fuel: {Fuel}");
        Console.WriteLine($"Bomb Type: {bombType}");
        Console.WriteLine($"Affective Target: {affectiveTarget}");
        Console.WriteLine($"Operated By Pilot: {operatedByPilot}");
        Console.WriteLine($"Number Of Bombs: {numberOfBombs}");
    }
}
