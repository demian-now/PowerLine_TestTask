namespace PowerLine_TestTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            SportCar sport = new SportCar("Lamborguni", 305, 50, (decimal)10);
            Truck truck = new Truck("MAN", 120, 200, (decimal)2);
            PassengerCar car = new PassengerCar("LADA CALINA", 200, 50, (decimal)4);

            List<IVehicle> vehicles = new List<IVehicle>();
            vehicles.Add(car);
            vehicles.Add(truck);
            vehicles.Add(sport);

            foreach (var i in vehicles)
                Console.WriteLine("{0}, {1}, {2}, {3}", i.TravelTime(100), i.MaxWay(), i.PowerReserve(), i.RestOfWay());
        }
    }
}