using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLA_Console
{
    public class Student
    {
        public string Name;
        public int Id;
        public float Height;
        public bool HasCar = false;

        public void PrintStudentDetails()
        {
            Console.WriteLine("The Student " + Name + ". Id "+Id);
            PrintStudentDetailsMore();
        
        }
        public void PrintStudentDetailsMore()
        {
            Console.WriteLine("The Student  Has Car " + HasCar + ". Height " + Height);
        }


    }
}
