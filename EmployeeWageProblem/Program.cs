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
            const int NUM_OF_WORKING_DAYS = 20;
            int empHrs = 0;
            int empWage = 0;
            int totalEmpWages = 0;
            
            for (int i = 0; i < NUM_OF_WORKING_DAYS; i++)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                Console.WriteLine("Random value:" + empCheck);


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
                totalEmpWages = totalEmpWages + empWage;
                Console.WriteLine("Employee Wage on Day{0} is {1}", i, empWage);
            }
            Console.WriteLine("total employee wage is=" + totalEmpWages);
            Console.ReadLine();
        }
    }
}
