namespace IDFOperationFirstStrike.HAMAS;

public class Terrorist
{
    //רשימת ערכים שהטרוריס מכיל
    protected string Name;
    protected int Rank;
    protected bool Status = true;
    protected List<Weapon> Weapons = new List<Weapon>();
    
    //בנאי של טרוריסט אחד עם שם דרגה וסטטוס
    public Terrorist(string name, int rank, bool status)
    {
        Name = name;
        Rank = rank;
        Status = status;
    }

    public string getName()
    {
        return Name;
    }

    public int getRank()
    {
        return Rank;
    }

    public bool getstatus()
    {
        return Status;
    }

    public bool setstatus(bool newStatus)
    {
        Status = newStatus;
        return Status;
    }
    
}