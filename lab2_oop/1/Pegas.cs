using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_oop
{
    class Pegas : Horse
    {
        private string kind = "Пегаса";


        public void Tofly()
        {
            Console.WriteLine("Летит{0} ",name);
        }
    }
}
