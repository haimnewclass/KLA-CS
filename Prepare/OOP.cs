using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prepare
{
    internal class OOP
    {
    }


    public class classA
    {
        protected string func1()
        {
            return "classA.func1";
        }

        public string CallToFunc2()
        {
            return func2();
        }
        protected string func2()
        {
            return "classA.func2";
        }

        public string CallToFunc3()
        {
            return func3();
        }
        protected virtual string func3()
        {
            return "classA.func3";
        }

        protected string func4()
        {
            return "classB.func4";
        }
    }

    public class classB : classA
    {
        protected new string func4()
        {
            return "classA.func4";
        }
        protected override string func3()
        {
            func4();
            base.func4();
            return "classB.func3";
        }
        protected string func2()
        {
            return "classB.func2";
        }
        public new  string func1()
        {
            return "classB.func1";
        }
        public void Run()
        {
            Console.WriteLine(CallToFunc3());
        }
    }

    public abstract class classC {
        public string func1()
        {

            return "classC.func1" + func2();
        }
    
        public abstract string func2();
    }

    public class classD : classC {
        public override string func2()
        {
            return "classD.func2";
        }
    }

}
