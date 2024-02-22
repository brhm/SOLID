using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.App.Good2
{
    // 2. solution with delegate. This solution is only for C#

    // delegate type:
    // 1. Action => take parameters return void.
    // 2. Predicare => take paremeters return bool.
    // 3. Function => take parameters return types.
    // we use the Func<decimal,decimal> delegate. first parameter is input, last parameter is always output.
    // Func<decimal,double,decimal> => take 2 input parametes and return decimal.

    public class LowSalaryCalculate
    {
       public decimal Calculate(decimal salary)
        {
            return salary * 2;
        }
    }
    public class MiddleSalaryCalculate
    {
        public decimal Calculate(decimal salary)
        {
            return salary * 4;
        }
    }
    public class HighSalaryCalculate
    {
        public decimal Calculate(decimal salary)
        {
            return salary * 6;
        }
    }
    // we only extended the codes and didn't change anything on exist codes.
    public class ManagerSalaryCalculate
    {
        public decimal Calculate(decimal salary)
        {
            return salary * 8;
        }
    }

    public class SalaryCalculate
    {
        public decimal Calculate(decimal salary,Func<decimal,decimal> calculateDelegate)
        {
            return calculateDelegate.Invoke(salary);
        }
    }
  

}
