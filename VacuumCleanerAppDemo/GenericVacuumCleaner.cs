namespace VacuumCleanerAppDemo
{
    // Generic class for vacuum cleaners
    public class GenericVacuumCleaner<T> where T : VacuumCleaner, new()
    {
        private T vacuumCleaner;

        public GenericVacuumCleaner()
        {
            vacuumCleaner = new T();
        }

        public string Model
        {
            get { return vacuumCleaner.Model; }
            set { vacuumCleaner.Model = value; }
        }

        public int MaxVolume
        {
            get { return vacuumCleaner.MaxVolume; }
            set { vacuumCleaner.MaxVolume = value; }
        }

        public void StartCleaning()
        {
            vacuumCleaner.StartCleaning();
        }

        public void StartCleaning(string room)
        {
            vacuumCleaner.StartCleaning(room);
        }

        public void CollectDust(int volume)
        {
            try
            {
                vacuumCleaner.CollectDust(volume);
                Console.WriteLine($"Collected {volume} units of dust.");
            }
            catch (VacuumCleanerException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

