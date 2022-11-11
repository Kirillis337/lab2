using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace lab2_oop
{
    class Cat : Animal
    {
        protected string name;
        public Cat()
        {
            Console.Write("Введите имя: ");
            name = Console.ReadLine();
            while (!Regex.IsMatch(name, @"^[А-Яа-я]+$"))
            {
                Console.Write("Введите корректное имя: ");
                name = Console.ReadLine();
            }
            
            Console.Write("Введите вес: ");
            while (!double.TryParse(Console.ReadLine(), out weight))
                Console.WriteLine("Введите корректный вес: ");
            Console.Write("Введите возраст: ");
            while (!int.TryParse(Console.ReadLine(), out age))
                Console.WriteLine("Введите корректный возраст: ");
            Console.Write("Введите пол: ");
            gender = Console.ReadLine();
            while (!(gender == "м" || gender == "ж"))
            {
                Console.WriteLine("Введите корректную x координату центра");
                gender = Console.ReadLine();
            }
        }
        public void Info()
        {
            Console.WriteLine($"Кличка:{name} Вес:{weight} Возраст:{age} Пол:{gender}");
        }
    }
}
