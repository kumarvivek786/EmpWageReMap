using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    public class Program
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 20;
        public const int MAX_HOURS_IN_MONTH = 100;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to employee wage computation program");

            int empHrs = 0;
            int totalEmpWages;
            int totalWorkingDays = 1;
            int totalEmployeeHour = 0;
            while (empHrs <= MAX_HOURS_IN_MONTH && totalWorkingDays <= NUM_OF_WORKING_DAYS)
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
                totalEmployeeHour += empHrs;
                Console.WriteLine("Day=" + totalWorkingDays + " Emplyee hours=" + empHrs);
                totalWorkingDays++;
            }
            totalEmpWages = totalEmployeeHour * EMP_RATE_PER_HOUR;
            Console.WriteLine("total employee wage is=" + totalEmpWages);
        }
    }
}
