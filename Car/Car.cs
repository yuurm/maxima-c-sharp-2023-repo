namespace Car

{
    public class Car
    {
        public enum CarColor
        {
            Blue, 
            Black,
            Red
        }

        private CarColor _color;
        private int _year;
        private double _mileage;
        private double _fuel;
        

        public Car( int year, CarColor color, double mileage, double fuel)
        {
            _color = color;
            _year = year;
            _mileage = mileage;
            _fuel = fuel;
        }

        public void GoOneMile()
        {
            _mileage += 1;
        }
        
        
        
        public double GetMileage()
        {
            return _mileage;
        }
        
        public double GetFuel()
        {
            return _fuel;
        }
        
        public void ConsumeFuel(int amount) {
            if (_fuel >= amount) {
                _fuel -= amount;
            } else {
                Console.WriteLine("Not enough fuel to consume.");
            }
        }

        public void Refuel(int amount) {
            _fuel += amount;
        }

        
        
        
        

        public int GetCarYear()
        {
            return DateTime.Now.Year - _year;
        }

        public override string ToString()
        {
            return $"Color: {_color}, Year: {_year}, Mileage: {_mileage}, Fuel: {_fuel}";
        }
        
        
    }
}