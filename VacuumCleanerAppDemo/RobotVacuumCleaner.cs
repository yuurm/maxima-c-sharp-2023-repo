namespace VacuumCleanerAppDemo;

// Робот-пылесос
public class RobotVacuumCleaner : VacuumCleaner
{
    public override void StartCleaning()
    {
        Console.WriteLine($"Cleaning started by {Model}");
        base.StartCleaning();
    }
    
    
    public static bool CollectDust<T>(T vacuumCleaner, int dustVolume) where T : RobotVacuumCleaner
    {
        if (dustVolume > vacuumCleaner.MaxVolume)
        {
            throw new VacuumCleanerException("Volume of dust exceeds maximum capacity.");
        }

        Console.WriteLine($"Collected {dustVolume} units of dust with {vacuumCleaner.Model}");

        return true;
    }

}