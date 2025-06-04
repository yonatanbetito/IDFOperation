using IDFOperationFirstStrike.HAMAS;
using System.Linq;
namespace IDFOperationFirstStrike.AMAN;

internal class Aman
{
    //רשימה שמכילה את כל הדיווחים
    public List<ReportMessage> intelMessages = new List<ReportMessage>();

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
            intelMessages.Add(new ReportMessage(t.getName(), location));
        }
    }
    //הוספה ידנית של דיווח
    public void AddReport(ReportMessage NewMas)
    {
        intelMessages.Add(NewMas);
    }

    //פונקציה שמחשבת את הטירוריסט המסוכן ביותר עפ כמות דיווחים
    public string PrintMostReportedTerrorist()
    {
        Dictionary<string, int> count = new Dictionary<string, int>();
        foreach (ReportMessage msg in intelMessages)
        {
            if (count.ContainsKey(msg.TerroristName))
            {
                count[msg.TerroristName]++;
            }
            else
            {
                count[msg.TerroristName] = 1;
            }
        }

        int max = 0;
        string name = "";
        foreach (var item in count)
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

        foreach (ReportMessage msg in intelMessages)
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