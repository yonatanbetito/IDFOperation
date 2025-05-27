namespace IDFOperationFirstStrike.IDF;

public class StrikeUnit
{
    protected string name;
    protected int numberOfBombs;

    public string GetName()
    {
        return name;
    }

    public int GetRemainingStrikes()
    {
        return numberOfBombs;
    }
}