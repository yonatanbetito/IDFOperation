namespace IDFOperationFirstStrike.IDF;

internal abstract class StrikeUnit
{
    public string Name;
    public int Fuel;
    public string EffectiveAgainst;
    public int numberOfBombs;

    
    //תקיפה
    public abstract void Strike(string target);
    
}

    internal class Hermes : StrikeUnit
    {
        public Hermes()
        {
            Name = "Hermes 460 Drone";
            numberOfBombs = 3;
            Fuel = 100;
            EffectiveAgainst = "people, vehicles";
        }

        // מבצע תקיפה עם כטב"ם הרמס
        public override void Strike(string target)
        {
            Console.WriteLine("Drone strike on " + target + " with bomb!");
            numberOfBombs--;
        }
    }
    
    internal class M109 : StrikeUnit
    {
        public M109()
        {
            Name = "M109 Artillery";
            numberOfBombs = 40;
            Fuel = 100;
            EffectiveAgainst = "open areas";
        }

        // מבצע תקיפה עם M109
        public override void Strike(string target)
        {
            Console.WriteLine("artillery strike on " + target + " with explosive shells!");
            numberOfBombs = numberOfBombs - 3;
        }
    }
    
    internal class F16 : StrikeUnit
    {
        public F16()
        {
            Name = "F16 Fighter Jet";
            numberOfBombs = 8;
            Fuel = 100;
            EffectiveAgainst = "buildings";
        }

        // מבצע תקיפה עם F16
        public override void Strike(string target)
        {
            Console.WriteLine("F16 strike on " + target + " with 1 ton bomb!");
            numberOfBombs--;
        }
    }
    
