using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLA4
{
    internal class Inheritence
    {
        public void Run() { classA c = new classA(); c.RunA2();       }
    }
    public class classA
    {
        private void RunA1()
        {

        }
        public void RunA2()
        {

        }
        protected void RunA3()
       {

       }
    }
    public class classB:classA
    {
        public void RunB()
        {
            RunA3();
            RunA2();
        }
    }




}
