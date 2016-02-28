using System;
using System.Collections.Generic;

namespace Ex.Third.Inheritance
{
    class ClassRoom
    {
        List<Pupil> pupilClass = new List<Pupil>();
        public ClassRoom(Pupil first, Pupil second, Pupil third, Pupil fourth)
        {
            pupilClass.Add(first);
            pupilClass.Add(second);
            pupilClass.Add(third);
            pupilClass.Add(fourth);
        }
        public ClassRoom(Pupil first, Pupil second, Pupil third)
        {
            pupilClass.Add(first);
            pupilClass.Add(second);
            pupilClass.Add(third);
        }
        public ClassRoom(Pupil first, Pupil second)
        {
            pupilClass.Add(first);
            pupilClass.Add(second);
        }

        public void ClassBook()
        {
            foreach (var item in pupilClass)
            {
                Console.WriteLine("{0} pulil:", pupilClass.IndexOf(item) + 1);
                item.Read();
                item.Relax();
                item.Write();
                item.Study();
                Console.WriteLine();
            }
        }
    }
}
