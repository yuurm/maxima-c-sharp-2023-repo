namespace VacuumCleanerAppDemo;

// Обычный пылесос
public class RegularVacuumCleaner : VacuumCleaner
{
    // Тело метода StartCleaning родителя оставляем без изменений
    
    public static bool CollectDust<T>(T vacuumCleaner, int dustVolume) where T : RegularVacuumCleaner
    {
        if (dustVolume > vacuumCleaner.MaxVolume)
        {
            throw new VacuumCleanerException("Volume of dust exceeds maximum capacity.");
        }

        Console.WriteLine($"Collected {dustVolume} units of dust with {vacuumCleaner.Model}");

        return true;
    }

}