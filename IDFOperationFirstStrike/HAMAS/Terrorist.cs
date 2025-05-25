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

    //מחשב את הניקוד של המחבל לפי מספר נשקים שיש לו
    public int GetThreatScore()
    {
        int totalPoints = 0;

        foreach (Weapon weapon in Weapons)
        {
            string type = weapon.getTypeWeapon().ToLower();

            if (type == "knife")
            {
                totalPoints += 1;
            }
            else if (type == "gun")
            {
                totalPoints += 2;
            }
            else if (type == "m16" || type == "ak47")
            {
                totalPoints += 3;
            }
        }

        int qualityScore = Rank * totalPoints;
        return qualityScore;
        
    }

}