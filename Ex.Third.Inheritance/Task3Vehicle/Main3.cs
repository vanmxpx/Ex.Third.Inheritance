namespace Ex.Third.Inheritance
{
    partial class Presenter
    {
        public void Vehicle()
        {
            Car Volvo = new Car(5000, 200, 2000);
            Ship BigOne = new Ship(10000, 100, 100, 2002, 40125);
            Plane Boeing = new Plane(120000, 400, 250, 2010, 25);

            Volvo.Information();
            BigOne.Information();
            Boeing.Information();
        }
    }
}
