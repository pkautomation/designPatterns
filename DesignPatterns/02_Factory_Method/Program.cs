using System;

namespace _02_Factory_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            // I can create a factory and perform testing without getting a rifle to my hands 
            var rifleFactory = new RifleFactory();
            rifleFactory.TestWeapon();
            // I like that, so I will get one for myself and perform some shooting
            var myWeapon = rifleFactory.Create();
            myWeapon.Assemble();
            myWeapon.Shoot();
        }
    }
}
