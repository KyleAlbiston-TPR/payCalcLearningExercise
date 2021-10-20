using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PayCalc;

namespace localPayCalc
{
    class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _EmployeeList;
        public MockEmployeeRepository()
        {
            _EmployeeList = new List<Employee>()
            {
                new Employee()
                { Id = 1, Name = "Kyle Albiston", AnnualSalary = 15000, AnnualBonus = 4000, HoursWorked = 1820 },
                new Employee()
                { Id = 2, Name = "Mark Hammerson", AnnualSalary = 18000, AnnualBonus = 2500, HoursWorked = 2000 }
            };

        }

        public Employee CalculateHourly()
        {
            throw new NotImplementedException();
        }

        public Employee CalculateTotal()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetAll(IEnumerable<int> Id)
        {
            using (var context = new MockEmployeeRepository(_EmployeeList))
            {
                return context._EmployeeList.Where(e => e.Id(id => id == e)).ToList();
            }
        }

        public Employee GetEmployee(int Id)
        {
            return _EmployeeList.FirstOrDefault(e => e.Id == Id);
        }
    }
}