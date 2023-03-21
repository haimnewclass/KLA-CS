using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLA2
{
    internal class Item
    {
        public static int ItemsPurchased { get; set; }
        public Item(string code)
        {
            Code = code;
            
        }
        string code; 
        public string Code
        {
            set
            {
                // verify that string length is smaller than 5
                string str = value;

                if(str.Length> 5) {
                    code = str.Substring(0, 5);
                }
                else
                    code = value;
            }
        
            get { return code; }
        }
        public int CountInStock { get; set; }
        public float? Price { get; set; }
        public string Name { get; set; }

        public float? Purchase(int count)
        {
            CountInStock -= count;
            ItemsPurchased += count;
            return Price * count;
            
        }
    }
}
