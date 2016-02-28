using System;

namespace Ex.Third.Inheritance
{
    class Ship : Vehicle
    {
        private int countOfPassengers, port;

        public Ship(int cost, int speed, int year, int count, int port)
        {
            this.cost = cost;
            this.speed = speed;
            this.year = year;
            countOfPassengers = count;
            this.port = port;
        }

        public void Information()
        {
            Console.WriteLine("Vehicle: Ship");
            Console.WriteLine("Features:");
            Console.WriteLine("speed - {0}km/h, year - {1}, passengers - {2}", speed, year, countOfPassengers);
            Console.WriteLine("Main port №{0}", port);
            Console.WriteLine("The price of the goods: {0}$", cost);
            Console.WriteLine();
        }
    }
}
