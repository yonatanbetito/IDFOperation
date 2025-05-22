namespace IDFOperationFirstStrike.IDF;

public abstract class Strike
{
    protected string Name;
    protected string Fuel;
    protected bool operatedByPilot;
    protected int numberOfBombs;

    protected Strike(string name, string fuel, bool operatedByPilot, int numberOfBombs)
    {
        Name = name;
        Fuel = fuel;
        this.operatedByPilot = operatedByPilot;
        this.numberOfBombs = numberOfBombs;
    }
    
    
    
    
    
    
}