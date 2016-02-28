using System;

namespace Ex.Third.Inheritance
{
    class DocumentWorker
    {
        public void OpenDocument()
        {
            Console.WriteLine("Document is opened.");
        }

        public virtual void EditDocument()
        {
            Console.WriteLine("Edit document is available in the Pro version.");
        }

        public virtual void SaveDocument()
        {
            Console.WriteLine("The preservation of the document is available in the Pro version.");
        }
    }
}
