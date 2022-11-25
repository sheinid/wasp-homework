namespace Autopark
{
    public class Autopark
    {
        private string _name;
        List<Car> _carsList= new List<Car>();

        public Autopark(string name)
        {
            _name = name;
        }
        public Autopark(string name, List<Car> carsList)
        {
            _name = name;
            _carsList = carsList;
        }

        public override string ToString()
        {
            string output;
            output = $"Автопарк: {_name}\n";
            foreach (Car car in _carsList)
            {
                output += car.ToString();
            }

            return output;
        }

        public void AddCarToAutopark(Car car)
        {
            _carsList.Add(car);
        }
    }
}

