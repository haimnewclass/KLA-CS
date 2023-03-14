using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLA_Console
{
    public class Car
    {
        public string Model;
        public int Id;
        public int KM = 0;

        public void PrintStatus()
        {
            Console.WriteLine("Car "+Model+" "+KM);
        }
        public bool CheckValidDrive()
        {
            if (KM < 1000)
                return true;
            else
                return false;
        }
        public void AddKm(int km)
        {
            KM = KM + km;
        }
    }
}
