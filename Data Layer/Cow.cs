using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap1.Data_Layer
{
    internal class Cow : IAnimal
    {
        Random random = new Random();
        public int Amount { get; set; }

        public int GiveBirth()
        {
            return random.Next(1, 3);
        }

        public int Milk()
        {
            return random.Next(0, 21);
        }

        public string Sound()
        {
            return "Moo....";
        }
    }
}
