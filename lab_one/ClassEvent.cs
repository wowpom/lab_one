using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace lab_one
{
    class ClassEvent
    {
        public void WriteInFile()
        {
            
            StreamWriter f = new StreamWriter("test.txt", true);
            f.WriteLine("Робот выбрал назад");
            f.Close();
        }
    }
}
