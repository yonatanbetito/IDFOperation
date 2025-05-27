namespace IDFOperationFirstStrike.IDF;

public abstract class StrikeUnit
{
    protected string Name;
    protected string Fuel;
    protected bool operatedByPilot;
    protected int numberOfBombs;

    protected StrikeUnit(string name, string fuel, bool operatedByPilot, int numberOfBombs)
    {
        Name = name;
        Fuel = fuel;
        this.operatedByPilot = operatedByPilot;
        this.numberOfBombs = numberOfBombs;
    }
    
    
    
    
    
    
}