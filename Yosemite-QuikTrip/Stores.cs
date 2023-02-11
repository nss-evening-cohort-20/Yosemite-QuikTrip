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
            var Manager = EmployeeRepository.GetByName( storeManager ) ?? new Employee();
           

            StoreNumber = storeNumber;
            StoreManager = EmployeeRepository.GetByName(storeManager);
            AssistantManager = EmployeeRepository.GetByName(assistantManager);
            //StoreRetailSales = EmployeeRepository.GetManagerRetailSales(storeManagerRetailSales);
            //AssistantRetailSales = EmployeeRepository.GetAsstiantRetailSales(assistantManagerRetailSales);

            
        }
        public Stores(int storeNumber, string districtName)
        {
            StoreNumber = storeNumber;
            DistrictName = districtName;
        }

        public int StoreNumber { get; set; }
        public Employee StoreManager { get; set; }
        public Employee AssistantManager { get; set; }
        public Employee StoreRetailSales { get; set; }
        public Employee AssistantRetailSales { get; set; }

        public string DistrictName { get; set; }

        //these are the employees that work at this store
        public  List<Employee> Employees { get; set; } = new List<Employee>();
        //public static List<GasRecord> GasRecords { get; set; } = new List<GasRecord>();

       



    }
}
