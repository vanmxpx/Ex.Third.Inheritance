using System;

namespace Ex.Third.Inheritance
{
    class ExcelentPupil : Pupil
    {
        public override void Read()
        {
            Console.WriteLine("Reading skill: Hight");
        }

        public override void Relax()
        {
            Console.WriteLine("Relaxing skill: Low");
        }

        public override void Study()
        {
            Console.WriteLine("Styding skill: Hight");
        }

        public override void Write()
        {
            Console.WriteLine("Writing skill: Hight");
        }
    }
}
