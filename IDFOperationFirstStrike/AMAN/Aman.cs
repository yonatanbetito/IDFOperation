using IDFOperationFirstStrike.HAMAS;
using System.Linq;
namespace IDFOperationFirstStrike.AMAN;

internal class Aman
{
    //רשימה שמכילה את כל הדיווחים (שהם פרטיים)
    public List<ReportMessage> IntelMessages { get; private set; }= new List<ReportMessage>();
    
    // מייצרת דיווחים אקראיים על טרוריסטים
    public void GenerateIntel(List<Terrorist> terrorists)
    {
        Random rnd = new Random();
        string[] locations = { "home", "car", "outside" };

        for (int i = 0; i < 15; i++)
        {
            int index = rnd.Next(terrorists.Count);
            Terrorist t = terrorists[index];
            string location = locations[rnd.Next(locations.Length)];
            IntelMessages.Add(new ReportMessage(t.getName(), location));
        }
    }
    //הוספה ידנית של דיווח
    public void AddReport(ReportMessage NewMas)
    {
        IntelMessages.Add(NewMas);
    }

    //פונקציה שמחשבת את הטירוריסט המסוכן ביותר עפ כמות דיווחים
    public string PrintMostReportedTerrorist()
    {
        Dictionary<string, int> countmessage = new Dictionary<string, int>();
        foreach (ReportMessage msg in IntelMessages)
        {
            if (countmessage.ContainsKey(msg.TerroristName))
            {
                countmessage[msg.TerroristName]++;
            }
            else
            {
                countmessage[msg.TerroristName] = 1;
            }
        }

        int max = 0;
        string name = "";
        foreach (var item in countmessage)
        {
            if (item.Value > max)
            {
                max = item.Value;
                name = item.Key;
            }

        }

        return name;
    }

    //פונקציה שמחזירה דיווח אחרון על טרוריסט מסוים
    public ReportMessage getLatestReport(string name)
    {
        ReportMessage latest = null;

        foreach (ReportMessage msg in IntelMessages)
        {
            if (msg.TerroristName == name)
            {
                if (latest == null || msg.TimeStamp > latest.TimeStamp)
                {
                    latest = msg;
                }
            }
        }

        return latest;
    }
}