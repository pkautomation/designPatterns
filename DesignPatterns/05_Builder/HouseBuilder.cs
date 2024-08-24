namespace _05_Builder;

public class HouseBuilder
{
    private House house = new House();

    public HouseBuilder AddWall()
    {
        house.HasWall = true;

        return this;
    }

    public HouseBuilder AddCeiling()
    {
        house.HasCeiling = true;

        return this;
    }

    public HouseBuilder SetSize(int newSize)
    {
        house.FloorSize = newSize;
        return this;
    }

    public House Build()
    {
        return house;
    }
}
