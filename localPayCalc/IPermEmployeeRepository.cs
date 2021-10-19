using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace localPayCalc
{
    public interface IPermEmployeeRepository
    {
        PermEmployee GetEmployee(int id);
        void save(PermEmployee employee);
    }
}
