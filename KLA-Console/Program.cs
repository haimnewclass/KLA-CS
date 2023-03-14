using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLA_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 12;
            float b = 12.4f;
            bool c = false;
            a++;

            Student moshe = new Student(); 
            moshe.Name = "Moshe Levi";
            moshe.Id = 132134;
            moshe.HasCar= true;
            moshe.Height= 200f;

            moshe.PrintStudentDetails();
            moshe.PrintStudentDetailsMore();



            Student avi = new Student();
            avi.Name = "avi Levi";
            avi.Id = 2332;
            avi.HasCar = false;
            avi.Height = 199f;
            avi.PrintStudentDetails();



            Student[] students = new Student[10];

            students[0] = new Student();

        }

















        static void Main2(string[] args)
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
            int num12 = muku.Next(int.MinValue, int.MaxValue);
            int num13 = muku.Next(10, 20);

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(muku.Next(10,100));
            }

            int[] students = new int[10];
            string[] strArr = new string[5];
            for (int i = 0; i < students.Length; i++)
            {
                students[i] = muku.Next(10,100);
                Console.WriteLine(students[i]);
            }

            
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i]);
            }

            // Exc 8
            int[] arr1 = new int[10];
            int[] arr2 = new int[arr1.Length];

            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = muku.Next(1, 1000);
            }

            for (int i = 0; i < arr1.Length; i++)
            {
                arr2[i] = arr1[i] * arr1[i];
            }

            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine(arr2[i]);
            }

            //////
            /// Exc 9
            /// 

            string[] strArr1 = new string[5];

            for (int i = 0; i < strArr1.Length; i++)
            {
                strArr1[i] = Console.ReadLine();
            }

            int max = 0;
            int location=0;
            for (int i = 0; i < strArr1.Length; i++)
            {
                Console.WriteLine(strArr1[i]);
                Console.WriteLine(strArr1[i].Length);
                if (strArr1[i].Length>max)
                {
                    max = strArr1[i].Length;
                    location = i;
                }
            }

            Console.WriteLine(string.Format("String {0} has {1} chars", strArr1[location], strArr1[location].Length));
            Console.ReadLine();
        }
    }
}
