using System;
using System.Text.RegularExpressions;

namespace lab2_oop
{
    class Program
    {
        static void Main(string[] args)
        {
            byte task;

            Console.Write("Введите номер задания(1-4): ");
            while (!byte.TryParse(Console.ReadLine(), out task))
                Console.Write("Введите корректную x координату центра: ");
            switch (task)
            {
                case 1:
                    
                    Horse hrs1 = new Horse();

                    Pegas pgs1 = new Pegas();

                    hrs1.Info();
                    
                    pgs1.Info();

                    pgs1.Tofly();
                    break;
                case 2:
                    //Cat cat1 = new Cat();
                    //cat1.Info();
                    break;
                case 3:

                    break;
                case 4:

                    break;
            }

        }
    }
}
