namespace VacuumCleanerAppDemo;

class Program
{
    static void Main(string[] args)
    {
        // Создание массива базового типа и добавление объектов классов-наследников
        VacuumCleaner[] vacuumCleaners = new VacuumCleaner[]
        {
            new RegularVacuumCleaner { Model = "Samsung 1000" },
            new RobotVacuumCleaner { Model = "iRobot Roomba" },
            new WetVacuumCleaner { Model = "Kaercher FC5" }
        };

        foreach (var vacuumCleaner in vacuumCleaners)
        {
            try
            {
                vacuumCleaner.StartCleaning();
                vacuumCleaner.CollectDust(50); 
                Console.WriteLine("Dust collected successfully.");

                if (vacuumCleaner is WetVacuumCleaner)
                {
                    ((WetVacuumCleaner)vacuumCleaner).StartCleaning();
                }
            }
            catch (VacuumCleanerException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
        
        
        

        Console.ReadLine();
        
        
        
    }
}