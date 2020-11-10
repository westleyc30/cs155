using System;
using System.Collections.Generic;
using System.Text;

namespace Homework9
{
    class Truck : Vehicle
    {
        public double LoadCapacity { get; set; }
        public int TowingCapacity { get; set; }

        public Truck(Person _owner, Manufacturer _manufacturer, int _cylinders, double _loadCapacity, int _towingCapacity  )
        {
            LoadCapacity = _loadCapacity;
            TowingCapacity = _towingCapacity;
            Cyclinders = _cylinders;
            Owner = _owner;
            Manufacturer = _manufacturer;
        }
        public Truck()
        {

        }

        override
        public string ToString()
        {
            return $"Owner: {Owner}\nManufacturer: {Manufacturer}\nCylinders: {Cyclinders}\nLoad Capacity: {LoadCapacity}\nTowing Capacity: {TowingCapacity} ";
        }
        override
        public bool Equals(object o)
        {
            if (o == null || !this.GetType().Equals(o.GetType()))
            {
                return false;
            }
            else
            {
                Truck otherTruck = (Truck)o;
                return otherTruck.Owner.Equals(Owner) && otherTruck.Manufacturer == Manufacturer && otherTruck.Cyclinders == Cyclinders && otherTruck.LoadCapacity == LoadCapacity && otherTruck.TowingCapacity == TowingCapacity;
            }
        }
    }
}
