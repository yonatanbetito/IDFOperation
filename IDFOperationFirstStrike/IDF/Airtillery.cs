namespace IDFOperationFirstStrike.IDF;

public class Airtillery: StrikeUnit
{
    protected string bombType;
    protected string affectiveTarget;

    public Airtillery() : base("Airtillery", "full", true, 3)
    {
        bombType = "explosive";
        affectiveTarget = "buildings";
    }
}