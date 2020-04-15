using System;
using System.Collections.Generic;
using System.Text;

namespace lab_one
{
    class Robot
    {
        public delegate void MethodContainer();
        public event MethodContainer Back;

        public void Move()
        {
            Random rnd = new Random();
            int number;
            for(int i = 0; i < 100; i++)
            {
                number = rnd.Next(1,5);
                switch (number)
                {
                    case 1:
                        Console.WriteLine("Вперёд");
                        break;
                    case 2:
                        Console.WriteLine("Влево");
                        break;
                    case 3:
                        Console.WriteLine("Вправо");
                        break;
                    case 4:
                        Console.WriteLine("Назад");
                        Back();
                        break;


                }
            }
        }
    }
}
