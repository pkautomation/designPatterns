namespace _02_Factory_Method;

class RifleFactory : WeaponFactory
{
    public override IWeapon Create()
    {
        return new Rifle();
    }
}
