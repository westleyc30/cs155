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

        /// <summary>
        /// sets scale
        /// Must be Uppercase C or F
        /// </summary>
        /// <param name="scale"></param>
        /// <returns>bool validation</returns>
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
        public double GetTempC()
        {
            if(scale.Equals('F'))
            {
                double temp = (temperature - 32) * 5 / 9;
                temp = Math.Round(temp, 1);
                return temp;
            } else
            {
                return Math.Round(temperature, 1);
            }
        }
        public double GetTempF()
        {
            if (scale.Equals('C'))
            {
                double temp = (temperature * 9 / 5) + 32;
                temp = Math.Round(temp, 1);
                return temp;
            }
            else
            {
                return Math.Round(temperature, 1);
            }
        }


        // Methods
        override
        public String ToString()
        {
            return $"{temperature}{scale}";
        }

        override
        public bool Equals(Object other)
        {
            if (other == null || !this.GetType().Equals(other.GetType()))
            {
                return false;
            } else
            {
                TemperatureScale otherTemp = (TemperatureScale)other;
                return this.GetTempC() == otherTemp.GetTempC();
            }
            
        }
    }
}
