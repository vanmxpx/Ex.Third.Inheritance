using System;

namespace Ex.Third.Inheritance
{
    class Plane : Vehicle
    {
        private int countOfPassengers, hight;

        public Plane(int cost, int speed, int year, int count, int hight)
        {
            this.cost = cost;
            this.speed = speed;
            this.year = year;
            countOfPassengers = count;
            this.hight = hight;
        }
        public void Information()
        {
            Console.WriteLine("Vehicle: Plane");
            Console.WriteLine("Features:");
            Console.WriteLine("speed - {0}km/h, year - {1}, passengers - {2}", speed, year, countOfPassengers);
            Console.WriteLine("Maximum hight {0}km", hight);
            Console.WriteLine("The price of the goods: {0}$", cost);
            Console.WriteLine();
        }
    }
}
