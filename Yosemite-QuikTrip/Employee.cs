using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yosemite_QuikTrip
{
    internal class Employee
    {
        public string EmployeeName { get; set; }
        public string EmployeeTitle { get; set; }

        public double RetailSales { get; set; }

        public int EmployeeStoreNumber { get; set; }

        public Employee(string name, string employeeTitle, double retailSales, int employeeStoreNumber)
        {
            EmployeeName = name;
            EmployeeTitle = employeeTitle;
            RetailSales = retailSales;
            EmployeeStoreNumber = employeeStoreNumber;
        }

       public Stores Store { get; set; }
        public void DisplayEmployee() 
        {
            Console.WriteLine(@"Employee Name: " + EmployeeName,
                "Employee Title: " + EmployeeTitle,
                "Retail sales" + RetailSales);
        }
            }
}
