using System;

namespace Ex.Third.Inheritance
{
    class Car : Vehicle
    {
        public Car(int cost, int speed, int year)
        {
            this.cost = cost;
            this.speed = speed;
            this.year = year;
        }

        public void Information()
        {
            Console.WriteLine("Vehicle: Car");
            Console.WriteLine("Features:");
            Console.WriteLine("speed - {0}km/h, year - {1}", speed, year);
            Console.WriteLine("The price of the goods: {0}$", cost);
            Console.WriteLine();
        }
    }
}
