using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityProject
{
    internal class Teacher
    {

        public Teacher(int id,int age,string name)
        {
            Id = id;
            Age = age;
            Name = name;
        }

        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private List<Professional> teachingProfessional;

        public List<Professional> TeachingProfessional
        {
            get { return teachingProfessional; }
            set { teachingProfessional = value; }
        }


    }
}
