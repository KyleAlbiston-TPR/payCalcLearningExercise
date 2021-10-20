using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace localPayCalc
{
    public interface IEmployeeRepository
    {
        Employee GetEmployee(int Id);
        IEnumerable<Employee> GetAll(IEnumerable<int> Id);
        Employee CalculateTotal();
        Employee CalculateHourly();
    }
}
