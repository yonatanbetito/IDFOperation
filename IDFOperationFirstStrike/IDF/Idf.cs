namespace IDFOperationFirstStrike.IDF;
using IDFOperationFirstStrike.HAMAS;
internal class Idf
{
   public string Commander;
   public DateTime DateFormation;
   public List<StrikeUnit> StrikeUnits = new List<StrikeUnit>();

   public Idf(string commander)
   {
      Commander = commander;
      DateFormation = DateTime.Now;
      StrikeUnits.Add(new F16());
      StrikeUnits.Add(new Hermes());
      StrikeUnits.Add(new M109());
      
   }
   
   // מדפיסה את זמינות כלי התקיפה
   public void ShowStrikeAvailability()
   {
      foreach (StrikeUnit unit in StrikeUnits)
      {
         Console.WriteLine("Unit: " + unit.Name);
         Console.WriteLine("Ammo: " + unit.numberOfBombs);
         Console.WriteLine("Fuel: " + unit.Fuel);
         Console.WriteLine("Effective against: " + unit.EffectiveAgainst);
         Console.WriteLine();
      }
   }
   
}