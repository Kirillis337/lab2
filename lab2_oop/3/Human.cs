using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_oop
{
    class Human : Monkey
    {
        protected string name;
        protected string surname;
        protected string job;
        public Human(bool tail, string hair, int fingers, string name, string surname, string job) : base(tail, hair,fingers)
        {
            this.tail = tail;
            this.hair = hair;
            this.fingers = fingers;
            this.name = name;
            this.surname = surname;
            this.job = job;
        }
        public void Totalk()
        {
            Console.WriteLine($"Я умею говорить. ");
        }
        public new void Info()
        {
            Console.Write($"Я {GetType().Name}. ");
            Console.Write($"Меня зовут {name} {surname}, ");
            if (tail)
                Console.Write("Хвост на месте, ");
            else
                Console.Write("Хвоста нет, ");

            Console.WriteLine($"Волосы: {hair}, Количество пальцев: {fingers}, Профессия:{job}.");

        }

    }
}
