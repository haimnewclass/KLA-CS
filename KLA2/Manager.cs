using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLA2
{

    internal class Manager
    {

        public BeerCup[] arr = new BeerCup[10];
        public void Run()
        {
            for (int i = 0; i < 10; i++)
            {
                BeerCup beerCup = new BeerCup();
                beerCup.Capacity = 10;
                AddCup(beerCup,i);
            }
        }

        public int currCup = 0;
        public void AddCup(BeerCup beerCup,int key)
        {
            if (key >= 10) return;

            arr[key] = beerCup;
             
        }
        public BeerCup GetCup(int key)
        {
            return arr[key];
        }
    }
}
