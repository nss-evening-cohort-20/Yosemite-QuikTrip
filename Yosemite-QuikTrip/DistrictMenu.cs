using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Yosemite_QuikTrip
{
    public class DistrictMenu
    {
        private DistrictRepository _districtRepository = new DistrictRepository();
        private enum MenuOptions
        {
            None,
            Show_Districts,
            Add_District,
            Remove_District,
            Edit_District,
            Add_Store,
            Go_Back
        }
        private bool breakWhile;
        public void RenderDistrictMenu()
        {
            breakWhile = true;
            while (breakWhile)
            {
                MenuOptions currentOption = MenuOptions.None;

                Console.Clear();

                StringBuilder stringBuilder = new StringBuilder();

                List<string> menuOptions = Enum.GetNames<MenuOptions>().ToList();

                for (int i = 1; i < menuOptions.Count; i++)
                {
                    stringBuilder.AppendLine($"{i}. {menuOptions[i]}");
                }
                Console.WriteLine("District Menu");
                Console.WriteLine();

                Console.WriteLine(stringBuilder.ToString().Replace('_', ' '));
                Console.Write("Please Select An Option:");
                string userInput = Console.ReadLine();

                MenuOptions userPickedOption = (MenuOptions)int.Parse(userInput);

                 void ShowDistricts()
                {
                    List<District> districts = _districtRepository.GetDistricts();
                    districts.ForEach(district => Console.WriteLine(district.Name));

                    Console.Write("Press enter to exit;");
                    Console.ReadLine();
                }

                //still dont understand switches because ethan = "bigDummy"
                switch (userPickedOption)
                {
                    case MenuOptions.None:
                        break;
                    case MenuOptions.Show_Districts:
                        ShowDistricts();
                        break;
                    case MenuOptions.Add_District:
                        _districtRepository.SaveNewDistrict();
                        break;
                    case MenuOptions.Remove_District:
                        _districtRepository.RemoveDistrict();
                        break;
                    case MenuOptions.Edit_District:
                        break;
                    case MenuOptions.Add_Store:
                        break;
                    case MenuOptions.Go_Back:
                        breakWhile = false;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
