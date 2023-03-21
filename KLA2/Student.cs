using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLA2
{
    internal class Student
    {

        public string Code { get; set; }

        public Student(int id)
        {
            Id = id;
        }

        public Student(int id,string name)
        {
            Id = id;
            Name = name;
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public int Age;
        public void SetAge(int age)
        {
            if(age>12)
                Age = age;
        }
        public int GetAge()
        {
            return Age;
        }

        public void Run(Editor edit,ref int num, out int ret)
        {
            edit.Num++;
            num++;
            ret = num * num;
            Id++;
        }
    }
}
