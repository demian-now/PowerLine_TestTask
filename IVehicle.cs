using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerLine_TestTask
{
    interface IVehicle
    {
        string Type { get; }
        int MaxSpeed { get; }
        decimal MaxFuel { get; }
        decimal Fuel { get; }
        decimal AverageFuelConsumption { get; }

        public decimal MaxWay();
        //Returns the power reserve without taking into account the variables 
        public decimal RestOfWay();
        //Returns the time in minutes needed to traverse the way
        public int TravelTime(decimal way);
        //Returns the driving range taking into account the passengers and cargo
        public decimal PowerReserve();
    }
}
