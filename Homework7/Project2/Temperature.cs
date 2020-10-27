using System;
namespace Project2
{
    public class TemperatureScale
    {
        // INSTANCE VARIABLES
        private float temperature;
        private char scale;

        // CONSTRUCTORS
        /// <summary>
        /// Default Constructor
        /// </summary>
        public TemperatureScale()
        {
            SetAll(0, 'C');
        }
        public TemperatureScale(float temperature)
        {
            SetAll(temperature, 'C');
        }
        public TemperatureScale(char scale)
        {
            SetAll(0, scale);
        }
        public TemperatureScale(float temperature, char scale)
        {
            SetAll(temperature, scale);
        }

        // SETTERS
        public bool SetTemperature(float temperature)
        {
            bool isValid = temperature.GetType() == typeof(float);
            if(isValid)
            {
                this.temperature = temperature;
            }
            return isValid;
        }
        public bool SetScale(char scale)
        {
            bool isValid = scale == 'C' || scale == 'F';

            if (isValid)
            {
                this.scale = scale;
            } else
            {
                Console.WriteLine("Please enter \"C\" or \"F\"");
            }
            return isValid;
        }
        public bool SetAll(float temperature, char scale)
        {
            return SetTemperature(temperature) && SetScale(scale);
        }

        // GETTERS
        public float GetTemperature()
        {
            return temperature;
        }
        public char GetScale()
        {
            return scale;
        }

        // Methods
        override
        public string ToString()
        {
            return $"{temperature}{scale}";
        }
    }
}
