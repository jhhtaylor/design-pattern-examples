public class HouseDirector
{
    public void ConstructLuxuryHouse(IHouseBuilder builder)
    {
        builder.BuildRooms(5);
        builder.BuildWindows(10);
        builder.BuildDoors(5);
        builder.BuildGarage();
        builder.BuildSwimmingPool();
    }

    public void ConstructSimpleHouse(IHouseBuilder builder)
    {
        builder.BuildRooms(2);
        builder.BuildWindows(4);
        builder.BuildDoors(2);
    }
}
