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
            new WetVacuumCleaner { Model = "Karcher FC5" }
        };

        // Вызов метода StartCleaning для каждого объекта массива
        foreach (var vacuumCleaner in vacuumCleaners)
        {
            vacuumCleaner.StartCleaning();
        }

        Console.ReadLine();
    }
}