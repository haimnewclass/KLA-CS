using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLA2
{
    internal class StaticSample
    {
        public static int Count;
        public int Id;
        public void Print()
        {
            Count++;
            Console.WriteLine(Count);
            Console.WriteLine(Id);
        }

        public static int FixCount(int count)
        {
            int a = 90;

            return Count;
        }
    }
}
