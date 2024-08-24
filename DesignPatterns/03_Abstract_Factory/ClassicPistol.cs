namespace _03_Abstract_Factory;

internal class ClassicPistol : Pistol
{
    public override void Shoot()
    {
        Console.WriteLine("Shooting real bullets. Thats pistol from adults!");
    }
}
