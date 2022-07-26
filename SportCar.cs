using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerLine_TestTask
{
    internal class SportCar : IVehicle
    {
        public string Type { get; }

        public int MaxSpeed { get; }

        public int MaxFuel { get; }

        private decimal _Fuel;
        public decimal Fuel
        {
            get => _Fuel;
            set
            {
                if (value > 0 || value <= MaxFuel)
                    _Fuel = value;
                else throw new ArgumentException("Too many passenger or value is negative");
            }
        }

        public decimal AverageFuelConsumption { get; }

        public SportCar(string type, int maxSpeed, int fuel, int aveFuelCons)
        {
            if (maxSpeed <= 0 || fuel <= 0 || aveFuelCons <= 0)
                throw new ArgumentException("Params can't be negative or null");
            Type = type;
            MaxSpeed = maxSpeed;
            MaxFuel = fuel;
            Fuel = fuel;
            AverageFuelConsumption = aveFuelCons;
        }
        public decimal MaxWay() => MaxFuel / AverageFuelConsumption * 100;
        public decimal PowerReserve() => Fuel / AverageFuelConsumption * 100;
        public decimal RestOfWay() => Fuel / AverageFuelConsumption * 100;
        public int TravelTime(decimal way) => (int)(way / MaxSpeed * 60);
    }
}
