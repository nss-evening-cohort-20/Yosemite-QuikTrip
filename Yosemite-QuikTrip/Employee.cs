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

    public List<Employee> Employees { get; set; }//= new List<Employee>();
    //public void AddEmployee(Employee employee)
    //{
    //    Employees.Add(employee);
    //}

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