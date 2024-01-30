public class House
{
    public int NumberOfWindows { get; set; }
    public int NumberOfDoors { get; set; }
    public int NumberOfRooms { get; set; }
    public bool HasGarage { get; set; }
    public bool HasSwimmingPool { get; set; }

    public override string ToString()
    {
        return $"House with {NumberOfRooms} rooms, {NumberOfWindows} windows, {NumberOfDoors} doors, " +
               $"{(HasGarage ? "with" : "without")} garage and {(HasSwimmingPool ? "with" : "without")} swimming pool.";
    }
}
