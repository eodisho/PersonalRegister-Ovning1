using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalRegister_Ovning1
{
    class PersonalRegister
    {
     public void AddEmployeeName( string name)
        {
            employeeName.Add(name);
        }
        public void AddEmployeeSalary(float salary)
        {
            employeeSalary.Add(salary);
        }

        List<string> employeeName = new List<string>();
        List<float> employeeSalary = new List<float>();

    }


}
