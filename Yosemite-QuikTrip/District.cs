namespace Yosemite_QuikTrip;

public class District
{
    ////District
    //list of stores
    //district manager
    //inherit from employee (override retail sales)
    //district name
    //district sales -- totals store sales



    //Public Properties//
    public string Manager { get; set; }

    public string Name { get; set; }

    public int Sales { get; set; }

    //Constructor Method//
    public District(string districtName, string districtManager, int districtSales)
    {
        Name = districtName;
        Manager = districtManager;
        Sales = districtSales;
    }

   
}



