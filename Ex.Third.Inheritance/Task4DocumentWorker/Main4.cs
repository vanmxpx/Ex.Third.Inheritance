using System;

namespace Ex.Third.Inheritance
{
    partial class Presenter
    {
        public void DocumentWorker()
        {
            DocumentWorker editor = new DocumentWorker();

            Console.WriteLine("*----- DOCUMENT WORKER -----*\n");
            Console.WriteLine("Enter a serial key to Pro- or Exress- versions.");
            Console.WriteLine("(if u dont have it press ENTER)");
            Console.Write("\t==> ");
            string key = Console.ReadLine();
            if ("express" == key)
            {
                Console.WriteLine("You work with the Express version.");
                editor = new ExpressDocumentWorker();
            }
            else if ("pro" == key)
            {
                Console.WriteLine("You work with the Pro version.");
                editor = new ProDocumentWorker();
            }
            else if ("" == key)
            {
                Console.WriteLine("You work with the Free version.");
            }
            else Console.WriteLine("Wrong serial key. Opening the Free version.");

            Console.WriteLine();
            editor.OpenDocument();
            editor.EditDocument();
            editor.SaveDocument();
        }
    }
}
