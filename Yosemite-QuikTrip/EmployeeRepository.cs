

namespace Yosemite_QuikTrip
{
    public class EmployeeRepository
    {
        static List<Employee> _employees = new List<Employee>();

        public List<Employee> GetEmployees()
        {
            return _employees;
        }

        public void SaveNewEmployee()
        {
            Console.Clear();

            Employee newEmployee = new Employee(0, "", "", "", 0, "");

           
            Console.Write("Employee Id: ");    
            newEmployee.Id = int.Parse(Console.ReadLine()); 
         

            Console.Write("Employee FristName: ");
            newEmployee.FristName = Console.ReadLine();

            Console.Write("Employee LastName: ");
            newEmployee.LastName = Console.ReadLine();

            Console.Write("Employee Title: ");
            newEmployee.Title = Console.ReadLine();

            Console.Write("Employee Store Number: ");
            newEmployee.Store = int.Parse(Console.ReadLine());
            string input2 = Console.ReadLine();
            newEmployee.Store =newEmployee.NumberValidation(input2);  

            Console.Write("Employee District: ");
            newEmployee.District = Console.ReadLine();
            _employees.Add(newEmployee);

            Console.WriteLine(@$"Employee {newEmployee.FristName} {newEmployee.LastName} added to database!
Title: {newEmployee.Title}
District: {newEmployee.District}
Store: {newEmployee.Store}");

            Console.Write("Press enter to exit.");
            Console.ReadLine();
        }

        public void UpdateEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public void RemoveEmployee()
        {
            Console.Write("Enter Employee Id to remove: ");

            int id = int.Parse(Console.ReadLine());
            Employee foundEmployeet = _employees.FirstOrDefault(d => d.Id == id);
            _employees.Remove(foundEmployeet);

            Console.WriteLine($"Employee #{id} was removed from database.");

            Console.Write("Press enter to exit.");
            Console.ReadLine();
        }
    }
}
