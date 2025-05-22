namespace IDFOperationFirstStrike.IDF;

public class Drones : Strike

{
    protected double bombType;
    protected string[] affectiveTarget;

    public Drones() : base("zik", "full", false, 3)
    {
        bombType = 1;
        affectiveTarget = new []{"people","vehicles"};
}
    
    
}