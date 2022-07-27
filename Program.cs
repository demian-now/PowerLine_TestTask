namespace PowerLine_TestTask
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello, World!");
            SportCar sport = new("Lamborguni", 305, 50, (decimal)10);
            Truck truck = new("MAN", 120, 200, (decimal)2);
            PassengerCar car = new("LADA CALINA MOYA MASHINA", 200, 50, (decimal)4);

            List<IVehicle> vehicles = new() { car, truck, sport };

            foreach (var i in vehicles)
                Console.WriteLine("{0}, {1}, {2}, {3}", i.TravelTime(100), i.MaxWay(), i.PowerReserve(), i.RestOfWay());
        }
    }
}