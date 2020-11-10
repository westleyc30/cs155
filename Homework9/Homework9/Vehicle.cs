using System;
using System.Collections.Generic;
using System.Text;

namespace Homework9
{
    class Vehicle
    {
        
        public int Cyclinders { get; set; }
        public Person Owner { get; set; }
        public Manufacturer Manufacturer;

        public Vehicle (int _cylinders, Person _owner, Manufacturer _manufacturer)
        {
            Cyclinders = _cylinders;
            Owner = _owner;
            Manufacturer = _manufacturer;
        }
        public Vehicle()
        {

        }
    }
}
