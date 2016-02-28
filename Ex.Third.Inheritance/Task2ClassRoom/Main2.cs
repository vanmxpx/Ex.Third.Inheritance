namespace Ex.Third.Inheritance
{
    partial class Presenter
    {
        public void ClassRoom()
        {
            BadPupil Brian = new BadPupil();
            GoodPupil Lucy = new GoodPupil();
            GoodPupil Locky = new GoodPupil();
            ExcelentPupil Jane = new ExcelentPupil();

            ClassRoom MyClassRoom = new ClassRoom(Brian, Lucy, Locky, Jane);

            MyClassRoom.ClassBook();
        }
    }
}
