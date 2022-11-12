using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_oop
{
    class Pegas : Horse
    {
        //protected new string kind = "Пегас";
        public void Tofly()
        {
            Console.WriteLine($"Летит {name}");
        }
    }
}
