using IDFOperationFirstStrike.HAMAS;
using IDFOperationFirstStrike.IDF;
using IDFOperationFirstStrike.AMAN;
namespace IDFOperationFirstStrike
{
    internal class Program
    {
        static void Main(string[] args)


        {
            //GeminiSimple.Run();
            
            // יצירת אובייקטים
            Hamas hamas = new Hamas("Yahya Sinwar");
            Aman intel = new Aman();
            Idf idf = new Idf("Herzi Halevi");

            // יצירת טרוריסטים עם נשקים
            hamas.Terrorists.Add(new Terrorist("Ahmad", 3, new List<Weapon> { new Weapon("Knife", 1), new Weapon("Gun", 2) }));
            hamas.Terrorists.Add(new Terrorist("Muhamad", 5, new List<Weapon> { new Weapon("AK47", 3), new Weapon("Gun", 2) }));
            hamas.Terrorists.Add(new Terrorist("Ali", 4, new List<Weapon> { new Weapon("M16", 3) }));
            hamas.Terrorists.Add(new Terrorist("Samir", 2, new List<Weapon> { new Weapon("Knife", 1) }));
            hamas.Terrorists.Add(new Terrorist("ZAide", 1, new List<Weapon> { new Weapon("Gun", 2), new Weapon("AK47", 3) }));

            // יצירת דיווחים אקראיים
            intel.GenerateIntel(hamas.Terrorists);

            int choice = -1;
            while (choice != 0)
            {
                Console.WriteLine(@"
                            Manu
                1. Who received the most reports
                2. Strike availability bombs and fuel
                3. Most dangerous terrorist
                4. Executing strike
                0. Exit
                Select an action: ");
                choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    string name = intel.PrintMostReportedTerrorist();
                    Console.WriteLine("The terrorist with the most reports - " + name);
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Strike availability: ");
                    idf.ShowStrikeAvailability();
                }
                else if (choice == 3)
                {
                    Terrorist t = hamas.getMostDangerous();
                    ReportMessage latest = intel.getLatestReport(t.getName());
                    Console.WriteLine("The most dangerous terrorist:");
                    Console.WriteLine("Name: " + t.getName());
                    Console.WriteLine("Rank: " + t.getRank());
                    Console.WriteLine("Weapon:");
                    foreach (Weapon w in t.getWeapons())
                    {
                        Console.WriteLine("- " + w.getTypeWeapon());
                    }
                    Console.WriteLine("Quality Score: " + t.GetThreatScore());
                    Console.WriteLine("Last location:: " + latest.Location);
                }
                else if (choice == 4)
                {
                    Terrorist target = hamas.getMostDangerous();
                    ReportMessage latest = intel.getLatestReport(target.getName());
                    Console.WriteLine($@"Launching strike on: {target.getName()}
                    location:{latest.Location}");

                    StrikeUnit unit = null;
                    foreach (StrikeUnit s in idf.StrikeUnits)
                    {
                        if (latest.Location == "home" && s.EffectiveAgainst.Contains("buildings"))
                        {
                            unit = s;
                            break;
                        }
                        else if (latest.Location == "car" && s.EffectiveAgainst.Contains("vehicles"))
                        {
                            unit = s;
                            break;
                        }
                        else if (latest.Location == "outside" && s.EffectiveAgainst.Contains("open"))
                        {
                            unit = s;
                            break;
                        }
                    }

                    if (unit != null && unit.numberOfBombs > 0)
                    {
                        unit.Strike(target.getName());
                        Console.WriteLine($@"The strike was carried by:{unit.Name}
                        Name of commanding: {idf.Commander}
                        Time attack :{DateTime.Now}
                        Latest intelligence update: {latest.Location} ,{latest.TimeStamp}");
                        target.setstatus(false);
                    }
                    else
                    {
                        Console.WriteLine("No strike unit available.");
                    }
                }
                else if (choice == 0)
                {
                    Console.WriteLine("Logging out of the system.");
                }
                else
                {
                    Console.WriteLine("Invalid selection, please try again.");
                }
            }
        }
    }
}
