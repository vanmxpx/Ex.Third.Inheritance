using System;

namespace Ex.Third.Inheritance
{
    class BadPupil : Pupil
    {
        public override void Read()
        {
            Console.WriteLine("Reading skill: Low");
        }

        public override void Relax()
        {
            Console.WriteLine("Relaxing skill: Hight");
        }

        public override void Study()
        {
            Console.WriteLine("Styding skill: Low");
        }

        public override void Write()
        {
            Console.WriteLine("Writing skill: Low");
        }
    }
}
