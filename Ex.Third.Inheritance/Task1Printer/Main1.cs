using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex.Third.Inheritance
{
    partial class Presenter
    {
        public void Printer()
        {
            TestClass1 print1 = new TestClass1();
            TestClass2 print2 = new TestClass2();
            TestClass3 print3 = new TestClass3();
            print1.Print("Hey!");
            print2.Print("I'm from another class. I changed color");
            print3.Print("And again!");

        }
    }
}
