using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.App
{
    public class SalaryCalculate
    {
        public decimal Calculate(decimal salary,SalaryType salaryType)
        {
            //This code depends on the enums and switch case. 
            //In the future we may want to change the enum list, add a new enum value, or change to calculate operations. all of those requirements affect all codes. we will need to change many things. 
            //We will need to change unit tests and the other dependent code as well

            decimal newSalary = 0;
            switch (salaryType)
            {
                case SalaryType.Low:
                    newSalary = salary * 2;
                    break;
                case SalaryType.Middle:
                    newSalary = salary * 4;
                    break;
                case SalaryType.High:
                    newSalary = salary * 6;
                    break;
                default:
                    break;
            }
            return newSalary;
        }

    }
   public enum SalaryType
    {
        Low,
        Middle,
        High
    }

}
