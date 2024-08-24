namespace _03_Abstract_Factory;

internal interface MilitaryItemsFactory
{
    public abstract Medikit CreateMedikit();
    public abstract Pistol CreatePistol();
}
