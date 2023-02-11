using Microsoft.Office.Interop.Outlook;
using System.ComponentModel;

namespace Yosemite_QuikTrip
{
    internal class District
    {
        public string districtName;
        public string districtManager;

        List<string> stores = new List<string>();
        



        public District()
        {
            districtName = "Yosemite";
            districtManager = "Brian Neal";
        }

        public District( string _districtName, string _districtManager, string _DistrictStores)
        {
            districtName = _districtName;
            districtManager = _districtManager;
        }

        

        
         

        public void PrintDistrictInfo()
        {
            Console.WriteLine("District Name " + districtName);
            Console.WriteLine("District Manager " + districtManager);
        }
    }
}
