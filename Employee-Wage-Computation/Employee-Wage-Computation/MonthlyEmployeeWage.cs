

   
using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Wage_computation
{
    public class MonthlyEmployeeWage
    {
        public const int IS_PART_TIME = 1, IS_FULL_TIME = 2, EMP_RATE_PER_HOUR = 20, NUM_OF_WORKING_DAYS = 20;
        int empHrs = 0, empWage = 0, totalEmpWage;
        public void Employee_Wage_Computation()
        {
            for (int day = 0; day < NUM_OF_WORKING_DAYS; day++)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                empWage = empHrs * EMP_RATE_PER_HOUR;
                totalEmpWage += empWage;
                Console.WriteLine("Employee Wage : " + empWage);
            }
            Console.WriteLine("Total Employee Wage : " + totalEmpWage);
        }
    }
}