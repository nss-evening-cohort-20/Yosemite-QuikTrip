namespace Yosemite_QuikTrip;
public class StoreRepository
{
    // we're using a static list here instead of a proper database
    // but the general idea still holds up once we cover databases
    // it's just another piece of code to replace and refactor nbd
    static List<Stores> _stores = new List<Stores>();

    public List<Stores> GetStores()
    {
        return _stores;
    }

    public void SaveNewStore()
    {
        Console.Clear();

        Stores newStore = new Stores("", "", 0);

        Console.Write("Store Name: ");
        newStore.Name = Console.ReadLine();

        Console.Write("Store Manager: ");
        newStore.Manager = Console.ReadLine();

        Console.Write("Store Sales: ");
        newStore.Sales = int.Parse(Console.ReadLine());

        _stores.Add(newStore);

        Console.WriteLine(@$"
==================================
District {newStore.Name} added to database!
Manager: {newStore.Manager}
Sales: {newStore.Sales}
==================================
");

        Console.Write("Press enter to exit.");
        Console.ReadLine();
    }

    public void UpdateStore(Stores stores)
    {
        throw new NotImplementedException();
    }

    public void RemoveStore()
    {
        Console.Write("Enter Store name to remove: ");

        string name = Console.ReadLine().ToLower();
        Stores foundStore = _stores.FirstOrDefault(d => d.Name.ToLower() == name);
        _stores.Remove(foundStore);

        Console.WriteLine($"Store {name.ToUpper()} was removed from database.");

        Console.Write("Press enter to exit.");
        Console.ReadLine();


    }
}

