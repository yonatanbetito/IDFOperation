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

    public string setTypeWeapon(string newTypeWepons)
    {
        TypeWeapon = newTypeWepons;
        return TypeWeapon;
    }

    public string getTypeWeapon()
    {
        return TypeWeapon;
    }

    public int setVolumeWeapon(int newVolumeWeapon)
    {
        ValumeWeapon = newVolumeWeapon;
        return ValumeWeapon;
    }

    public int getVolumeWeapon()
    {
        return ValumeWeapon;
    }
}
