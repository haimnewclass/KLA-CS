using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLA_Console
{
    internal class ArcherRecepie
    {
        public string Name;
        public bool Ported;
        public DateTime Date;
        public Test[] testList = new Test[1000];
        public int testSum = 0;
        public void Run()
        {

        }

        public void Save()
        {

        }

        public void AddTest(Test newTest)
        {
            testList[testSum] = newTest;
            testSum++;
        }
    }
}
