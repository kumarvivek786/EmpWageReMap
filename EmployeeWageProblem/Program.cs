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
            int IS_PART_TIME = 1;
            int IS_FULL_TIME = 2;
            int EMP_RATE_PER_HOUR = 20;
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            if(empCheck == IS_PART_TIME)
            {
                empHrs = 4;
                Console.WriteLine("PartTime Employee is Present");
            }
            else if (empCheck == IS_FULL_TIME)
            {
                empHrs = 8;
                Console.WriteLine("FullTIme Employee is Present");

            }
            else
            {
                empHrs = 0;
                Console.WriteLine("Employee is Absent");
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee wages is=" + empWage);
            Console.ReadLine();
        }
    }
}
