using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLA_Console
{
    internal class ArcherRecepieEditor
    {
        public int[] arr = new int[4];
        public ArcherRecepie[] ArcherRecepiesList = new ArcherRecepie[100];
        public int recepieNum = 0;
        public void Add(ArcherRecepie newArcherRecepie)
        {
            ArcherRecepiesList[recepieNum] = newArcherRecepie;
            recepieNum++;
        }
        
        
        public ArcherRecepie Create()
        {
            ////////////////
            ArcherRecepie archerRecepie = new ArcherRecepie();

            return archerRecepie;
        }

        
    }
}
