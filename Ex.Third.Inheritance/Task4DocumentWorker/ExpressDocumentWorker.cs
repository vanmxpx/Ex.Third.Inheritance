using System;

namespace Ex.Third.Inheritance
{
    class ExpressDocumentWorker : ProDocumentWorker
    {
        public override void SaveDocument()
        {
            Console.WriteLine("The document is saved in new format");
        }
    }
}
