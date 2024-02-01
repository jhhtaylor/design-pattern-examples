public interface IHouseBuilder
{
    void BuildWindows(int number);
    void BuildDoors(int number);
    void BuildRooms(int number);
    void BuildGarage();
    void BuildSwimmingPool();
    House GetHouse();
}

public class ConcreteHouseBuilder : IHouseBuilder
{
    private House house = new House();

    public void BuildWindows(int number)
    {
        house.NumberOfWindows = number;
    }

    public void BuildDoors(int number)
    {
        house.NumberOfDoors = number;
    }

    public void BuildRooms(int number)
    {
        house.NumberOfRooms = number;
    }

    public void BuildGarage()
    {
        house.HasGarage = true;
    }

    public void BuildSwimmingPool()
    {
        house.HasSwimmingPool = true;
    }

    public House GetHouse()
    {
        return house;
    }
}

