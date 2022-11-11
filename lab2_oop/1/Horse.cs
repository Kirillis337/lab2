using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace lab2_oop
{
    class Horse
    {
        private string kind="Лошади";
        protected string name;
        
        public Horse()
        {
            Console.WriteLine($"Создание {kind}");
            Console.Write("Введите имя: ");
            name = Console.ReadLine();
            while (!Regex.IsMatch(name, @"^[А-Яа-я]+$"))
            {
                Console.Write("Введите корректное имя: ");
                name = Console.ReadLine();
            }
        }

        public void Info()
        {
            Console.WriteLine($"Кличка:  {name}");
        }

    }
}
