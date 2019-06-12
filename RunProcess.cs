using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELKOJlogTranEmpOrg
{
    internal class RunProcess : Common
    {
        public void Run()
        {
            new DataProcess().ReadData(EmpFileName);
            new DataProcess().ReadData(DeptFileName);
        }
    }
}