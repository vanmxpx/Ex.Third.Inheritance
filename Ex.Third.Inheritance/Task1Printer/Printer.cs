using System;

namespace Ex.Third.Inheritance
{
    class Printer
    {
        private static Random rnd = new Random();

        public void Print(string value)
        {
            Console.ForegroundColor = (ConsoleColor)rnd.Next(16);
            Console.WriteLine(value);
            Console.ResetColor();
        }
    }
}
