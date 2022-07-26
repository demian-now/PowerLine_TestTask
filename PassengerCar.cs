using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerLine_TestTask
{
    internal class PassengerCar : IVehicle
    {
        public string Type { get; }
        public int MaxSpeed { get; }
        public int MaxFuel { get; }
        public decimal Fuel { get; }
        public decimal AverageFuelConsumption { get; }
        public int MaxCountOfPassenger { get; }
        public int CountOfPassenger { get; set; }

        public PassengerCar(string type, int maxSpeed, int fuel, int aveFuelCons)
        {
            if (maxSpeed <= 0 || fuel <= 0 || aveFuelCons <= 0)
                throw new ArgumentException("Params can't be negative or null");
            Type = type;
            MaxSpeed = maxSpeed;
            MaxFuel = fuel;
            Fuel = fuel;
            AverageFuelConsumption = aveFuelCons;
            MaxCountOfPassenger = 4; //standart
            CountOfPassenger = 0;
        }

        public PassengerCar(string type, int maxSpeed, int fuel, int aveFuelCons, int countOfPass)
        {
            if (maxSpeed <= 0 || fuel <= 0 || aveFuelCons <= 0 || countOfPass < 0)
                throw new ArgumentException("Params can't be negative or null");
            Type = type;
            MaxSpeed = maxSpeed;
            MaxFuel = fuel;
            Fuel = fuel;
            AverageFuelConsumption = aveFuelCons;
            MaxCountOfPassenger = countOfPass; 
            CountOfPassenger = 0;
        }

        public decimal MaxWay() => MaxFuel / AverageFuelConsumption * 100;

        public decimal PowerReserve() => (Fuel / AverageFuelConsumption * 100)*(1 - (decimal)0.06*CountOfPassenger);

        public decimal RestOfWay() => Fuel / AverageFuelConsumption * 100;

        public int TravelTime(decimal way) => (int)(way / MaxSpeed * 60);

        public void AddPassenger(int newPass = 1)
        {
            if (CountOfPassenger + newPass <= MaxCountOfPassenger)
                CountOfPassenger += newPass;
            else throw new ArgumentException("Too many passenger");
        }
    }
}
