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

            int num1 = 10;
            int num2 = 20;
            bool cond = true;

            cond = num1 > num2;

            if(num1>num2)
            {
                Console.WriteLine("Num1 is Big");
            }
            else
            {
                Console.WriteLine("Num1 is NOT Big");
            }

            string userInput = "";
            userInput = Console.ReadLine();
            while (userInput!="EXIT")
            {
                Console.WriteLine(userInput);
                Console.WriteLine("Please Insert new Value");
                userInput = Console.ReadLine();
            }

            int y = 9;
            y = y + 1;
            y++;

            y = y - 1;
            y--;

            y = y + 90;
            y += 90;

            y = y - 80;
            y -= 80;




            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            ///////////////////////////
            /// Random Numbers
            
            Random muku = new Random();
            int num12 = muku.Next(10, 20);
            int num13 = muku.Next(10, 20);

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(muku.Next(10,100));
            }

            int[] students = new int[30];
            students[0] = 90;
            students[1] = 100;
            students[2] = 30;
            students[3] = 69;
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i]);
            }



            Console.ReadLine();
        }
    }
}
