using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yosemite_QuikTrip
{
    internal class EmployeeRepository
    {
        public static List<Employee> Employees {get; set;} = new List<Employee>() 
        {
            new Employee {EmployeeName = "Brian", EmployeeTitle = "Manager"}
            
        };

        public static Employee GetByName(string name)
        {
            return Employees.Find(e => e.EmployeeName == name);
        }
        
        public static Employee GetManagerRetailSales(double sales) 
        {
            return Employees.Find(s => s.ManagerRetailSales == sales);
        }

        public static Employee GetAsstiantRetailSales(double aSales)
        {
            return Employees.Find(a => a.AssistantRetailSales == aSales );
        }


    }
}
