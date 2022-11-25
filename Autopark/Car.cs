namespace Autopark
{
    public class Car
    {
        protected string _model;

        protected int
            _power,
            _year;

        public Car(string model, int power, int year)
        {
            _model = model;
            _power = power;
            _year = year;
        }

        public override string ToString()
        {
            return $"Model: {_model}\n Power: {_power}\n Prod. year: {_year}\n";
        }
    }

    public class PassengerCar : Car
    {
        private int _passengerAmount = 2;
        private Dictionary<string, int> _repairBook = new Dictionary<string, int>();

        public PassengerCar(string model, int power, int year)
            : base(model, power, year)
        {
        }

        public void AddDetailToRepairBook(string detail, int year)
        {
            _repairBook.Add(detail, year);
        }

        public int GetYearOfReplacement(string detail)
        {
            return _repairBook[detail];
        }

        public void PrintRepairBook()
        {
            foreach (var note in _repairBook)
            {
                Console.WriteLine($"Detail: {note.Key} Replacement year: {note.Value}");
            }
        }

        public override string ToString()
        {
            return $"Model: {_model}\n Power: {_power}\n Prod. year: {_year}\n Passenger amount: {_passengerAmount}\n";
        }
    }

    public class Truck : Car
    {
        private int _loadCapacity = 100;
        private string _driverName = "John Doe";
        private Dictionary<string, int> _currentCargo = new Dictionary<string, int>();
        public Truck(string model, int power, int year)
            : base(model, power, year)
        {
        }


        public void DriverChange(string newDriver)
        {
            _driverName = newDriver;
        }

        public void AddCargo(string cargo, int weight)
        {
            _currentCargo.Add(cargo, weight);
        }

        public void RemoveCargo(string cargo)
        {
            _currentCargo.Remove(cargo);
        }

        public void PrintCurrentCargo()
        {
            foreach (var cargo in _currentCargo)
            {
                Console.WriteLine($"Cargo: {cargo.Key} Weight: {cargo.Value}");
            }
        }

        public override string ToString()
        {
            return
                $"Model: {_model}\n Power: {_power}\n Prod. year: {_year}\n Load capacity: {_loadCapacity}\n Driver name: {_driverName}\n";
        }
    }
}