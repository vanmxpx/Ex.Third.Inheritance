using System;

namespace Ex.Third.Inheritance
{
    class GoodPupil : Pupil
    {
        public override void Read()
        {
            Console.WriteLine("Reading skill: Middle");
        }

        public override void Relax()
        {
            Console.WriteLine("Relaxing skill: Middle");
        }

        public override void Study()
        {
            Console.WriteLine("Styding skill: Middle");
        }

        public override void Write()
        {
            Console.WriteLine("Writing skill: Middle");
        }
    }
}
