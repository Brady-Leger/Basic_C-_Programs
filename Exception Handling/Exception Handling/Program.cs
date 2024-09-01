using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    Console.WriteLine("Pick a number.");
            //    int numberOne = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Pick another number.");
            //    int numberTwo = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Dividing the two ...");
            //    int numberThree = numberOne / numberTwo;
            //    Console.WriteLine(numberOne + " divided by " + numberTwo + " equals " + numberThree);
            //    Console.ReadLine();
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine("Please type a whole number");
            //    return;
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("That's .... not possible ..");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{

            //    Console.ReadLine();
            //}


            //Console App Strings & Integers Assignment

            //List of integers
            List<int> numberList = new List<int>() { 90, 124, 222, 2716, 500, 134, 2, 11 };

            bool valueValid = false;
            while (!valueValid)
            {
                // Making a try catch block to produce error messages for the user
                try
                {
                    Console.WriteLine("Enter a number to divide our list by!");
                    float valueDivide = float.Parse(Console.ReadLine());
                    if (valueDivide == 0)
                    {
                        Console.WriteLine("You ... can't do that... you knew that though right...?");
                    }

                    // This else block will take each number in the list and divide it by the number provided
                    else
                    {
                        foreach (int num in numberList)
                        {
                            float Divide = num / valueDivide;
                            Console.WriteLine(num + "/" + valueDivide + " = " + Divide);
                        }
                        valueValid = true;
                    }
                }
                // Catching errors
                catch (FormatException)
                {
                    Console.WriteLine("Please select a whole number ... that is not 0 ..");
                }

            }
            Console.ReadLine();
        }
    }
}
