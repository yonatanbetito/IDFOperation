namespace IDFOperationFirstStrike.HAMAS;

public class Weapon
{
    protected string TypeWeapon;
    protected int ValumeWeapon;

    public Weapon(string typeWeapon, int valumeWeapon)
    {
        TypeWeapon = typeWeapon;
        ValumeWeapon = valumeWeapon;
    }
    
    public string getTypeWeapon()
    {
        return TypeWeapon;
    }
    
    public int getVolumeWeapon()
    {
        return ValumeWeapon;
    }
}
