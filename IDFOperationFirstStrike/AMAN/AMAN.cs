using IDFOperationFirstStrike.HAMAS;
using System.Linq;
namespace IDFOperationFirstStrike.AMAN;

public class AMAN
{
    //רשימה של טרוריסטים
    private List<Terrorist> terrorists;
    //רשימה שמכילה את כל הדיווחים
    private List<ReportMessage> intelMessages = new();

    public AMAN(List<Terrorist> terroristList)
    {
        terrorists = terroristList;
    }

    public void AddReport(ReportMessage NewMas)
    {
        intelMessages.Add(NewMas);
    }
    //פונקציה שמחשבת את הטירוריסט המסוכן ביותר עפ כמות דיווחים
    public void PrintMostReportedTerrorist()
    {
        var most = intelMessages
            .GroupBy(r => r.Target)
            .OrderByDescending(g => g.Count())
            .FirstOrDefault();

        if (most != null)
        {
            Console.WriteLine($"Most reported terrorist: {most.Key.getName()} ({most.Count()} reports)");
        }
        else
        {
            Console.WriteLine("No reports available.");
        }
    }
    
    //פונקציה שמחשבת את הטירוריסט המסוכן ביותר עפ ניקוד
    public Terrorist GetTopTarget()
    {
        Terrorist mostDangerous = null;
        int highestScore = -1;

        foreach (Terrorist t in terrorists)
        {
            if (t.getstatus() == true)
            {
                int score = t.GetThreatScore();
                if (score > highestScore)
                {
                    highestScore = score;
                    mostDangerous = t;
                }
            }
        }
        return mostDangerous;
    }
    
     //הדפסת דיווח האחרון לפי מחבל
    public ReportMessage GetLatestReportFor(Terrorist t)
    {
        ReportMessage latest = null;

        foreach (ReportMessage msg in intelMessages)
        {
            if (msg.Target == t)
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