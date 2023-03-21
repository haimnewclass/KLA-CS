using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLA_Console
{







    internal class Item
    {
        public float Price;
        public string Name;
        public int Barcode;
        public string Word;

        public string  Description()
        {
            string ret = string.Format("The Item {0} Costs {1}", Name, Price);
            return ret;
        }

        public float Haim(int a)
        {
            return a * a * Price;
        }

    }
}
