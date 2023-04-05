namespace VacuumCleanerAppDemo;

// Класс, описывающий пылесос
public class VacuumCleaner
{
    public virtual string? Model { get; set; }

    public virtual void StartCleaning()
    {
        Console.WriteLine("Cleaning started");
    }

    public virtual void StartCleaning(string room)
    {
        Console.WriteLine($"Cleaning started in {room}");
    }
}