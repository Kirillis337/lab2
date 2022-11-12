using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_oop
{
    class Fish
    {
        protected bool tail;
        public Fish(bool tail)
        {
            this.tail = tail;
        }
        
        public void ToSwim()
        {
            Console.WriteLine("Я умею плавать.") ;
        }
        public void Info()
        {
            Console.Write($"Я {GetType().Name}. ");
            if (tail)
                Console.WriteLine("Хвост на месте.");
            else
                Console.WriteLine("Хвоста нет.");


        }
    }
}
