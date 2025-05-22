namespace IDFOperationFirstStrike.IDF;

public class Airtillery: Strike
{
    protected string bombType;
    protected string affectiveTarget;

    public Airtillery() : base("Airtillery", "full", true, 3)
    {
        bombType = "explosive";
        affectiveTarget = "buildings";
    }
}