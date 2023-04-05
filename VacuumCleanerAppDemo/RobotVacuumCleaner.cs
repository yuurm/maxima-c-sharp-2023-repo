namespace VacuumCleanerAppDemo;

// Робот-пылесос
public class RobotVacuumCleaner : VacuumCleaner
{
    public override void StartCleaning()
    {
        Console.WriteLine($"Cleaning started by {Model}");
        base.StartCleaning();
    }
}