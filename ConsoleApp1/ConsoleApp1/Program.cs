using System;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double windChillIndex(double windSpeed, double temperature)
            {
                double WCI;
                if (windSpeed >= 0 && windSpeed <= 4)
                {
                    WCI = temperature;
                } else if (windSpeed >= 45) 
                {
                    WCI = (1.6 * temperature) - 55;
                } else
                {
                    WCI = 91.4 + (91.4 - temperature) * (0.02203 * temperature - (0.304 * Math.Sqrt(temperature)) - 0.474);
                }
                return WCI;
            }
            String checkOutfit(double windSpeed, double temperature, int humidity, int rain)
            {
                double WCI = windChillIndex(windSpeed, temperature);
                if(WCI == 80 || humidity >= 90)
                {
                    return "Outfit 1";
                } else if(WCI < 0 && rain < 70)
                {
                    return "outfit 2";
                } else if(humidity <= 20 && WCI >= 30 && WCI <= 70)
                {
                    return "outfit 3";
                } else
                {
                    return "outfit 4";
                }
            }
            Console.WriteLine(checkOutfit(0, 45, 0, 0));

        }
    }
}
