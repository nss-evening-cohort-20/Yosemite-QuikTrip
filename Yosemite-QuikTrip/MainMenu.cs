using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Yosemite_QuikTrip
{
    public class MainMenu
    {
        readonly DistrictMenu districtMenu = new DistrictMenu();
        readonly EmployeeRepository employeeRepository= new EmployeeRepository();

        private enum MenuOptions
        {
            None,            
            Enter_District_Sales,           
            Generate_District_Report,            
            Add_New_Employee,            
            Add_A_Store_Or_District,
            Exit
        }
        public void Render()
        {
        bool breakWhileLoop = true;
            while(breakWhileLoop)
            {
                MenuOptions currentOption = MenuOptions.None;

                Console.Clear();

                StringBuilder stringBuilder = new StringBuilder();

                List<string> menuOptions = Enum.GetNames<MenuOptions>().ToList();

                for (int i = 1; i < menuOptions.Count; i++) 
                {
                    stringBuilder.AppendLine($"{i}. {menuOptions[i]}");
                }
                Console.WriteLine("QuikTrip Management Systems");
                Console.WriteLine();

                Console.WriteLine( stringBuilder.ToString().Replace('_', ' ') );
                Console.Write("Please Select An Option:");
                string userInput = Console.ReadLine();

                MenuOptions userPickedOption = (MenuOptions)int.Parse(userInput);

                //still dont understand switches because ethan = "bigDummy"
                switch (userPickedOption) 
                {
                    case MenuOptions.None:
                        break;
                    case MenuOptions.Enter_District_Sales:
                        break;
                    case MenuOptions.Generate_District_Report:
                        break;
                    case MenuOptions.Add_New_Employee:
                        employeeRepository.SaveNewEmployee();
                        break;
                    case MenuOptions.Add_A_Store_Or_District:
                        districtMenu.RenderDistrictMenu();
                        break;
                    case MenuOptions.Exit:
                        Exit();
                        breakWhileLoop = false;
                        break;
                    default: break;
                }
            }
         void Exit()
        {
            Console.WriteLine("Exiting QuikTrip Systems...");
        }
        }
    }
}
