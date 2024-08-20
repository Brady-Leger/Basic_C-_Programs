using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Exrpess! Please follow the below instructions.");
            Console.WriteLine("Please provide the weight of your package (in lbs, cannot exceed 50lbs.)");
            int weight = Convert.ToInt32(Console.ReadLine());

            //This If/else statment checks to see the if the users inputted weight is over 50! 
            if (weight > 50)
            {
                Console.WriteLine("This package is too heavy to be shipped via Package Express. Have a nice day!");
                Console.ReadLine();
                System.Environment.Exit(1);
            }
            else
            {
                Console.WriteLine("Package weight entered.");
            }

            Console.WriteLine("Please provide the width in inches (cannot exceed 50inches).");
            int width = Convert.ToInt32(Console.ReadLine());

            //This If/else statment checks to see the if the users inputted width is over 50!
            if (width > 50)
            {
                Console.WriteLine("This package is too wide to be shipped via Package Express. Have a nice day!");
                Console.ReadLine();
                System.Environment.Exit(1);
            }
            else
            {
                Console.WriteLine("Package width entered.");
            }

            Console.WriteLine("Please provide the height in inches (cannot exceed 50inches).");
            int height = Convert.ToInt32(Console.ReadLine());

            //This If/else statment checks to see the if the users inputted height is over 50!
            if (height > 50)
            {
                Console.WriteLine("This package is too tall to be shipped via Package Express. Have a nice day!");
                Console.ReadLine();
                System.Environment.Exit(1);
            }
            else
            {
                Console.WriteLine("Package height entered.");
            }

            Console.WriteLine("Please provide the length in inches (cannot exceed 50inches).");
            int length = Convert.ToInt32(Console.ReadLine());

            //This If/else statment checks to see the if the users inputted length is over 50!
            if (length > 50)
            {
                Console.WriteLine("This package is too long to be shipped via Package Express. Have a nice day!");
                Console.ReadLine();
                System.Environment.Exit(1);
            }
            else
            {
                Console.WriteLine("Package height entered.");
            }


            //These equations multiply the inputted height, width and length together,
            // then multiplies that amount by the weight. It then takes that amount,
            // that amount being assigned to the int "product" divides "product" by 100
            // giving us a value for the int "quote"

            int product = (height * width * length) * weight;
            int quote = (product / 100);

            Console.WriteLine("Your estimated shipping cost for this package is $" + quote + ".00 , thank you have a nice day!");
            Console.ReadLine();
        }
    }
}
