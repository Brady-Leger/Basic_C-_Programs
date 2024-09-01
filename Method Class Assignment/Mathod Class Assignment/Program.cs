using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathod_Class_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Here we will Instantiate the class
            MathOperation foo = new MathOperation();
            //User Input asking for an integer
            Console.WriteLine("Enter an integer");
            int i = Convert.ToInt32(Console.ReadLine());
            //Asking the user for a second integer, this one will print to screen
            Console.WriteLine("Enter a second integer");
            int j = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The second integer you provided was " + j);
            

            foo.MathOp(i, j);
            foo.MathOp(first: i, second: j);
           
            Console.ReadLine();
        }
    }
}
