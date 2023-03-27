using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Prepare
{
    interface aInt
    {
        public  static int num { get; set; }
          int MyProperty { get; set; }
        
    }


    internal class Interfaces:aInt
    {
         public  int MyProperty { get; set; }
         

    }

    public class RunMe
    {
        public void Run()
        {
            Interfaces inter = new();
            
             
        }
    
    }


}
