using System;

namespace _02_Factory_Method;

class Rifle : IWeapon
{
    public void Assemble()
    {
        Console.WriteLine($"Assembling {this.GetType().Name}");
    }

    public void Shoot()
    {
        Console.WriteLine($"{this.GetType().Name} shoot series of bullets");
    }

    public void ShowDescription()
    {
        Console.WriteLine($"{this.GetType().Name} description");
    }
}
