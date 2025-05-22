namespace IDFOperationFirstStrike.HAMAS;

internal class Hamas
{
    protected string DateFormation;
    protected string currentComander;
    protected List<Terrorist> Terrorists;

    //בנאי שמכיל בתוכו גם את מחבל 
    public Hamas(string name, int rank, bool status, string dateFormation, string currentComander, List<object> terrorists) 
    {

    }

    //הוספה של טרוריסט לתוך המערך של החמאס
    public void AddTerrorist(Terrorist terrorist)
    {
        Terrorists.Add(terrorist);
    }
}
    