namespace VacuumCleanerAppDemo;

// Класс, описывающий пылесос
public class VacuumCleaner
{
    
    
    public virtual string? Model { get; set; }
    public virtual int MaxVolume { get; set; } = 1000; 

    public virtual void StartCleaning()
    {
        Console.WriteLine("Cleaning started");
    }

    public virtual void StartCleaning(string room)
    {
        Console.WriteLine($"Cleaning started in {room}");
    }
    
    
    public void CollectDust(int volume)
    {
        if (volume > MaxVolume)
        {
            throw new VacuumCleanerException("Volume of dust exceeds maximum capacity.");
        }
        else
        {
            Console.WriteLine($"Collected {volume} units of dust.");
        }
    }
    
    
    

}

