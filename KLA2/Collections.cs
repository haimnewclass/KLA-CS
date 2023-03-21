using KLA2.A;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLA2
{
    internal class Collections
    {
        public void Run()
        {
            Dictionary<string,Employee> d = new Dictionary<string, Employee>();
            List<Employee> list = new List<Employee>();
            Queue<Employee> queue = new Queue<Employee>();
            Stack<Employee> stack = new Stack<Employee>();
            

            for (int i = 0; i < 10; i++)
            {
                Employee e = new Employee();
                e.Name = "Avi";
                e.Taz = 234234;
                e.EmpId = 5;
                e.UUID = Guid.NewGuid();
                list.Add(e);

                queue.Enqueue(e);
                stack.Push(e);
            }

            while (queue.Count>0)
            {
                Employee e = queue.Dequeue();
                Console.WriteLine(e.Name);
            }

            while (stack.Count > 0)
            {
                Employee e = stack.Pop();
                Console.WriteLine(e.Name);
            }

        }
    }
}
