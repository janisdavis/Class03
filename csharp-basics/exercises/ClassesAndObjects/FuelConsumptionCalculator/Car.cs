namespace FuelConsumptionCalculator
{
    public class Car
    {   
        double startKilometers; 
        double endKilometers; 
        double _liters;
        public Car(double startOdo)
        {
            startKilometers = startOdo;
        }

        public double CalculateConsumption()
        {
            return endKilometers/ _liters;
        }

        private double ConsumptionPer100Km()
        {
            return (double) 100/ CalculateConsumption();
        }

        public bool GasHog()
        {
            return ConsumptionPer100Km() > 15;
        }

        public bool EconomyCar()
        {
            return ConsumptionPer100Km() < 5;
        }

        public void FillUp(int mileage, double liters)
        {
            endKilometers = mileage;
            _liters = liters;
        }
    }
}
