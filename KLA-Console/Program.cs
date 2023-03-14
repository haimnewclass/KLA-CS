using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLA_Console
{
    internal class Program
    {
        static void Main2(string[] args)
        {
            int a = 9;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("");

            int a;
            a = 10;
            int b = 40 + a;

            double g = 12.4f;

            string str = "adfsdfsdfsdf";
            string kuku;
            str = Console.ReadLine();

            string fullStr = str +" "+ str;
            fullStr = $"This is my Say : {str} and number {b}";
            fullStr = string.Format("This is my Say : {0} and number {1}", str, b);

            string str5 = "10";
            int num = int.Parse(str5);

            int res = num * 22;

            Console.WriteLine(res);

            Console.ReadLine();
        }
    }
}
