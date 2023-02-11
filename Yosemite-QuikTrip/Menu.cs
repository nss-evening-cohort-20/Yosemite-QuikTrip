using System.Text;

namespace Yosemite_QuikTrip;
public class Menu
{
    private DistrictRepository _districtRepository = new DistrictRepository();

    private enum MenuOption
    {
        DistrictSales = 1,
        DistrictReport,
        NewEmployee,
        ShowDistricts,
        AddDistrict,
        RemoveDistrict,
        EditDistrict,
        AddStore,
        Exit
    }

    private bool _running;

    public void Show()
    {
        _running = true;
        while (_running)
        {
            MenuOption currentOption = MenuOption.DistrictSales;

            Console.Clear();
            string menuText = GetMenuAsText();
            Console.Write(menuText);

            string input = Console.ReadLine();
            MenuOption chooseOption = (MenuOption)int.Parse(input);

            switch (chooseOption)
            {
                case MenuOption.DistrictSales:
                    GetDistrictSales();
                    break;

                case MenuOption.DistrictReport:
                    GetDistrictReport();
                    break;

                case MenuOption.NewEmployee:
                    GetNewEmployee();
                    break;

                case MenuOption.ShowDistricts:
                    ShowDistricts();
                    break;

                case MenuOption.AddDistrict:
                    _districtRepository.SaveNewDistrict();
                    break;

                case MenuOption.RemoveDistrict:
                    _districtRepository.RemoveDistrict();
                    break;

                case MenuOption.EditDistrict:
                    Console.WriteLine("editing district...");
                    break;

                case MenuOption.AddStore:
                    AddStore();
                    break;

                case MenuOption.Exit:
                    Exit();
                    _running = false;
                    break;

                default:
                    break;

            }
        }
    }

    public void ShowDistricts()
    {
        List<District> districts = _districtRepository.GetDistricts();
        districts.ForEach(district => Console.WriteLine(district.Name));

        Console.Write("Press enter to exit;");
        Console.ReadLine();
    }

    private string GetMenuAsText()
    {
        StringBuilder bldr = new StringBuilder();

        List<string> menuOptions = Enum.GetNames<MenuOption>().ToList();

        for (int i = 0; i < menuOptions.Count; i++) //start at 1, don't print the 0 option
        {
            bldr.AppendLine($"{i + 1}. {menuOptions[i]}");
        }

        bldr.AppendLine();
        bldr.Append("Please select a menu option: ");

        return bldr.ToString();
    }

    public void Exit()
    {
        Console.WriteLine("Exiting...");
    }

    private void GetDistrictSales()
    {
        Console.WriteLine("Enter District Sales");

        Console.ReadLine();
    }

    private void GetDistrictReport()
    {
        Console.Write("Generate District Report");
        Console.ReadLine();
    }

    private void GetNewEmployee()
    {
        Console.WriteLine("Add New Employee");
        Console.Write("Press enter to go back...");
        Console.ReadLine();
    }

    private void AddStore()
    {
        Console.WriteLine("Add a Store/District");

        Console.ReadLine();
    }


}
