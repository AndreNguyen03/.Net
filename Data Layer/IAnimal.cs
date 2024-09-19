using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap1
{
    public interface IAnimal
    {
        int Amount { get; set; }
        string Sound();
        int Milk();
        int GiveBirth();
    }
}
