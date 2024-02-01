using System;

// Subsystem Class 1
public class CPU
{
    public void Freeze() => Console.WriteLine("CPU freeze");
    public void Jump(long position) => Console.WriteLine($"Jump to position {position}");
    public void Execute() => Console.WriteLine("Execute operations");
}

// Subsystem Class 2
public class Memory
{
    public void Load(long position, byte[] data) => Console.WriteLine($"Load from position {position}");
}

// Subsystem Class 3
public class HardDrive
{
    public byte[] Read(long lba, int size)
    {
        Console.WriteLine($"Reading data from sector {lba}");
        return new byte[size];
    }
}

// Facade
public class ComputerFacade
{
    private CPU _cpu;
    private Memory _memory;
    private HardDrive _hardDrive;

    public ComputerFacade()
    {
        _cpu = new CPU();
        _memory = new Memory();
        _hardDrive = new HardDrive();
    }

    public void Start()
    {
        _cpu.Freeze();
        _memory.Load(BOOT_ADDRESS, _hardDrive.Read(BOOT_SECTOR, SECTOR_SIZE));
        _cpu.Jump(BOOT_ADDRESS);
        _cpu.Execute();
    }

    private const long BOOT_ADDRESS = 0x0000;
    private const long BOOT_SECTOR = 0x0007;
    private const int SECTOR_SIZE = 1024;
}