using System;
using System.Text.RegularExpressions;

namespace lab2_oop
{
    class Program
    {
        static void Main(string[] args)
        {
            byte task;

            Console.Write("Введите номер задания(1-3): ");
            while (!byte.TryParse(Console.ReadLine(), out task))
                Console.Write("Введите корректную x координату центра: ");
            switch (task)
            {
                case 1:
                    Horse hrs1 = new Horse();
                    DrawLine();
                    Pegas pgs1 = new Pegas();
                    DrawLine();
                    hrs1.Info();
                    pgs1.Info();
                    DrawLine();
                    pgs1.Tofly();
                    break;
                case 2:
                    Console.WriteLine("Создаем кота");
                    Cat cat1 = new Cat();
                    DrawLine();
                    cat1.Info();
                    DrawLine();
                    Console.WriteLine("Создаем собаку");
                    Dog dog1 = new Dog();
                    DrawLine();
                    dog1.Info();
                    break;
                case 3:
                    Fish fsh = new Fish(true);
                    fsh.Info();
                    fsh.ToSwim();
                    Animal animal = new Animal(false, "Шерсть");
                    animal.Info();
                    fsh.ToSwim();
                    animal.ToWalk();
                    Monkey mnk = new Monkey(true, "Шерсть", 20);
                    mnk.Info();
                    fsh.ToSwim();
                    animal.ToWalk();
                    mnk.ToClimb();
                    Human hum = new Human(true, "Густая шевелюра", 16, "Вася","Пупкин","Слесарь");
                    hum.Info();
                    fsh.ToSwim();
                    animal.ToWalk();
                    mnk.ToClimb();
                    hum.Totalk();
                    break;
                  
            }

             Console.ReadKey();
        }
        static void DrawLine()
        {
            Console.WriteLine("--------------------------------------------------------------------------------");
        }
    }
}
