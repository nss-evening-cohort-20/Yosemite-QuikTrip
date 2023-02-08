using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yosemite_QuikTrip
{
    internal class Stores
    {
        public Stores(int storeNumber, string storeManager, string assistantManager,
           double storeManagerRetailSales, double assistantManagerRetailSales
       )
        {
            StoreNumber = storeNumber;
            StoreManager = storeManager;
            AssistantManager = assistantManager;
            StoreRetailSales = storeManagerRetailSales;
            AssistantRetailSales = assistantManagerRetailSales;
        }
        public Stores(int storeNumber, string districtName)
        {
            StoreNumber = storeNumber;
            DistrictName = districtName;
        }

        public int StoreNumber { get; set; }
        public string StoreManager { get; set; }
        public string AssistantManager { get; set; }
        public double StoreRetailSales { get; set; }
        public double AssistantRetailSales { get; set; }

        public string DistrictName { get; set; }
        public static List<Employee> Employees { get; set; } = new List<Employee>();
        public static List<GasRecord> GasRecords { get; set; } = new List<GasRecord>();



    }
}
