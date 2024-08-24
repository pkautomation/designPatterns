using System;

namespace _02_Factory_Method;

abstract class WeaponFactory
{
    public abstract IWeapon Create();

    public void TestWeapon()
    {
        var weaponToTest = Create();
        Console.WriteLine("Testing how the weapon is shooting");
        Console.WriteLine("------");
        weaponToTest.Shoot();
        Console.WriteLine("------");
    }
}
