using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_and_Objects_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiating of Employees in the Employee Class. 

            Employee employee1 = new Employee();
            employee1.ID = 1234;
            employee1.FirstName = "Brady";
            employee1.LastName = "Leger";

            Employee employee2 = new Employee();
            employee2.ID = 4321;
            employee2.FirstName = "Adia";
            employee2.LastName = "Leger";

            Console.WriteLine(employee1 == employee2);
            Console.ReadLine();
        }

        
    }
}
