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
}