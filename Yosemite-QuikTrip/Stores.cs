//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Yosemite_QuikTrip
//{
//    internal class Stores
//    {
//        public Stores(int storeNumber, string storeManager, string assistantManager,
//           double storeManagerRetailSales, double assistantManagerRetailSales
//       )
//        {
//            StoreNumber = storeNumber;
//            StoreManager = storeManager;
//            AssistantManager = assistantManager;
//            StoreRetailSales = storeManagerRetailSales;
//            AssistantRetailSales = assistantManagerRetailSales;
//        }
//        public Stores(int storeNumber, string districtName)
//        {
//            StoreNumber = storeNumber;
//            DistrictName = districtName;
//        }

<<<<<<< HEAD
            StoreNumber = storeNumber;
            StoreManager = EmployeeRepository.GetByName(storeManager);
            AssistantManager = EmployeeRepository.GetByName(assistantManager);
            //StoreRetailSales = EmployeeRepository.GetManagerRetailSales(storeManagerRetailSales);
            //AssistantRetailSales = EmployeeRepository.GetAsstiantRetailSales(assistantManagerRetailSales);
=======
//        public int StoreNumber { get; set; }
//        public string StoreManager { get; set; }
//        public string AssistantManager { get; set; }
//        public double StoreRetailSales { get; set; }
//        public double AssistantRetailSales { get; set; }
>>>>>>> 9196728035dc5de21d6e9fa322859404fb7fb7d7

//        public string DistrictName { get; set; }
//        public static List<Employee> Employees { get; set; } = new List<Employee>();
//        public static List<GasRecord> GasRecords { get; set; } = new List<GasRecord>();



//    }
//}
