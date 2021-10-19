using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace localPayCalc
{
    public class MockEmployeeRepository : IPermEmployeeRepository
    {
        private List<PermEmployee> permEmployeeList;

        public MockEmployeeRepository()
        {
            permEmployeeList = new List<PermEmployee>()
            {
                new PermEmployee()
                { 
                StaffID = 001,
                StaffName = "Kyle Albiston",
                AnnualSalary = 15000,
                AnnualBonus = 200,
                HoursWorked = 1820                
                }
            };
        }

        public PermEmployee GetEmployee(int StaffID)
        {
            return permEmployeeList.FirstOrDefault(e => e.StaffID == StaffID);
        }



        public void save(PermEmployee employee)
        {
            throw new NotImplementedException();
        }
    }
}
