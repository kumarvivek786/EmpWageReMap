using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Employee Wage Computation");
            const int IS_PART_TIME = 1;
            const int IS_FULL_TIME = 2;
            const int EMP_RATE_PER_HOUR = 20;
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0,3);
            switch (empCheck)
            {
                case IS_PART_TIME:
                    empHrs = 4;
                    Console.WriteLine("PartTime Employee is Present");
                    break;
                case IS_FULL_TIME:
                    empHrs = 8;
                    Console.WriteLine("FullTime Employee is Present");
                    break;
                default:
                    empHrs = 0;
                    break;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee wages is=" + empWage);
            Console.ReadLine();
        }
    }
}
