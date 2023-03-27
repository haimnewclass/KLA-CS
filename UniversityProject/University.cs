using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityProject
{
    internal class University
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string address;

        public string  Addfress
        {
            get { return address; }
            set { address = value; }
        }
        public Dictionary<string, Professional> Professionals = new Dictionary<string, Professional>();

        public Dictionary<int, Student> Students = new Dictionary<int, Student>();
        public Dictionary<int, Teacher> Teachers = new Dictionary<int, Teacher>();        


        public University()
        {
            string professionalsFileName = @"C:\Users\ASI\source\repos\KLA-CS\UniversityProject\Professional.txt";
            LoadProfessional(professionalsFileName);

            string fileName = @"C:\Users\ASI\source\repos\KLA-CS\UniversityProject\Students.txt";
            LoadStudents(fileName);

            string teacherFileName = @"C:\Users\ASI\source\repos\KLA-CS\UniversityProject\Teachers.txt";
            LoadTeachers(teacherFileName);


        }

        public void LoadTeachers(string fName)
        {
            // Read file into string arrray
            string[] allLines = System.IO.File.ReadAllLines(fName);

            for (int i = 0; i < allLines.Length; i++)
            {
                string oneLine = allLines[i];
                string[] teacherDetails = oneLine.Split(',');
                int age = int.Parse(teacherDetails[2]);
                int id = int.Parse(teacherDetails[0]);
                string name = teacherDetails[1];
                string professional = teacherDetails[3];

                Professional professionalObj = Professionals[professional];
                
                Teacher teacher = new Teacher(id, age, name);
                if (!Teachers.ContainsKey(id))
                {
                    teacher.TeachingProfessional = new List<Professional>();
                    teacher.TeachingProfessional.Add(professionalObj);
                    Teachers.Add(id, teacher);
                }
                else
                {
                    teacher = Teachers[id];
                    teacher.TeachingProfessional.Add(professionalObj);
                }

            }

        }
        public void LoadStudents(string fName)
        {
            // Read file into string arrray
            string[] allLines = System.IO.File.ReadAllLines(fName);

            // Split each line into varibles
            for (int i = 0; i < allLines.Length; i++)
            {
                string oneLine = allLines[i];
                string[] studentDetails = oneLine.Split(',');
                int age = int.Parse(studentDetails[2]);
                int id = int.Parse(studentDetails[0]);
                string name  = studentDetails[1];
                string professional = studentDetails[3];

                // Create Student object
                Student newStudent = new Student(id, age, name);
                Professional professionalObj = Professionals[professional];
                newStudent.RegisterToProfessional = professionalObj;

                // Insert student object into Studnts dictionary
                Students.Add(id, newStudent);
            }

          
        }



        public void LoadProfessional(string fName)
        {
            // Read file into string arrray
            string[] allLines = System.IO.File.ReadAllLines(fName);

            // Split each line into varibles
            for (int i = 0; i < allLines.Length; i++)
            {
                string oneLine = allLines[i];

                string[] professionalDetails = oneLine.Split(',');

                string name = professionalDetails[0];
                string description= professionalDetails[1];
                int years = int.Parse(professionalDetails[2]);

                Professional  professional = new Professional(name, years, description);
                if (!Professionals.ContainsKey(name))
                    Professionals.Add(name, professional);
            }



        }

        public void PrintAllStudents()
        {
            Student student = null;
            Student[] students = Students.Values.ToArray<Student>();

            for (int i = 0; i < students.Length; i++)
            {
                student = students[i];
                Console.WriteLine(student.Name);
            }

        }

        public void PrintAllTeachers()
        {
            Teacher teacher = null;
            //Teacher[] teachers = Teachers.Values.ToArray<Teacher>();
            foreach (Teacher item in Teachers.Values)
            {
                Console.WriteLine(item.Name);
            }
        }

        public void PrintAllProfessionals()
        {
            foreach(Professional item in Professionals.Values)
            {
                Console.WriteLine(item.Name);
            }
        }

        public void PrintAllMathStudents()
        {
            foreach(Student student in Students.Values)
            {
                if(student.RegisterToProfessional.Name=="Math")
                {
                    Console.WriteLine(student.Name);
                }
            }
        }

        public void PrintAllTeachersWithAinName()
        {
            foreach(Teacher teacher in Teachers.Values)
            {
                if(teacher.Name.ToLower().Contains("a"))
                {
                    Console.WriteLine(teacher.Name);
                }
            }
        }

        public void PrintAllStudentsThatAreOldThan30()
        {
            foreach(Student student in Students.Values)
            {
                if(student.Age>30)
                {
                    Console.WriteLine(student.Name);
                }
            }
        }
    }
}
