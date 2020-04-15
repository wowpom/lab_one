using System;

namespace lab_one
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.File.Delete("test.txt");
            Robot robot = new Robot();
            ClassEvent classevent = new ClassEvent();

            robot.Back += classevent.WriteInFile;

            robot.Move();
        }
    }
}
