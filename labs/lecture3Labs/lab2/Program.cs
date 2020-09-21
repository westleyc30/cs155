using System;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean  pluggedIn, freshBulb, lightOn;
            String lightStatus, plugStatus, bulbStatus;

            pluggedIn = true;
            freshBulb = false;

            if (pluggedIn == true && freshBulb == true)
            {
                lightOn = true;
                lightStatus = "on";
            } else
            {
                lightStatus = "off";
            }

            if (pluggedIn)
            {
                plugStatus = "plugged in";
            } else
            {
                plugStatus = "disconnected, please plug in";
            }

            if (freshBulb)
            {
                bulbStatus = "Light bulb active";
            } else
            {
                bulbStatus = "please replace bulb";

            }
            
            Console.WriteLine("\n=================================================");
            Console.WriteLine($"\n\tLight Status: {lightStatus}");
            Console.WriteLine("\n=================================================\n");
            Console.WriteLine($"\tPlug Status: {plugStatus}");
            Console.WriteLine($"\tBulb Status: {bulbStatus}");
        }
    }
}
