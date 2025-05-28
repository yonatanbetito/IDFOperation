namespace IDFOperationFirstStrike.HAMAS;

internal class Hamas
{
    protected DateTime DateFormation;
    protected string CurrentComander;
    protected internal List<Terrorist> Terrorists;

    //בנאי שמכיל בתוכו גם את מחבל 
    public Hamas(string currentComander)
    {
        CurrentComander = currentComander;
        DateFormation = DateTime.Now;
        Terrorists = new List<Terrorist>();

    }
    
    // מחזירה את הטרוריסט הכי מסוכן לפי ניקוד
    public Terrorist getMostDangerous()
    {
        int max = 0;
        Terrorist danger = null;
        foreach (Terrorist t in Terrorists)
        {
            int score = t.GetThreatScore();
            if (score > max)
            {
                max = score;
                danger = t;
            }
        }
        return danger;
    }
    
    //================================================
    //הוספה של טרוריסט לתוך המערך של החמאס
    public void AddTerrorist(Terrorist terrorist)
    {
        Terrorists.Add(terrorist);
    }
}
    