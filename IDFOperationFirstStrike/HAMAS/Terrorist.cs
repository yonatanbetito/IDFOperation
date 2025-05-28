namespace IDFOperationFirstStrike.HAMAS;

public class Terrorist
{
    //רשימת ערכים שהטרוריס מכיל
    protected string Name;
    protected int Rank;
    protected bool Status = true;
    protected List<Weapon> Weapons = new List<Weapon>();

    //בנאי של טרוריסט אחד עם שם דרגה וסטטוס
    public Terrorist(string name, int rank, bool status,List<Weapon> weapons)
    {
        Name = name;
        Rank = rank;
        Status = status;
        Weapons = weapons;
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

    public List<Weapon> getWeapons()
    {
        return Weapons;
    }
    
    //מחשב את הניקוד של המחבל לפי מספר נשקים שיש לו
    public int GetThreatScore()
    {
        int sum = 0;
        foreach (Weapon w in Weapons)
        {
            sum += w.getVolumeWeapon();
        }
        return Rank * sum;
    }

}