using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityProject
{
    internal class Professional
    {
        public Professional(string name,int years,string description = "")
        {
            Name = name;
            YearsToLearn = years;
            Description = description;
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        private int yearsToLearn;

        public int YearsToLearn
        {
            get { return yearsToLearn; }
            set { yearsToLearn = value; }
        }



    }
}
