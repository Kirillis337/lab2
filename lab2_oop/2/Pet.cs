using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_oop
{
    class Pet
    {
        protected double weight;
        protected int age;
        protected string gender;
        public Pet()
        {
            Console.Write("Введите вес: ");
            while (!(double.TryParse(Console.ReadLine(), out weight) && weight > 0))
                Console.Write("Введите корректный вес: ");
            Console.Write("Введите возраст: ");
            while (!(int.TryParse(Console.ReadLine(), out age) && age > 0))
                Console.Write("Введите корректный возраст: ");
            Console.Write("Введите пол (м/ж): ");
            gender = Console.ReadLine();
            while (!(gender == "м" || gender == "ж"))
            {
                Console.Write("Есть только 2 гендера. Введите пол(м/ж): ");
                gender = Console.ReadLine();
            }

        }
 
    }
}
