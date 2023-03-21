using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLA2
{
  
    internal class BaseCup
    {
        public  int Capacity { get; set; }
        public string Color { get; set; }

        public void Drink()
        {

        }
    }

    internal class CoffeeCup:BaseCup
    {
        public bool HasPlatte { get; set; } = false;
    }

    internal class BeerCup : CoffeeCup
    {
        public int Id;
        public Guid UUID = Guid.NewGuid();
        public bool HasLogo { get; set; } = true;
    }
}
