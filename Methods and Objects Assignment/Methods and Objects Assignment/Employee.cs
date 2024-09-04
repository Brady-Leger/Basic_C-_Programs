using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_and_Objects_Assignment
{
    public class Employee : Person, IQuittable
    {
        public int ID { get; set; }

        

        public void Quit(Employee employee)
        {
            throw new NotImplementedException();
        }


        //The below blocks take the employees being compared and returns a value of true
        // or false when comparing their ID numbers to see if they do or do not equal
        // the same value. 


        public static bool operator== (Employee employee1, Employee employee2)
        {
            return employee1.ID == employee2.ID;
        }
        
        public static bool operator!= (Employee employee1, Employee employee2)
        {
            return employee1.ID != employee2.ID;
        }
    }





}
