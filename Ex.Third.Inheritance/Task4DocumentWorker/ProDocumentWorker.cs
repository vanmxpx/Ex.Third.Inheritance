using System;

namespace Ex.Third.Inheritance
{
    class ProDocumentWorker : DocumentWorker
    {
        public override void EditDocument()
        {
            Console.WriteLine("The document is edited.");
        }

        public override void SaveDocument()
        {
            Console.WriteLine("The document is saved in old format.");
            Console.WriteLine("The preservation of the document in other formats is available in the Express version.");
        }
    }
}
