using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLA2
{
    internal class TypeCasting
    {
        public void Run()
        {
            int a = 1343;
            byte b = 1;
            a = b;
            a = 50000;
            b = (byte) a;

            float f = 12.3f;
            a = 67;
            a =(int) f;
            f = a;

            string str = "123";
            a = Convert.ToInt32(str);
            a = int.Parse(str);


        }
    }
}
