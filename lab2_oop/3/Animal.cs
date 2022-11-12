using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_oop
{
    class Animal : Fish
    {
        protected string hair;
        public Animal(bool tail, string hair) : base(tail)
        {
            this.tail = tail;
            this.hair = hair;
        }

        public void ToWalk()
        {
            Console.WriteLine($"Я умею ходить.");
        }
        public new void Info()
        {
            Console.Write($"Я {GetType().Name}. ");
            if (tail)
                Console.Write("Хвост на месте, ");
            else
                Console.Write("Хвоста нет, ");

            Console.WriteLine($"Волосы: {hair}. ");
        }
    }
}
