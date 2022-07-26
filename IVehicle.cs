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
        int MaxFuel { get; }
        decimal Fuel { get; }
        decimal AverageFuelConsumption { get; }

        public decimal MaxWay();
        /// <summary>
        /// Returns the power reserve without taking into account the variables 
        /// </summary>
        /// <returns></returns>
        public decimal RestOfWay();
        /// <summary>
        /// Returns the time in minutes needed to traverse the way
        /// </summary>
        /// <param name="way"></param>
        /// <returns></returns>
        public int TravelTime(decimal way);
        /// <summary>
        /// Returns the driving range taking into account the passengers and cargo
        /// </summary>
        /// <returns></returns>
        public decimal PowerReserve();
    }
}
