using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace KLA2.A
{
    public class Employee
    {
        public int Taz { get; set; }
        public string Name { get;set; }
        public int EmpId { get; set; }

        public Guid UUID { get; set; }

    }

    public class Manager
    {
       
        
         
        public Dictionary<int, Employee> list2 = new Dictionary<int, Employee>();

        public Employee[] list = new Employee[1000];
        public Employee CreateEmployee(int Taz, string Name,int EmpId)
        {
          
            Employee ret = new Employee();
            ret.Taz = Taz;
            ret.Name = Name;
            ret.EmpId = EmpId;

            return ret;
        }

        public void AddEmp(Employee emp)
        {
            list[emp.EmpId] = emp;
           // list2[emp.Taz] = emp;
            list2.Add(emp.EmpId, emp);
           
            
        }

        public void RemoveEmp(Employee emp)
        {
            list[emp.EmpId] = null;
            list2[emp.Taz] = null;
        }
    }

}
