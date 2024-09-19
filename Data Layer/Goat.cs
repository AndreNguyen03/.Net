using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap1.Data_Layer
{
    internal class Goat : IAnimal
    {
        Random random = new Random();
        public int Amount { get ; set ; }

        public int GiveBirth()
        {
            return random.Next(1,5);
        }

        public int Milk()
        {
            return random.Next(0,11);
        }

        public string Sound()
        {
            return "Maaa.....";
        }
    }
}
