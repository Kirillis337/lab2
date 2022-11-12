using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_oop
{
    class Monkey : Animal
    {
        protected int fingers;
        public Monkey(bool tail, string hair, int fingers):base(tail,hair)
        {
            this.tail = tail;
            this.hair = hair;
            this.fingers = fingers;
        }
        public void ToClimb()
        {
            Console.WriteLine($"Я умею взбираться на деревья. ");
        }
        public new void Info()
        {
            Console.Write($"Я {GetType().Name}. ");
            if (tail)
                Console.Write("Хвост на месте, ");
            else
                Console.Write("Хвоста нет, ");

            Console.WriteLine($"Волосы: {hair}, Количество пальцев: {fingers}.");

        }
    }

}
