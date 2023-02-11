namespace Yosemite_QuikTrip;
public class DistrictRepository
{
    // we're using a static list here instead of a proper database
    // but the general idea still holds up once we cover databases
    // it's just another piece of code to replace and refactor nbd
        static List<District> _districts = new List<District>();

        public List<District> GetDistricts()
        {
        return _districts;
    }

    public void SaveNewDistrict()
    {
        Console.Clear();

        District newDistrict = new District("", "", 0);

        Console.Write("District Name: ");
        newDistrict.Name = Console.ReadLine();

        Console.Write("District Manager: ");
        newDistrict.Manager = Console.ReadLine();

        Console.Write("District Sales: ");
        newDistrict.Sales = int.Parse(Console.ReadLine());

        _districts.Add(newDistrict);

        Console.WriteLine(@$"
==================================
District {newDistrict.Name} added to database!
Manager: {newDistrict.Manager}
Sales: {newDistrict.Sales}
==================================
");

        Console.Write("Press enter to exit.");
        Console.ReadLine();
        }

    public void UpdateDistrict(District district)
        {
            throw new NotImplementedException();
        }

    public void RemoveDistrict()
    {
        Console.Write("Enter district name to remove: ");

        string name = Console.ReadLine().ToLower();
        District foundDistrict = _districts.FirstOrDefault(d => d.Name.ToLower() == name);
        _districts.Remove(foundDistrict);

        Console.WriteLine($"District {name.ToUpper()} was removed from database.");

        Console.Write("Press enter to exit.");
        Console.ReadLine();


    }
}
//class StoreRepository
//{
//    static List<Store> _stores = new List<Store>();

//    public List<Store> GetStores();
//    {
//        throw new NotImplementedException();
//    }
//}
