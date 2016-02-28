using System;

namespace Ex.Third.Inheritance
{
    partial class Presenter
    {
        public void RunTask()
        {
            Console.WriteLine("Welcome to me programm\n*-Exersize 3: Inheritance-*\n");
            for(int i = 0; i < 4; i++)
            {
                switch (i)
                {
                    case 0:
                        Printer();
                        break;
                    case 1:
                        ClassRoom();
                        break;
                    case 2:
                        Vehicle();
                        break;
                    default:
                        DocumentWorker();
                        break;
                }
                Console.WriteLine("Enter any key to continue.");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
