using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
                string hourlyRate1 = Console.ReadLine();
            Console.WriteLine("Hours Worked Per Week?");
                string hours1 = Console.ReadLine();
                int salary1 = Convert.ToInt32(hourlyRate1) * Convert.ToInt32(hours1) * 52;
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
                string hourlyRate2 = Console.ReadLine();
            Console.WriteLine("Hours Worked Per Week?");
                string hours2 = Console.ReadLine();
                int salary2 = Convert.ToInt32(hourlyRate2) * Convert.ToInt32(hours2) * 52;
            Console.WriteLine("Annual Salary of Person 1: " + Convert.ToString(salary1));
            Console.ReadLine();
            Console.WriteLine("Annual Salary of Person 2: " + Convert.ToString(salary2));
            Console.ReadLine();
                bool isMore = salary1 > salary2;
            Console.WriteLine("Person 1 makes more money than person 2? " + Convert.ToString(isMore));
            Console.ReadLine();
        }
    }
}
