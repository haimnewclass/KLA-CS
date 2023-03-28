using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLA4.Abs
{
    internal class AbstractClass
    {
        public AbstractClass() { }
        public void Run()
        {
            ArcharV17 archarBase = new ArcharV17();
            archarBase.RunRecEditor();
        }
    }

    abstract class ArcharBase
    { 
        public void OpenToolTCUY()
        {

        }
        public void RunRecEditor() {
             
            string ret = InstallArcherVersion("***");
            if(TestStatus("rec1"))
            {
                if(TestStatus("rec2"))
                {
                    Console.WriteLine("Success");
                } 
            }
        }

        abstract public string InstallArcherVersion(string str);
       
        abstract public bool TestStatus(string path);

    }

    class ArcharV17:ArcharBase
    {
        override public string InstallArcherVersion(string str)
        {
            OpenToolTCUY();
            return str + "17";
        }

        override public bool TestStatus(string path)
        {
            for (int i = 0; i < 10; i++)
            {
                OpenToolTCUY();
            }
           
            return false;
        }
    }

    class ArcharV18: ArcharBase
    {
       override public string InstallArcherVersion(string str)
        {
            return str + "18";
        }

        override public bool TestStatus(string path)
        {
            for (int i = 0; i < 2; i++)
            {
                OpenToolTCUY();
            }

            return false;
        }
    }
}
