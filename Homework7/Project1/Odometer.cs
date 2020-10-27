using System;
namespace Project1
{
    public class Odometer
    {
        // INSTANCE VARIABLES
        private double _milesDriven;
        private double _fuelUsed;

        // CONSTRUCTORS
        /// <summary>
        /// Builds Odometer with no parameters
        /// </summary>
        public Odometer()
        {
            MilesDriven = 0;
            FuelUsed = 0;
        }

        /// <summary>
        /// Builds odometer with parameters
        /// </summary>
        ///
        public Odometer(double milesDriven, double fuelUsed)
        {
            MilesDriven = milesDriven;
            FuelUsed = fuelUsed;
        }

        // GETTERS/SETTERS
        public double MilesDriven
        {
            get
            {
                return _milesDriven;
            }
            set
            {
                _milesDriven = value;
                if (_milesDriven < 0)
                    _milesDriven = 0;
            }
        }

        public double FuelUsed
        {
            get
            {
                return _fuelUsed;
            }
            set
            {
                _fuelUsed = value;
                if (_fuelUsed < 0)
                    _fuelUsed = 0;
            }
        }

        public double calculateMPG()
        {
            if (MilesDriven > 0 && FuelUsed > 0)
            {
                return MilesDriven / FuelUsed;
            }
            else
            {
                Console.WriteLine("Values have to be greater than 0 to calculate");
                return 0;
            }
            
        }

        public void Reset()
        {
            MilesDriven = 0;
            FuelUsed = 0;
        }

        override
        public string ToString()
        {
            return $"Miles Driven: {MilesDriven}\nFuel Used: {FuelUsed}";
        }
    }
}
