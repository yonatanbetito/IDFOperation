namespace IDFOperationFirstStrike.IDF;

public class F16 : StrikeUnit

{
    private int bombType;
    private string affectiveTarget;

    public F16() : base("F16", "full", true, 8)
    {
        bombType = 1;
        affectiveTarget = "buildings";
    }
}
