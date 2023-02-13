namespace Yosemite_QuikTrip;



public class Employee
{
    public Employee()
    {
    }

    public Employee(int id, string fristName, string lastName, string title, int store, string district)
    {
        Id = id;
        FristName = fristName;
        LastName = lastName;
        Title = title;
        Store = store;
        District = district;
    }

    public int Id { get; set; }
    public string FristName { get; set; }
    public string LastName { get; set; }
    public string Title { get; set; }

    public int Store { get; set; }
    public string District { get; set; }

    public List<Employee> _employees { get; set; }//= new List<Employee>();
                                                 //public void AddEmployee(Employee employee)
                                                 //{
                                                 //    Employees.Add(employee);
                                                 //}

    public int NumberValidation(string input)
    {

        int ValidNumber = 0;
        //string input = Console.ReadLine();
        bool isInvalid, isOutOfRange;
        isOutOfRange = true;
        do
        {
            isInvalid = !int.TryParse(input, out ValidNumber);
            if (!isInvalid)
            {
                isOutOfRange = (ValidNumber < 1 || ValidNumber > 1000);
            }
           
            if (isInvalid)
            {
                Console.Write("Please enter a valid Number value: #");
                input = Console.ReadLine();

            }
            else if (isOutOfRange)
            {
                Console.Write("Please enter value between 1 and 1000: #");
                input = Console.ReadLine();
            }

        } while (isInvalid || isOutOfRange);

        return ValidNumber;
        //newEmployee.Store = ValidNumber;
    }

    /*---------------//valid Name--------------------*/

    public string StringValidation(string input)
    {
        string ValidString = " ";
        while (string.IsNullOrWhiteSpace(input))
        {
            Console.Write("Name cannot be blank: ");
            input = Console.ReadLine();
        }
        //ValidString.
        return ValidString;
    }
    /*---------------//remove an employee--------------------*/

    public void RemoveEmployee(int input)
    {
        //Employee _employees;
        Console.Write("Enter Employee Id to remove: ");

        input = int.Parse(Console.ReadLine());
        Employee foundEmployeet = _employees.FirstOrDefault(d => d.Id == input);
        _employees.Remove(foundEmployeet);

        Console.WriteLine($"Employee #{input} was removed from database.");

        Console.Write("Press enter to exit.");
        Console.ReadLine();
    }









    public void PrintEmployeesToConsol()
    {
        string output = $@"
====================
Employee:{FristName}{LastName}
Title:{Title}
=====================
";
 Console.WriteLine(output);
        
    }


}





//        public Employee(string name, string employeeTitle, double retailSales)
//        {
//            Name = name;
//            EmployeeTitle = employeeTitle;
//            RetailSales = retailSales;
//        }

//        public string RoleMenu
//        {
//            get
//            {
//                return
//    @$"Please Choose Employee's Role
//1) Manager
//2) Assistant Manager
//3) Associate
//";
//            }

//        }

//        public enum RoleSelection
//        {
//            None = -1,
//            Manager = 1,
//            AssistantManager = 2,
//            Associate = 3,
//        }

//        internal Employee()
//        {
//            Role = RoleSelection.None;
//        }


//        public RoleSelection Role;
//        public string Name;
//        public string EmployeeTitle;
//        public int RetailSales;

//        public void EmployeeDetails()
//        {
//            Console.WriteLine($@"
//  {Role}
//  Employee Name: {Name} 
//  Retail Sales: ${RetailSales}
//");
    //}




//}