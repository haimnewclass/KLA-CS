using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace KLA4_InpuitDataFromUser
{
    internal class InputData
    {
        public void InputDataFromConsole()
        {
            bool IsRunning = true;
            Console.WriteLine("For Exit, type EXIT");
            Console.WriteLine("Enter Student Details by following format: <Name>,<Age>,<Id>");
            while (IsRunning)
            {

                string userResponse = Console.ReadLine();
                if(userResponse=="EXIT")
                {
                    IsRunning = false;
                }

                string[] details = userResponse.Split(',');
                string name = details[0];
                int age= int.Parse(details[1]);
                int taz= int.Parse(details[2]);
            }

            Console.WriteLine("Thanks");
            Console.ReadLine();
        }


        public void InputDataFromFile()
        {
            string fileName = @"C:\Users\ASI\source\repos\KLA-CS\Students.txt";
            string[] allLines =  File.ReadAllLines(fileName);
            for(int currLine = 0; currLine < allLines.Length; currLine++)
            {
                string line = allLines[currLine];
                string[] details = line.Split(',');
                string name = details[0];
                int age = int.Parse(details[1]);
                int taz = int.Parse(details[2]);

                Student student = new Student();
                student.Age = age;
                // create new student object

                string f = string.Format("The Sudent {0} is {1} years old, has Id {2}",name,age,taz);

                string old = (age> 40)?("Old"):("Not Old");

                f = $"The Sudent {name} is {age} years old, has Id {taz} { old } {1+1}";
            }

        }


    }
}
