using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace localPayCalc
{
    public class PermEmployeeRepository : IPermEmployeeRepository
    {
        public PermEmployee GetEmployee(int StaffID)
        {
            throw new NotImplementedException();
            //logic to get employee details
        }
        public void save(PermEmployee employee)
        { 
            //logice to save details
        }
    }
}
